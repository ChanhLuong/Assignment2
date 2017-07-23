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
    public partial class New_Project_Form : Form
    {
        public New_Project_Form()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Assignment2;Integrated Security=True");
        SqlCommand comd = new SqlCommand();

        public void GenerateProjectID()
        {
            conn.Open();
            comd = new SqlCommand("SELECT COUNT(ID) FROM Projects", conn);
            int i = Convert.ToInt32(comd.ExecuteScalar());
            conn.Close();
            i++;
            lblProjectID.Text = "PRJ" + i.ToString();
        }

        public void GenerateSusbSystemID()
        {
            conn.Open();
            comd = new SqlCommand("SELECT COUNT(ID) FROM SubSystem", conn);
            int i = Convert.ToInt32(comd.ExecuteScalar());
            conn.Close();
            i++;
            lblSubSystemID.Text = "SUB" + i.ToString();
        }

        public void GenerateBuildID()
        {
            conn.Open();
            comd = new SqlCommand("SELECT COUNT(ID) FROM BuildInfo", conn);
            int i = Convert.ToInt32(comd.ExecuteScalar());
            conn.Close();
            i++;
            lblBuildID.Text = "BLD" + i.ToString();
        }

        private void New_Project_Form_Load(object sender, EventArgs e)
        {
            GenerateProjectID();
            GenerateSusbSystemID();
            GenerateBuildID();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtProjectName.Text)) || (string.IsNullOrEmpty(txtSubSystemName.Text)) || (string.IsNullOrEmpty(txtBuildDescription.Text)))
            {
                MessageBox.Show("Please input data for required field", "Required field check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                conn.Open();
                comd = new SqlCommand("INSERT INTO Projects (ID, Name) VALUES('" + lblProjectID.Text + "','" + txtProjectName.Text + "')", conn);
                comd.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                comd = new SqlCommand("INSERT INTO BuildInfo (ID, Description, SubSystemID) VALUES('" + lblBuildID.Text + "','" + txtBuildDescription.Text + "', '" + lblSubSystemID.Text + "')", conn);
                comd.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                comd = new SqlCommand("INSERT INTO SubSystem (ID, Description, BuildID, ProjectID) VALUES('" + lblSubSystemID.Text + "','" + txtSubSystemName.Text + "','" + lblBuildID.Text + "', '" + lblProjectID.Text + "')", conn);
                comd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Records Inserted");
                
            }
            }
    }
}
