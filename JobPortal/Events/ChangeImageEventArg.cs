using System;
using System.Drawing;

namespace JobPortal.Events
{
    public class ChangeImageEventArg : EventArgs
    {
        public Bitmap Image { get; set; }
    }
}