using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BossME70_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "me70");

            migrationBuilder.CreateTable(
                name: "compressor_effects",
                schema: "me70",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Sustain = table.Column<decimal>(type: "numeric", nullable: true),
                    Sens = table.Column<decimal>(type: "numeric", nullable: true),
                    Attack = table.Column<decimal>(type: "numeric", nullable: true),
                    Tone = table.Column<decimal>(type: "numeric", nullable: true),
                    Level = table.Column<decimal>(type: "numeric", nullable: true),
                    Peak = table.Column<decimal>(type: "numeric", nullable: true),
                    Low = table.Column<decimal>(type: "numeric", nullable: true),
                    High = table.Column<decimal>(type: "numeric", nullable: true),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_compressor_effects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "delay",
                schema: "me70",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Time = table.Column<decimal>(type: "numeric", nullable: true),
                    Feedback = table.Column<decimal>(type: "numeric", nullable: true),
                    ELevel = table.Column<decimal>(type: "numeric", nullable: true),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_delay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "modulation",
                schema: "me70",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Rate = table.Column<decimal>(type: "numeric", nullable: true),
                    Key = table.Column<decimal>(type: "numeric", nullable: true),
                    Time = table.Column<decimal>(type: "numeric", nullable: true),
                    Depth = table.Column<decimal>(type: "numeric", nullable: true),
                    Harmony = table.Column<decimal>(type: "numeric", nullable: true),
                    DLevel = table.Column<decimal>(type: "numeric", nullable: true),
                    Feedback = table.Column<decimal>(type: "numeric", nullable: true),
                    ELevel = table.Column<decimal>(type: "numeric", nullable: true),
                    Resonance = table.Column<decimal>(type: "numeric", nullable: true),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modulation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "noise_suppressor",
                schema: "me70",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Threshold = table.Column<decimal>(type: "numeric", nullable: true),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_noise_suppressor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "overdrive_distortion",
                schema: "me70",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Drive = table.Column<decimal>(type: "numeric", nullable: true),
                    Tone = table.Column<decimal>(type: "numeric", nullable: true),
                    Level = table.Column<decimal>(type: "numeric", nullable: true),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_overdrive_distortion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "patch",
                schema: "me70",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompressorEffectsId = table.Column<int>(type: "integer", nullable: true),
                    OverdriveDistortionId = table.Column<int>(type: "integer", nullable: true),
                    ModulationId = table.Column<int>(type: "integer", nullable: true),
                    DelayId = table.Column<int>(type: "integer", nullable: true),
                    PreampId = table.Column<int>(type: "integer", nullable: true),
                    NoiseSuppressorId = table.Column<int>(type: "integer", nullable: true),
                    ReverbId = table.Column<int>(type: "integer", nullable: true),
                    PedalEffectsId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pedal_effects",
                schema: "me70",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedal_effects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "preamp",
                schema: "me70",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Low = table.Column<decimal>(type: "numeric", nullable: true),
                    LowMid = table.Column<decimal>(type: "numeric", nullable: true),
                    HighMid = table.Column<decimal>(type: "numeric", nullable: true),
                    High = table.Column<decimal>(type: "numeric", nullable: true),
                    Level = table.Column<decimal>(type: "numeric", nullable: true),
                    Gain = table.Column<decimal>(type: "numeric", nullable: true),
                    Bass = table.Column<decimal>(type: "numeric", nullable: true),
                    Middle = table.Column<decimal>(type: "numeric", nullable: true),
                    Treble = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_preamp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "reverb",
                schema: "me70",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<int>(type: "integer", nullable: true),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reverb", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "compressor_effects",
                schema: "me70");

            migrationBuilder.DropTable(
                name: "delay",
                schema: "me70");

            migrationBuilder.DropTable(
                name: "modulation",
                schema: "me70");

            migrationBuilder.DropTable(
                name: "noise_suppressor",
                schema: "me70");

            migrationBuilder.DropTable(
                name: "overdrive_distortion",
                schema: "me70");

            migrationBuilder.DropTable(
                name: "patch",
                schema: "me70");

            migrationBuilder.DropTable(
                name: "pedal_effects",
                schema: "me70");

            migrationBuilder.DropTable(
                name: "preamp",
                schema: "me70");

            migrationBuilder.DropTable(
                name: "reverb",
                schema: "me70");
        }
    }
}
