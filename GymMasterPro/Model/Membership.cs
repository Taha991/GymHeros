using System.Numerics;

namespace GymMasterPro.Model
{
    public class Membership : Base
    {
        public int MemberId { get; set; }
        public int PlanId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public virtual Member? Member { get; set; }
        public virtual Plan? Plan { get; set; }
    }
}
