namespace BossME70_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NoiseSuppressorController : AbstractController<NoiseSuppressor>
{
    [HttpPost]
    public override IActionResult Save(NoiseSuppressor noiseSuppressor)
    {
        try
        {
            if (noiseSuppressor is null)
                throw new ArgumentNullException(nameof(noiseSuppressor));

            using var DbContext = new BossDbContext();

            if (noiseSuppressor.Id is 0)
                DbContext.NoiseSuppressors!.Add(noiseSuppressor);
            else
                DbContext.NoiseSuppressors!.Update(noiseSuppressor);

            var qtd = DbContext.SaveChanges();

            return Ok(qtd);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
