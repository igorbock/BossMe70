namespace BossME70_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReverbController : AbstractController<Reverb>
{
    [HttpPost]
    public override IActionResult Save(Reverb reverb)
    {
        try
        {
            if (reverb is null)
                throw new ArgumentNullException(nameof(reverb));

            using var DbContext = new BossDbContext();

            if (reverb.Id is 0)
                DbContext.Reverbs!.Add(reverb);
            else
                DbContext.Reverbs!.Update(reverb);

            var qtd = DbContext.SaveChanges();

            return Ok(qtd);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
