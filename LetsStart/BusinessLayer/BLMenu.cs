using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataAccessLayer;
namespace BusinessLayer
{
    public class BLMenu
    {
        protected DALMenu objDALMenu = null;
        public IList<MLMenu> GetMenuItems(bool isAdmin)
        {
            objDALMenu = new DALMenu();
            return objDALMenu.GetMenuItems(isAdmin);
        }
    }
}
