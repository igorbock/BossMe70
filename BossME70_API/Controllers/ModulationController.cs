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
}
