
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PawFect_Match.Data;
using PawFect_Match.Models;

namespace PawFect_Match.Repositories
{
    public class AnimalRepository
    {
        // Retrieve all available animals
        public List<Animal> GetAvailableAnimals()
        {
            List<Animal> animals = new List<Animal>();

            using (SqlConnection connection =
                DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT AnimalID, Name, Species, Breed, Age,
                           Gender, Size, ActivityLevel, Description,
                           PhotoPath, Status, CreatedAt, IsArchived
                    FROM tbl_Animals
                    WHERE Status = @Status
                    AND IsArchived = 0
                    ORDER BY CreatedAt DESC";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@Status", SqlDbType.VarChar, 30).Value = "Available";

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Animal animal = CreateAnimalFromReader(reader);

                            if (animal != null)
                            {
                                animals.Add(animal);
                            }
                        }
                    }
                }
            }

            return animals;
        }

        // Retrieve one animal using its ID
        public Animal GetAnimalByID(int animalID)
        {
            using (SqlConnection connection =
                DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT AnimalID, Name, Species, Breed, Age,
                           Gender, Size, ActivityLevel, Description,
                           PhotoPath, Status, CreatedAt, IsArchived
                    FROM tbl_Animals
                    WHERE AnimalID = @AnimalID
                    AND IsArchived = 0";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@AnimalID", SqlDbType.Int).Value = animalID;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return CreateAnimalFromReader(reader);
                        }
                    }
                }
            }

            return null;
        }

        // Convert database records into Dog or Cat objects
        private Animal CreateAnimalFromReader(SqlDataReader reader)
        {
            string species = reader["Species"].ToString();

            Animal animal;

            if (species.Equals("Dog",
                StringComparison.OrdinalIgnoreCase))
            {
                animal = new Dog();
            }
            else if (species.Equals("Cat",
                StringComparison.OrdinalIgnoreCase))
            {
                animal = new Cat();
            }
            else
            {
                return null;
            }

            animal.AnimalID = Convert.ToInt32(reader["AnimalID"]);
            animal.Name = reader["Name"].ToString();
            animal.Species = species;
            animal.Breed = reader["Breed"].ToString();
            animal.Age = Convert.ToInt32(reader["Age"]);
            animal.Gender = reader["Gender"].ToString();
            animal.Size = reader["Size"].ToString();
            animal.ActivityLevel = reader["ActivityLevel"].ToString();
            animal.Description = reader["Description"].ToString();
            animal.PhotoPath = reader["PhotoPath"].ToString();
            animal.Status = reader["Status"].ToString();
            animal.CreatedAt = Convert.ToDateTime(reader["CreatedAt"]);
            animal.IsArchived = Convert.ToBoolean(reader["IsArchived"]);

            return animal;
        }
    }
}
