using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataAccessLayer;
namespace BusinessLayer
{
    public class BLAdminHome
    {
        DALAdminHome objDALAdminHome = null;
        public MLResultQuestions LoadQuestionsList()
        {
            objDALAdminHome = new DALAdminHome();
            return objDALAdminHome.LoadQuestionsList();
        }
    }
}
