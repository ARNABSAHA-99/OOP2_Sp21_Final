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
    public partial class DeleteInfo : Form
    {
        public DeleteInfo()
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

        private void btnDeleteSearch_Click(object sender, EventArgs e) //Search the user ID for delete
        {

            string deleteSearch = "";


            string errMsg = null;
            if (tbDeleteSearch.Text.Equals(""))
            {
                errMsg += "\nPlease search any Id";
            }
            else
            {
                deleteSearch = tbDeleteSearch.Text;
            }
            if (errMsg != null)
            {
                MessageBox.Show(errMsg);
            }



            var conn = DBConnection.Connect();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int id = Int32.Parse(tbDeleteSearch.Text);
            string query = "select * from users where id = " + id;

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            User u = new User();
            while (reader.Read())
            {

                u.Id = reader.GetInt32(reader.GetOrdinal("Id"));
            }
            conn.Close();



        }

        private void btnDeleteInfo_Click(object sender, EventArgs e) //Delete the specific Id which searched
        {
            var conn = DBConnection.Connect();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int id = Int32.Parse(tbDeleteSearch.Text);
            string query = "delete from users where id = " + id;

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            User u = new User();
            while (reader.Read())
            {

                u.Id = reader.GetInt32(reader.GetOrdinal("Id"));
            }
            conn.Close();
            MessageBox.Show("The Info Delete Successfully");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DashBord().Show();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShowInfo().Show();
        }
    }
}
