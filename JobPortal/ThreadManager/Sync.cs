using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.ThreadManager
{
    public static class Sync
    {
        public static object pageLock = new object();
        public static object stopLock = new object();
        public static object compeleteLock = new object();
    }
}
