using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class MLMenu
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
