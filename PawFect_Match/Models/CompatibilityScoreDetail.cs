namespace PawFect_Match.Models
{
    public class CompatibilityScoreDetail
    {
        public int ScoreDetailID { get; set; }
        public int ScoreID { get; set; }

        public string CriterionName { get; set; }

        public decimal Weight { get; set; }
        public decimal MatchFactor { get; set; }
        public decimal EarnedPoints { get; set; }

        public CompatibilityScoreDetail()
        {
            CriterionName = "";
        }
    }
}