using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Medical_Management_System
{
    public partial class DashBord : Form
    {
        public DashBord()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
            { Application.Exit(); }
        }


        private void DashBord_Load(object sender, EventArgs e)
        {

        }

        //after click on the add button add patient page will be opened
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddPatient().Show();
        }
        //after click on the show button add show all patient page will be opened
        private void btnShow_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShowPatient().Show();
        }

        //after click on the edit button edit patient page will be opened
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditPatient().Show();
        }

        //after click on the edit button edit patient page will be opened
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DeletePatient().Show();
        }

        //after click on the show doctor button show all doctor page will be opened
        private void btnShowDoctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShowAllDoctor().Show();
        }
    }
}
