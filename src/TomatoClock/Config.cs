using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TomatoClock
{
    class Config
    {
        private static Dictionary<string, object> _data;
        public static Dictionary<string, object> Data
        {
            get
            {
                if (_data == null)
                {
                    _data = new Dictionary<string, object>();
                    _initialize();
                }
                return _data;
            }
        }

        private static void _initialize()
        {
            _data["interval"] = 1500000;
        }
    }
}
