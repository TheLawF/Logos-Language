namespace Logos.Logics.Proposition
{
    public class Equivalent : IEquivalent<AbstractEquivalent, AbstractEquivalent>
    {
        public IProposition GetProposition()
        {
            return this;
        }

        public AbstractEquivalent Antecedent { get; set; }
        public AbstractEquivalent Consequence { get; set; }

        public static bool IsEquivalent(AbstractEquivalent left, AbstractEquivalent right)
        {
            Dialectics<string, string, string> key = left.Key;
            bool b1 = left.Antecedent == right.Antecedent;
            bool b2 = left.Consequence == right.Antecedent;
            bool b3 = b1 == b2;
            return b3;
        }
    }
}