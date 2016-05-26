using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LetsStart.Hubs
{
    public class JSException : Exception
    {
        public string Message { get; set; }
        public string Url { get; set; }
        public int LineNumber { get; set; }
        public string ErrorStack { get; set; }
        public int Column { get; set; }
        public string User { get; set; }
        public string Application { get; set; }
        public string Source { get; set; }
        public override string ToString()
        {
            return Message + Environment.NewLine +
                "Url: " + Url + Environment.NewLine +
                "User: "+User+Environment.NewLine+
                "Application: " + Application + Environment.NewLine +
                "Source: " + Source + Environment.NewLine +
                "Line: " + LineNumber + Environment.NewLine +
                "Column: " + Column + Environment.NewLine +
                (!string.IsNullOrEmpty(ErrorStack) ? ("Stack Trace: " + ErrorStack + Environment.NewLine) : string.Empty) + base.ToString();
        }
    }
}