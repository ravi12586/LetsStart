using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
namespace DataAccessLayer
{
    public class DLCommon
    {
        public IList<MLDropdown> GetDropdownList(MLDropdownBindOption objDDLBind)
        {
            using(OnlineTestDBEntities dbContext=new OnlineTestDBEntities())
            {
                var objDropdown = dbContext.usp_GetDropdownList(objDDLBind.TableName, objDDLBind.ColID, objDDLBind.ColText, objDDLBind.Option).ToList();
                if (objDropdown != null)
                {
                    return objDropdown.Select(x => new MLDropdown
                    {
                        ID = x.ID,
                        Text = x.Text,
                        ParentID = x.ParentID
                    }).ToList();
                }
                else
                {
                    return new List<MLDropdown>();
                }
            }
        }
    }
}
