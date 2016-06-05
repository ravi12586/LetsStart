using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class MLDropdown
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public Nullable<int> ParentID { get; set; }
    }

    public class MLDropdownBindOption
    {
        public string TableName { get; set; }
        public string ColID { get; set; }
        public string ColText { get; set; }
        public string Option { get; set; }
    }

}
