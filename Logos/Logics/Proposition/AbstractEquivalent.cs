using System.Runtime.CompilerServices;

namespace Logos.Logics.Proposition
{
    public abstract class AbstractEquivalent : IEquivalent<bool, bool>
    {
        public bool Antecedent { get; set; }
        public bool Consequence { get; set; }
        

        public Dialectics<string, string, string> Key;
        public Dialectics<bool, bool, bool> IsTrue;
        
        public AbstractEquivalent(Dialectics<string, string, string> keyIn, Dialectics<bool, bool, bool> isTrue)
        {
            Key = keyIn;
            IsTrue = isTrue;
        }


        public IProposition GetProposition()
        {
            return this;
        }
    }
}