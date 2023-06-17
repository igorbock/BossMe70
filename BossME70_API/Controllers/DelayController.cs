﻿namespace BossME70_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DelayController : AbstractController<Delay>
{
    public DelayController(BossDbContext bossDbContext) : base(bossDbContext) { }

    [HttpPost]
    public override IActionResult Save(Delay delay)
    {
        try
        {
            if (delay is null)
                throw new ArgumentNullException(nameof(delay));

            var qtd = InsertOrUpdate(delay);

            return Ok(qtd);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
