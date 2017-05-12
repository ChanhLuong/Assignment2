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
    public partial class AddNewTester : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MEOMEO-PC\SQLEXPRESS;Initial Catalog=Assignment2;Integrated Security=True");
        SqlCommand comd = new SqlCommand();
        public AddNewTester()
        {
            InitializeComponent();
        }

        public string UserIDTester { get; set; }
        string asID;
        string prjID;
        public void AutoTesterID()
        {
            conn.Open();
            comd = new SqlCommand("SELECT COUNT(ID) FROM Users", conn);
            int i = Convert.ToInt32(comd.ExecuteScalar());
            conn.Close();
            i++;
            lblTesterID.Text = "UID" + i.ToString();
        }

        public void SubsystemList()
        {
            conn.Open();
            SqlCommand SubsystemQuery = new SqlCommand("SELECT ID, Description FROM SubSystem WHERE ID in (SELECT SubSystemID from Assignment Where UserID = '" + UserIDTester + "')", conn);
            SqlDataReader SubsystemRead = SubsystemQuery.ExecuteReader();
            while (SubsystemRead.Read())
            {
                cmbSubSystem.Items.Add(SubsystemRead["ID"].ToString());// + "-" + SubsystemRead["Description"].ToString());                
            }
            conn.Close();
            cmbSubSystem.SelectedIndex = 0;

        }
        void ProjectInfo()
        {
            conn.Open();
            //SqlCommand sqlCmd = new SqlCommand("SELECT DISTINCT Name FROM Projects", conn);
            SqlCommand sqlCmd = new SqlCommand("select ID, Name from Projects where ID in (select ProjectID from SubSystem where ID in (select SubSystemID from Assignment where UserID = '" + UserIDTester + "'))", conn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            while (sqlReader.Read())
            {
                txtProject.Text = sqlReader["ID"].ToString() + " - " + sqlReader["Name"].ToString();
                prjID = sqlReader["ID"].ToString();
            }
            conn.Close();
        }

        void RoleList()
        {
            conn.Open();
            //SqlCommand sqlCmd = new SqlCommand("SELECT DISTINCT Name FROM Projects", conn);
            SqlCommand sqlCmd = new SqlCommand("select ID, Description from Role where ID = '" + "R1"+ "'OR ID = '" + "R2" +"'", conn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            while (sqlReader.Read())
            {
                cmbRole.Items.Add(sqlReader["ID"].ToString() + " - " + sqlReader["Description"].ToString());

            }
            conn.Close();
            cmbRole.SelectedIndex = 0;
        }

        public void AutoAssignmentID()
        {
            conn.Open();
            comd = new SqlCommand("SELECT COUNT(ID) FROM Assignment", conn);
            int i = Convert.ToInt32(comd.ExecuteScalar());
            conn.Close();
            i++;
            asID = "ASS" + i.ToString();
        }

        private void AddNewTester_Load(object sender, EventArgs e)
        {
            AutoTesterID();
            SubsystemList();
            ProjectInfo();
            RoleList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AutoAssignmentID();
            conn.Open();
            SqlCommand comd1 = new SqlCommand("INSERT INTO Users VALUES('" + lblTesterID.Text +
               "','" + txtName.Text + "','" + txtPassword.Text + "')", conn);
            comd1.ExecuteNonQuery();

            SqlCommand comd2 = new SqlCommand("INSERT INTO Assignment (ID, ProjectID, SubSystemID ) VALUES ('" + asID +
               "','" + txtProject.Text + "','" + cmbSubSystem.SelectedIndex.ToString() + "')", conn);
            comd2.ExecuteNonQuery();

            MessageBox.Show("Testcase Inserted");
            DialogResult = DialogResult.OK;
            conn.Close();
            AutoTesterID();
        }
    }
}
