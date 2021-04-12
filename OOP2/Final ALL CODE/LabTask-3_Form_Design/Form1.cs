using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTask_3_Form_Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitClick(object sender, EventArgs e)
        {
            string fname = "";
            string lname = "";
            string month = "";
            string day = "";
            string year = "";
            string gender = "";
            string email = "";
            string retypeemail = "";
            string password = "";
            string retypepassword = "";
            string securityquestion = "";
            string securityanswer = "";
            string address = "";
            string city = "";
            string state = "";
            string zipcode = "";
            string phone = "";
            string mobile = "";

            string errMsg = null;
            if(txtFirstname.Text.Equals(""))
            {
                errMsg += "\nFirst Name Requried";
            }
            else if (txtFirstname.Text.Length <= 2)
            {
                errMsg += "\nFirst Name must be at least 3 characters";
            }
            else
            {
                fname = txtFirstname.Text;
            }

            if(txtLastname.Text.Equals(""))
            {
                errMsg += "\nLast Name Requried";
            }
            else if (txtLastname.Text.Length <= 2)
            {
                errMsg += "\nLast Name must be at least 3 characters";
            }
            else
            {
                lname = txtLastname.Text;
            }

            if (cbMonth.SelectedItem == null)
            {
                errMsg += "\nMonth Required for Date of Birth";
            }
            else
            {
                month = cbMonth.SelectedItem.ToString();
            }

            if (cbDay.SelectedItem == null)
            {
                errMsg += "\nDay Required for Date of Birth";
            }
            else
            {
                day = cbDay.SelectedItem.ToString();
            }

            if (cbYear.SelectedItem == null)
            {
                errMsg += "\nYear Required for Date of Birth";
            }
            else
            {
                year = cbYear.SelectedItem.ToString();
            }

            if (cbGender.SelectedItem == null)
            {
                errMsg += "\nGender Required";
            }
            else
            {
                gender = cbGender.SelectedItem.ToString();
            }

            if (txtEmail.Text.Equals(""))
            {
                errMsg += "\nEmail Requried";
            }
            else
            {
                email = txtEmail.Text;
            }

            if (txtRetypeemail.Text.Equals(""))
            {
                errMsg += "\nRe-Type Email is also Requried";
            }
            else
            {
                retypeemail = txtRetypeemail.Text;
            }

            if (txtPassword.Text.Equals(""))
            {
                errMsg += "\nPassword Requried";
            }
            else
            {
                password = txtPassword.Text;
            }

            if (txtRetypepassword.Text.Equals(""))
            {
                errMsg += "\nRe-Type Password is also Requried";
            }
            else
            {
                retypepassword = txtRetypepassword.Text;
            }

            if (cbSecurityquestion.SelectedItem == null)
            {
                errMsg += "\nSecurity Question Requried";
            }
            else
            {
                securityquestion = cbSecurityquestion.SelectedItem.ToString();
            }

            if (txtSecurityanswer.Text.Equals(""))
            {
                errMsg += "\nSecurity Answer is also Requried";
            }
            else
            {
                securityanswer = txtSecurityanswer.Text;
            }

            if (txtAddress.Text.Equals(""))
            {
                errMsg += "\nAddress Requried";
            }
            else
            {
               address = txtAddress.Text;
            }

            if (txtCity.Text.Equals(""))
            {
                errMsg += "\nCity Requried";
            }
            else
            {
                city = txtCity.Text;
            }

            if (cbState.SelectedItem == null)
            {
                errMsg += "\nState Requried";
            }
            else
            {
                state = cbState.SelectedItem.ToString();
            }

            if (txtZipcode.Text.Equals(""))
            {
                errMsg += "\nZip Code Requried";
            }
            else
            {
                zipcode = txtZipcode.Text;
            }

            if (txtPhone.Text.Equals(""))
            {
                errMsg += "\nPhone Requried";
            }
            else
            {
                phone = txtPhone.Text;
            }

            if (cbMobile.SelectedItem == null)
            {
                errMsg += "\nMobile Operator Requried";
            }
            else
            {
                mobile = cbMobile.SelectedItem.ToString();
            }
            /*string fname = txtFirstname.Text;
            string lname = txtLastname.Text;
            string month = cbMonth.SelectedItem.ToString();
            string day = cbDay.SelectedItem.ToString();
            string year = cbYear.SelectedItem.ToString();
            string gender = cbGender.SelectedItem.ToString();
            string email = txtEmail.Text;
            string retypeemail = txtRetypeemail.Text;
            string password = txtPassword.Text;
            string retypepassword = txtRetypepassword.Text;
            string securityquestion = cbSecurityquestion.SelectedItem.ToString();
            string securityanswer = txtSecurityanswer.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string state = cbState.SelectedItem.ToString();
            string zipcode = txtZipcode.Text;
            string phone = txtPhone.Text;
            string mobile = cbMobile.SelectedItem.ToString();*/

            if (errMsg == null)
            {
                rtOutput.Text = string.Format("First Name: {0}\nLast Name: {1}\nDate of Birth: {2}-{3}-{4}\n" +
               "Gender: {5}\n" + "Email: {6}\nRe-Type Email: {7}\nPassword: {8}\n" +
               "Re-Type Password: {9}\nSecurity Question: {10}\nSecurity Answer: {11}\n" +
               "Address : {12}\nCity: {13}\nState: {14}\nZip Code: {15}\nPhone: {16};  Mobile: {17}",
                fname, lname, month, day, year, gender, email, retypeemail, password, retypepassword,
               securityquestion, securityanswer, address, city, state, zipcode, phone, mobile);
            }
            else
            {
                MessageBox.Show(errMsg);
            }

           
        
        }
    }
}
