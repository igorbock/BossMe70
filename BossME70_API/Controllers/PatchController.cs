namespace BossME70_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PatchController : AbstractController<Patch>
{
    public PatchController(BossDbContext bossDbContext) : base(bossDbContext) { }

    [HttpPost]
    public override IActionResult Save(Patch patch)
    {
        try
        {
            if (patch is null)
                throw new ArgumentNullException(nameof(patch));

            var qtd = InsertOrUpdate(patch);

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
