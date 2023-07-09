namespace BossME70_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NoiseSuppressorController : AbstractController<NoiseSuppressor>
{
    public NoiseSuppressorController(BossDbContext bossDbContext) : base(bossDbContext) { }

    [HttpPost]
    public override IActionResult Save(NoiseSuppressor noiseSuppressor)
    {
        try
        {
            if (noiseSuppressor is null)
                throw new ArgumentNullException(nameof(noiseSuppressor));

            var qtd = InsertOrUpdate(noiseSuppressor);

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
