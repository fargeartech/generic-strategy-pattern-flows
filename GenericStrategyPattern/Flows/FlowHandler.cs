using System.Collections.Generic;

namespace GenericStrategyPattern.Flows
{
    public static class FlowHandler<T, U>
    {
        public static ICollection<T> BuildNextStatus(IStatusFlows<T, U> input, U source)
        {
            return input.NextStatus(source);
        }
    }

    public class FlowHandlerNonStatic<T, U>
    {
        public static ICollection<T> BuildNextStatus(IStatusFlows<T, U> input, U source)
        {
            return input.NextStatus(source);
        }
    }
}
