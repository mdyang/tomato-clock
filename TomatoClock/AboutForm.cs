using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace TomatoClock
{
    public partial class AboutForm : Form
    {

        public AboutForm()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(AboutForm_FormClosed);
        }

        void AboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Integrator.AboutFormInstance = null;
        }
       
        private void _linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/mdyang/TomatoClock");
        }
    }
}
