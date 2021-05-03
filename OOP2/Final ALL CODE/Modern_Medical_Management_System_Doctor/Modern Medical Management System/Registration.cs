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

namespace Modern_Medical_Management_System
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown) { Application.Exit(); }
        }

        //after clicking the registration button
        private void btnRegistration_Click(object sender, EventArgs e) 
        {
            //null validation for registration module

            string name = "";
            string email = "";
            string mobileno = "";
            string address = "";
            string password = "";
            string confrim_password = "";
            string type = "";
            string gender = "";
            string shift = "";
            string day = "";
            string month = "";
            string year = "";
           

            string errMsg = null;
            if (tbDname.Text.Equals(""))
            {
                errMsg += "\nName Requried";
            }
            else
            {
                name = tbDname.Text;
            }

            if (tbDemail.Text.Equals(""))
            {
                errMsg += "\nEmail Requried";
            }
            else
            {
                email = tbDemail.Text;
            }

            if (tbDmobileno.Text.Equals(""))
            {
                errMsg += "\nMobile Number Requried";
            }
            else
            {
                mobileno = tbDmobileno.Text;
            }

            if (tbDaddress.Text.Equals(""))
            {
                errMsg += "\nAddress Requried";
            }
            else
            {
                address = tbDaddress.Text;
            }

            if (tbDpassword.Text.Equals(""))
            {
                errMsg += "\nPassword Requried";
            }
            else
            {
                password = tbDpassword.Text;
            }

            if (tbDconfirmpassword.Text.Equals(""))
            {
                errMsg += "\nConfirm Password Requried";
            }
            else if (tbDpassword.Text != tbDconfirmpassword.Text)
            {
                errMsg += "\nPassword Doesn't match!! Type Again";
            }
            else
            {
                confrim_password = tbDconfirmpassword.Text;
            }

            if (cbDoctorType.SelectedItem == null)
            {
                errMsg += "\nSelect Any Type";
            }
            else
            {
                type = cbDoctorType.SelectedItem.ToString();
            }

            if (cbDgender.SelectedItem == null)
            {
                errMsg += "\nSelect Any Gender";
            }
            else
            {
                gender = cbDgender.SelectedItem.ToString();
            }

            if (cbDshift.SelectedItem == null)
            {
                errMsg += "\nSelect Any Shift";
            }
            else
            {
                shift = cbDshift.SelectedItem.ToString();
            }

            if (cbDay.SelectedItem == null)
            {
                errMsg += "\nDay Required for Date of Birth";
            }
            else
            {
                day = cbDay.SelectedItem.ToString();
            }

            if (cbMonth.SelectedItem == null)
            {
                errMsg += "\nMonth Required for Date of Birth";
            }
            else
            {
                month = cbMonth.SelectedItem.ToString();
            }

            if (cbYear.SelectedItem == null)
            {
                errMsg += "\nYear Required for Date of Birth";
            }
            else
            {
                year = cbYear.SelectedItem.ToString();
            }


            if (errMsg == null)
            {

                //Value insertion in the database using registration module
                var conn = DBConnection.Connect();
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                string query = string.Format("insert into doctor_reg values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", name, email, mobileno, address, password, type, gender, shift,day+month+year);

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Registration Completed");
                    }
                    else
                    {
                        MessageBox.Show("Registration Failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                conn.Close();
                RefreshControls(); //after registration every box will be empty
            }

            else
            { 

                MessageBox.Show(errMsg);
            }
        }

        void RefreshControls() // Refresh funtion to blank the all form box after registration
        {
            tbDname.Text = "";
            tbDemail.Text = "";
            tbDmobileno.Text = "";
            tbDaddress.Text = "";
            tbDpassword.Text = "";
            tbDconfirmpassword.Text = "";
            cbDoctorType.SelectedIndex =-1;
            cbDoctorType.Text = "Choose Any Type";
            cbDgender.SelectedIndex =-1;
            cbDgender.Text ="Choose Any Gender";
            cbDshift.SelectedIndex = -1;
            cbDshift.Text = "Choose Any Shift";
            cbDay.SelectedIndex = -1;
            cbDay.Text = "Day";
            cbMonth.SelectedIndex = -1;
            cbMonth.Text = "Month";
            cbYear.SelectedIndex = -1;
            cbYear.Text="Year";
         
        }

        //after clicking the login button login page will be opened
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

       

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbYear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
