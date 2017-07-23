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
        SqlConnection conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Assignment2;Integrated Security=True");
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
                sda = new SqlDataAdapter("SELECT ID, Description, Priority, Status FROM BugData WHERE ReporterID ='"
                    + this.UserIDHP.ToString() + "' order by DateTime ASC", conn);
                dt = new DataTable();
                sda.Fill(dt);
                gvHome2.DataSource = dt;
                conn.Close();

                conn.Open();
                sda1 = new SqlDataAdapter("SELECT ID, Description, Priority, Status FROM BugData WHERE Assignee = '"
                    + this.UserNameHP.ToString() + "' order by Priority ASC", conn);
                dt1 = new DataTable();
                sda1.Fill(dt1);
                gvHome.DataSource = dt1;
                conn.Close();
                pieBugStatus.Visible = true;
                chrDefectStatus.Visible = true;
                pieChart1();
                barChart1();

            }
            else if (this.UserRoleIDHP == "R2")
            {
                {
                    
                    conn.Open();
                    sda = new SqlDataAdapter("SELECT ID, Description, Priority, Status FROM BugData WHERE Assignee = '"
                                + this.UserNameHP.ToString() + "' and Status != 'Closed' order by Priority DESC", conn);
                    dt = new DataTable();
                    sda.Fill(dt);
                    gvHome.DataSource = dt;
                    gvHome2.Hide();
                    label3.Visible = false;
                    conn.Close();

                    pieBugStatus.Visible = true;
                    chrDefectStatus.Hide();
                    pieChart2();
                }           
            }

            else if (this.UserRoleIDHP == "R3")
            {

                conn.Open();
                sda = new SqlDataAdapter("select * From BugData Where SubSystem in (select SubSystemID from Assignment where UserID = '" 
                    + this.UserIDHP.ToString() + "') order by DateTime DESC", conn);
                dt = new DataTable();
                sda.Fill(dt);
                gvHome.DataSource = dt;
                gvHome2.Hide();
                label3.Visible = false;
                conn.Close();
                pieBugStatus.Visible = true;
                pieChart3();
                chrDefectStatus.Visible = true;
                barChart3();
            }
            else if (this.UserRoleIDHP == "R4")
            {
                conn.Open();
                sda = new SqlDataAdapter("SELECT * FROM BugData WHERE Project ='" + this.projectIDHP.ToString() + "' order by Priority DESC", conn);
                dt = new DataTable();
                sda.Fill(dt);
                gvHome.DataSource = dt;
                gvHome2.Hide();
                label3.Visible = false;
                conn.Close();
                pieBugStatus.Visible = true;
                pieChart4();
                chrDefectStatus.Visible = true;
                barChart4();
                
            }
        }

        void pieChart4()
        {
            conn.Open();
            SqlDataAdapter pBugStatus = new SqlDataAdapter("SELECT Status, count(ID) as BugNumber from BugData where Project = '"
                                                                                + this.projectIDHP.ToString() + "' group by Status", conn);
            DataTable dt4 = new DataTable();
            pBugStatus.Fill(dt4);
            pieBugStatus.DataSource = dt4;
            pieBugStatus.ChartAreas["ChartArea1"].AxisX.Title = "Status";
            pieBugStatus.ChartAreas["ChartArea1"].AxisX.Title = "BugNumber";

            pieBugStatus.Series["Status"].XValueMember = "Status";
            pieBugStatus.Series["Status"].YValueMembers = "BugNumber";
            conn.Close();
        }

        void barChart4()
        {
            conn.Open();
            SqlDataAdapter barBugStatus = new SqlDataAdapter("SELECT Assignee, count(ID) as BugNumber from BugData where Project = '"
                                                                                + this.projectIDHP.ToString() + "' group by Assignee", conn);
            DataTable dt4 = new DataTable();
            barBugStatus.Fill(dt4);
            chrDefectStatus.DataSource = dt4;
            chrDefectStatus.ChartAreas["ChartArea1"].AxisX.Title = "Assignee";
            chrDefectStatus.ChartAreas["ChartArea1"].AxisX.Title = "Bug Number";
            chrDefectStatus.Series["Status"].XValueMember = "Assignee";
            chrDefectStatus.Series["Status"].YValueMembers = "BugNumber";
            conn.Close();
        }

        void pieChart3()
        {
            conn.Open();
            SqlDataAdapter pBugStatus = new SqlDataAdapter("SELECT Status, count(ID) as BugNumber from BugData where SubSystem in (select SubSystemID from Assignment where UserID = '"
                                                                                + this.UserIDHP.ToString() + "') group by Status", conn);
            DataTable dt3 = new DataTable();
            pBugStatus.Fill(dt3);
            pieBugStatus.DataSource = dt3;
            pieBugStatus.ChartAreas["ChartArea1"].AxisX.Title = "Status";
            pieBugStatus.ChartAreas["ChartArea1"].AxisX.Title = "BugNumber";

            pieBugStatus.Series["Status"].XValueMember = "Status";
            pieBugStatus.Series["Status"].YValueMembers = "BugNumber";
            conn.Close();
        }

        void barChart3()
        {
            conn.Open();
            SqlDataAdapter barBugStatus = new SqlDataAdapter("SELECT Status, count(ID) as BugNumber from BugData where SubSystem in (select SubSystemID from Assignment where UserID = '"
                                                                                + this.UserIDHP.ToString() + "') group by Status", conn);
            DataTable dt3 = new DataTable();
            barBugStatus.Fill(dt3);
            chrDefectStatus.DataSource = dt3;
            chrDefectStatus.ChartAreas["ChartArea1"].AxisX.Title = "Status";
            chrDefectStatus.ChartAreas["ChartArea1"].AxisX.Title = "Bug Number";
            chrDefectStatus.Series["Status"].XValueMember = "Status";
            chrDefectStatus.Series["Status"].YValueMembers = "BugNumber";
            conn.Close();
        }

        void pieChart2()
          { 
                    conn.Open();
                    SqlDataAdapter pBugStatus = new SqlDataAdapter("SELECT Status, count(ID) as BugNumber from BugData where Assignee = '"
                        + this.UserNameHP.ToString() + "' AND Status != 'Closed' group by Status", conn);
                    DataTable dt2 = new DataTable();
                    pBugStatus.Fill(dt2);
                    pieBugStatus.DataSource = dt2;
                    pieBugStatus.ChartAreas["ChartArea1"].AxisX.Title = "Status";
                    pieBugStatus.ChartAreas["ChartArea1"].AxisX.Title = "BugNumber";

                    pieBugStatus.Series["Status"].XValueMember = "Status";
                    pieBugStatus.Series["Status"].YValueMembers = "BugNumber";
                    conn.Close();
           }

    void pieChart1()
        {
            conn.Open();
            SqlDataAdapter pBugStatus = new SqlDataAdapter("SELECT Status, count(ID) as BugNumber from BugData where ReporterID = '" 
                +UserIDHP.ToString() +"' AND Status != 'Closed' group by Status", conn);
            DataTable dt = new DataTable();
            pBugStatus.Fill(dt);
            pieBugStatus.DataSource = dt;
            pieBugStatus.ChartAreas["ChartArea1"].AxisX.Title = "Status";
            pieBugStatus.ChartAreas["ChartArea1"].AxisX.Title = "BugNumber";

            pieBugStatus.Series["Status"].XValueMember = "Status";
            pieBugStatus.Series["Status"].YValueMembers = "BugNumber";
            conn.Close();           
        }

        void barChart1()
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
           
        }

        private void gvHome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.UserRoleIDHP == "R4")
            {
                return;
            }
        
            DefectDetails DefectDetails = new DefectDetails();
            DefectDetails.UserIDDD = this.UserIDHP;
            DefectDetails.UserNameDD = this.UserNameHP;
            DefectDetails.BugID = gvHome.CurrentCell.Value.ToString();
            DefectDetails.RoleIDDD = UserRoleIDHP.ToString();
            DefectDetails.Show();
            
                       
        }
       

  }     
        
}
