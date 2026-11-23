namespace PawFect_Match.Models
{
    public class AnimalRequirement
    {
        public int AnimalID { get; set; }

        public bool RequiresFencedYard { get; set; }
        public bool GoodWithChildren { get; set; }
        public bool GoodWithOtherPets { get; set; }

        public string MinimumExperience { get; set; }
        public string RequirementNotes { get; set; }

        public bool RequirementsVerified { get; set; }

        public AnimalRequirement()
        {
            MinimumExperience = "";
            RequirementNotes = "";
            RequirementsVerified = false;
        }
    }
}