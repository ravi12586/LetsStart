using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataAccessLayer;
namespace BusinessLayer
{
    public class BLUser
    {
        protected DALUser objDALUser=null;
        public MLUser Login(MLUser objMLUser)
        {
            objDALUser = new DALUser();
            return objDALUser.Login(objMLUser);
        }
    }
}
