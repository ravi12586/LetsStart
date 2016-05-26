using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace ModelLayer
{
  public enum StatusStage
    {
        InActive = 0,
        Active = 1
    }
  public class MLQuestion
  {
      public long QID { get; set; }
      public string Question { get; set; }
      public string QuestionDesc { get; set; }
      public Nullable<int> StatusID { get; set; }
      public Nullable<int> CreatedBy { get; set; }
      public Nullable<System.DateTime> CreatedDate { get; set; }
      public Nullable<int> ModifiedBy { get; set; }
      public Nullable<System.DateTime> ModifiedDate { get; set; }
      public Nullable<int> QuestionLevelID { get; set; }
      public Nullable<bool> IsStudyType { get; set; }
      public Nullable<bool> IsMultipleAns { get; set; }

      public IEnumerable<MLAnswer> Answers { get; set; }
  }

  public class MLResult
  {
      public string ParamText1 { get; set; }
      public string ParamText2 { get; set; }
      public string ParamText3 { get; set; }
      public int TotalRecordCount { get; set; }
      public Nullable<int> ParamValue1 { get; set; }
      public Nullable<int> ParamValue2 { get; set; }
      public Nullable<int> ParamValue3 { get; set; }
      
  }

  public class MLResultQuestions
  {
      public IList<MLQuestion> ListQuestionAnswers { get; set; }

  }
  public class MLAnswer
  {
      public long AnsId { get; set; }
      public Nullable<long> QId { get; set; }
      public string Answer { get; set; }
      public string AnswerDesc { get; set; }
      public Nullable<bool> IsAnsTrue { get; set; }
      public Nullable<int> CreatedBy { get; set; }
      public Nullable<System.DateTime> CreatedDate { get; set; }
      public Nullable<int> ModifiedBy { get; set; }
      public Nullable<System.DateTime> ModifiedDate { get; set; }
      public Nullable<int> Status { get; set; }
  }
}
