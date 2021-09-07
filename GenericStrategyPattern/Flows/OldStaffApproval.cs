using System.Collections.Generic;

namespace GenericStrategyPattern.Flows
{

    public class OldStaffApproval : IStatusFlows<ApprovalStateStatus, Approval>
    {
        private List<ApprovalStateStatus> _statuses;
        public IEnumerable<ApprovalStateStatus> NextStatus(Approval source)
        {
            _statuses = new List<ApprovalStateStatus>();
            var current = source.CurrentStatus;
            if (current == ApprovalStatus.Submitted)
            {
                _statuses.Add(new ApprovalStateStatus
                {
                    ApprovalStatus = ApprovalStatus.Reviewed,
                    Messages = "Please review it firsts"
                });
                _statuses.Add(new ApprovalStateStatus
                {
                    ApprovalStatus = ApprovalStatus.Reject,
                    Messages = "reject will sent and email "
                });
            }
            else if (current == ApprovalStatus.Reject)
            {
                _statuses.Add(new ApprovalStateStatus
                {
                    ApprovalStatus = ApprovalStatus.Submitted,
                    Messages = "has been rejected, and submit again"
                });
            }
            else if (current == ApprovalStatus.Reviewed)
            {
                _statuses.Add(new ApprovalStateStatus
                {
                    ApprovalStatus = ApprovalStatus.ProficientcyTest1,
                });
                _statuses.Add(new ApprovalStateStatus
                {
                    ApprovalStatus = ApprovalStatus.Reject,
                });
            }
            else if (current == ApprovalStatus.ProficientcyTest1)
            {
                _statuses.Add(new ApprovalStateStatus
                {
                    ApprovalStatus = ApprovalStatus.ProficientcyTest1Pass,
                });
                _statuses.Add(new ApprovalStateStatus
                {
                    ApprovalStatus = ApprovalStatus.Reject,
                });
            }

            return _statuses;
        }
    }
}
