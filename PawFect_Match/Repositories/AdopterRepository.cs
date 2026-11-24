
using System;
using System.Data;
using System.Data.SqlClient;
using PawFect_Match.Data;
using PawFect_Match.Models;

namespace PawFect_Match.Repositories
{
    public class AdopterRepository
    {
        // Save a new adopter profile
        public int AddAdopterProfile(Adopter adopter)
        {
            if (adopter == null)
            {
                throw new ArgumentNullException("adopter");
            }

            using (SqlConnection connection =
                DatabaseConnection.GetConnection())
            {
                string query = @"
                    INSERT INTO tbl_Adopters
                    (
                        UserID, FullName, Phone, Address,
                        PreferredAnimal, PreferredSize, HomeType,
                        HasYard, HasFencedYard, ActivityLevel,
                        HasOtherPets, OtherPetDetails,
                        HasChildren, ChildrenAgeGroup, ExperienceLevel
                    )
                    VALUES
                    (
                        @UserID, @FullName, @Phone, @Address,
                        @PreferredAnimal, @PreferredSize, @HomeType,
                        @HasYard, @HasFencedYard, @ActivityLevel,
                        @HasOtherPets, @OtherPetDetails,
                        @HasChildren, @ChildrenAgeGroup, @ExperienceLevel
                    );

                    SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@UserID", SqlDbType.Int).Value =
                        adopter.UserID;

                    command.Parameters.Add("@FullName", SqlDbType.NVarChar, 150).Value =
                        adopter.FullName;

                    command.Parameters.Add("@Phone", SqlDbType.NVarChar, 30).Value =
                        adopter.Phone;

                    command.Parameters.Add("@Address", SqlDbType.NVarChar, 255).Value =
                        adopter.Address;

                    command.Parameters.Add("@PreferredAnimal", SqlDbType.NVarChar, 30).Value =
                        adopter.PreferredAnimal;

                    command.Parameters.Add("@PreferredSize", SqlDbType.NVarChar, 30).Value =
                        adopter.PreferredSize;

                    command.Parameters.Add("@HomeType", SqlDbType.NVarChar, 50).Value =
                        adopter.HomeType;

                    command.Parameters.Add("@HasYard", SqlDbType.Bit).Value =
                        adopter.HasYard;

                    command.Parameters.Add("@HasFencedYard", SqlDbType.Bit).Value =
                        adopter.HasFencedYard;

                    command.Parameters.Add("@ActivityLevel", SqlDbType.NVarChar, 30).Value =
                        adopter.ActivityLevel;

                    command.Parameters.Add("@HasOtherPets", SqlDbType.Bit).Value =
                        adopter.HasOtherPets;

                    command.Parameters.Add("@OtherPetDetails", SqlDbType.NVarChar, 500).Value =
                        adopter.OtherPetDetails;

                    command.Parameters.Add("@HasChildren", SqlDbType.Bit).Value =
                        adopter.HasChildren;

                    command.Parameters.Add("@ChildrenAgeGroup", SqlDbType.NVarChar, 50).Value =
                        adopter.ChildrenAgeGroup;

                    command.Parameters.Add("@ExperienceLevel", SqlDbType.NVarChar, 50).Value =
                        adopter.ExperienceLevel;

                    connection.Open();

                    int adopterID =
                        Convert.ToInt32(command.ExecuteScalar());

                    adopter.AdopterID = adopterID;

                    return adopterID;
                }
            }
        }

        // Retrieve an adopter profile using the UserID
        public Adopter GetAdopterByUserID(int userID)
        {
            using (SqlConnection connection =
                DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT *
                    FROM tbl_Adopters
                    WHERE UserID = @UserID";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@UserID", SqlDbType.Int).Value =
                        userID;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        Adopter adopter = new Adopter();

                        adopter.AdopterID =
                            Convert.ToInt32(reader["AdopterID"]);

                        adopter.UserID =
                            Convert.ToInt32(reader["UserID"]);

                        adopter.FullName = reader["FullName"].ToString();
                        adopter.Phone = reader["Phone"].ToString();
                        adopter.Address = reader["Address"].ToString();

                        adopter.PreferredAnimal =
                            reader["PreferredAnimal"].ToString();

                        adopter.PreferredSize =
                            reader["PreferredSize"].ToString();

                        adopter.HomeType = reader["HomeType"].ToString();

                        adopter.HasYard =
                            Convert.ToBoolean(reader["HasYard"]);

                        adopter.HasFencedYard =
                            Convert.ToBoolean(reader["HasFencedYard"]);

                        adopter.ActivityLevel =
                            reader["ActivityLevel"].ToString();

                        adopter.HasOtherPets =
                            Convert.ToBoolean(reader["HasOtherPets"]);

                        adopter.OtherPetDetails =
                            reader["OtherPetDetails"].ToString();

                        adopter.HasChildren =
                            Convert.ToBoolean(reader["HasChildren"]);

                        adopter.ChildrenAgeGroup =
                            reader["ChildrenAgeGroup"].ToString();

                        adopter.ExperienceLevel =
                            reader["ExperienceLevel"].ToString();

                        return adopter;
                    }
                }
            }
        }
    }
}
