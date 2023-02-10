namespace Logos.Logics.Proposition
{
    public class Implication : AbstractEquivalent, IEquivalent<bool, bool>
    {

        public Dialectics<Being, Being, Implication> Dialectics = new Dialectics<Being, Being, Implication>();

        public new Implication GetProposition()
        {
            return this;
        }

        public Implication(Dialectics<string, string, string> key, Dialectics<bool, bool, bool> condition) : base(key, condition)
        {
            condition.Thesis = Antecedent;
            condition.Antithesis = Consequence;
        }

        IProposition IProposition.GetProposition()
        {
            return GetProposition();
        }

        public static Implication Imply(Implication left, Implication right)
        {
            Dialectics<string, string, string> key = left.Key;
            bool b1 = left.Antecedent & right.Antecedent;
            bool b2 = left.Consequence & right.Antecedent;
            bool b3 = b1 && b2;
            Dialectics<bool, bool, bool> isTrue = new Dialectics<bool, bool, bool>();
            isTrue.Thesis = b1;
            isTrue.Antithesis = b2;
            isTrue.Synthesis = b3;
            return new Implication(key, isTrue);
        }

        public Implication Implicits(Implication implication)
        {
            Dialectics<string, string, string> key = Key;
            bool b1 = Antecedent & implication.Antecedent;
            bool b2 = Consequence & implication.Antecedent;
            bool b3 = b1 && b2;
            Dialectics<bool, bool, bool> isTrue = new Dialectics<bool, bool, bool>();
            isTrue.Thesis = b1;
            isTrue.Antithesis = b2;
            isTrue.Synthesis = b3;
            return new Implication(key, isTrue);
        }

        public static bool IsImplicit(Implication left, Implication right)
        {
            return Imply(left, right).IsTrue.Synthesis;
        }
        
        public static Implication operator &(Implication left, Implication right)
        {
            return Imply(left, right);
        }
        
        public new bool Antecedent { get; set; }
        public new bool Consequence { get; set; }
    }
}