using BenchmarkDotNet.Running;
using GenericStrategyPattern.Benchmark;
using GenericStrategyPattern.Flows;
using System;
using System.Collections.Generic;

namespace GenericStrategyPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            //var approval = new Approval();
            //var listNextStatus = FlowHandler<ApprovalStateStatus, Approval>.BuildNextStatus(new NewStaffApproval(), approval);
            //PrintMessage(listNextStatus);
            //Console.WriteLine("\n ----------------- \n");
            //approval.CurrentStatus = ApprovalStatus.ProficientcyTest1;
            //var next = FlowHandler<ApprovalStateStatus, Approval>.BuildNextStatus(new OldStaffApproval(), approval);
            //PrintMessage(next);
            BenchmarkRunner.Run<TestFlow>();
        }

        private static void PrintMessage(IEnumerable<ApprovalStateStatus> listNextStatus)
        {
            foreach (var status in listNextStatus)
            {
                var message = !string.IsNullOrEmpty(status.Messages) ? status.Messages : "-";
                Console.WriteLine("Next Status : " + status.ApprovalStatus.ToString() + "\n" + "Special Message : " + message);
                Console.WriteLine("");
            }
        }
    }
    public enum ApprovalStatus
    {
        Submitted = 1,
        Reviewed,
        Approve,
        Reject,
        Close,
        ProficientcyTest1,
        ProficientcyTest1Pass,
        ProficientcyTest2,
        ProficientcyTest2Pass,
        ProficientcyTest3,
        ProficientcyTest3Pass
    }
}
