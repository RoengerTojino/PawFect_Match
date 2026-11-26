
using System;
using System.Data;
using System.Data.SqlClient;
using PawFect_Match.Data;
using PawFect_Match.Models;

namespace PawFect_Match.Repositories
{
    public class AdoptionHistoryRepository
    {
        public int AddAdoptionHistory(AdoptionHistory history)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                string query = @"
                    INSERT INTO tbl_AdoptionHistory
                    (ApplicationID, AdoptionDate, Notes)
                    VALUES
                    (@ApplicationID, @AdoptionDate, @Notes);

                    SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@ApplicationID", SqlDbType.Int)
                        .Value = history.ApplicationID;

                    command.Parameters.Add("@AdoptionDate", SqlDbType.DateTime2)
                        .Value = history.AdoptionDate;

                    command.Parameters.Add("@Notes", SqlDbType.VarChar, 500)
                        .Value = history.Notes ?? "";

                    int adoptionID = Convert.ToInt32(command.ExecuteScalar());

                    history.AdoptionID = adoptionID;

                    return adoptionID;
                }
            }
        }

        public AdoptionHistory GetHistoryByApplicationID(int applicationID)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT AdoptionID, ApplicationID, AdoptionDate, Notes
                    FROM tbl_AdoptionHistory
                    WHERE ApplicationID = @ApplicationID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@ApplicationID", SqlDbType.Int)
                        .Value = applicationID;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new AdoptionHistory
                            {
                                AdoptionID = Convert.ToInt32(reader["AdoptionID"]),
                                ApplicationID = Convert.ToInt32(reader["ApplicationID"]),
                                AdoptionDate = Convert.ToDateTime(reader["AdoptionDate"]),
                                Notes = reader["Notes"].ToString() ?? ""
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
