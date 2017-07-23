using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class ComboData
    {
        static SqlConnection conn = new SqlConnection(@"Data Source=MEOMEO-PC\SQLEXPRESS;Initial Catalog=Assignment2;Integrated Security=True");
        static SqlCommand comd = new SqlCommand();
        public static List<CmbItem> GetRole()
        {
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand("select ID, Description from Role where ID != '" + "R5" + "'", conn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            List<CmbItem> roleList = new List<CmbItem>();
            while (sqlReader.Read())
            {
                var cmbItem = new CmbItem(sqlReader["ID"].ToString(), sqlReader["Description"].ToString());
                roleList.Add(cmbItem);


            }
            return roleList;
        }
    }
}
