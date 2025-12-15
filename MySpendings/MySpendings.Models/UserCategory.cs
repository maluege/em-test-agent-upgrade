namespace MySpendings.Models
{
    public class UserCategory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; } = null!;
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!;
    }
}
