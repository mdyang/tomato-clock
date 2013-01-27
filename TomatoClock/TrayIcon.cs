using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using TomatoClock.Properties;

namespace TomatoClock
{
    public class TrayIcon
    {
        private NotifyIcon _notifyIcon;
        // right click menu
        private ContextMenu _contextMenu;
        // exit
        private MenuItem _menuItem_Op;
        private MenuItem _menuItem_About;
        private MenuItem _menuItem_Exit;

        private IContainer _components;
        
        public TrayIcon()
        {
            CreateNotifyicon();
        }
        private void CreateNotifyicon()
        {
            _components = new Container();
            _contextMenu = new ContextMenu();

            // Initialize menuItem

            _menuItem_Op = new MenuItem("Sta&rt");
            _menuItem_Op.Index = 0;
            _menuItem_Op.Click += new EventHandler(menuOp_Click);

            _menuItem_About = new MenuItem("A&bout");
            _menuItem_About.Index = 1;
            _menuItem_About.Click += new EventHandler(_menuItem_About_Click);

            _menuItem_Exit = new MenuItem("E&xit");
            _menuItem_Exit.Index = 2;
            _menuItem_Exit.Click += new EventHandler(_menuExit_Click);
          
            // Initialize contextMenu1
            _contextMenu.MenuItems.Add(_menuItem_Op);
            _contextMenu.MenuItems.Add("-");
            _contextMenu.MenuItems.Add(_menuItem_About);
            _contextMenu.MenuItems.Add(_menuItem_Exit);
            
            // Create the NotifyIcon.
            _notifyIcon = new NotifyIcon(_components);

            // The Icon property sets the icon that will appear
            // in the systray for this application.
            _notifyIcon.Icon = Resources.TomatoClock_stopped;
            _notifyIcon.Text = "TomatoClock is not working.";
            _notifyIcon.MouseMove += new MouseEventHandler(_notifyIcon_MouseMove);

            // The ContextMenu property sets the menu that will
            // appear when the systray icon is right clicked.
            _notifyIcon.ContextMenu = _contextMenu;

            
            // The Text property sets the text that will be displayed,
            // in a tooltip, when the mouse hovers over the systray icon.          
            _notifyIcon.Visible = true;
        }

        void _menuItem_About_Click(object sender, EventArgs e)
        {
            if (Integrator.AboutFormInstance == null)
            {
                Integrator.AboutFormInstance = new AboutForm();
                Integrator.AboutFormInstance.Show();
            }
        }

        void _notifyIcon_MouseMove(object sender, MouseEventArgs e)
        {
            if (Integrator.CurrentState == State.RUNNING)
            {
                TimeSpan elapsed = DateTime.Now - Integrator.BeginTime;
                TimeSpan total = new TimeSpan(0, 0, 0, 1, (int)Config.Data["interval"]);
                TimeSpan remaining = total - elapsed;
                _notifyIcon.Text = String.Format("Elapsed: {0}:{1}\nRemaining: {2}:{3}",
                    elapsed.Minutes, elapsed.Seconds.ToString("D2"),
                    remaining.Minutes, remaining.Seconds.ToString("D2"));
            }
        }

        void menuOp_Click(object sender, EventArgs e)
        {
            switch (Integrator.CurrentState)
            {
                case State.STOPPED:
                    Integrator.StartFormInstance.Start();
                    break;
                case State.RUNNING:
                    Integrator.Stop();
                    break;
            }
        }

        // Exit
        void _menuExit_Click(object sender, EventArgs e)
        {
            Integrator.Exit();
        }
        public NotifyIcon NotifyIconObj
        {
            get
            {
                return _notifyIcon;
            }
        }

        public MenuItem MenuItemOp
        {
            get
            {
                return _menuItem_Op;
            }
        }
        
    }
}