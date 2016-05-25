using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace DataAccessLayer
{
   public class DALMenu
    {
       public IList<MLMenu> GetMenuItems(bool  isAdmin)
       {
           using (OnlineTestDBEntities dbContext = new OnlineTestDBEntities())
           {
               return dbContext.tblMenus.AsQueryable().Where(x => x.StatusID == 1 && x.IsAdminMenu == isAdmin).Select(x => new MLMenu { 
                        MenuID=x.MenuID,
                        NameOption=x.NameOption,
                        Controller=x.Controller,
                        Action=x.Action,
                        ImageClass=x.ImageClass,
                        IsAdminMenu=x.IsAdminMenu,
                        StatusID=x.StatusID,
                        IsParent=x.IsParent,
                        ParentID=x.ParentID
                    }).ToList(); ;
              
           }
       }

    }
}
