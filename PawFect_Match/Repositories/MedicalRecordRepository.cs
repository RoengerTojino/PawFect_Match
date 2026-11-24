
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PawFect_Match.Data;
using PawFect_Match.Models;

namespace PawFect_Match.Repositories
{
    public class MedicalRecordRepository
    {
        // Retrieve all medical records of an animal
        public List<MedicalRecord> GetRecordsByAnimalID(int animalID)
        {
            List<MedicalRecord> records =
                new List<MedicalRecord>();

            using (SqlConnection connection =
                DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT MedicalRecordID, AnimalID,
                           RecordType, Description,
                           RecordDate, NextDueDate,
                           CreatedBy, IsArchived
                    FROM tbl_MedicalRecords
                    WHERE AnimalID = @AnimalID
                    AND IsArchived = 0
                    ORDER BY RecordDate DESC";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@AnimalID", SqlDbType.Int).Value = animalID;

                    connection.Open();

                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MedicalRecord record =
                                new MedicalRecord();

                            record.MedicalRecordID =
                                Convert.ToInt32(reader["MedicalRecordID"]);

                            record.AnimalID =
                                Convert.ToInt32(reader["AnimalID"]);

                            record.RecordType =
                                reader["RecordType"].ToString();

                            record.Description =
                                reader["Description"].ToString();

                            record.RecordDate =
                                Convert.ToDateTime(reader["RecordDate"]);

                            record.NextDueDate =
                                reader["NextDueDate"] == DBNull.Value
                                ? (DateTime?)null
                                : Convert.ToDateTime(reader["NextDueDate"]);

                            record.CreatedBy =
                                Convert.ToInt32(reader["CreatedBy"]);

                            record.IsArchived =
                                Convert.ToBoolean(reader["IsArchived"]);

                            records.Add(record);
                        }
                    }
                }
            }

            return records;
        }

        // Add a new medical record
        public int AddMedicalRecord(MedicalRecord record)
        {
            if (record == null)
            {
                throw new ArgumentNullException("record");
            }

            using (SqlConnection connection =
                DatabaseConnection.GetConnection())
            {
                string query = @"
                    INSERT INTO tbl_MedicalRecords
                    (
                        AnimalID, RecordType, Description,
                        RecordDate, NextDueDate, CreatedBy, IsArchived
                    )
                    VALUES
                    (
                        @AnimalID, @RecordType, @Description,
                        @RecordDate, @NextDueDate, @CreatedBy, @IsArchived
                    );

                    SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@AnimalID", SqlDbType.Int).Value =
                        record.AnimalID;

                    command.Parameters.Add(
                        "@RecordType", SqlDbType.NVarChar, 50).Value =
                        record.RecordType;

                    command.Parameters.Add(
                        "@Description", SqlDbType.NVarChar, -1).Value =
                        record.Description;

                    command.Parameters.Add(
                        "@RecordDate", SqlDbType.DateTime2).Value =
                        record.RecordDate;

                    command.Parameters.Add(
                        "@NextDueDate", SqlDbType.DateTime2).Value =
                        record.NextDueDate.HasValue
                        ? (object)record.NextDueDate.Value
                        : DBNull.Value;

                    command.Parameters.Add(
                        "@CreatedBy", SqlDbType.Int).Value =
                        record.CreatedBy;

                    command.Parameters.Add(
                        "@IsArchived", SqlDbType.Bit).Value =
                        record.IsArchived;

                    connection.Open();

                    int recordID =
                        Convert.ToInt32(command.ExecuteScalar());

                    record.MedicalRecordID = recordID;

                    return recordID;
                }
            }
        }
    }
}
