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
    public partial class EditPatient : Form
    {
        public EditPatient()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
            { Application.Exit(); }
        }

        //after click the search button
        private void btnSearch_Click(object sender, EventArgs e) 
        {
           //null validation for search button
            string searhBox = "";
          
            string errMsg = null;
            if (tbPsearch.Text.Equals(""))
            {
                errMsg += "\nSearch Any Patient Id which is available";
            }
            else
            {
                searhBox = tbPsearch.Text;
            }


            if (errMsg == null)
            {

                //all values will be appear for the respective id
                var conn = DBConnection.Connect();
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                int id = Int32.Parse(tbPsearch.Text); 
                string query = "select * from patient where id = " + id;

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                Patient p = new Patient();
                while (reader.Read())
                {

                    p.Patient_Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    p.Patient_Name = reader.GetString(reader.GetOrdinal("Name"));
                    p.Patient_Email = reader.GetString(reader.GetOrdinal("Email"));
                    p.Patient_Mobile_No = reader.GetString(reader.GetOrdinal("MobileNo"));
                    p.Patient_Gender = reader.GetString(reader.GetOrdinal("Gender"));
                    p.Patient_Age = reader.GetString(reader.GetOrdinal("Age"));
                    p.Patient_Weight = reader.GetString(reader.GetOrdinal("Weight"));
                    p.Patient_Date_of_Birth = reader.GetString(reader.GetOrdinal("DateofBirth"));



                }
                conn.Close();
                //all values are show in the respective box
                tbUpdatePname.Text = p.Patient_Name;
                tbUpdatePemail.Text = p.Patient_Email;
                tbUpdatePmobileNo.Text = p.Patient_Mobile_No;
                tbUpdatePgender.Text = p.Patient_Gender;
                tbUpdatePage.Text = p.Patient_Age;
                tbUpdatePweight.Text = p.Patient_Weight;
                tbUpdatePdob.Text = p.Patient_Date_of_Birth;
        }

            else {MessageBox.Show(errMsg); }
}


        //after click the update button
        private void btnUpdate_Click(object sender, EventArgs e) 
        {

            //null validation for update value
            string searhBox = "";
            string editName = "";
            string editEmail = "";
            string editMobileNo = "";
            string editGender = "";
            string editAge = "";
            string editWeight = "";
            string editDob = "";


            string errMsg = null;
            if (tbPsearch.Text.Equals(""))
            {
                errMsg += "\nSearch Any Patient Id which is available";
            }
            else
            {
                searhBox = tbPsearch.Text;
            }


            if (tbUpdatePname.Text.Equals(""))
            {
                errMsg += "\nUpdate Patient Name If needed";
            }
            else
            {
                editName = tbUpdatePname.Text;
            }


            if (tbUpdatePemail.Text.Equals(""))
            {
                errMsg += "\nUpdate Patient Email If needed";
            }
            else
            {
                editEmail = tbUpdatePemail.Text;
            }


            if (tbUpdatePmobileNo.Text.Equals(""))
            {
                errMsg += "\nUpdate Patient Mobile No If needed";
            }
            else
            {
                editMobileNo = tbUpdatePmobileNo.Text;
            }

            if (tbUpdatePgender.Text.Equals(""))
            {
                errMsg += "\nUpdate Patient Gender If needed";
            }
            else
            {
                editGender = tbUpdatePgender.Text;
            }


            if (tbUpdatePage.Text.Equals(""))
            {
                errMsg += "\nUpdate Patient Age If needed";
            }
            else
            {
                editAge = tbUpdatePage.Text;
            }


            if (tbUpdatePweight.Text.Equals(""))
            {
                errMsg += "\nUpdate Weight If needed";
            }
            else
            {
                editWeight = tbUpdatePweight.Text;
            }


            if (tbUpdatePdob.Text.Equals(""))
            {
                errMsg += "\nUpdate Patient Date of Birth If needed";
            }
            else
            {
                editDob = tbUpdatePdob.Text;
            }

            if (errMsg == null)
            {
                //edit the values in the indivdual box after that it will updated in the database
                int id = Int32.Parse(tbPsearch.Text); 
                string name = tbUpdatePname.Text.Trim();
                string email = tbUpdatePemail.Text.Trim();
                string mobile_no = tbUpdatePmobileNo.Text.Trim();
                string gender = tbUpdatePgender.Text.Trim();
                string age = tbUpdatePage.Text.Trim();
                string weight = tbUpdatePweight.Text.Trim();
                string dob = tbUpdatePdob.Text.Trim();

                var conn = DBConnection.Connect();
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                string query = string.Format("update patient set Name='{0}', Email='{1}', MobileNo='{2}', Gender='{3}', Age='{4}', Weight='{5}', DateofBirth='{6}'where id={7}", name, email, mobile_no, gender, age, weight, dob, id);

                SqlCommand cmd = new SqlCommand(query, conn);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("Patient Info Updated");
                }
                else
                {
                    MessageBox.Show("Failed to Update Patient Info");
                }
                conn.Close();
                RefreshControls(); //after update data every box will be empty
            }

            else { MessageBox.Show(errMsg);}
        }

        void RefreshControls() // Refresh funtion to blank the all form box after update data
        {
            tbPsearch.Text = "";
            tbUpdatePname.Text = "";
            tbUpdatePemail.Text = "";
            tbUpdatePmobileNo.Text = "";
            tbUpdatePgender.Text = "";
            tbUpdatePage.Text = "";
            tbUpdatePweight.Text = "";
            tbUpdatePdob.Text = "";

        }

        //after click the go button show all patient page will visible
        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShowPatient().Show();
        }

        //after click the back button dashboard page will visible
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DashBord().Show();
        }



        private void EditInfo_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
