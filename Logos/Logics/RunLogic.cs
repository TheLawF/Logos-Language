using System;
using System.Collections;
using System.Collections.Generic;

namespace Logos.Logics
{
    public class RunLogic
    {
        public static void Run(string args)
        {
            var lines = SyntaxLogic.SplitLine(args);
            var intVarTable = new Hashtable();

            foreach (var l in lines)
            {
                var containsDef = SyntaxLogic.ContainsKeyword(l, Keywords.DefSyntax);

                if (containsDef)
                {
                    var line = SyntaxLogic.Strip(l, " ");
                    var kvArr = SyntaxLogic.SplitStr(line, Symbols.Assignment);
                    intVarTable.Add(kvArr[0], kvArr[1]);
                    Console.Out.Write(intVarTable.Keys);
                }
            }
            var phrase = SyntaxLogic.GetStringBetween(
            args, Keywords.DefSyntax + "(",
            ")");
            List<string> words = new List<string>();
            words = SyntaxLogic.SplitStr(phrase, "=");
        }
    }
}