using JobPortal.JobData;
using System;
using System.Collections.Generic;

namespace JobPortal.Events
{
    public class StopThreadEventArg : EventArgs
    {
        public string Status { get; set; }
        public bool isStopped { get; set; }
    }
}