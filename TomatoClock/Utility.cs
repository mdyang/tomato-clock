using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TomatoClock
{
    class Utility
    {
        private static TomatoTimer _timer = null;
        private static Thread _thread;

        public static Thread TimerThread
        {
            get
            {
                if (_thread == null)
                {
                    _thread = new Thread(new ThreadStart(Timer.run));
                }
                return _thread;
            }
            set
            {
                _thread = value;
            }
        }

        public static TomatoTimer Timer
        {
            get
            {
                if (_timer == null)
                {
                    _timer = new TomatoTimer();
                }
                return _timer;
            }
        }
    }
}
