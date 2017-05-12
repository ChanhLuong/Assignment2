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
    public partial class ReportForm : Form
    {
        public string userIDRP { get; set; }
        public string subSystemIDRP { get; set; }
        public string projectIDRP { get; set; }
        public string userRoleRP { get; set; }

        SqlConnection conn = new SqlConnection(@"Data Source=MEOMEO-PC\SQLEXPRESS;Initial Catalog=Assignment2;Integrated Security=True");
        SqlCommand comd = new SqlCommand();
        public ReportForm()
        {
            InitializeComponent();
        }

        
        private void ReportForm_Load(object sender, EventArgs e)
        {

           
            DateFields();
            ProjectID();
            SubSystemID();
          
            reportViewer1.Hide();
            reportViewer2.Hide();
            reportViewer3.Hide();
            reportViewer4.Hide();
            this.reportViewer4.RefreshReport();
        }

        void ProjectID()
        {
            conn.Open();
            //SqlCommand sqlCmd = new SqlCommand("SELECT DISTINCT Name FROM Projects", conn);
            SqlCommand sqlCmd = new SqlCommand("select ID, Name from Projects where ID in (select ProjectID from SubSystem where ID in (select SubSystemID from Assignment where UserID = '" + this.userIDRP + "'))", conn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            while (sqlReader.Read())
            {
               
                projectIDRP = sqlReader["ID"].ToString();
            }
            conn.Close();
        }

        void SubSystemID()
        {
            conn.Open();
            SqlCommand SubsystemQuery = new SqlCommand("SELECT ID FROM SubSystem WHERE ID in (SELECT SubSystemID from Assignment Where UserID = '" + this.userIDRP + "')", conn);
            SqlDataReader SubsystemRead = SubsystemQuery.ExecuteReader();
            while (SubsystemRead.Read())
            {                
                subSystemIDRP = SubsystemRead["ID"].ToString();
            }
            conn.Close();
        }


        void DateFields()
        {
            conn.Open();
            SqlCommand DateQuery = new SqlCommand("SELECT DateTime FROM BugData order by DateTime ASC", conn);
            SqlDataReader DateRead = DateQuery.ExecuteReader();
            while (DateRead.Read())
            {
                cmbFrom.Items.Add(DateRead["DateTime"].ToString());
                cmbTo.Items.Add(DateRead["DateTime"].ToString());
            }
            conn.Close();
        }




        private void btnBugProject_Click_1(object sender, EventArgs e)
        {
            reportViewer2.Hide();
            reportViewer3.Hide();
            reportViewer4.Hide();
            using (Assignment2Entities2 db = new Assignment2Entities2())
            {
                GetBugByProject_ResultBindingSource.DataSource = db.GetBugByProject(cmbFrom.SelectedItem.ToString(), cmbTo.SelectedItem.ToString(), this.projectIDRP);
                Microsoft.Reporting.WinForms.ReportParameter[] rPara = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                        new Microsoft.Reporting.WinForms.ReportParameter("FromDate",cmbFrom.SelectedItem.ToString()),
                        new Microsoft.Reporting.WinForms.ReportParameter("ToDate", cmbTo.SelectedItem.ToString()),
                        new Microsoft.Reporting.WinForms.ReportParameter("ProjectID", this.projectIDRP)
                    };

                reportViewer1.LocalReport.SetParameters(rPara);
                reportViewer1.RefreshReport();
                reportViewer1.Show();
                reportViewer1.Dock = DockStyle.None;
                reportViewer1.BorderStyle = BorderStyle.None;
            }
        }

        private void btnBugRating_Click(object sender, EventArgs e)
        {
            reportViewer1.Hide();
            reportViewer3.Hide();
            reportViewer4.Hide();
            using (Assignment2Entities5 db = new Assignment2Entities5())
            {
                GetBugRating_ResultBindingSource.DataSource = db.GetBugRating(cmbFrom.SelectedItem.ToString(), cmbTo.SelectedItem.ToString(), this.projectIDRP);
                Microsoft.Reporting.WinForms.ReportParameter[] rPara = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                        new Microsoft.Reporting.WinForms.ReportParameter("FromDate",cmbFrom.SelectedItem.ToString()),
                        new Microsoft.Reporting.WinForms.ReportParameter("ToDate", cmbTo.SelectedItem.ToString()),
                        new Microsoft.Reporting.WinForms.ReportParameter("ProjectID", this.projectIDRP)
                    };
                

                reportViewer2.LocalReport.SetParameters(rPara);
                reportViewer2.RefreshReport();                
                reportViewer2.Show();
                reportViewer2.Dock = DockStyle.None;
                reportViewer2.BorderStyle = BorderStyle.None;
            }
        }

        private void btnBugInd_Click(object sender, EventArgs e)
        {
            reportViewer1.Hide();
            reportViewer2.Hide();
            reportViewer4.Hide();
            using (Assignment2Entities6 db = new Assignment2Entities6())
            {
                GetBugNumberAssignee_ResultBindingSource.DataSource = db.GetBugNumberAssignee(this.projectIDRP);
                Microsoft.Reporting.WinForms.ReportParameter[] rPara = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                        new Microsoft.Reporting.WinForms.ReportParameter("ProjectID", this.projectIDRP)
                    };


                reportViewer3.LocalReport.SetParameters(rPara);
                reportViewer3.RefreshReport();
                reportViewer3.Show();
                reportViewer3.Dock = DockStyle.None;
                reportViewer3.BorderStyle = BorderStyle.None;
            }
        }

        int numberOfClick = 0;
        private void btnBugStatus_Click(object sender, EventArgs e)
        {
            numberOfClick++;
            switch (numberOfClick)
            {
                case 1:
                    {
                        reportViewer1.Hide();
                        reportViewer2.Hide();
                        reportViewer3.Hide();
                        lblStatus.Visible = true;
                        cmbStatus.Visible = true;
                        break;
                    }
                case 2:
                    {

                        using (Assignment2Entities8 db = new Assignment2Entities8())
                        {
                            GetBugNumberStatusPeriod_ResultBindingSource.DataSource = db.GetBugNumberStatusPeriod(cmbFrom.SelectedItem.ToString(), cmbTo.SelectedItem.ToString(), cmbStatus.SelectedItem.ToString(), this.projectIDRP);
                            Microsoft.Reporting.WinForms.ReportParameter[] rPara = new Microsoft.Reporting.WinForms.ReportParameter[]
                                {
                                new Microsoft.Reporting.WinForms.ReportParameter("FromDate",cmbFrom.SelectedItem.ToString()),
                                new Microsoft.Reporting.WinForms.ReportParameter("ToDate", cmbTo.SelectedItem.ToString()),                               
                                new Microsoft.Reporting.WinForms.ReportParameter("ProjectID", this.projectIDRP),
                                new Microsoft.Reporting.WinForms.ReportParameter("Status", cmbStatus.SelectedItem.ToString())
                                };
                            reportViewer4.LocalReport.SetParameters(rPara);
                            reportViewer4.RefreshReport();
                            reportViewer4.Show();
                            reportViewer4.Dock = DockStyle.None;
                            reportViewer4.BorderStyle = BorderStyle.None;
                            numberOfClick = 1;
                        }
                        break;
                    }
                
            }

        }
        }
    }

