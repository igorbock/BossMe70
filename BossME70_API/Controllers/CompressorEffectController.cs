namespace BossME70_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CompressorEffectController : AbstractController<CompressorEffect>
{
    public CompressorEffectController(BossDbContext bossDbContext) : base(bossDbContext){ }

    [HttpPost]
    public override IActionResult Save(CompressorEffect compressorEffect)
    {
        try
        {
            if (compressorEffect is null)
                throw new ArgumentNullException(nameof(compressorEffect));

            var qtd = InsertOrUpdate(compressorEffect);

            return Ok(qtd);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
