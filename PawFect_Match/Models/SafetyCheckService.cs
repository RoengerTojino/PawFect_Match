using System;
using PawFect_Match.Models;

namespace PawFect_Match.Services
{
    public class SafetyCheckService
    {
        public SafetyCheckResult CheckAdopter(
            Adopter adopter,
            AnimalRequirement requirement)
        {
            SafetyCheckResult result = new SafetyCheckResult();

            // Check for missing information
            if (adopter == null || requirement == null)
            {
                result.NeedsReview = true;
                result.Issues.Add("Adopter or animal requirements are missing.");
                return result;
            }

            // Requirements must be verified by an administrator
            if (!requirement.RequirementsVerified)
            {
                result.NeedsReview = true;
                result.Issues.Add("Animal requirements have not been verified.");
            }

            // Fenced yard requirement
            if (requirement.RequiresFencedYard && !adopter.HasFencedYard)
            {
                result.Issues.Add("This animal requires a fenced yard.");
            }

            // Children compatibility
            if (adopter.HasChildren && !requirement.GoodWithChildren)
            {
                result.Issues.Add("This animal is not marked as suitable for children.");
            }

            // Other pets compatibility
            if (adopter.HasOtherPets && !requirement.GoodWithOtherPets)
            {
                result.Issues.Add("This animal is not marked as suitable for other pets.");
            }

            // Experience requirement
            if (!string.IsNullOrWhiteSpace(requirement.MinimumExperience))
            {
                if (string.IsNullOrWhiteSpace(adopter.ExperienceLevel))
                {
                    result.NeedsReview = true;
                    result.Issues.Add("Adopter experience level is missing.");
                }
                else
                {
                    int requiredLevel = GetExperienceRank(
                        requirement.MinimumExperience);

                    int adopterLevel = GetExperienceRank(
                        adopter.ExperienceLevel);

                    if (requiredLevel == 0 || adopterLevel == 0)
                    {
                        result.NeedsReview = true;
                        result.Issues.Add("Experience level needs administrator review.");
                    }
                    else if (adopterLevel < requiredLevel)
                    {
                        result.Issues.Add(
                            "Adopter does not meet the minimum experience requirement.");
                    }
                }
            }

            // Passed only when there are no issues requiring attention
            result.Passed =
                result.Issues.Count == 0 &&
                !result.NeedsReview;

            return result;
        }

        private int GetExperienceRank(string level)
        {
            switch (level.Trim().ToLower())
            {
                case "beginner":
                    return 1;

                case "intermediate":
                    return 2;

                case "experienced":
                    return 3;

                default:
                    return 0;
            }
        }
    }
}