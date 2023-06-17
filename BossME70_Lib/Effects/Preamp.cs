namespace BossME70_Lib.Effects;

[Table("preamp", Schema = "me70")]
public class Preamp : IEffects
{
    [Key]
    public int Id { get; set; }
    public string? Type { get; set; }
    public decimal? Low { get; set; }
    public decimal? LowMid { get; set; }
    public decimal? HighMid { get; set; }
    public decimal? High { get; set; }
    public decimal? Level { get; set; }
    public decimal? Gain { get; set; }
    public decimal? Bass { get; set; }
    public decimal? Middle { get; set; }
    public decimal? Treble { get; set; }
}
