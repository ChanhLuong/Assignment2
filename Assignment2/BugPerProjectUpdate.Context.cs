﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Assignment2Entities9 : DbContext
    {
        public Assignment2Entities9()
            : base("name=Assignment2Entities9")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<GetBugByProject_Result> GetBugByProject(string fromDate, string toDate, string projectID)
        {
            var fromDateParameter = fromDate != null ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(string));
    
            var toDateParameter = toDate != null ?
                new ObjectParameter("ToDate", toDate) :
                new ObjectParameter("ToDate", typeof(string));
    
            var projectIDParameter = projectID != null ?
                new ObjectParameter("ProjectID", projectID) :
                new ObjectParameter("ProjectID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBugByProject_Result>("GetBugByProject", fromDateParameter, toDateParameter, projectIDParameter);
        }
    }
}
