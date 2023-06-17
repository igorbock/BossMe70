namespace BossME70_Lib.Effects;

[Table("modulation", Schema = "me70")]
public class Modulation : IEffects
{
    [Key]
    public int Id { get; set; }
    public string? Type { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Key { get; set; }
    public decimal? Time { get; set; }
    public decimal? Depth { get; set; }
    public decimal? Harmony { get; set; }
    public decimal? DLevel { get; set; }
    public decimal? Feedback { get; set; }
    public decimal? ELevel { get; set; }
    public decimal? Resonance { get; set; }
    public bool Active { get; set; }
}
