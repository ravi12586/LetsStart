using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataAccessLayer;
namespace BusinessLayer
{
    public class BLCommon
    {
        DLCommon objDLCommon = null;
        public IList<MLDropdown> GetDropdownList(MLDropdownBindOption objDDLBind)
        {
            objDLCommon = new DLCommon();
            return objDLCommon.GetDropdownList(objDDLBind);
        }
    }
}
