using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserBalanceAPI.Data;
using UserBalanceAPI.Models;

namespace UserBalanceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserBalanceController : ControllerBase
    {
        private readonly UserBalanceContext _context;

        public UserBalanceController(UserBalanceContext context)
        {
            _context = context;
        }

        [HttpGet("{email}")]
        public async Task<ActionResult<decimal>> GetBalance(string email)
        {
            var userBalance = await _context.UserBalances
                .FirstOrDefaultAsync(ub => ub.Email == email);

            if (userBalance == null)
            {
                return NotFound();
            }

            return userBalance.Balance;
        }

        [HttpPost("debit/{email}")]
        public async Task<IActionResult> Debit(string email, [FromBody] decimal amount)
        {
            var userBalance = await _context.UserBalances
                .FirstOrDefaultAsync(ub => ub.Email == email);
            
            if (userBalance == null)
            {
                return NotFound();
            }

            userBalance.Balance -= amount;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost("credit/{email}")]
        public async Task<IActionResult> Credit(string email, [FromBody] decimal amount)
        {
            var userBalance = await _context.UserBalances
                .FirstOrDefaultAsync(ub => ub.Email == email);

            if (userBalance == null)
            {
                return NotFound();
            }

            userBalance.Balance += amount;
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
