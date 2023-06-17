namespace BossME70_Lib.Effects;

[Table("reverb", Schema = "me70")]
public class Reverb : IEffects
{
    [Key]
    public int Id { get; set; }
    public string? Type { get; set; }
    public int? Value { get; set; }
    public bool Active { get; set; }
}
