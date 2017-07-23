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

namespace Assignment2
{
    public partial class MDIParent1 : Form
    {
        public static MDIParent1 mdiobj;
        public Login log;
        public string userRoleIDMDI;
        public string projectName;
        public string projectID;

        SqlConnection conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Assignment2;Integrated Security=True");
        SqlCommand comd = new SqlCommand();
        public MDIParent1()
        {
            InitializeComponent();
        }

        void ProjectNameLabel()
        {
            conn.Open();           
            SqlCommand sqlCmd = new SqlCommand("select ID, Name from Projects where ID in (select ProjectID from Assignment where UserID = '" 
                                                    + this.txtUserID.Text + "' AND ProjectID is not null)", conn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            while (sqlReader.Read())
            {
                lblPrjName.Text = sqlReader["Name"].ToString();
                projectID = sqlReader["ID"].ToString();                                  
            }
            conn.Close();
        }

        public void MDIParent1_Load(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Maximized;
            Login log = new Login();            
            log.Dock = DockStyle.Fill;
            log.FormBorderStyle = FormBorderStyle.None;
            log.ShowDialog();

            this.Controls["userRole"].Text = log.UserRoleDes;
            this.Controls["txtUser"].Text = log.UserName;
            this.Controls["txtUserID"].Text = log.UserID;
            userRoleIDMDI = log.UserRoleID;
            ProjectNameLabel();
            if (userRoleIDMDI == "R2")
            {
                report.Visible = true;
                lblPrjName.Visible = false;
                ProjectNameLabel();
                addNewTestcaseToolStripMenuItem.Visible = false;
                addNewDefectToolStripMenuItem.Visible = false;               
            }

            if (userRoleIDMDI=="R5")
            {
                report.Visible = true;
                lblPrjName.Visible = false;
                ProjectNameLabel();
                addNewMemberToolStripMenuItem.Visible = true;
                addNewProjectToolStripMenuItem.Visible = true;
                addNewDefectToolStripMenuItem.Visible = false;
                addNewTestcaseToolStripMenuItem.Visible = false;
                report.Visible = false;
                homeToolStripMenuItem.Visible = false;
            }
            else if (userRoleIDMDI == "R4")
            {
                report.Visible = true;
                lblPrjName.Visible = true;
                ProjectNameLabel();
                addNewMemberToolStripMenuItem.Visible = false;
                addNewProjectToolStripMenuItem.Visible = false;
                addNewDefectToolStripMenuItem.Visible = false;
                addNewTestcaseToolStripMenuItem.Visible = false;
            }
            else
            {
                report.Visible = false;
                addNewMemberToolStripMenuItem.Visible = false;
                addNewProjectToolStripMenuItem.Visible = false;
            }          
        }              

        private void addNewDefectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {           
            Add_New_Defect form = new Add_New_Defect();
            form.UserNameND = this.txtUser.Text;
            form.UserRoleDesND = this.userRole.Text;
            form.UserRoleIDND = this.userRoleIDMDI;
            form.UserID = this.txtUserID.Text;
            form.MdiParent = this;
            form.Show();
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;              
        }

        //private void searchDefectToolStripMenuItem_Click_1(object sender, EventArgs e)
        //{
        //    SearchPage SearchForm = new SearchPage();
        //    SearchForm.MdiParent = this;
        //    SearchForm.Show();
        //    SearchForm.Dock = DockStyle.Fill;
        //    SearchForm.FormBorderStyle = FormBorderStyle.None;
        //}

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home HomePage = new Home();
            HomePage.UserNameHP = this.txtUser.Text;
            HomePage.UserIDHP = this.txtUserID.Text;
            HomePage.UserRoleIDHP = this.userRoleIDMDI;
            HomePage.projectIDHP = this.projectID;           
            HomePage.MdiParent = this;
            HomePage.Show();
            HomePage.Dock = DockStyle.Fill;           
            HomePage.FormBorderStyle = FormBorderStyle.None;
        }

        private void addNewTestcaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_New_Testcase formTC = new Add_New_Testcase();
            formTC.UserIDTC = this.txtUserID.Text;
            formTC.MdiParent = this;
            formTC.Show();
            formTC.Dock = DockStyle.Fill;
            formTC.FormBorderStyle = FormBorderStyle.None;
        }

        private void report_Click(object sender, EventArgs e)
        {
            ReportForm formRP = new ReportForm();
            formRP.userIDRP = this.txtUserID.Text;            
            formRP.MdiParent = this;
            formRP.Show();
            formRP.Dock = DockStyle.Fill;
            formRP.FormBorderStyle = FormBorderStyle.None;
        }

        private void addNewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewTester formTT = new AddNewTester();            
            formTT.MdiParent = this;
            formTT.UserIDTester = this.txtUserID.Text;
            formTT.Show();
            formTT.Dock = DockStyle.Fill;
            formTT.FormBorderStyle = FormBorderStyle.None;
        }

        private void addNewProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Project_Form formP = new New_Project_Form();
            formP.MdiParent = this;           
            formP.Show();
            formP.Dock = DockStyle.Fill;
            formP.FormBorderStyle = FormBorderStyle.None;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }            
        }
    }
}
