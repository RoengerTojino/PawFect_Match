using System.Collections.Generic;

namespace PawFect_Match.Models
{
    public class SafetyCheckResult
    {
        public bool Passed { get; set; }
        public bool NeedsReview { get; set; }
        public List<string> Issues { get; set; }

        public SafetyCheckResult()
        {
            Passed = false;
            NeedsReview = false;
            Issues = new List<string>();
        }
    }
}