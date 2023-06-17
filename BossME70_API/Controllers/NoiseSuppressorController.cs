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
}
