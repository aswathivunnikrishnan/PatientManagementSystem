using PatientManagementsystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PatientManagementsystem.DAL
{
    public class PatientDBHelper
    {
        private SqlConnection con;
        private void Connection()
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\180933\\source\\repos\\PatientManagementSystem\\PatientManagementsystem\\App_Data\\PatientDB.mdf;Integrated Security=True";
            con = new SqlConnection(constring);
        }
        public bool CreatePatientDetails(Patient obj)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("CreatePatient", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@Patient_id", obj.Patient_id);
            cmd.Parameters.AddWithValue("@Patient_FName", obj.FName);
            cmd.Parameters.AddWithValue("@Patient_lName", obj.LName);
            cmd.Parameters.AddWithValue("@Patient_Gender", obj.Patient_Gender);
            cmd.Parameters.AddWithValue("@Patient_Age", obj.Patient_Age);
            cmd.Parameters.AddWithValue("@Patient_Address", obj.Patient_Address);
            cmd.Parameters.AddWithValue("@PhoneNumber", obj.PhoneNumber);
            cmd.Parameters.AddWithValue("@Email", obj.Email);
            cmd.Parameters.AddWithValue("@DeletedStatus", 1);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        public List<Patient> GetAll()
        {
            Connection();
            List<Patient> PatientList = new List<Patient>();

            SqlCommand cmd = new SqlCommand("GetAllPatients", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                sd.Fill(dt);
                con.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    PatientList.Add(
                        new Patient
                        {
                            Patient_id = Convert.ToInt32(dr["Id"]),
                            FName = Convert.ToString(dr["Name"]),
                            LName = Convert.ToString(dr["LastName"]),
                            Patient_Gender = Convert.ToString(dr["Age"]),
                            Patient_Age = Convert.ToInt32(dr["Gender"]),
                            Patient_Address = Convert.ToString(dr["dateTime"]),
                            PhoneNumber = Convert.ToInt32(dr["InPatient"]),
                            Email = Convert.ToString(dr["Created_by"]),
                            

                        });
                }
                }
            catch (Exception)
            {
                throw;
            }
            return PatientList;
        }
    }
}