using System.Collections.Generic;

namespace Logos.Logics.Proposition
{
    public interface IEquivalent<TA, TC> : IProposition
    {
        TA Antecedent { get; set; }
        TC Consequence { get; set; }

    }
}