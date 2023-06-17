namespace BossME70_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ModulationController : AbstractController<Modulation>
{
    [HttpPost]
    public override IActionResult Save(Modulation modulation)
    {
        try
        {
            if (modulation is null)
                throw new ArgumentNullException(nameof(modulation));

            using var DbContext = new BossDbContext();

            if (modulation.Id is 0)
                DbContext.Modulations!.Add(modulation);
            else
                DbContext.Modulations!.Update(modulation);

            var qtd = DbContext.SaveChanges();

            return Ok(qtd);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
