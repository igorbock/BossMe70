namespace BossME70_API.Context;

public class BossDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5433;Database=postgres;User Id=postgres;Password=teste");

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Patch>().ToTable("patch", "me70");
        modelBuilder.Entity<PedalEffect>().ToTable("pedal_effects", "me70");
        modelBuilder.Entity<Reverb>().ToTable("reverb", "me70");
        modelBuilder.Entity<NoiseSuppressor>().ToTable("noise_suppressor", "me70");
        modelBuilder.Entity<Preamp>().ToTable("preamp", "me70");
        modelBuilder.Entity<Delay>().ToTable("delay", "me70");
        modelBuilder.Entity<Modulation>().ToTable("modulation", "me70");
        modelBuilder.Entity<OverdriveDistortion>().ToTable("overdrive_distortion", "me70");
        modelBuilder.Entity<CompressorEffect>().ToTable("compressor_effects", "me70");

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Patch>? Patches { get; set; }
    public DbSet<PedalEffect>? PedalEffects { get; set; }
    public DbSet<Reverb>? Reverbs { get; set; }
    public DbSet<NoiseSuppressor>? NoiseSuppressors { get; set; }
    public DbSet<Preamp>? Preamps { get; set; }
    public DbSet<Delay>? Delays { get; set; }
    public DbSet<Modulation>? Modulations { get; set; }
    public DbSet<OverdriveDistortion>? OverdriveDistortions { get; set; }
    public DbSet<CompressorEffect>? CompressorEffects { get; set; }
}
