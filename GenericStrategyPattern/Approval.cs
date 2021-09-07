using System;

namespace GenericStrategyPattern
{

    public class Approval
    {
        public string Title { get; set; }
        public ApprovalStatus CurrentStatus { get; set; }
        public Approval()
        {
            CurrentStatus = ApprovalStatus.Submitted;
        }
        public Approval(ApprovalStatus approvalStatus)
        {
            this.CurrentStatus = approvalStatus;
        }
    }
}
