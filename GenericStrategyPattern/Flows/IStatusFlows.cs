using System.Collections.Generic;

namespace GenericStrategyPattern.Flows
{
    public interface IStatusFlows<T, S>
    {
        IEnumerable<T> NextStatus(S source);
    }
}
