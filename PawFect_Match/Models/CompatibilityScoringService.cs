
using System.Collections.Generic;
using PawFect_Match.Models;

namespace PawFect_Match.Services
{
    public class CompatibilityScoringService
    {
        public CompatibilityResult CalculateScore(
            Adopter adopter,
            Animal animal,
            int applicationID)
        {
            CompatibilityResult result = new CompatibilityResult();

            result.ApplicationID = applicationID;

            List<CompatibilityScoreDetail> details =
                new List<CompatibilityScoreDetail>();

            decimal totalScore = 0;

            // 1. Animal Type Preference - 20%
            AddScore(details, ref totalScore,
                "Animal Type", 20,
                adopter.PreferredAnimal, animal.Species);

            // 2. Animal Size Preference - 15%
            AddScore(details, ref totalScore,
                "Animal Size", 15,
                adopter.PreferredSize, animal.Size);

            // 3. Living Arrangement - 20%
            string suitableHome = "Any";

            if (animal.Species == "Dog" &&
                adopter.HomeType == "Apartment")
            {
                suitableHome = "Apartment";
            }
            else if (animal.Species == "Cat")
            {
                suitableHome = "Any";
            }

            AddScore(details, ref totalScore,
                "Living Arrangement", 20,
                adopter.HomeType, suitableHome);

            // 4. Yard Availability - 15%
            string yardPreference = "Any";

            if (animal.Species == "Dog" &&
                animal.Size == "Large")
            {
                yardPreference = "Yard";
            }

            string adopterYard = adopter.HasYard ? "Yard" : "No Yard";

            AddScore(details, ref totalScore,
                "Yard Availability", 15,
                adopterYard, yardPreference);

            // 5. Activity Level - 20%
            AddScore(details, ref totalScore,
                "Activity Level", 20,
                adopter.ActivityLevel, animal.ActivityLevel);

            // 6. Other Pets Compatibility - 10%
            string otherPets = adopter.HasOtherPets ? "Yes" : "No";

            AddScore(details, ref totalScore,
                "Other Pets", 10,
                otherPets, "Any");

            result.TotalScore = totalScore;
            result.SafetyPassed = false;

            return result;
        }

        private void AddScore(
            List<CompatibilityScoreDetail> details,
            ref decimal totalScore,
            string criterion,
            decimal weight,
            string adopterValue,
            string animalValue)
        {
            decimal matchFactor = 0;

            if (adopterValue == "Any" ||
                animalValue == "Any")
            {
                matchFactor = 1;
            }
            else if (!string.IsNullOrWhiteSpace(adopterValue) &&
                     !string.IsNullOrWhiteSpace(animalValue))
            {
                if (adopterValue.ToLower() ==
                    animalValue.ToLower())
                {
                    matchFactor = 1;
                }
                else
                {
                    matchFactor = 0;
                }
            }

            decimal earnedPoints = weight * matchFactor;

            CompatibilityScoreDetail detail =
                new CompatibilityScoreDetail();

            detail.CriterionName = criterion;
            detail.Weight = weight;
            detail.MatchFactor = matchFactor;
            detail.EarnedPoints = earnedPoints;

            details.Add(detail);

            totalScore += earnedPoints;
        }
    }
}
