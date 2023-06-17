namespace BossME70_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PreampController : AbstractController<Preamp>
{
    [HttpPost]
    public override IActionResult Save(Preamp preamp)
    {
        try
        {
            if (preamp is null)
                throw new ArgumentNullException(nameof(preamp));

            using var DbContext = new BossDbContext();

            if (preamp.Id is 0)
                DbContext.Preamps!.Add(preamp);
            else
                DbContext.Preamps!.Update(preamp);

            var qtd = DbContext.SaveChanges();

            return Ok(qtd);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
