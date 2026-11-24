
using System;
using System.Data;
using System.Data.SqlClient;
using PawFect_Match.Data;
using PawFect_Match.Models;

namespace PawFect_Match.Repositories
{
    public class AnimalRequirementRepository
    {
        // Retrieve animal requirements using AnimalID
        public AnimalRequirement GetRequirementsByAnimalID(int animalID)
        {
            using (SqlConnection connection =
                DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT AnimalID,
                           RequiresFencedYard,
                           GoodWithChildren,
                           GoodWithOtherPets,
                           MinimumExperience,
                           RequirementNotes,
                           RequirementsVerified
                    FROM tbl_AnimalRequirements
                    WHERE AnimalID = @AnimalID";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@AnimalID", SqlDbType.Int).Value = animalID;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        AnimalRequirement requirement =
                            new AnimalRequirement();

                        requirement.AnimalID =
                            Convert.ToInt32(reader["AnimalID"]);

                        requirement.RequiresFencedYard =
                            Convert.ToBoolean(reader["RequiresFencedYard"]);

                        requirement.GoodWithChildren =
                            Convert.ToBoolean(reader["GoodWithChildren"]);

                        requirement.GoodWithOtherPets =
                            Convert.ToBoolean(reader["GoodWithOtherPets"]);

                        requirement.MinimumExperience =
                            reader["MinimumExperience"].ToString();

                        requirement.RequirementNotes =
                            reader["RequirementNotes"].ToString();

                        requirement.RequirementsVerified =
                            Convert.ToBoolean(reader["RequirementsVerified"]);

                        return requirement;
                    }
                }
            }
        }

        // Check whether requirements exist for an animal
        public bool RequirementsExist(int animalID)
        {
            using (SqlConnection connection =
                DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT COUNT(1)
                    FROM tbl_AnimalRequirements
                    WHERE AnimalID = @AnimalID";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@AnimalID", SqlDbType.Int).Value = animalID;

                    connection.Open();

                    int count = Convert.ToInt32(
                        command.ExecuteScalar());

                    return count > 0;
                }
            }
        }
    }
}
