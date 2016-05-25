using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
namespace DataAccessLayer
{
    public class DALUser
    {
        public MLUser Login(MLUser objMLUser)
        {
            MLUser objMLUserInfo = new MLUser();
            using (OnlineTestDBEntities dbContext = new OnlineTestDBEntities())
            {
                var userInfo = dbContext.tblUsers.Where(x => x.EmailID == objMLUser.EmailID && x.Password == x.Password && x.StatusID==1).Select(x => x).FirstOrDefault();
                if (userInfo != null)
                {
                    objMLUserInfo.UserID=userInfo.UID;
                    objMLUserInfo.FName =userInfo.FName;
                    objMLUserInfo.LName = userInfo.LName;
                    objMLUserInfo.FullName = objMLUserInfo.GetFullName(objMLUser.FName, objMLUser.LName);
                    objMLUserInfo.DOB = userInfo.DOB;
                    objMLUserInfo.UserTypeID = userInfo.UserTypeID??2;

                }
            }
           
            return objMLUserInfo;
        }

        public void UpdateUserLastLogin(OnlineTestDBEntities dbContext, tblUser objTblUser)
        {
            objTblUser.LastLogin = DateTime.Now;
            dbContext.SaveChanges();
        }
    }
}
