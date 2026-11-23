using System;

namespace PawFect_Match.Models
{
    public class AdoptionApplication
    {
        public int ApplicationID { get; set; }
        public int AnimalID { get; set; }
        public int AdopterID { get; set; }

        public DateTime SubmittedAt { get; set; }
        public ApplicationStatus Status { get; set; }

        public string AdopterMessage { get; set; }

        public int? ReviewedBy { get; set; }
        public DateTime? ReviewedAt { get; set; }
        public string ReviewNotes { get; set; }

        public AdoptionApplication()
        {
            SubmittedAt = DateTime.Now;
            Status = ApplicationStatus.Submitted;
            AdopterMessage = "";
            ReviewNotes = "";
        }
    }
}