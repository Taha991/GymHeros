namespace GymMasterPro.Model
{
    public class Member : Base
    {
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public int  TrainerId { get; set; }
        public virtual Trainer? Trainer { get; set; }
        public virtual ICollection<Membership>? Memberships { get; set; }

        public virtual ICollection<CheckActive>? CheckActives { get; set; }

    }
}
