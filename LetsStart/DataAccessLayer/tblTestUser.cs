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
    
    public partial class tblTestUser
    {
        public tblTestUser()
        {
            this.tblTestUserQuestions = new HashSet<tblTestUserQuestion>();
        }
    
        public long TestUID { get; set; }
        public Nullable<int> TestID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.TimeSpan> TimeTaken { get; set; }
        public Nullable<decimal> MarksObtained { get; set; }
        public Nullable<System.DateTime> TestGivenDate { get; set; }
        public Nullable<System.TimeSpan> TestStartTime { get; set; }
        public Nullable<System.TimeSpan> TestEndTime { get; set; }
    
        public virtual tblTest tblTest { get; set; }
        public virtual ICollection<tblTestUserQuestion> tblTestUserQuestions { get; set; }
        public virtual tblUser tblUser { get; set; }
    }
}
