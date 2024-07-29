using System.ComponentModel.DataAnnotations;

namespace UserBalanceAPI.Dto
{
    public class AddUserBalanceDto
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public decimal Balance { get; set; }
    }
}