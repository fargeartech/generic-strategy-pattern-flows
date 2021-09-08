using System.Collections.Generic;

namespace GenericStrategyPattern.Flows
{
    public interface IStatusFlows<T, U>
    {
        ICollection<T> NextStatus(U parameter);
    }
}
