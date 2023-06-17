namespace BossME70_Lib.Effects;

[Table("delay", Schema = "me70")]
public class Delay : IEffects
{
    [Key]
    public int Id { get; set; }
    public string? Type { get; set; }
    public decimal? Time { get; set; }
    public decimal? Feedback { get; set; }
    public decimal? ELevel { get; set; }
    public bool Active { get; set; }
}
