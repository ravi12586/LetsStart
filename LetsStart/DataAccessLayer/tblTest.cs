//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTest
    {
        public tblTest()
        {
            this.tblGroupMembers = new HashSet<tblGroupMember>();
            this.tblTestQuestions = new HashSet<tblTestQuestion>();
            this.tblTestUsers = new HashSet<tblTestUser>();
        }
    
        public int TestID { get; set; }
        public string TestName { get; set; }
        public Nullable<System.TimeSpan> TestDuration { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<int> CreatedByID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedByID { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual ICollection<tblGroupMember> tblGroupMembers { get; set; }
        public virtual ICollection<tblTestQuestion> tblTestQuestions { get; set; }
        public virtual tblUser tblUser { get; set; }
        public virtual tblUser tblUser1 { get; set; }
        public virtual ICollection<tblTestUser> tblTestUsers { get; set; }
    }
}
