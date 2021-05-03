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
    public partial class ShowAllDoctor : Form
    {
        public ShowAllDoctor()
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
        List<Doctor> GetAllDoctors()
        {
            var conn = DBConnection.Connect();
            List<Doctor> doctors = new List<Doctor>();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = "select * from doctor_reg";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //set the doctor class property value
                    Doctor d = new Doctor();
                    d.Doctor_Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    d.Doctor_Name = reader.GetString(reader.GetOrdinal("Name"));
                    d.Doctor_Email = reader.GetString(reader.GetOrdinal("Email"));
                    d.Doctor_Mobile_No = reader.GetString(reader.GetOrdinal("MobileNo"));
                    d.Doctor_Address = reader.GetString(reader.GetOrdinal("Address"));
                    d.Doctor_Type = reader.GetString(reader.GetOrdinal("Doctor_Type"));
                    d.Doctor_Gender = reader.GetString(reader.GetOrdinal("Gender"));
                    d.Doctor_Shift = reader.GetString(reader.GetOrdinal("Shift"));
                    d.Doctor_Date_of_Birth = reader.GetString(reader.GetOrdinal("Date_of_Birth"));
                    doctors.Add(d);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return doctors;
        }


        //When just run/Refresh the From. Data will Automatically Loaded from Database
        private void ShowAllDoctor_Load(object sender, EventArgs e)
        {
            var doctors = GetAllDoctors();
            dtShowAllDoctor.DataSource = doctors;
        }

        //after click on the back button dashboard will visible
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DashBord().Show();

        }
    }
}
