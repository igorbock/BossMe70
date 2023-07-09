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
