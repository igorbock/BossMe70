namespace BossME70_Lib.Effects;

[Table("pedal_effects", Schema = "me70")]
public class PedalEffect : IEffects
{
    [Key]
    public int Id { get; set; }
    public string? Type { get; set; }
    public bool Active { get; set; }
}
