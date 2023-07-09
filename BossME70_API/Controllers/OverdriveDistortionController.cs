namespace BossME70_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OverdriveDistortionController : AbstractController<OverdriveDistortion>
{
    public OverdriveDistortionController(BossDbContext bossDbContext) : base(bossDbContext) { }

    [HttpPost]
    public override IActionResult Save(OverdriveDistortion overdriveDistortion)
    {
        try
        {
            if (overdriveDistortion is null)
                throw new ArgumentNullException(nameof(overdriveDistortion));

            var qtd = InsertOrUpdate(overdriveDistortion);

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
