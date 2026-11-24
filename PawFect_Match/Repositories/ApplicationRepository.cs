
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PawFect_Match.Data;
using PawFect_Match.Models;

namespace PawFect_Match.Repositories
{
    public class ApplicationRepository
    {
        // Save a new adoption application
        public int AddApplication(AdoptionApplication application)
        {
            if (application == null)
            {
                throw new ArgumentNullException("application");
            }

            using (SqlConnection connection =
                DatabaseConnection.GetConnection())
            {
                string query = @"
                    INSERT INTO tbl_Applications
                    (AnimalID, AdopterID, SubmittedAt, Status, AdopterMessage)
                    VALUES
                    (@AnimalID, @AdopterID, @SubmittedAt, @Status, @AdopterMessage);

                    SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@AnimalID", SqlDbType.Int).Value =
                        application.AnimalID;

                    command.Parameters.Add(
                        "@AdopterID", SqlDbType.Int).Value =
                        application.AdopterID;

                    command.Parameters.Add(
                        "@SubmittedAt", SqlDbType.DateTime2).Value =
                        application.SubmittedAt;

                    command.Parameters.Add(
                        "@Status", SqlDbType.VarChar, 30).Value =
                        application.Status.ToString();

                    command.Parameters.Add(
                        "@AdopterMessage", SqlDbType.NVarChar, -1).Value =
                        application.AdopterMessage ?? "";

                    connection.Open();

                    int applicationID =
                        Convert.ToInt32(command.ExecuteScalar());

                    application.ApplicationID = applicationID;

                    return applicationID;
                }
            }
        }

        // Retrieve all applications submitted by an adopter
        public List<AdoptionApplication> GetApplicationsByAdopter(
            int adopterID)
        {
            List<AdoptionApplication> applications =
                new List<AdoptionApplication>();

            using (SqlConnection connection =
                DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT ApplicationID, AnimalID, AdopterID,
                           SubmittedAt, Status, AdopterMessage,
                           ReviewedBy, ReviewedAt, ReviewNotes
                    FROM tbl_Applications
                    WHERE AdopterID = @AdopterID
                    ORDER BY SubmittedAt DESC";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@AdopterID", SqlDbType.Int).Value = adopterID;

                    connection.Open();

                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AdoptionApplication application =
                                new AdoptionApplication();

                            application.ApplicationID =
                                Convert.ToInt32(reader["ApplicationID"]);

                            application.AnimalID =
                                Convert.ToInt32(reader["AnimalID"]);

                            application.AdopterID =
                                Convert.ToInt32(reader["AdopterID"]);

                            application.SubmittedAt =
                                Convert.ToDateTime(reader["SubmittedAt"]);

                            ApplicationStatus status;

                            if (Enum.TryParse(
                                reader["Status"].ToString(),
                                out status))
                            {
                                application.Status = status;
                            }

                            application.AdopterMessage =
                                reader["AdopterMessage"] == DBNull.Value
                                ? ""
                                : reader["AdopterMessage"].ToString();

                            application.ReviewedBy =
                                reader["ReviewedBy"] == DBNull.Value
                                ? (int?)null
                                : Convert.ToInt32(reader["ReviewedBy"]);

                            application.ReviewedAt =
                                reader["ReviewedAt"] == DBNull.Value
                                ? (DateTime?)null
                                : Convert.ToDateTime(reader["ReviewedAt"]);

                            application.ReviewNotes =
                                reader["ReviewNotes"] == DBNull.Value
                                ? ""
                                : reader["ReviewNotes"].ToString();

                            applications.Add(application);
                        }
                    }
                }
            }

            return applications;
        }
    }
}
