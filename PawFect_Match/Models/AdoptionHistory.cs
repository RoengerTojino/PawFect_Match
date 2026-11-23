using System;

namespace PawFect_Match.Models
{
    public class AdoptionHistory
    {
        public int AdoptionID { get; set; }
        public int ApplicationID { get; set; }

        public DateTime AdoptionDate { get; set; }
        public string Notes { get; set; }

        public AdoptionHistory()
        {
            AdoptionDate = DateTime.Now;
            Notes = "";
        }
    }
}