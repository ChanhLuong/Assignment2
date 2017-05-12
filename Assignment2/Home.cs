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
    public partial class Home : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MEOMEO-PC\SQLEXPRESS;Initial Catalog=Assignment2;Integrated Security=True");
        SqlDataAdapter sda,sda1;
        DataTable dt, dt1;
        SqlCommand cmd = new SqlCommand();            
        public string UserNameHP { get; set; }

        public string UserIDHP { get; set; }
        public string UserRoleIDHP { get; set; }    
        public string subSystemIDTemp { get; set; }
        public string projectIDHP { get; set; }
        public string projectNameHP { get; set; }
        public string SelectedSubID;
        
        public Home()
        {
            InitializeComponent();
        }

        void FillDefectList()
        {
            if (this.UserRoleIDHP == "R1")
            {
                conn.Open();
                sda = new SqlDataAdapter("SELECT ID, Description, Priority, Status FROM BugData WHERE ReporterID ='" + this.UserIDHP.ToString() + "' order by DateTime ASC", conn);
                dt = new DataTable();
                sda.Fill(dt);
                gvHome2.DataSource = dt;
                conn.Close();

                conn.Open();
                sda1 = new SqlDataAdapter("SELECT ID, Description, Priority, Status FROM BugData WHERE Assignee = '" + this.UserNameHP.ToString() + "' order by Priority ASC", conn);
                dt1 = new DataTable();
                sda1.Fill(dt1);
                gvHome.DataSource = dt1;
                conn.Close();
            }
            else if (this.UserRoleIDHP == "R2")
            {

                conn.Open();
                sda = new SqlDataAdapter("SELECT * FROM BugData WHERE ReporterID ='" + this.UserIDHP.ToString() + "' OR Assignee = '"
                    + this.UserNameHP.ToString() + "' order by DateTime ASC", conn);
                dt = new DataTable();
                sda.Fill(dt);
                gvHome.DataSource = dt;
                gvHome2.Hide();
                conn.Close();
            }

            else if (this.UserRoleIDHP == "R3")
            {

                conn.Open();
                sda = new SqlDataAdapter("SELECT * FROM BugData WHERE SubSystem ='" + subSystemIDTemp.ToString() + "'", conn);
                dt = new DataTable();
                sda.Fill(dt);
                gvHome.DataSource = dt;
                gvHome2.Hide();
                conn.Close();
            }
            else if (this.UserRoleIDHP == "R4")
            {
                conn.Open();
                sda = new SqlDataAdapter("SELECT * FROM BugData WHERE Project ='" + projectIDHP.ToString() + "'", conn);
                dt = new DataTable();
                sda.Fill(dt);
                gvHome.DataSource = dt;
                gvHome2.Hide();
                conn.Close();
            }
        }


        void pieChart()
        {
            conn.Open();
            SqlDataAdapter pBugStatus = new SqlDataAdapter("SELECT Status, count(ID) as BugNumber from BugData where ReporterID = '" +UserIDHP.ToString() +"' AND Status != 'Closed' group by Status", conn);
            DataTable dt = new DataTable();
            pBugStatus.Fill(dt);
            pieBugStatus.DataSource = dt;
            pieBugStatus.ChartAreas["ChartArea1"].AxisX.Title = "Status";
            pieBugStatus.ChartAreas["ChartArea1"].AxisX.Title = "BugNumber";

            pieBugStatus.Series["Status"].XValueMember = "Status";
            pieBugStatus.Series["Status"].YValueMembers = "BugNumber";
            conn.Close();           
        }

        void barChart()
        {
            conn.Open();
            SqlDataAdapter barBugStatus = new SqlDataAdapter("SELECT Status, count(ID) as BugNumber from BugData where ReporterID = '" + UserIDHP.ToString() + "' group by Status", conn);
            DataTable dt1 = new DataTable();
            barBugStatus.Fill(dt1);
            chrDefectStatus.DataSource = dt1;
            chrDefectStatus.ChartAreas["ChartArea1"].AxisX.Title = "Status";
            chrDefectStatus.ChartAreas["ChartArea1"].AxisX.Title = "Bug Number";
            chrDefectStatus.Series["Status"].XValueMember = "Status";
            chrDefectStatus.Series["Status"].YValueMembers = "BugNumber";
            conn.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {         
            FillDefectList();        
            pieChart();
            barChart();
        }

        private void gvHome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // MDIParent1 mdi = new MDIParent1();
            DefectDetails DefectDetails = new DefectDetails();
            DefectDetails.UserIDDD = this.UserIDHP;
            DefectDetails.UserNameDD = this.UserNameHP;
            DefectDetails.BugID = gvHome.CurrentCell.Value.ToString();
            DefectDetails.RoleIDDD = UserRoleIDHP.ToString();
            DefectDetails.Show();
            
                       
        }
       

  }     
        
}
