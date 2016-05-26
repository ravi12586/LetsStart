using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
   public enum QuestionLevel
    {
        Easy=1,
        Medium,
        Regular,
        Important,
        Critical
    };

    public enum AppStatus
    {
        Active = 1,
        InActive,
        Blocked,
        UnVerified
    };

   public class Constants
    {
       public const int USERTYPEADMIN = 1;
    }
}
