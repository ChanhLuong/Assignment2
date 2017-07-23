namespace Assignments.Business
{
    using System.Collections.Generic;

    using Assignment2.DataAccess;
    using Assignment2.Domain;

    public class DefectService
    {
        public List<Project> ProjectList(string UserIDTemp)
        {
            var dataAccess = new DefectData();
            return dataAccess.ProjectList(UserIDTemp);
        }
    }
}
