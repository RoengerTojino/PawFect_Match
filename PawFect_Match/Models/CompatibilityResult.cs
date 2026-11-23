using System;

namespace PawFect_Match.Models
{
    public class CompatibilityResult
    {
        public int ScoreID { get; set; }
        public int ApplicationID { get; set; }

        public decimal TotalScore { get; set; }
        public bool SafetyPassed { get; set; }

        public string SafetyNotes { get; set; }
        public string ScoreVersion { get; set; }

        public DateTime CalculatedAt { get; set; }

        public CompatibilityResult()
        {
            SafetyNotes = "";
            ScoreVersion = "1.0";
            CalculatedAt = DateTime.Now;
        }
    }
}