namespace BossME70_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PedalEffectController : AbstractController<PedalEffect>
{
    public PedalEffectController(BossDbContext bossDbContext) : base(bossDbContext) { }

    [HttpPost]
    public override IActionResult Save(PedalEffect pedalEffect)
    {
        try
        {
            if (pedalEffect is null)
                throw new ArgumentNullException(nameof(pedalEffect));

            var qtd = InsertOrUpdate(pedalEffect);

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
