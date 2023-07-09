namespace BossME70_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ModulationController : AbstractController<Modulation>
{
    public ModulationController(BossDbContext bossDbContext) : base(bossDbContext) { }

    [HttpPost]
    public override IActionResult Save(Modulation modulation)
    {
        try
        {
            if (modulation is null)
                throw new ArgumentNullException(nameof(modulation));

            var qtd = InsertOrUpdate(modulation);

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
