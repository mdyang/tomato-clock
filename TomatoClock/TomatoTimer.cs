using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace TomatoClock
{
    class TomatoTimer
    {
        Dictionary<string, object> _data = new Dictionary<string,object>();

        public Dictionary<string, object> Data
        {
            get { return _data; }
        }

        public void run()
        {
            Thread.Sleep((int)Config.Data["interval"]);
            Integrator.TimeUp();
        }
    }
}
