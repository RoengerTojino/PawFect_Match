namespace PawFect_Match.Models
{
    public class Adopter : UserAccount
    {
        public int AdopterID { get; set; }

        // Personal Information
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        //sample
        // Animal Preferences
        public string PreferredAnimal { get; set; }
        public string PreferredSize { get; set; }

        // Household Information
        public string HomeType { get; set; }
        public bool HasYard { get; set; }
        public bool HasFencedYard { get; set; }

        // Lifestyle Information
        public string ActivityLevel { get; set; }

        // Other Pets
        public bool HasOtherPets { get; set; }
        public string OtherPetDetails { get; set; }

        // Children
        public bool HasChildren { get; set; }
        public string ChildrenAgeGroup { get; set; }

        // Experience
        public string ExperienceLevel { get; set; }

        public Adopter()
        {
            Role = UserRole.Adopter;

            FullName = "";
            Phone = "";
            Address = "";

            PreferredAnimal = "";
            PreferredSize = "";
            HomeType = "";

            ActivityLevel = "";

            OtherPetDetails = "";
            ChildrenAgeGroup = "";
            ExperienceLevel = "";
        }
    }
}