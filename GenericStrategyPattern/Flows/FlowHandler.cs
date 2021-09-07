using System.Collections.Generic;

namespace GenericStrategyPattern.Flows
{
    public static class FlowHandler<T, U>
    {
        public static IEnumerable<T> BuildNextStatus(IStatusFlows<T, U> input, U source)
        {
            return input.NextStatus(source);
        }
    }
}
