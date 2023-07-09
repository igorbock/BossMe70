namespace BossME70_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReverbController : AbstractController<Reverb>
{
    public ReverbController(BossDbContext bossDbContext) : base(bossDbContext) { }

    [HttpPost]
    public override IActionResult Save(Reverb reverb)
    {
        try
        {
            if (reverb is null)
                throw new ArgumentNullException(nameof(reverb));

            var qtd = InsertOrUpdate(reverb);

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
