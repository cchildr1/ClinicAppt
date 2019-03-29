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

        /// <summary>
        /// updates a visit with new information
        /// </summary>
        /// <param name="oldVisit">object containing the old information</param>
        /// <param name="newVisit">object containing the new information</param>
        /// <returns>true if updated one row, false otherwise</returns>
        public bool UpdateVisit(Visit oldVisit, Visit newVisit)
        {
            string statement = "UPDATE visit " +
                "SET visit_datetime = @newDateTime, " +
                "weight = @newWeight, " +
                "bp_systolic = @newbp_systolic, " +
                "bp_diastolic = @newbp_diastolic, " +
                "body_temp = @newbody_temp, " +
                "pulse = @newpulse, " +
                "symptoms = @newsymptoms, " +
                "checkup_info = @newcheckup_info, " +
                "nurse_id = @newnurse_id, " +
                "appointment_id = @newappointment_id, " +
                "initial_diagnosis = @newinitial_diagnosis, " +
                "final_diagnosis = @newfinal_diagnosis " +
                "WHERE visit_datetime = @oldDateTime AND " +
                "weight = @oldWeight AND " +
                "bp_systolic = @oldbp_systolic AND " +
                "bp_diastolic = @oldbp_diastolic AND " +
                "body_temp = @oldbody_temp AND " +
                "pulse = @oldpulse AND " +
                "symptoms = @oldsymptoms AND " +
                "checkup_info = @oldcheckup_info AND " +
                "nurse_id = @oldnurse_id AND " +
                "appointment_id = @oldappointment_id AND " +
                "initial_diagnosis = @oldinitial_diagnosis AND " +
                "final_diagnosis = @oldfinal_diagnosis;";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand update = new SqlCommand(statement, connection))
                {
                    update.Parameters.AddWithValue("@newDateTime", newVisit.DateTime);
                    update.Parameters.AddWithValue("@newWeight", newVisit.Weight);
                    update.Parameters.AddWithValue("@newbp_systolic", newVisit.BpSystolic);
                    update.Parameters.AddWithValue("@newbp_diastolic", newVisit.BpDiastolic);
                    update.Parameters.AddWithValue("@newbody_temp", newVisit.BodyTemperature);
                    update.Parameters.AddWithValue("@newpulse", newVisit.Pulse);
                    update.Parameters.AddWithValue("@newsymptoms", newVisit.Symptoms);
                    update.Parameters.AddWithValue("@newcheckup_info", newVisit.Info);
                    update.Parameters.AddWithValue("@newnurse_id", newVisit.Nurse.NurseID);
                    update.Parameters.AddWithValue("@newappointment_id", newVisit.Appointment.AppointmentID);
                    update.Parameters.AddWithValue("@newinitial_diagnosis", newVisit.InitialDiagnosis);
                    update.Parameters.AddWithValue("@newfinal_diagnosis", newVisit.FinalDiagnosis);

                    update.Parameters.AddWithValue("@oldDateTime", oldVisit.DateTime);
                    update.Parameters.AddWithValue("@oldWeight", oldVisit.Weight);
                    update.Parameters.AddWithValue("@oldbp_systolic", oldVisit.BpSystolic);
                    update.Parameters.AddWithValue("@oldbp_diastolic", oldVisit.BpDiastolic);
                    update.Parameters.AddWithValue("@oldbody_temp", oldVisit.BodyTemperature);
                    update.Parameters.AddWithValue("@oldpulse", oldVisit.Pulse);
                    update.Parameters.AddWithValue("@oldsymptoms", oldVisit.Symptoms);
                    update.Parameters.AddWithValue("@oldcheckup_info", oldVisit.Info);
                    update.Parameters.AddWithValue("@oldnurse_id", oldVisit.Nurse.NurseID);
                    update.Parameters.AddWithValue("@oldappointment_id", oldVisit.Appointment.AppointmentID);
                    update.Parameters.AddWithValue("@oldinitial_diagnosis", oldVisit.InitialDiagnosis);
                    update.Parameters.AddWithValue("@oldfinal_diagnosis", oldVisit.FinalDiagnosis);

                    int count = update.ExecuteNonQuery();
                    connection.Close();
                    return count > 0;

                }
            }
        }
    }
}
