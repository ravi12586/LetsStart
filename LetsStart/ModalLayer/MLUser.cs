using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{

    public class MLUser
    {
       
        public int UserID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string FullName { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public Nullable<DateTime> DOB { get; set; }
        public int UserTypeID { get; set; }

        public Nullable<int> CreatedByID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifyByID { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> StatusID { get; set; }

         public string GetFullName(string fName, string lName)
        {
            string FullName = string.Empty;
            if (!string.IsNullOrEmpty(fName))
                FullName = fName;
            if (!string.IsNullOrEmpty(lName))
                FullName += " " + lName;
            return FullName;
        }
    }
   
}
