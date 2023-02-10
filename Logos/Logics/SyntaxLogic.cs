using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Logos.Logics.Proposition;

namespace Logos.Logics
{
    public static class SyntaxLogic
    {
        public static string Strip(string line, string pattern)
        {
            return line.Replace(pattern, "");
        }
        
        public static bool ContainsPair(string origin, string startPattern, string endPattern)
        {
            return origin.Contains(startPattern) && origin.Contains(endPattern);
        }

        public static string GetStringBetween(string origin, string startPattern, string endPattern)
        {
            var start = "";
            var end = "";
            
            if (origin.Contains(startPattern)) {
                start = origin.Replace(startPattern, "");
            }
            if (!start.Equals("") && origin.Contains(endPattern)) {
                end = start.Replace(endPattern, "");
            }
            
            return end;
        }

        public static string GetFirstLastBetween(string line, string first, char last)
        {
            var start = "";
            var end = "";
            var arr = line.ToCharArray();
            
            if (line.Contains(first)) {
                start = line.Replace(start, "");
            }
            if (!start.Equals("") && line.Contains(last) && arr[arr.Length-1] == last) {
                end = start.Replace(last.ToString(), "");
            }

            return end;
        }


        public static List<string> SplitMulti(string origin, List<string> splitKeys)
        {
            return new List<string>();
        }

        public static List<string> SplitLine(string passage)
        {
            return new List<string>(passage.Replace("\n", "").Split(Symbols.LineBreak));
        }

        public static LinkedList<string> GetHierarchy(string line)
        {
            LinkedList<string> hierarchy = new LinkedList<string>();
            List<string> defSymbol = new List<string>();
            if (GetKeyword(line, Keywords.DefSyntax) != null)
            {
                hierarchy.AddFirst(GetKeyword(line, Keywords.DefSyntax));
            }

            bool containsDefKey = hierarchy.Find(Keywords.DefSyntax) != null;
            
            if (!containsDefKey && line.Contains(Symbols.Definition))
            {
                defSymbol = SplitStr(line, Symbols.Definition);
                hierarchy.AddFirst(defSymbol[0]);
            }
            
            var next = defSymbol[1].Split(new[] { Symbols.Assignment },
                StringSplitOptions.None);
            
            if (containsDefKey && line.Contains(Symbols.Assignment))
            {
                var node = hierarchy.Find(defSymbol[0]);
                if (node != null) hierarchy.AddAfter(node, defSymbol[0]);
            }

            return hierarchy;
        }

        public static List<string> SplitStr(string str, string separator)
        {
            string[] strArr = str.Split(new []{separator}, StringSplitOptions.None);
            return new List<string>(strArr);
        }

        public static LinkedListNode<string> GetKeyword(string line, string keyword)
        {
            var charArr = line.ToCharArray();
            if (ContainsKeyword(line, keyword))
            {
                return new LinkedListNode<string>(keyword);
            }

            return null;
        }

        public static bool ContainsKeyword(string line, string keyword)
        {
            int count = 0;
            char[] charArr = line.ToCharArray();
            foreach (var cha in keyword)
            {
                if (charArr.Contains(cha) && keyword == Keywords.DefSyntax)
                {
                    count++;
                }
                else if (charArr.Contains(cha) && keyword == Keywords.PrintSyntax)
                {
                    count++;
                }
            }
            
            if (count == 3 && keyword == Keywords.DefSyntax)
            {
                return true;
            }
            if(count == 5 && keyword == Keywords.PrintSyntax)
            {
                return true;
            }

            return false;
        }

        public static unsafe long* GetAddress(long l)
        {
            var addr = &l;
            return addr;
        }

        public static unsafe int* GetAddress(int i)
        {
            var addr = &i;
            return addr;
        }

        public static string GetAddress(object o)
        {
            var gc = GCHandle.Alloc(o, GCHandleType.WeakTrackResurrection);
            var addr = GCHandle.ToIntPtr(gc);
            return "0x" + addr.ToString("X");
        }
        
    }
}