namespace Model
{
    public class Base
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public string? CreatedBy { get; set; }
    }
}
