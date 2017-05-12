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
    public partial class Add_New_Testcase : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MEOMEO-PC\SQLEXPRESS;Initial Catalog=Assignment2;Integrated Security=True");
        SqlCommand comd = new SqlCommand();
        public Add_New_Testcase()
        {
            InitializeComponent();
        }

        public string UserIDTC { get; set; }
        string subID;
        //string UserIDTemp;

       public void AutoTestcaseID()
            {
            conn.Open();
            comd = new SqlCommand("SELECT COUNT(ID) FROM Testcases", conn);
            int i = Convert.ToInt32(comd.ExecuteScalar());
            conn.Close();
            i++;
            lblTestcaseID.Text = "TC" + i.ToString();
        }

        public void Subsystem()
        {
            conn.Open();
            SqlCommand SubsystemQuery = new SqlCommand("SELECT ID, Description FROM SubSystem WHERE ID in (SELECT SubSystemID from Assignment Where UserID = '" + UserIDTC + "')", conn);
            SqlDataReader SubsystemRead = SubsystemQuery.ExecuteReader();
            while (SubsystemRead.Read())
            {

                txtSubSystem.Text = SubsystemRead["Description"].ToString();
                subID = SubsystemRead["ID"].ToString();
            }
            conn.Close();

        }

        private void Add_New_Testcase_Load(object sender, EventArgs e)
        {
            AutoTestcaseID();
            Subsystem();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            conn.Open();
            comd = new SqlCommand("INSERT INTO Testcases VALUES('" + lblTestcaseID.Text +
               "','" + txtDescription.Text + "','" + txtDescription.Text +
               "', '" + subID +
               "','" + txtUsecase.Text +"', getdate())", conn);
            comd.ExecuteNonQuery();
            MessageBox.Show("Testcase Inserted");
            DialogResult = DialogResult.OK;      
            conn.Close();
            AutoTestcaseID();
        }
    }
}
