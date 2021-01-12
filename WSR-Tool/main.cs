using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

//start of legendary shit

//end of legendary shit


namespace WSR_Tool
{
    public partial class main : Form
    {
        public string currentVer = "1.2";


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public main()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }



        private void maketransparentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced");
                try
                {
                    Object TaskbarAcrylicOpacity = registryKey.GetValue("TaskbarAcrylicOpacity");
                    if (TaskbarAcrylicOpacity == null)
                    {
                        Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced").SetValue("TaskbarAcrylicOpacity", 0, RegistryValueKind.DWord);
                        //registryKey.SetValue("TaskbarAcrylicOpacity", 0, RegistryValueKind.DWord);
                        MessageBox.Show("Succesfully Made Taskbar Transparent", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        foreach (var process in Process.GetProcessesByName("explorer"))
                        {
                            process.Kill();
                            Thread.Sleep(100);
                            process.Start();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Taskbar Is Already Transparent", "Already Transparent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced");
                    if (key == null)
                    {
                        Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Unexpected error! Tell me about it on discord: robiot#5485", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced");
                if (registryKey == null)
                {
                    Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced");
                }
            }
        }

        private void defaultTaskbarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced");
                try
                {
                    Object TaskbarAcrylicOpacity = registryKey.GetValue("TaskbarAcrylicOpacity");
                    if (TaskbarAcrylicOpacity != null)
                    {
                        RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced");
                        key.DeleteValue("TaskbarAcrylicOpacity");
                        MessageBox.Show("Succesfully Set Taskbar To Default", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        foreach (var process in Process.GetProcessesByName("explorer"))
                        {
                            process.Kill();
                            Thread.Sleep(100);
                            process.Start();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Taskbar Is Already Not Transparent", "Already Not Transparent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced");
                    if (key == null)
                    {
                        Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Unexpected error! Tell me about it on discord: robiot#5485", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced");
                if (registryKey == null)
                {
                    Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced");
                }
            }
        }


        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                      .IsInRole(WindowsBuiltInRole.Administrator);
        }
        private void removeBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons", true);
                if (registryKey == null)
                {
                    Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons").SetValue("29", "%windir%\\System32\\shell32.dll,-50");
                    MessageBox.Show("Removed Arrow Icon From Shortcuts!", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (var process in Process.GetProcessesByName("explorer"))
                    {
                        process.Kill();
                        Thread.Sleep(100);
                        process.Start();
                    }

                }
                else
                {
                    MessageBox.Show("The icons are already removed", "Already Removed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Couldnt remove the Arrows! Make sure to run the program as Administrator", "Error: Permissions Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void main_Load(object sender, EventArgs e)
        {
            //versionLbl.Text = path;
            versionLbl.Text = "v"+currentVer;
            try
            {
                WebClient wc = new WebClient();

                string[] Update = wc.DownloadString("https://raw.githubusercontent.com/robi0t/Update/main/Module.txt").Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string latestVersion = Update[0].ToString();
                //string downloadLink = Update[1].ToString();
                if (!string.Equals(latestVersion, currentVer))
                {
                    DialogResult updateBox = MessageBox.Show(
                        "You are using version "+currentVer+" However version "+latestVersion+" Is available! Do you want to download the latest version?",
                        "New Version Available", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Information);
                    if (updateBox == DialogResult.Yes)
                    {
                        string downloadLink = Update[1].ToString();
                        Process.Start(downloadLink);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Couldnt check for the latest update", "Error: No Network Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.LocalMachine.DeleteSubKeyTree(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons");
                MessageBox.Show("Restored Arrow Icon on Shortcuts to default!", "Restored", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (var process in Process.GetProcessesByName("explorer"))
                {
                    process.Kill();
                    Thread.Sleep(100);
                    process.Start();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Couldnt restore the Arrows! Make sure to run the program as Administrator", "Error: Permissions Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void discordLogo_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();

            string[] Update = wc.DownloadString("https://raw.githubusercontent.com/robi0t/Update/main/Module.txt").Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string discordLink = Update[2].ToString();

            Process.Start(discordLink);
        }

        private void blankNames_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult updateBox = MessageBox.Show(
                    "Are you sure you want to hide Windows Activation",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (updateBox == DialogResult.Yes)
                {
                    try
                    {
                        RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop");
                        try
                        {
                            //registryKey.DeleteValue("PaintDesktopVersion");
                            //Thread.Sleep(100);
                            Registry.CurrentUser.CreateSubKey(@"Control Panel\Desktop").SetValue("PaintDesktopVersion", 0, RegistryValueKind.DWord);
                            //registryKey.SetValue("TaskbarAcrylicOpacity", 0, RegistryValueKind.DWord);
                            MessageBox.Show("Succesfully Hid Windows Activation. Restart your computer to finish the process", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        catch (Exception)
                        {
                            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop");
                            if (key == null)
                            {
                                Registry.CurrentUser.CreateSubKey(@"Control Panel\Desktop");
                            }
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unexpected error! Tell me about it on discord: robiot#5485", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop");
                        if (registryKey == null)
                        {
                            Registry.CurrentUser.CreateSubKey(@"Control Panel\Desktop");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unexpected error, make sure to run the program as administrator", "Error: Missing Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
