using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Modern_Medical_Management_System
{
    public partial class ShowPatient : Form
    {
        public ShowPatient()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
            { Application.Exit(); }
        }



        //To show the all values from database this is the method
        List<Patient> GetAllPatients()
        {
            var conn = DBConnection.Connect();
            List<Patient> patients = new List<Patient>();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = "select * from patient";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Patient p = new Patient();
                    p.Patient_Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    p.Patient_Name = reader.GetString(reader.GetOrdinal("Name"));
                    p.Patient_Email = reader.GetString(reader.GetOrdinal("Email"));
                    p.Patient_Mobile_No = reader.GetString(reader.GetOrdinal("MobileNo"));
                    p.Patient_Gender = reader.GetString(reader.GetOrdinal("Gender"));
                    p.Patient_Age = reader.GetString(reader.GetOrdinal("Age"));
                    p.Patient_Weight = reader.GetString(reader.GetOrdinal("Weight"));
                    p.Patient_Date_of_Birth = reader.GetString(reader.GetOrdinal("DateofBirth"));
                    patients.Add(p);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return patients;
        }

        //When we just run/Refresh the From Data is Automatically Loaded from Database
        private void ShowInfo_Load(object sender, EventArgs e)
        {
            var patients = GetAllPatients();
            dtShowPatient.DataSource = patients;
        }

        //after click the back button dashboard page will visible
        private void btnBack_Click(object sender, EventArgs e)
        {
                this.Hide();
                new DashBord().Show(); 
        }

    }
}
