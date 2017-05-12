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
    public partial class SearchPage : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MEOMEO-PC\SQLEXPRESS;Initial Catalog=Assignment2;Integrated Security=True");
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommand cmd = new SqlCommand();            

        public SearchPage()
        {            
            InitializeComponent();    
        }

        void FillDefectList()
        {
            conn.Open();
            sda = new SqlDataAdapter("Select * from BugData order by ID ASC", conn);
            dt = new DataTable();
            sda.Fill(dt);
            gridViewDefectList.DataSource = dt;
            conn.Close();
        }
        void FillComboProject()
        {
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand("SELECT distinct Name FROM Projects", conn);
            SqlDataReader NameReader = sqlCmd.ExecuteReader();
            while (NameReader.Read())
            {
                cmbPrjSrcPg.Items.Add(NameReader["Name"].ToString());
            }
           conn.Close();
        }

        void FillComboAssignee()
        {
            conn.Open();
            SqlCommand sqlAssignee = new SqlCommand("SELECT Name FROM Users ORDER BY Name ASC", conn);
            SqlDataReader AssigneeReader = sqlAssignee.ExecuteReader();
            while (AssigneeReader.Read())
            {
                cmbAssigneeSrcPg.Items.Add(AssigneeReader["Name"].ToString());
                cmbReporter.Items.Add(AssigneeReader["Name"].ToString());
            }
            conn.Close();
        }

        void FillComboSubSystem()
        {
            conn.Open();
            SqlCommand sqlCmd1 = new SqlCommand("SELECT DISTINCT Description FROM SubSystem", conn);
            SqlDataReader SubSystemReader = sqlCmd1.ExecuteReader();
            while (SubSystemReader.Read())
            {
                cmbSubSrchPg.Items.Add(SubSystemReader["Description"].ToString());
            }
            conn.Close();
        }

       
    
        private void SearchPage_Load(object sender, EventArgs e)
        {            
            FillComboProject();
            FillComboAssignee();
            FillComboSubSystem();
            FillDefectList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnSearch_Click(object sender, EventArgs e)
        {

            dt = new DataTable();
            var sql = new StringBuilder("SELECT * FROM BugData WHERE ");
            var args = new List<string>();

            args.Add("(1=1)");
            if (!string.IsNullOrEmpty(cmbPrjSrcPg.Text))
                args.Add(" (Project LIKE '" + cmbPrjSrcPg.Text + "%') ");
            if (!string.IsNullOrEmpty(txtDefectID.Text))
                args.Add(" (ID = '" + txtDefectID.Text + "') ");
            if (!string.IsNullOrEmpty(txtDescription.Text))
                args.Add("(Description LIKE '" + txtDescription.Text + "%' OR Steps LIKE '" + txtDescription.Text + "%')");
            if (!string.IsNullOrEmpty(cmbAssigneeSrcPg.Text))
                args.Add("(Assignee = '" + cmbAssigneeSrcPg.Text + "')");
            if (!string.IsNullOrEmpty(txtEnv.Text))
                args.Add("(Env = '" + txtEnv.Text + "')");
            if (!string.IsNullOrEmpty(cmbStatus.Text))
                args.Add("(Status = '" + cmbStatus.Text + "')");
            if (!string.IsNullOrEmpty(txtBuildInfo.Text))
                args.Add("(BuildNo LIKE '" + txtBuildInfo.Text + "%')");
            if (!string.IsNullOrEmpty(cmbSubSrchPg.Text))
                args.Add("(Subsystem = '" + cmbSubSrchPg.Text + "')");
            if (!string.IsNullOrEmpty(cmbPriority.Text))
                args.Add("(Priority = '" + cmbPriority.Text.ToString() + "')");
            if (!string.IsNullOrEmpty(cmbReporter.Text))
                args.Add("(Reporter = '" + cmbReporter.Text + "')");
            sql.Append(string.Join(" AND ", args));
            conn.Open();
            sda = new SqlDataAdapter(sql.ToString(), conn);
            sda.Fill(dt);
            gridViewDefectList.DataSource = dt;
            conn.Close();
        }

       

        private void gridViewDefectList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DefectDetails DefectDetails = new DefectDetails();          
            DefectDetails.Show();
            DefectDetails.Dock = DockStyle.Fill;
        }
    }
    }

