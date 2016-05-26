using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class MLMessages
    {
        public string ErrorID { get; set; }

        public string Message { get; set; }

        public string Host { get; set; }

        public DateTime Date { get; set; }
    }

    public class MLError : MLMessages
    {
        public string User { get; set; }
        public string Application { get; set; }
        public string Source { get; set; }
        public string Url { get; set; }
        public int LineNumber { get; set; }
        public string ErrorStack { get; set; }
        public int Column { get; set; }
    }
}
