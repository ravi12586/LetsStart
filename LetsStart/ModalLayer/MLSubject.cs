using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ModelLayer
{

    public class MLSubject
    {
        [ScaffoldColumn(false)]
        public int SubjectId { get; set; }
        public string Subject { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<int> CreatedByID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifyByID { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> StatusID { get; set; }
    }
}
