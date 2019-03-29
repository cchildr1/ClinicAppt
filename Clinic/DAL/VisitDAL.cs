using Clinic.Model;
using System;
using System.Collections.Generic;
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
            //throw arg exec if visit is null.
            if (visit is null)
            {
                throw new ArgumentException("Visit object cannot be null");
            }

            //throw arg exec if there is no Nurse in Visit.
            if (visit.Nurse is null)
            {
                throw new ArgumentException("The Visit object has no Nurse specified.");
            }

            //throw arg exec if there is no Appointment in Visit.
            if (visit.Appointment is null)
            {
                throw new ArgumentException("The Visit object has no Appointment specified.");
            }

            string insertStatement = "INSERT visit (id, visit_datetime, weight, bp_systolic, bp_diastolic, body_temp, " +
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
                        insertCommand.Parameters.AddWithValue("@nurse_id", visit.Nurse.NurseID);
                        insertCommand.Parameters.AddWithValue("@appointment_id", visit.Appointment.AppointmentID);
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

        /// <summary>
        /// Returns all visits in DB
        /// </summary>
        /// <returns>List of all visits</returns>
        public List<Visit> GetAllVisits()
        {
            AppointmentDAL appointmentDAL = new AppointmentDAL();
            List<Visit> visits = new List<Visit>();
            string selectStatement = "SELECT * FROM visit;";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Visit visit = new Visit
                            {
                                VisitId = (int)reader["id"],
                                DateTime = (DateTime)reader["visit_datetime"],
                                Weight = (decimal)reader["weight"],
                                BpSystolic = (int)reader["bp_systolic"],
                                BpDiastolic = (int)reader["bp_diastolic"],
                                BodyTemperature = (decimal)reader["body_temp"],
                                Pulse = (int)reader["pulse"],
                                Symptoms = reader["symptoms"].ToString(),
                                Info = reader["checkup_info"].ToString(),
                                Nurse = NurseDAL.GetNurseByID((int)reader["nurse_id"]),
                                Appointment = appointmentDAL.GetAppointmentByID((int)reader["appointment_id"]),                               
                                InitialDiagnosis = reader["initial_diagnosis"].ToString(),
                                FinalDiagnosis = reader["final_diagnosis"].ToString()
                            };
                            visits.Add(visit);
                        }
                    }
                }
                connection.Close();
            }
            return visits;
        }

        /// <summary>
        /// Returns a visit specified by it's ID
        /// </summary>
        /// <param name="id">visit id</param>
        /// <returns></returns>
        public Visit GetVisitByID(int id)
        {
            AppointmentDAL appointmentDAL = new AppointmentDAL();
            Visit visit = new Visit();
            string selectStatement = "SELECT * FROM visit WHERE id = @visitID;";
            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@visitID", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            visit.VisitId = (int)reader["id"];
                            visit.DateTime = (DateTime)reader["visit_datetime"];
                            visit.Weight = (decimal)reader["weight"];
                            visit.BpSystolic = (int)reader["bp_systolic"];
                            visit.BpDiastolic = (int)reader["bp_diastolic"];
                            visit.BodyTemperature = (decimal)reader["body_temp"];
                            visit.Pulse = (int)reader["pulse"];
                            visit.Symptoms = reader["symptoms"].ToString();
                            visit.Info = reader["checkup_info"].ToString();
                            visit.Nurse = NurseDAL.GetNurseByID((int)reader["nurse_id"]);
                            visit.Appointment = appointmentDAL.GetAppointmentByID((int)reader["appointment_id"]);
                            visit.InitialDiagnosis = reader["initial_diagnosis"].ToString();
                            visit.FinalDiagnosis = reader["final_diagnosis"].ToString();

                        }
                    }
                }
                connection.Close();
            }
            return visit;
        }
    }
}
