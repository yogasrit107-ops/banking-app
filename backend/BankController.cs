using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/bank")]
public class BankController : ControllerBase
{
    static int balance = 50000;

    [HttpGet("balance")]
    public IActionResult GetBalance()
    {
        return Ok(balance);
    }

    [HttpPost("deposit")]
    public IActionResult Deposit(int amount)
    {
        balance += amount;
        return Ok("Deposit Success");
    }

    [HttpPost("withdraw")]
    public IActionResult Withdraw(int amount)
    {
        if(amount > balance)
            return BadRequest("Insufficient Balance");

        balance -= amount;
        return Ok("Withdraw Success");
    }
}