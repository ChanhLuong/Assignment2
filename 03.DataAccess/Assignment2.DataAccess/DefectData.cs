namespace Assignment2.DataAccess
{
    using System.Collections.Generic;

    using Assignment2.Domain;
    using System.Data.SqlClient;

    public class DefectData
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=MEOMEO-PC\SQLEXPRESS;Initial Catalog=Assignment2;Integrated Security=True");

        public List<Project> ProjectList(string UserIDTemp)
        {
            var results = new List<Project>();
            conn.Open(); // connection management

            // database queries 
            //SqlCommand sqlCmd = new SqlCommand("SELECT DISTINCT Name FROM Projects", conn);
            SqlCommand sqlCmd = new SqlCommand("select ID, Name from Projects where ID in (select ProjectID from SubSystem where ID in (select SubSystemID from Assignment where UserID = '" + UserIDTemp + "'))", conn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            // render data to UI
            while (sqlReader.Read())
            {
                var project = new Project();
                project.Name = sqlReader["Name"].ToString();
                project.Id = sqlReader["ID"].ToString();
                results.Add(project);
            }

            //connection management
            conn.Close();

            return results;
        }
    }
}
