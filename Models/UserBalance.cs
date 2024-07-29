namespace UserBalanceAPI.Models
{
    public class UserBalance
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public decimal Balance { get; set; }
    }
}
