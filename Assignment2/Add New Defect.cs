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
    public partial class Add_New_Defect : Form
    {
        Add_New_Testcase formTC = new Add_New_Testcase();

        SqlConnection conn = new SqlConnection(@"Data Source=MEOMEO-PC\SQLEXPRESS;Initial Catalog=Assignment2;Integrated Security=True");
        SqlCommand comd = new SqlCommand();
        string SubSystemIDTemp;
        string UserIDTemp;
        string BuildIDTemp;
        string projectID;

        public string UserNameND { get; set; }
        public string UserRoleDesND { get; set; }
        public string UserRoleIDND { get; set; }
        public string UserID { get; set; }

        
        //  public string SubSystemIDTempt { get; private set; }
        
        

        public Add_New_Defect()
        {
            InitializeComponent();

        }
        void ProjectList()
        {
            conn.Open();
            //SqlCommand sqlCmd = new SqlCommand("SELECT DISTINCT Name FROM Projects", conn);
            SqlCommand sqlCmd = new SqlCommand("select ID, Name from Projects where ID in (select ProjectID from SubSystem where ID in (select SubSystemID from Assignment where UserID = '" + UserIDTemp + "'))", conn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            while (sqlReader.Read())
            {
                lblProjectName.Text = sqlReader["Name"].ToString();
                projectID = sqlReader["ID"].ToString();
            }
            conn.Close();
        }

        void SubSystem()
        {
            conn.Open();
            SqlCommand SubsystemQuery = new SqlCommand("SELECT ID, Description,BuildID FROM SubSystem WHERE ID in (SELECT SubSystemID from Assignment Where UserID = '" + UserIDTemp + "')", conn);
            SqlDataReader SubsystemRead = SubsystemQuery.ExecuteReader();
            while (SubsystemRead.Read())
            {

                lblSubSystem.Text = SubsystemRead["Description"].ToString();
                SubSystemIDTemp = SubsystemRead["ID"].ToString();
                BuildIDTemp = SubsystemRead["BuildID"].ToString();
            }
            conn.Close();
        }

        void BuildInfo()
        {
            conn.Open();
            SqlCommand BuildInfoQuery = new SqlCommand("select Description from BuildInfo Where ID = '" + BuildIDTemp + "'", conn);
            SqlDataReader BuildInfoRead = BuildInfoQuery.ExecuteReader();
            while (BuildInfoRead.Read())
            {

                txtBuild.Text = BuildInfoRead["Description"].ToString();
            }
            conn.Close();
        }

        void AssigneeList()
        {
            conn.Open();
            SqlCommand AssigneeQuery = new SqlCommand("SELECT Name FROM Users where ID in (select UserID from Assignment where UserID != '" + UserID + "' AND SubSystemID = '" + SubSystemIDTemp + "')", conn);
            SqlDataReader AssigneeRead = AssigneeQuery.ExecuteReader();
            while (AssigneeRead.Read())
            {
                cmbAssignee.Items.Add(AssigneeRead["Name"].ToString());
            }
            conn.Close();
        }

        void TestcaseList()
        {
            conn.Open();
            SqlCommand TestcaseQuery = new SqlCommand("SELECT ID, Name FROM Testcases WHERE SubSystemID = '" + SubSystemIDTemp + "' order by DateTime ASC", conn);
            SqlDataReader TestcaseRead = TestcaseQuery.ExecuteReader();
            while (TestcaseRead.Read())
            {
                cmbTestcase.Items.Add(TestcaseRead["ID"].ToString() + '-' + TestcaseRead["Name"].ToString());
            }
            conn.Close();
        }


        public void GenerateAutoID()
        {
            conn.Open();
            comd = new SqlCommand("SELECT COUNT(ID) FROM BugData", conn);
            int i = Convert.ToInt32(comd.ExecuteScalar());
            conn.Close();
            i++;
            txtDefect.Text = "BUG" + i.ToString();
        }

        private void BindStatusData(string role)
        {
            var listStatus = new List<DefectStatus>();
            var status1 = new DefectStatus("New");
            listStatus.Add(status1);
            cmbStatus.DataSource = listStatus;
            cmbStatus.DisplayMember = "Description";
            cmbStatus.ValueMember = "Description";
        }

        private void Add_New_Defect_Load(object sender, EventArgs e)
        {
            GenerateAutoID();
            this.lblReporter.Text = this.UserNameND;
            UserIDTemp = this.UserID;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            comd.Connection = conn;
            ProjectList();
            SubSystem();
            AssigneeList();
            
            TestcaseList();
            BuildInfo();
            cmbPriorityAdd.SelectedIndex = 2;

            cmbSeverityAdd.SelectedIndex = 2;
            cmbTaxonomy.SelectedIndex = 2;
            BindStatusData(this.UserRoleIDND.ToString());
            //  conn.Open();
            if ((this.UserRoleIDND.ToString() == "R1") || (this.UserRoleIDND.ToString() == "R2"))
            {
                //cmbAssignee.Visible = false;
                cmbAssignee.Enabled = false;


            }
            else
            {
                cmbAssignee.Enabled = true;
            }
            DialogResult dr = new DialogResult();
            dr = formTC.DialogResult;
            if (dr == DialogResult.OK)
            {
                TestcaseList();
            }
            


        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string severityNo = null;

            if(cmbSeverityAdd.SelectedItem.ToString() == "Critical")
            {
               severityNo = "4";
            }
            else if(cmbSeverityAdd.SelectedItem.ToString() == "High")
            {
                severityNo = "3";
            }
            else if (cmbSeverityAdd.SelectedItem.ToString() == "Medium")
            {
                severityNo = "2";
            }
            else if (cmbSeverityAdd.SelectedItem.ToString() == "Low")
            {
                severityNo = "1";
            }

            if ((string.IsNullOrEmpty(txtDesc.Text)) || (string.IsNullOrEmpty(cmbPriorityAdd.SelectedItem.ToString())) || (string.IsNullOrEmpty(cmbStatus.SelectedItem.ToString())) || (string.IsNullOrEmpty(cmbSeverityAdd.SelectedItem.ToString())) || (string.IsNullOrEmpty(txtEnvironment.Text)) || (string.IsNullOrEmpty(txtSteps.Text)) || (string.IsNullOrEmpty(cmbTaxonomy.SelectedItem.ToString())) || (string.IsNullOrEmpty(cmbTestcase.SelectedItem.ToString())))
            {
                MessageBox.Show("Please input data for required field", "Required field check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                conn.Open();
                comd = new SqlCommand("INSERT INTO BugData (ID, Description, Priority, Steps, Status, BuildNo, Subsystem, Env, Severity, Project, ReporterID,TestCase, Taxonamy, DateTime,SeverityNo) VALUES('" + txtDefect.Text +
                   "','" + txtDesc.Text + "','" + cmbPriorityAdd.SelectedItem.ToString() +
                   "', '" + txtSteps.Text +
                   "','" + cmbStatus.Text +
                   "', '" + txtBuild.Text + "','" + SubSystemIDTemp + "', '" + txtEnvironment.Text +
                   "', '" + cmbSeverityAdd.SelectedItem.ToString() +
                   "','" + projectID + "','" + UserID.ToString() +
                   "', '" + cmbTestcase.SelectedItem.ToString() +
                   "', '" + cmbTaxonomy.SelectedItem.ToString() + "', getdate(),'"+ severityNo.ToString() + "')", conn);
                comd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted");
                conn.Close();
                GenerateAutoID();

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

       