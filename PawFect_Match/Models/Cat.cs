namespace PawFect_Match.Models
{
    public class Cat : Animal
    {
        public string Temperament { get; set; }
        public bool IndoorPreference { get; set; }

        public Cat()
        {
            Species = "Cat";
            Temperament = "";
        }
    }
}