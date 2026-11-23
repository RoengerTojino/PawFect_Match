using System;

namespace PawFect_Match.Models
{
    public abstract class Animal
    {
        public int AnimalID { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Size { get; set; }
        public string ActivityLevel { get; set; }
        public string Description { get; set; }
        public string PhotoPath { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsArchived { get; set; }

        protected Animal()
        {
            Name = "";
            Species = "";
            Breed = "";
            Gender = "";
            Size = "";
            ActivityLevel = "";
            Description = "";
            PhotoPath = "";
            Status = "Available";
            CreatedAt = DateTime.Now;
            IsArchived = false;
        }
    }
}