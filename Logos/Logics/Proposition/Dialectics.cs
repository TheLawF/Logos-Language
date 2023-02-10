namespace Logos.Logics.Proposition
{
    public struct Dialectics<TT, TA, TS> : IProposition
    {
        public TT Thesis { get; set; }
        public TA Antithesis { get; set; }
        public TS Synthesis { get; set; }
        
        public IProposition GetProposition()
        {
            return this;
        }
    }
}