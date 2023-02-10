using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logos.Logics;

namespace Logos
{
    class PanelUtil
    {
        public static readonly string[] keywordsArr = 
        {
            Keywords.PrintSyntax,
            Keywords.DefSyntax,
            Keywords.StaticSyntax,
            Keywords.FinalSyntax,
            Keywords.ExeSyntax,

            Keywords.ThesisValue,
            Keywords.AntithesisValue,
            Keywords.SynthesisValue
        };

        public static readonly string[] symbolArr =
        {
            Symbols.Thesis,
            Symbols.Antithesis,
            Symbols.Synthesis,
            
            Symbols.Assignment,
            Symbols.Equal,
            Symbols.NotEqual,
            Symbols.Plus,
            Symbols.Minus,
            Symbols.Multiple,
            Symbols.Division,

            Symbols.And,
            Symbols.Or,
            Symbols.Not,
            Symbols.Invoker,
            Symbols.Quotation,

            Symbols.Lambda,
            Symbols.Implicit,
            Symbols.Equivalent,

            Symbols.Definition,
            Symbols.ChainDef,
            Symbols.Deduction,
            Symbols.Address
            
        };
    }
}
