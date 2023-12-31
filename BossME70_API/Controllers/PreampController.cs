﻿namespace BossME70_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PreampController : AbstractController<Preamp>
{
    public PreampController(BossDbContext bossDbContext) : base(bossDbContext) { }

    [HttpPost]
    public override IActionResult Save(Preamp preamp)
    {
        try
        {
            if (preamp is null)
                throw new ArgumentNullException(nameof(preamp));

            var qtd = InsertOrUpdate(preamp);

            return Ok(qtd);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete]
    public override IActionResult Delete(int id)
    {
        try
        {
            return Ok(Remove(id));
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public override IActionResult Read(int? id)
    {
        try
        {
            return Ok(GetAllOrId(id));
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
