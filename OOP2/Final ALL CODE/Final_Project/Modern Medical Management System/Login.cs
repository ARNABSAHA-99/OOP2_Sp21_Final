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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown) 
                { Application.Exit();
            }
        }


        //after clicking the login button
        private void btnLogin_Click(object sender, EventArgs e)
        {

            //null validation for login module
            string name = "";
            string password = "" ;

            string errMsg = null;

            if (tbName.Text.Equals(""))
            {
                errMsg += "\nPlease enter name";
            }
            else
            {
                name = tbName.Text;
            }

            if (tbPassword.Text.Equals(""))
            {
                errMsg += "\nPlease enter password";
            }
            else
            {
                password = tbPassword.Text;
            }

            if (errMsg == null)
            {
                //if name & password value will match with database value login will be successfull
                var conn = DBConnection.Connect();
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                string query = string.Format("select * from doctor_reg where Name='{0}' and Password='{1}'", name, password);
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (cmd.ExecuteReader().Read())
                    {
                        MessageBox.Show("Login Successful");
                        this.Hide();
                        new DashBord().Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Doctor Name or Password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                RefreshControls(); //after login every form box will be empty
            }

            else { MessageBox.Show(errMsg); }
        }

        void RefreshControls() //Refresh funtion to blank the form box after log in/invalid input
        {
            tbName.Text = "";
            tbPassword.Text = "";

        }

        //after click on the registration button registration page will be opened
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
