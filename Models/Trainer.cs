namespace Model
{
    public class Trainer : Base
    {
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public string Notes { get; set; }
        public virtual ICollection<Member>? Members { get; set; }
    }
}
