namespace BossME70_API.Controllers;

public abstract class AbstractController<TipoT> : Controller where TipoT : IEffects
{
    public AbstractController(BossDbContext bossDbContext)
    {
        DbContext = bossDbContext;
    }

    public BossDbContext? DbContext { get; set; }

    public abstract IActionResult Save(TipoT entidade);
    public abstract IActionResult Delete(int id);
    public abstract IActionResult Read(int? id);

    [NonAction]
    public int InsertOrUpdate(TipoT entidade)
    {
        if (entidade.Id is 0)
            DbContext!.Add(entidade);
        else
            DbContext!.Update(entidade);

        return DbContext!.SaveChanges();
    }

    public IEffects? Entity { get; set; }

    [NonAction]
    public int Remove(int id)
    {
        switch(typeof(TipoT).Name)
        {
            case "CompressorEffect": 
                Entity = DbContext!.Find<CompressorEffect>(id);
                if(Entity is null)
                    throw new KeyNotFoundException(nameof(id));

                DbContext!.Remove<CompressorEffect>((CompressorEffect)Entity);
                break;

            case "Delay": 
                Entity = DbContext!.Find<Delay>(id);
                if(Entity is null)
                    throw new KeyNotFoundException(nameof(id));

                DbContext!.Remove<Delay>((Delay)Entity);
                break;

            case "Modulation": 
                Entity = DbContext!.Find<Modulation>(id);
                if(Entity is null)
                    throw new KeyNotFoundException(nameof(id));

                DbContext!.Remove<Modulation>((Modulation)Entity);
                break;

            case "NoiseSupressor": 
                Entity = DbContext!.Find<NoiseSuppressor>(id);
                if(Entity is null)
                    throw new KeyNotFoundException(nameof(id));

                DbContext!.Remove<NoiseSuppressor>((NoiseSuppressor)Entity);
                break;

            case "OverdriveDistortion": 
                Entity = DbContext!.Find<OverdriveDistortion>(id);
                if(Entity is null)
                    throw new KeyNotFoundException(nameof(id));

                DbContext!.Remove<OverdriveDistortion>((OverdriveDistortion)Entity);
                break;

            case "Patch": 
                Entity = DbContext!.Find<Patch>(id);
                if(Entity is null)
                    throw new KeyNotFoundException(nameof(id));

                DbContext!.Remove<Patch>((Patch)Entity);
                break;

            case "PedalEffect": 
                Entity = DbContext!.Find<PedalEffect>(id);
                if(Entity is null)
                    throw new KeyNotFoundException(nameof(id));

                DbContext!.Remove<PedalEffect>((PedalEffect)Entity);
                break;

            case "Preamp": 
                Entity = DbContext!.Find<Preamp>(id);
                if(Entity is null)
                    throw new KeyNotFoundException(nameof(id));

                DbContext!.Remove<Preamp>((Preamp)Entity);
                break;

            case "Reverb": 
                Entity = DbContext!.Find<Reverb>(id);
                if(Entity is null)
                    throw new KeyNotFoundException(nameof(id));

                DbContext!.Remove<Reverb>((Reverb)Entity);
                break;

            default: throw new NotImplementedException();
        }

        return DbContext!.SaveChanges();
    }

    [NonAction]
    public IEnumerable<IEffects> GetAllOrId(int? id)
    {
        switch(typeof(TipoT).Name)
        {
            case "CompressorEffect":
                if(id is null)
                    return DbContext!.CompressorEffects!;

                return new[] { DbContext!.Find<CompressorEffect>(id)! };

            case "Delay": 
                if(id is null)
                    return DbContext!.Delays!;

                return new[] { DbContext!.Find<Delay>(id)! };

            case "Modulation": 
                if(id is null)
                    return DbContext!.Modulations!;

                return new[] { DbContext!.Find<Modulation>(id)! };

            case "NoiseSupressor": 
                if(id is null)
                    return DbContext!.NoiseSuppressors!;

                return new[] { DbContext!.Find<NoiseSuppressor>(id)! };

            case "OverdriveDistortion": 
                if(id is null)
                    return DbContext!.OverdriveDistortions!;

                return new[] { DbContext!.Find<OverdriveDistortion>(id)! };

            case "Patch": 
                if(id is null)
                    return DbContext!.Patches!;

                return new[] { DbContext!.Find<Patch>(id)! };

            case "PedalEffect": 
                if(id is null)
                    return DbContext!.PedalEffects!;

                return new[] { DbContext!.Find<PedalEffect>(id)! };

            case "Preamp": 
                if(id is null)
                    return DbContext!.Preamps!;

                return new[] { DbContext!.Find<Preamp>(id)! };

            case "Reverb": 
                if(id is null)
                    return DbContext!.Reverbs!;

                return new[] { DbContext!.Find<Reverb>(id)! };

            default: throw new NotImplementedException();
        }
    }
}
