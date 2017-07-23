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
        SqlConnection conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Assignment2;Integrated Security=True");
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

       
        void ProjectInfo()
        {
            conn.Open();
            List<CmbItem> itemList = new List<CmbItem>();     
            SqlCommand sqlCmd = new SqlCommand("select ID, Name from Projects", conn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            while (sqlReader.Read())
            {
                var cmbItem = new CmbItem(sqlReader["ID"].ToString(), sqlReader["Name"].ToString());
                itemList.Add(cmbItem);
            }
            conn.Close();
            cmbProject.DataSource = itemList;
            cmbProject.DisplayMember = "Text";
            cmbProject.ValueMember = "ID";
            cmbProject.SelectedIndex = 0;

        }

        void RoleList()
        {           
            List<CmbItem> roleList = ComboData.GetRole();
            cmbRole.DataSource = roleList;
            cmbRole.DisplayMember = "Text";
            cmbRole.ValueMember = "Id";
            cmbRole.SelectedIndex = 0;
        }

        public void AutoAssignmentID()
        {
            conn.Open();
            comd = new SqlCommand("SELECT COUNT(ID) FROM Assignment", conn);
            int i = Convert.ToInt32(comd.ExecuteScalar());
            conn.Close();
            i++;
            asID = "A" + i.ToString();
        }

        private void AddNewTester_Load(object sender, EventArgs e)
        {
            RoleList();
            AutoTesterID();
            ProjectInfo();
            subsystemlist();
                        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string roleID = cmbRole.SelectedValue.ToString();
          
            string projectID = cmbProject.SelectedValue.ToString(); 

            string subsystemleID = cmbSubSystem.SelectedValue.ToString();

            AutoAssignmentID();
            conn.Open();
            SqlCommand comd1 = new SqlCommand("INSERT INTO Users VALUES('" + lblTesterID.Text +
               "','" + txtName.Text + "','" + txtPassword.Text + "')", conn);
            comd1.ExecuteNonQuery();
            conn.Close();

            conn.Open();
            SqlCommand comd2 = new SqlCommand("INSERT INTO Assignment (ID, UserID, RoleID, SubSystemID, ProjectID ) VALUES ('" + asID +
               "', '"+ lblTesterID.Text + "','" + roleID +"', '"+ subsystemleID +"', '" + projectID + "')", conn);
            comd2.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("New Member Inserted");
            DialogResult = DialogResult.OK;
            AutoTesterID();
        }

        void subsystemlist()
        {
            string projectID = cmbProject.SelectedValue.ToString();
            conn.Open();

            SqlCommand sqlCmd = new SqlCommand("select ID, Description from SubSystem Where ProjectID = '" + projectID + "'", conn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            List<CmbItem> itemList = new List<CmbItem>();
            while (sqlReader.Read())
            {
                var cmbItem = new CmbItem(sqlReader["ID"].ToString(), sqlReader["Description"].ToString());
                itemList.Add(cmbItem);
            }
            conn.Close();
            cmbSubSystem.DataSource = itemList;
            cmbSubSystem.DisplayMember = "Text";
            cmbSubSystem.ValueMember = "Id";

        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            subsystemlist();
        }
    }
}
