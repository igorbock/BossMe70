namespace BossME70_Lib.Models;

[Table("patch", Schema = "me70")]
public class Patch : IEffects
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Bank { get; set; }
    public int? CompressorEffectsId { get; set; }
    public int? OverdriveDistortionId { get; set; }
    public int? ModulationId { get; set; }
    public int? DelayId { get; set; }
    public int? PreampId { get; set; }
    public int? NoiseSuppressorId { get; set; }
    public int? ReverbId { get; set; }
    public int? PedalEffectsId { get; set; }
}
