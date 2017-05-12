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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MEOMEO-PC\SQLEXPRESS;Initial Catalog=Assignment2;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        public string UserName { get; set; }
        public string UserRoleDes { get; set; }
        public string UserID { get; set; }
        public string UserRoleID { get; set; }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }
     
        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT ID from Users where Name = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'",con);
            DataTable dt1 = new DataTable();   
            sda1.Fill(dt1);
            if (dt1.Rows.Count == 1)
            {
                this.UserName = this.txtUsername.Text;
                this.UserID = dt1.Rows[0][0].ToString();
                DialogResult = DialogResult.OK;
            }
            con.Close();

            con.Open();
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT ID, Description from Role where ID in (select RoleID from Assignment where UserID = '" + UserID + "')", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            if(dt2.Rows.Count == 1)
            {
                this.UserRoleID = dt2.Rows[0][0].ToString();
                this.UserRoleDes = dt2.Rows[0][1].ToString();
            }
            con.Close();
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
