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
    
    public partial class tblMenu
    {
        public int MenuID { get; set; }
        public string NameOption { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string ImageClass { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<bool> IsParent { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<bool> IsAdminMenu { get; set; }
    }
}