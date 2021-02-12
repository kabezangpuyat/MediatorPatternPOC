using System;
using System.Collections.Generic;
using System.Text;

namespace MNV.Requests.Commands
{
    public class ApplicationInsightsLogExceptionCommand : ICommand
    {
        public Exception Exception { get; set; }
        public Dictionary<string, string> Properties { get; set; }
    }
}
