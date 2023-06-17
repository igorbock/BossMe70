namespace BossME70_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DelayController : AbstractController<Delay>
{
    public DelayController(BossDbContext bossDbContext) : base(bossDbContext){}

    [HttpPost]
    public override IActionResult Save(Delay delay)
    {
        try
        {
            if (delay is null)
                throw new ArgumentNullException(nameof(delay));

            using var DbContext = new BossDbContext();

            if (delay.Id is 0)
                DbContext.Delays!.Add(delay);
            else
                DbContext.Delays!.Update(delay);

            var qtd = DbContext.SaveChanges();

            return Ok(qtd);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
