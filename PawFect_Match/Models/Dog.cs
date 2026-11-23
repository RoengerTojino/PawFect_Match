namespace PawFect_Match.Models
{
    public class Dog : Animal
    {
        public string TrainingStatus { get; set; }

        public Dog()
        {
            Species = "Dog";
            TrainingStatus = "";
        }
    }
}