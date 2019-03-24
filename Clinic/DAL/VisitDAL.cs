using Clinic.Model;
using System;
using System.Data.SqlClient;

namespace Clinic.DAL
{
    class VisitDAL
    {
        /// <summary>
        /// Inserts a new Visit object into the database.
        /// </summary>
        /// <param name="visit">The visit object to insert.</param>
        /// <returns>The count of records added, if a record was added.</returns>
        public int AddNewVisit(Visit visit)
        {
            if (visit is null)
            {
                throw new ArgumentException("Visit object cannot be null");
            }

            string insertStatement = "INSERT visit (id,visit_datetime, weight, bp_systolic, bp_diastolic, body_temp, " +
                "pulse, symptoms, checkup_info, nurse_id, appointment_id, initial_diagnosis, final_diagnosis) " +
                "VALUES (@id, @visit_datetime, @weight, @bp_systolic, @bp_diastolic, @body_temp, @pulse, " +
                "@symptoms, @checkup_info, @nurse_id, @appointment_id, @initial_diagnosis, @final_diagnosis)";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@id", visit.VisitId);
                        insertCommand.Parameters.AddWithValue("@visit_datetime", visit.DateTime);
                        insertCommand.Parameters.AddWithValue("@weight", visit.Weight);
                        insertCommand.Parameters.AddWithValue("@bp_systolic", visit.BpSystolic);
                        insertCommand.Parameters.AddWithValue("@bp_diastolic", visit.BpDiastolic);
                        insertCommand.Parameters.AddWithValue("@body_temp", visit.BodyTemperature);
                        insertCommand.Parameters.AddWithValue("@pulse", visit.Pulse);
                        insertCommand.Parameters.AddWithValue("@symptoms", visit.Symptoms);
                        insertCommand.Parameters.AddWithValue("@checkup_info", visit.Info);
                        insertCommand.Parameters.AddWithValue("@nurse_id", visit.Nurse);
                        insertCommand.Parameters.AddWithValue("@appointment_id", visit.Appointment);
                        insertCommand.Parameters.AddWithValue("@initial_diagnosis", visit.InitialDiagnosis);
                        insertCommand.Parameters.AddWithValue("@final_diagnosis", visit.FinalDiagnosis);
                        insertCommand.ExecuteNonQuery();
                        string selectStatement = "SELECT IDENT_CURRENT('visit') FROM visit";
                        SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                        int visitID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return visitID;
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }
    }
}
