using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace LCProxy
{

    // Please visit the User Classes to see the code

    public partial class LCProxyGUI : Form
    {
        // Rounded Corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );

        // Shit for dragable panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public LCProxyGUI()
        {
            InitializeComponent();

            // Round the form corners
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));

            installerPanel.Hide();
            troubleShootPanel.Hide();
        }

        private void exitApplicationBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void homeTabBtn_Click(object sender, EventArgs e)
        {
            homeTabBtn.ForeColor = Color.White;

            installerTabBtn.ForeColor = Color.Gray;
            troubleshootTabBtn.ForeColor = Color.Gray;

            installerPanel.Hide();
            troubleShootPanel.Hide();
        }

        private void installerTabBtn_Click(object sender, EventArgs e)
        {
            installerTabBtn.ForeColor = Color.White;

            homeTabBtn.ForeColor = Color.Gray;
            troubleshootTabBtn.ForeColor = Color.Gray;

            installerPanel.Show();
            troubleShootPanel.Hide();
        }

        private void troubleshootTabBtn_Click(object sender, EventArgs e)
        {
            troubleshootTabBtn.ForeColor = Color.White;

            homeTabBtn.ForeColor = Color.Gray;
            installerTabBtn.ForeColor = Color.Gray;

            installerPanel.Hide();
            troubleShootPanel.Show();
        }

        private void installNowBtn_Click(object sender, EventArgs e)
        {
            installerPanel.Show();

            installerTabBtn.ForeColor = Color.White;
            homeTabBtn.ForeColor = Color.Gray;
        }

        private void havingIssuesBtn_Click(object sender, EventArgs e)
        {
            troubleShootPanel.Show();

            troubleshootTabBtn.ForeColor = Color.White;
            homeTabBtn.ForeColor = Color.Gray;
        }

        private void LCProxyGUI_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("discord:///invite-proxy/914512197781176392");
        }

        private void installerPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
