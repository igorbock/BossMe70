namespace BossME70_Lib.Effects;

[Table("overdrive_distortion", Schema = "me70")]
public class OverdriveDistortion : IEffects
{
    [Key]
    public int Id { get; set; }
    public string? Type { get; set; }
    public decimal? Drive { get; set; }
    public decimal? Tone { get; set; }
    public decimal? Level { get; set; }
    public bool Active { get; set; }
}
