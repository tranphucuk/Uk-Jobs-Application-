using JobPortal.JobData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Events
{
    public class TaskSuccessEventArg
    {
        public List<JobInfo> Total { get; set; }
        public bool IsComplete { get; set; }
    }
}
