using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Media;
using System.Windows.Forms;
using TomatoClock.Properties;
using System.ComponentModel;

namespace TomatoClock
{
    enum State{
        RUNNING, STOPPED
    }
    class Integrator
    {
        private static SoundPlayer _player = new SoundPlayer(Resources.REMINDER);
        private static TrayIcon _icon;
        public static DateTime BeginTime { get; set; }
        public static State CurrentState { get; set; }

        private static StartForm _startForm = new StartForm();
        public static StartForm StartFormInstance { get { return _startForm; } }

        public static AboutForm AboutFormInstance { get; set; }
        
        public static void StartUp()
        {
            CurrentState = State.STOPPED;
            _icon = new TrayIcon();
        }

        public static void Start()
        {
            _icon.NotifyIconObj.Icon = Resources.TomatoClock_running;
            Utility.TimerThread.Start();
            _icon.MenuItemOp.Text = "Stop";
            CurrentState = State.RUNNING;
            BeginTime = DateTime.Now;
        }

        public static void TimeUp()
        {
            //Notifier.Popup();
            _icon.NotifyIconObj.ShowBalloonTip(7000, "TomatoClock", "Preset time is up.", ToolTipIcon.Info);
            Utility.TimerThread = null;
            _icon.NotifyIconObj.Icon = Resources.TomatoClock_stopped;
            _player.Play();
            _TimeoutCleanup();
        }

        public static void Stop()
        {
            Utility.TimerThread.Abort();
            Utility.TimerThread = null;
            _TimeoutCleanup();
        }

        public static void Exit()
        {
            Stop();
            _icon.NotifyIconObj.Visible = false;
            Application.Exit();
        }

        private static void _TimeoutCleanup()
        {
            _icon.MenuItemOp.Text = "Start";
            _icon.NotifyIconObj.Icon = Resources.TomatoClock_stopped;
            _icon.NotifyIconObj.Text = "TomatoClock is not working";
            CurrentState = State.STOPPED;
        }
    }
}
