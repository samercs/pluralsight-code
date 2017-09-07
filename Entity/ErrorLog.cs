using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ErrorLog
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public string ControllerName { get; set; }
        public DateTime DateTime { get; set; }
        public string SessionId { get; set; }
        public string UserAgint { get; set; }
        public string TargetResult { get; set; }
    }
}
