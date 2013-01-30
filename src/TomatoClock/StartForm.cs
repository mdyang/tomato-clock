using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TomatoClock
{
    public partial class StartForm : Form
    {
        int _timeout;
        System.Timers.Timer _timer;

        public StartForm()
        {
            InitializeComponent();
            _timer = new System.Timers.Timer(1000);
            _timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            _timeout--;
            _remainSec.Text = _timeout.ToString();
            if (_timeout == 0)
            {
                _timer.Stop();
                try
                {
                    Config.Data["interval"] = int.Parse(_inputMin.Text) * 60000;
                }
                catch (Exception)
                {
                    _remainSec.Text = "25";
                    Config.Data["interval"] = 1500000;
                }
                Hide();
                Integrator.Start();
            }
        }

        public void Start()
        {
            _remainSec.Text = "7";
            Show();
            Top = Control.MousePosition.Y - 48;
            Left = Control.MousePosition.X - 156;
            _inputMin.Focus();
            _inputMin.SelectAll();
            _timeout = 7;
            _timer.Start();
        }

        private void _btClose_Click(object sender, EventArgs e)
        {
            _inputMin.Text = "25";
        }
    }
}
