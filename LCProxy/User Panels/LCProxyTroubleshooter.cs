using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace LCProxy
{
    public partial class LCProxyTroubleshooter : UserControl
    {
        public LCProxyTroubleshooter()
        {
            InitializeComponent();
        }


        // Goes through every fix in attempt to fix the users issues.
        private void troubleshootBtn_Click(object sender, EventArgs e)
        {
            statusTxt.Text = "LCProxy has started to troubleshoot...";

            System.Threading.Thread.Sleep(1000);

            try
            {
                // [Step 1] ~ Killing the Minecraft process.
                foreach (Process proc in Process.GetProcessesByName("javaw"))
                {
                    proc.Kill();
                }


                // [Step 2] ~ Delete / create hosts file
                if (!File.Exists("C:\\Windows\\System32\\drivers\\etc\\hosts"))
                {
                    File.Create("C:\\Windows\\System32\\drivers\\etc\\hosts");

                    Process.Start("cmd.exe", "/c echo # hosts > C:\\Windows\\System32\\drivers\\etc\\hosts").WaitForExit();
                }
                else if (File.Exists("C:\\Windows\\System32\\drivers\\etc\\hosts"))
                {
                    Process.Start("cmd.exe", "/c del C:\\Windows\\System32\\drivers\\etc\\hosts").WaitForExit();

                    Process.Start("cmd.exe", "/c echo # hosts > C:\\Windows\\System32\\drivers\\etc\\hosts").WaitForExit();

                    if (!File.Exists("C:\\Windows\\System32\\drivers\\etc\\hosts"))
                    {
                        File.Create("C:\\Windows\\System32\\drivers\\etc\\hosts");
                    }
                }
                else
                {
                    statusTxt.Text = "Troubleshooting failed to fix issues. Please contact support. (hosts)";
                    return;
                }

                // [Step 3] ~ Delete lmhosts.sam file
                if (File.Exists("C:\\Windows\\System32\\drivers\\etc\\lmhosts.sam"))
                {
                    try
                    {
                        File.Delete("C:\\Windows\\System32\\drivers\\etc\\lmhosts.sam");
                    }
                    catch
                    {
                        Process.Start("cmd.exe", "/c del C:\\Windows\\System32\\drivers\\etc\\lmhosts.sam").WaitForExit();
                    }
                }

                statusTxt.Text = "Troubleshooting has completed! Please restart your\ncomputer to finish the process.";
            }
            catch (Exception)
            {
                // Ignore
            }
        }

    }
}
