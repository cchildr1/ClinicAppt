using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Clinic.DAL
{
    public static class PatientDAL
    {
        public static List<Visit> GetAllVisitsByPatient(Patient patient)
        {
            List<Visit> visits = new List<Visit>();
            string selectStatement = "SELECT visit_datetime as visitTime, " +
                "weight, " +
                "bp_systolic AS bpSystolic, " +
                "bp_diastolic AS bpDiastolic, " +
                "body_temp AS bodyTemp, " +
                "pulse, " +
                "symptoms, " +
                "checkup_info AS checkupInfo, " +
                "nurse_id AS nurseID, " +
                "appointment_id AS appointmentID, " +
                "initial_diagnosis, " +
                "final_diagnosis, " +
                "scheduled_datetime AS appointmentTime, " +
                "reason_for_visit, " +
                "doctor_id AS doctorID, " +
                "patient_id AS patientID " +
                "FROM visit v " +
                "JOIN appointment a ON v.appointment_id = a.id AND a.patient_id = @patientID";

            using (SqlConnection connection = ClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@patientID", patient.PatientID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Visit visit = new Visit
                            {
                                DateTime = (DateTime)reader["visitTime"],
                                Weight = (decimal)reader["weight"],
                                BpSystolic = (int)reader["bpSystolic"],
                                BpDiastolic = (int)reader["bpDiastolic"],
                                BodyTemperature = (decimal)reader["bodyTemp"],
                                Pulse = (int)reader["pulse"],
                                Symptoms = reader["symptoms"].ToString(),
                                Info = reader["checkupInfo"].ToString(),
                                InitialDiagnosis = reader["initial_diagnosis"].ToString(),
                                FinalDiagnosis = reader["final_diagnosis"].ToString(),
                                Nurse = new Nurse
                                {
                                    NurseID = (int)reader["nurseID"]
                                },
                                Appointment = new Appointment
                                {
                                    AppointmentID = (int)reader["appointmentID"],
                                    Scheduled_Date = (DateTime)reader["appointmentTime"],
                                    Doctor = new Doctor
                                    {
                                        DoctorId = (int)reader["doctorID"]
                                    },
                                    Patient = patient,
                                    Reason_For_Visit = reader["reason_for_visit"].ToString()
                                }
                            };
                            visits.Add(visit);
                        }
                    }
                    return visits;
                }
            }
        }
    }
}
