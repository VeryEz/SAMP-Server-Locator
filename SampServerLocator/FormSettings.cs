using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SampServerLocator
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }
        public bool bMinimizeOnConnect = false;
        public bool bUseCustomName = true;
        public bool bRefreshServerQuery = true;
        public bool bRefreshIPInfo = true;

        private bool bEnableShutdownOnTime = false;
        private static FormMain formMAIN = new FormMain();

        private void button5_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseGTAWindow()
        {
            if (IsWindowActive("GTA:SA:MP") == false)
            {
                MessageBox.Show("GTA:SA:MP Window not found", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Process[] process = Process.GetProcesses();
                foreach (Process process1 in process)
                {
                    if (process1.MainWindowTitle == "GTA:SA:MP")
                    {
                        //MessageBox.Show(process1.Id.ToString(), "found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        process1.Kill();
                    }
                }
            }
            catch (Exception errprocess)
            {
                MessageBox.Show(errprocess.Message, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Movement
        private static Point downPoint = Point.Empty;

        private void ThisForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = new Point(e.X, e.Y);
        }

        private void ThisForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint != Point.Empty)
                Location = new Point(Left + e.X - downPoint.X, Top + e.Y - downPoint.Y);
        }

        private void ThisForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = Point.Empty;
        }
        #endregion

        private void buttonCopyPlayerName_Click(object sender, EventArgs e)
        {
            if (textBox_InputCustomName.Text == "" || textBox_InputCustomName.Text == "Input new name")
            {
                MessageBox.Show("Copy operation failed, invalid name.", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Clipboard.SetText(textBox_InputCustomName.Text);
            MessageBox.Show("Name successfully copied!", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEraseNameBox_Click(object sender, EventArgs e)
        {
            if (textBox_InputCustomName.Text.Length != 0)
                textBox_InputCustomName.Clear();
        }

        private void buttonEraseShutdownBox_Click(object sender, EventArgs e)
        {
            if (metroTextBoxShutdownTimeInput.Text.Length != 0)
                metroTextBoxShutdownTimeInput.Clear();
        }

        private string getCurrentTime()
        {
            DateTime clockTime = DateTime.Now;
            return clockTime.Hour.ToString() + ":" + clockTime.Minute.ToString() + ":" + clockTime.Second.ToString();
        }

        private bool IsWindowActive(string WinName)
        {
            if (WinName == null)
                return false;

            try
            {
                Process[] process = Process.GetProcesses();
                foreach (Process process1 in process)
                {
                    if (process1.MainWindowTitle == WinName)
                    {
                        return true;
                    }
                }
            }
            catch (Exception errprocess)
            {
                MessageBox.Show(errprocess.Message, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void buttonShutdownGame_Click(object sender, EventArgs e)
        {
            if (IsWindowActive("GTA:SA:MP") == false)
            {
                MessageBox.Show("GTA SA window not found.", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (metroTextBoxShutdownTimeInput.Text.Length == 0)
            {
                MessageBox.Show("Input box cannot be empty.", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!bEnableShutdownOnTime)
            {
                bEnableShutdownOnTime = true;
                timer1.Start();
                MessageBox.Show("Shutdown: Enabled\nGame will shutdown at: " + metroTextBoxShutdownTimeInput.Text, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonShutdownGame.ForeColor = Color.SpringGreen;
            }
            else
            {
                bEnableShutdownOnTime = false;
                if (timer1.Enabled)
                {
                    MessageBox.Show("Shutdown: Disabled" + metroTextBoxShutdownTimeInput.Text, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timer1.Stop();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsWindowActive("GTA:SA:MP") == false)
            {
                if (bEnableShutdownOnTime)
                    bEnableShutdownOnTime = false;
                if (timer1.Enabled)
                {
                    timer1.Stop();
                }
                buttonShutdownGame.ForeColor = Color.SpringGreen;
                return;
            }

            if (getCurrentTime() == metroTextBoxShutdownTimeInput.Text)
            {
                CloseGTAWindow();
                timer1.Stop();
                bEnableShutdownOnTime = false;
                buttonShutdownGame.ForeColor = Color.White;
            }
        }

        private void buttonExitGame_Click(object sender, EventArgs e)
        {
            CloseGTAWindow();
            if (bEnableShutdownOnTime)
            {
                timer1.Stop();
                buttonShutdownGame.ForeColor = Color.White;
                bEnableShutdownOnTime = false;
            }
        }

        private void buttonMinimzeONConnect_Click(object sender, EventArgs e)
        {
            if(!bMinimizeOnConnect)
            {
                buttonMinimzeONConnect.ForeColor = Color.SpringGreen;
                bMinimizeOnConnect = true;
            }
            else
            {
                buttonMinimzeONConnect.ForeColor = Color.White; 
                bMinimizeOnConnect = false;
            }
        }

        private void buttonCustomName_Click(object sender, EventArgs e)
        {
            if (!bUseCustomName)
            {
                buttonCustomName.ForeColor = Color.SpringGreen;
                bUseCustomName = true;
            }
            else
            {
                buttonCustomName.ForeColor = Color.White;
                bUseCustomName = false;
            }
        }

        private void buttonRefreshIPInfo_Click(object sender, EventArgs e)
        {
            if (!bRefreshIPInfo)
            {
                buttonRefreshIPInfo.ForeColor = Color.SpringGreen;
                bRefreshIPInfo = true;
            }
            else
            {
                buttonRefreshIPInfo.ForeColor = Color.White;
                bRefreshIPInfo = false;
            }
        }

        private void buttonRefreshSrvQuery_Click(object sender, EventArgs e)
        {
            if (!bRefreshServerQuery)
            {
                buttonRefreshSrvQuery.ForeColor = Color.SpringGreen;
                bRefreshServerQuery = true;
            }
            else
            {
                buttonRefreshSrvQuery.ForeColor = Color.White;
                bRefreshServerQuery = false;
            }
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            bRefreshIPInfo = true;
            bRefreshServerQuery = true;

            if (bRefreshServerQuery)
            {
                buttonRefreshSrvQuery.ForeColor = Color.SpringGreen;
            }
            else
            {
                buttonRefreshSrvQuery.ForeColor = Color.White;
            }


            if (bRefreshIPInfo)
            {
                buttonRefreshIPInfo.ForeColor = Color.SpringGreen;
            }
            else
            {
                buttonRefreshIPInfo.ForeColor = Color.White;
            }


            if (bUseCustomName)
            {
                buttonCustomName.ForeColor = Color.SpringGreen;
            }
            else
            {
                buttonCustomName.ForeColor = Color.White;
            }


            if (bMinimizeOnConnect)
            {
                buttonMinimzeONConnect.ForeColor = Color.SpringGreen;
            }
            else
            {
                buttonMinimzeONConnect.ForeColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(formMAIN.ip_info_provider != "https://ipapi.co/")
            formMAIN.ip_info_provider = "https://ipapi.co/";
            MessageBox.Show(formMAIN.ip_info_provider);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (formMAIN.ip_info_provider != "https://ipinfo.io/")
                formMAIN.ip_info_provider = "https://ipinfo.io/";
            MessageBox.Show(formMAIN.ip_info_provider);
        }
    }
}
