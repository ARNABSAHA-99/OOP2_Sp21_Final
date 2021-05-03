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
    public partial class DeletePatient : Form
    {
        public DeletePatient()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
            { Application.Exit(); }
        }


        private void DeleteInfo_Load(object sender, EventArgs e)
        {

        }

        //to delete a user I have to serach with user id first put user id then tap on the search button
        private void btnDeleteSearch_Click(object sender, EventArgs e) 
        {
            //null validation if any user press the serach button without put a value
            string deleteSearch = "";

            string errMsg = null;

            if (tbDeleteSearch.Text.Equals(""))
            {
                errMsg += "\nPlease enter any Id";
            }
            else
            {
                deleteSearch = tbDeleteSearch.Text;
            }
            if (errMsg == null)
            {
                //desire row value is come from database for desire user id which I want to delete
                List<Patient> GetOnePatient() //method for retrive row value for individual user id
                {
                    var conn = DBConnection.Connect();
                    List<Patient> patient = new List<Patient>();
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    //show patient id info which value is currently put in the search box
                    int id = Int32.Parse(tbDeleteSearch.Text); 
                    string query = "select * from patient where id = " + id;

                    try
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            //show the all value for respective patient id
                            Patient p = new Patient();
                            p.Patient_Id = reader.GetInt32(reader.GetOrdinal("Id"));
                            p.Patient_Name = reader.GetString(reader.GetOrdinal("Name"));
                            p.Patient_Email = reader.GetString(reader.GetOrdinal("Email"));
                            p.Patient_Mobile_No = reader.GetString(reader.GetOrdinal("MobileNo"));
                            p.Patient_Gender = reader.GetString(reader.GetOrdinal("Gender"));
                            p.Patient_Age = reader.GetString(reader.GetOrdinal("Age"));
                            p.Patient_Weight = reader.GetString(reader.GetOrdinal("Weight"));
                            p.Patient_Date_of_Birth = reader.GetString(reader.GetOrdinal("DateofBirth"));
                            patient.Add(p);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    conn.Close();
                    return patient;
                }

                //row data is appear in the data grid view which user id I want to delete
                var onepatient = GetOnePatient(); //
                dtDeletePatient.DataSource = onepatient;


            }
            else { MessageBox.Show(errMsg); }
        }

        void RefreshControls() // Refresh funtion to blank the serach box after delete the user info
        {
            tbDeleteSearch.Text = "";
            
        }

        //Delete the specific Id which searched
        private void btnDeleteInfo_Click(object sender, EventArgs e) 
        {
            //null validation if any user press the delete button without put a value in search box
            string deleteSearch = "";
            string errMsg = null;

            if (tbDeleteSearch.Text.Equals(""))
            {
                errMsg += "\nPlease enter any Id in the search box";
            }
            else
            {
                deleteSearch = tbDeleteSearch.Text;
            }
            if (errMsg == null)
            {

                //to delete the value individual patient info

                var conn = DBConnection.Connect();
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //delete patient id info which is currently show in the search box
                int id = Int32.Parse(tbDeleteSearch.Text); 
                string query = "delete from patient where id = " + id;

                SqlCommand cmd = new SqlCommand(query, conn);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("Patient Info Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Failed to Delete Patient Info");
                }
                conn.Close();
                RefreshControls(); //after delation search box will be empty
                dtDeletePatient.DataSource = ""; //after delation data grid view will be empty

            }
            else {MessageBox.Show(errMsg); }
        }

        private void btnBack_Click(object sender, EventArgs e)//back to dashboard
        {
            this.Hide();
            new DashBord().Show();
        }

        private void btnGo_Click(object sender, EventArgs e)//go to showinfo page
        {
            this.Hide();
            new ShowPatient().Show();
        }
    }
}
