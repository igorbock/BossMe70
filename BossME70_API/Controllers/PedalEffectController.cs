namespace BossME70_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PedalEffectController : AbstractController<PedalEffect>
{
    [HttpPost]
    public override IActionResult Save(PedalEffect pedalEffect)
    {
        try
        {
            if (pedalEffect is null)
                throw new ArgumentNullException(nameof(pedalEffect));

            using var DbContext = new BossDbContext();

            if (pedalEffect.Id is 0)
                DbContext.PedalEffects!.Add(pedalEffect);
            else
                DbContext.PedalEffects!.Update(pedalEffect);

            var qtd = DbContext.SaveChanges();

            return Ok(qtd);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
