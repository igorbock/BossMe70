namespace BossME70_Lib.Effects;

[Table("compressor_effects", Schema = "me70")]
public class CompressorEffect : IEffects
{
    [Key]
    public int Id { get; set; }
    public string? Type { get; set; }
    public decimal? Sustain { get; set; }
    public decimal? Sens { get; set; }
    public decimal? Attack { get; set; }
    public decimal? Tone { get; set; }
    public decimal? Level { get; set; }
    public decimal? Peak { get; set; }
    public decimal? Low { get; set; }
    public decimal? High { get; set; }
    public bool Active { get; set; }
}