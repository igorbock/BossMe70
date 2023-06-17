namespace BossME70_API.Controllers;

public abstract class AbstractController<TipoT> : Controller where TipoT : IEffects
{
    public AbstractController(BossDbContext bossDbContext)
    {
        DbContext = bossDbContext;
    }

    public BossDbContext? DbContext { get; set; }

    public abstract IActionResult Save(TipoT entidade);

    public int InsertOrUpdate(TipoT entidade)
    {
        if (entidade.Id is 0)
            DbContext!.Add(entidade);
        else
            DbContext!.Update(entidade);

        return DbContext!.SaveChanges()
    }
}
