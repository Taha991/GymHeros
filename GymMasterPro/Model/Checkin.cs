using System.ComponentModel.DataAnnotations.Schema;
namespace GymMasterPro.Model
{
    public class Checkin: Base
    {

        public int MemberId { get; set; }
        //public int PlanId { get; set; }
        [NotMapped]
        public string? Status { get; set; }
        [NotMapped]
        public DateTime? EndDate { get; set; }
        public virtual Member? Member { get; set; }
    }
}
