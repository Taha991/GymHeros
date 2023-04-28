namespace Model
{
    public class Plan : Base
    {

        public string Name { get; set; }
        public int Duration { get; set; }
        public double Price { get; set; }
        public string Notes { get; set; }
        public virtual ICollection<Membership>? Memberships { get; set; }
    }
}
