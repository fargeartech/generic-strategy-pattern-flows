using BenchmarkDotNet.Attributes;
using GenericStrategyPattern.Flows;
using System.Collections.Generic;

namespace GenericStrategyPattern.Benchmark
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class TestFlow
    {
        private Approval _approval;

        public TestFlow()
        {
            _approval = new Approval();
        }

        [Benchmark(Baseline = true)]
        public ICollection<ApprovalStateStatus> NonStatic()
        {
            return FlowHandlerNonStatic<ApprovalStateStatus, Approval>.BuildNextStatus(new NewStaffApproval(), _approval);
        }
        [Benchmark]
        public ICollection<ApprovalStateStatus> StaticClass()
        {
            return FlowHandler<ApprovalStateStatus, Approval>.BuildNextStatus(new NewStaffApproval(), _approval);
        }
    }
}
