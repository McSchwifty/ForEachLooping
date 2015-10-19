// Andrew Mackinnon
// October 19 2015
// ICS3UR
// MAKES RAINBOWS
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ForEachLooping
{
    public partial class frmForEachLooping : Form
    {
        public frmForEachLooping()
        {
            InitializeComponent();
        }

        private void btnTouchMe_Click(object sender, EventArgs e)
        {
            // Varibles
            const int time = 100;
            foreach (Control firstControl in this.Controls)
            {
                firstControl.ForeColor = Color.Red;
                Thread.Sleep(time);
                Refresh();
                firstControl.ForeColor = Color.Orange;
                Thread.Sleep(time);
                Refresh();
                firstControl.ForeColor = Color.Yellow;
                Thread.Sleep(time);
                Refresh();
                firstControl.ForeColor = Color.Green;
                Thread.Sleep(time);
                Refresh();
                firstControl.ForeColor = Color.Blue;
                Thread.Sleep(time);
                Refresh();
                firstControl.ForeColor = Color.Purple;
                Thread.Sleep(time);
                Refresh();
                firstControl.ForeColor = Color.Red;
                Thread.Sleep(time);
                Refresh();
            }
        }
    }
}

