namespace Logos.Logics
{
    public static class Symbols
    {
        /// <summary>
        /// Logos 语言特有的正反合辩证语法（笑）
        /// </summary>
        public static readonly string Thesis = "!";
        public static readonly string Antithesis = "?";
        public static readonly string Synthesis = "!!";

        /// <summary>
        /// 赋值与基本数学运算符
        /// </summary>
        public static readonly string Assignment = "=";
        public static readonly string Equal = "==";
        public static readonly string NotEqual = "!=";
        public static readonly string Plus = "+";
        public static readonly string Minus = "-";
        public static readonly string Multiple = "*";
        public static readonly string Division = "/";
        
        /// <summary>
        /// 基本逻辑运算符
        /// </summary>
        public static readonly string And = "&";
        public static readonly string Or = "|";
        public static readonly string If = "?";
        public static readonly string Not = "!";
        public static readonly string Invoker = ".";

        /// <summary>
        /// 杂项：接续、行列、引用与转义字符
        /// </summary>
        public static readonly string Comma = ",";
        public static readonly char LineBreak = ';';
        public static readonly string Quotation = "\"";
        public static readonly string EscChar = "\\";

        /// <summary>
        /// 高级逻辑运算符是Logos语言的特色，不得不品尝（逃）
        /// 
        /// 逻辑运算符大全：
        ///  a -> b | Lambda表达式，表示将a的值传入函数b里面，或者将函数a的
        ///         | 返回值赋值给b，用法如下：
        ///         | def A = 5;
        ///         | def B;
        ///         | def C = (A) -> {A + 1} -> B;
        ///         | print B, C;
        ///         |
        ///         | 输出：
        ///         | 66
        /// ----------------------------------------------------
        ///  a => b | 蕴涵表达式，表示“如果a那么b”，a为条件表达式，b为函数，
        ///         | 如果a整体的值为true那么执行b，b若为条件函数，则其真假
        ///         | 不受到a的影响。用法如下：
        ///         | def A = any(10);
        ///         | def B = any(20);
        ///         | print (A == B) => {def C = A == B};
        ///         |
        ///         | 输出：
        ///         | @如果随机值A与随机值B相等：true => true
        ///         | @如果随机值A与随机值B不等：false => false
        /// </summary>
        public static readonly string Lambda = "->";
        public static readonly string Implicit = "=>";
        public static readonly string Equivalent = "<=>";

        public static readonly string Definition = ":";
        public static readonly string ChainDef = ":>";
        public static readonly string Deduction = "|-";
        public static readonly string Address = "@";
    }
}