using FinalProject;

namespace FinalProject.Models
{
    public class ViewStrains
    {
        public string? Strain { get; set; }
        public string? THC { get; set; }
        public string? CBD { get; set; }
        public string? CBG { get; set; }
        public string? StrainType { get; set; }
        public string? Climate { get; set; }
        public string? Difficulty { get; set; }
        public string? FungalResistance { get; set; }
        public int IndoorYieldGramsMin { get; set; }
        public int IndoorYieldGramsMax { get; set; }
        public int OutdoorYieldGramsMin { get; set; }
        public int OutdoorYieldGramsMax { get; set; }
        public int FloweringWeeksMin { get; set; }
        public int FloweringWeeksMax { get; set; }
        public int HeightInchesMin { get; set; }
        public int HeightInchesMax { get; set; }
        public string? GoodEffects { get; set; }
        public string? SideEffects { get; set; }
        public string? Image { get; set; }
        public string? Activity { get; set; }
        public string? Type { get; set; }
    }
}