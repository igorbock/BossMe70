namespace BossME70_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OverdriveDistortionController : AbstractController<OverdriveDistortion>
{
    [HttpPost]
    public override IActionResult Save(OverdriveDistortion overdriveDistortion)
    {
        try
        {
            if (overdriveDistortion is null)
                throw new ArgumentNullException(nameof(overdriveDistortion));

            using var DbContext = new BossDbContext();

            if (overdriveDistortion.Id is 0)
                DbContext.OverdriveDistortions!.Add(overdriveDistortion);
            else
                DbContext.OverdriveDistortions!.Update(overdriveDistortion);

            var qtd = DbContext.SaveChanges();

            return Ok(qtd);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
