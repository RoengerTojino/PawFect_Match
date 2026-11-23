using System;

namespace PawFect_Match.Models
{
    public class MedicalRecord
    {
        public int MedicalRecordID { get; set; }
        public int AnimalID { get; set; }

        public string RecordType { get; set; }
        public string Description { get; set; }

        public DateTime RecordDate { get; set; }
        public DateTime? NextDueDate { get; set; }

        public int CreatedBy { get; set; }
        public bool IsArchived { get; set; }

        public MedicalRecord()
        {
            RecordType = "";
            Description = "";
            RecordDate = DateTime.Now;
            IsArchived = false;
        }
    }
}