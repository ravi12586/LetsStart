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
    
    public partial class tblSubject
    {
        public tblSubject()
        {
            this.tblQuestionSubjects = new HashSet<tblQuestionSubject>();
        }
    
        public int SID { get; set; }
        public string Subject { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> StatusID { get; set; }
    
        public virtual ICollection<tblQuestionSubject> tblQuestionSubjects { get; set; }
    }
}
