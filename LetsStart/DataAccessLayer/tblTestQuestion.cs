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
    
    public partial class tblTestQuestion
    {
        public long TestQID { get; set; }
        public Nullable<int> TestID { get; set; }
        public Nullable<long> QuestionID { get; set; }
    
        public virtual tblQuestion tblQuestion { get; set; }
        public virtual tblTest tblTest { get; set; }
    }
}
