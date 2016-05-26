using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
namespace DataAccessLayer
{
    public class DALAdminHome
    {
        public MLResultQuestions LoadQuestionsList()
        {
            using (OnlineTestDBEntities dbContext = new OnlineTestDBEntities())
            {
                MLResultQuestions objMLResult = new MLResultQuestions();
                objMLResult.ListQuestionAnswers = dbContext.tblQuestions.Where(x => x.StatusID == 1).Select(x => new MLQuestion
                {
                    QID = x.QID,
                    Question = x.Question,
                    QuestionDesc = x.QuestionDesc,
                    QuestionLevelID = x.QuestionLevelID,
                    IsMultipleAns = x.IsMultipleAns,
                    IsStudyType = x.IsStudyType,
                    ModifiedBy = x.ModifiedBy,
                    ModifiedDate = x.ModifiedDate,
                }).ToList();
                return objMLResult;
            }
        }
    }
}
