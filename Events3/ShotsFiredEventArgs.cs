using System;
using System.Collections.Generic;
using System.Text;

namespace Events3
{
    public class ShotsFiredEventArgs : EventArgs
    {
        public DateTime TimeOfKill { get; set; }
        public ShotsFiredEventArgs(DateTime dateTime)
        {
            TimeOfKill = dateTime;
        }
    }
}
