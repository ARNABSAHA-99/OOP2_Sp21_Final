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
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown) { Application.Exit(); }
        }


        //after click the Add button
        private void btAddPatient_Click(object sender, EventArgs e)
        {
            //null validation for add patient module

            string Pname = "";
            string Pemail = "";
            string Pmobileno = "";
            string Pgender = "";
            string Page = "";
            string Pweight = "";
            string Pdob= "";
            

            string errMsg = null;
            if (tbPname.Text.Equals(""))
            {
                errMsg += "\nPatient Name Requried";
            }
            else
            {
                Pname = tbPname.Text;
            }

            if (tbPemail.Text.Equals(""))
            {
                errMsg += "\nPatient Email Requried";
            }
            else
            {
                Pemail = tbPemail.Text;
            }


            if (tbPmobileno.Text.Equals(""))
            {
                errMsg += "\nPatient Mobile Number Requried";
            }
            else
            {
                Pmobileno = tbPmobileno.Text;
            }

            if (cbPgender.SelectedItem == null)
            {
                errMsg += "\nPatient Gender Requried";
            }
            else
            {
                Pgender = cbPgender.SelectedItem.ToString();
            }

            if (tbPage.Text.Equals(""))
            {
                errMsg += "\nPatient Age Requried";
            }
            else
            {
                Page = tbPage.Text;
            }

            if (tbPweight.Text.Equals(""))
            {
                errMsg += "\nPatient Weight Requried";
            }
            else
            {
                Pweight= tbPweight.Text;
            }

            if (tbPdob.Text.Equals(""))
            {
                errMsg += "\nPatient Date of Birth Requried";
            }
            else
            {
                Pdob = tbPdob.Text;
            }

            if (errMsg == null)
            {

                //Value insertion in the database using add patient module
                var conn = DBConnection.Connect();
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                string query = string.Format("insert into patient values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", Pname, Pemail, Pmobileno,Pgender, Page, Pweight,Pdob);

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Patient Added");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Add Patient");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                RefreshControls(); //after adding the patient every box will be empty
            }

            else
            {
                MessageBox.Show(errMsg);
            }
        }

        void RefreshControls() // Refresh funtion to blank the all form box after adding the patient
        {
            tbPname.Text = "";
            tbPemail.Text = "";
            tbPmobileno.Text = "";
            cbPgender.SelectedIndex = -1;
            cbPgender.Text = "Select Gender";
            tbPage.Text = "";
            tbPweight.Text = "";
            tbPdob.Text = "";
        }

        //after click the back button dashboard page will visible
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DashBord().Show();
        }

        //after click the go button show all patient page will visible
        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShowPatient().Show();
        }
    }
}

