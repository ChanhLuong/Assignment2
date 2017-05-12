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
    public partial class DefectDetails : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MEOMEO-PC\SQLEXPRESS;Initial Catalog=Assignment2;Integrated Security=True");
        SqlCommand comd = new SqlCommand();
        string roleIDTemp;
        public DefectDetails()
        {
            InitializeComponent();
        }

        public string UserNameDD { get; set; }
        public string UserIDDD { get; set; }

        public string BugID { get; set; }
        public string RoleIDDD { get; set; }

        private void BindStatusData(string role)
        {

            var listStatus = new BindingList<DefectStatus>();
           // var listStatus = new List<DefectStatus>();            
            var Assigned = new DefectStatus("Assigned");
            var Fixed = new DefectStatus("Fixed");
            var Rejected = new DefectStatus("Rejected");
            var Closed = new DefectStatus("Closed");
            var Reopened = new DefectStatus("Reopened");
            var New = new DefectStatus("New");
            if (role == "R1") //Tester
            {                
                listStatus.Add(Assigned);
                listStatus.Add(Fixed);
                listStatus.Add(Reopened);
                listStatus.Add(Closed);
                cmbAssignee.Enabled = false;
            }
            else if (role == "R2") //Developer
            {
                listStatus.Add(Fixed);
                listStatus.Add(Rejected);
                listStatus.Add(Reopened);
                cmbAssignee.Enabled = false;
            }
            else if ((role == "R3") || (role == "R4"))
            {
                listStatus.Add(New);
                listStatus.Add(Closed);
            }
            cmbStatus.DataSource = listStatus;
            cmbStatus.DisplayMember = "Description";
            cmbStatus.ValueMember = "Description";
           // cmbStatus.DataSource = listStatus;
        }

        private void DefectDetails_Load(object sender, EventArgs e)
        {
            roleIDTemp = this.RoleIDDD;
            BindStatusData(roleIDTemp);

            this.TopMost = true;
            lblReporter.Text = this.UserNameDD;
            lblDefectID.Text = this.BugID.ToString();
            conn.Open();

            SqlCommand DefectDetailQuery = new SqlCommand("SELECT Description,Priority, Steps, Status, BuildNo, Assignee, Env, Subsystem, Severity, Project, TestCase, Taxonamy, DateTime FROM BugData WHERE ID = '" + this.BugID.ToString() + "'", conn);
            SqlDataReader DefectDetailRead = DefectDetailQuery.ExecuteReader();
            while (DefectDetailRead.Read())
            {
                txtDescription.Text = DefectDetailRead["Description"].ToString();
                cmbPriority.Text = DefectDetailRead["Priority"].ToString();
                txtSteps.Text = DefectDetailRead["Steps"].ToString();
                txtBuildNo.Text = DefectDetailRead["BuildNo"].ToString();
                cmbAssignee.Text = DefectDetailRead["Assignee"].ToString();
                lblSubSystem.Text = DefectDetailRead["Subsystem"].ToString();
                lblEnvironment.Text = DefectDetailRead["Env"].ToString();
                cmbSeverity.Text = DefectDetailRead["Severity"].ToString();
                cmbStatus.Text = DefectDetailRead["Status"].ToString();
                lblProjectDesc.Text = DefectDetailRead["Project"].ToString();
                lblTestcase.Text = DefectDetailRead["TestCase"].ToString();
                lblTaxonamy1.Text = DefectDetailRead["Taxonamy"].ToString();
                var createdDate = DateTime.Parse(DefectDetailRead["DateTime"].ToString());
                lblCreaedDate.Text = createdDate.ToShortDateString();
            }
            conn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
            cmbAssignee.Enabled = true;
            cmbStatus.Enabled = true;
            txtComment.Enabled = true;
            btnSave.Enabled = true;
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            conn.Open();
            comd = new SqlCommand("UPDATE BugData SET Status= '"+ cmbStatus.SelectedValue.ToString()+"', Comment = '"+ 
                txtComment.Text +"' WHERE ID = '"+ this.BugID.ToString()+"'", conn);
            comd.ExecuteNonQuery();
            MessageBox.Show("Record Updated");
            conn.Close();
        }
    }
}
