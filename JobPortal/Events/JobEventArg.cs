using JobPortal.JobData;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobPortal.BoardDetail
{
    public class JobEventArg : EventArgs
    {
        public List<JobInfo> Data { get; set; }
    }
}
