namespace BossME70_Lib.Effects;

[Table("noise_suppressor", Schema = "me70")]
public class NoiseSuppressor : IEffects
{
    [Key]
    public int Id { get; set; }
    public decimal? Threshold { get; set; }
    public bool Active { get; set; }
}
