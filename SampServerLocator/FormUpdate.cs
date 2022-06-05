using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SampServerLocator
{
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }
        private bool IsURLHTTP(string uri)
        {
            if (!Uri.IsWellFormedUriString(uri, UriKind.Absolute))
                return false;
            Uri tmp;
            if (!Uri.TryCreate(uri, UriKind.Absolute, out tmp))
                return false;
            return tmp.Scheme == Uri.UriSchemeHttp || tmp.Scheme == Uri.UriSchemeHttps;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (buttonDownloadUpdate.BackColor == Color.DimGray)
            {
                DialogResult dialogResult = MessageBox.Show("Download is active\ndo you want to abort ?", "SA:MP Server Locator", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    buttonDownloadUpdate.ForeColor = Color.White;
                    buttonDownloadUpdate.BackColor = Color.SteelBlue;
                    buttonDownloadUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 200, 200, 200);
                    if (progressBar1.Visible == true)
                    {
                        szLabelUpdateChecker.Text = "No new updates found.";
                        szLabelUpdateChecker.Location = new Point(187, 47);
                        szLabelProgress.Text = "...";
                        textBox1.Visible = true;
                        textBoxPath.Visible = true;
                        buttonPathChoose.Visible = true;
                        szLabelProgress.Visible = false;
                        progressBar1.Value = 0;
                        progressBar1.Visible = false;
                    }
                    if (webClient.IsBusy)
                        webClient.CancelAsync();
                    Hide();
                }
            }
            else Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private WebClient webClient = null;
        private Thread thread;
        private void buttonDownloadUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonDownloadUpdate.BackColor == Color.DimGray)
                {
                    DialogResult dialogResult = MessageBox.Show("Download is already active\ndo you want to abort ?", "SA:MP Server Locator", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(dialogResult == DialogResult.Yes)
                    {
                        buttonDownloadUpdate.ForeColor = Color.White;
                        buttonDownloadUpdate.BackColor = Color.SteelBlue;
                        buttonDownloadUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 200, 200, 200);
                        if (progressBar1.Visible == true)
                        {
                            szLabelUpdateChecker.Text = "No new updates found.";
                            szLabelUpdateChecker.Location = new Point(187, 47);
                            szLabelProgress.Text = "...";
                            textBox1.Visible = true;
                            textBoxPath.Visible = true;
                            buttonPathChoose.Visible = true;
                            szLabelProgress.Visible = false;
                            progressBar1.Value = 0;
                            progressBar1.Visible = false;
                        }
                        if(webClient.IsBusy)
                        webClient.CancelAsync();
                    }
                }
                else
                {
                    if(string.IsNullOrEmpty(textBoxPath.Text))
                    {
                        MessageBox.Show("Invalid path!\nSelect some folder to save download to.", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPath.Text = "C:\\Users\\" + Environment.UserName + "\\Desktop\\";
                        return;
                    }

                    if (string.IsNullOrEmpty(textBox1.Text) || IsURLHTTP(textBox1.Text) == false)
                    {
                        MessageBox.Show("Invalid download link.", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (progressBar1.Visible == false)
                    {
                        szLabelProgress.Visible = true;
                        textBox1.Visible = false;
                        textBoxPath.Visible = false;
                        buttonPathChoose.Visible = false;
                        progressBar1.Visible = true;
                    }

                    szLabelUpdateChecker.ForeColor = Color.White;
                    buttonDownloadUpdate.ForeColor = Color.Silver;
                    buttonDownloadUpdate.BackColor = Color.DimGray;
                    buttonDownloadUpdate.FlatAppearance.MouseOverBackColor = Color.DimGray;
                    szLabelUpdateChecker.Text = $"{string.Format("Downloading File: {0}", Path.GetFileName(textBox1.Text))}";
                    szLabelUpdateChecker.Location = new Point(50, 47);
                    thread = new Thread(() =>
                    {
                        Uri uri = new Uri(textBox1.Text);
                        string filename = Path.GetFileName(uri.AbsoluteUri);
                        webClient.DownloadFileAsync(uri, $"{string.Format("{0}", textBoxPath.Text + filename)}");
                    });
                    thread.Start();
                }
            }
            catch(Exception err)
            {
                if (webClient.IsBusy)
                    webClient.CancelAsync();
            }
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            szLabelProgress.Text = "...";
            textBoxPath.Text = "C:\\Users\\" + Environment.UserName + "\\" + Environment.SpecialFolder.Desktop.ToString() + "\\";
            textBox1.Text = "https://download938.mediafire.com/7a4b7lf41icg/6evini6nalc5ys2/SampServerLocator.rar";
            webClient = new WebClient();
            webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                try
                {
                    buttonDownloadUpdate.ForeColor = Color.White;
                    buttonDownloadUpdate.BackColor = Color.SteelBlue;
                    buttonDownloadUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 200, 200, 200);
                    if (progressBar1.Visible == true)
                    {
                        progressBar1.Value = 0;
                        if (szLabelUpdateChecker.ForeColor == Color.Red)
                        {
                            szLabelUpdateChecker.Text = "Error: Invalid Link!";
                            szLabelUpdateChecker.Location = new Point(50, 47);
                            webClient.CancelAsync();
                        }
                        else
                        {
                            szLabelUpdateChecker.Text = "Download Complete";
                            szLabelUpdateChecker.Location = new Point(187, 47);
                            szLabelUpdateChecker.ForeColor = Color.White;
                        }
                        szLabelProgress.Text = "...";
                        textBox1.Visible = true;
                        textBoxPath.Visible = true;
                        buttonPathChoose.Visible = true;
                        szLabelProgress.Visible = false;
                        progressBar1.Visible = false;
                    }
                }
                catch(Exception)
                {
                    if (webClient.IsBusy)
                        webClient.CancelAsync();
                }
            }));
        }


        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                try
                {
                    double receive = double.Parse(e.BytesReceived.ToString());
                    double total = double.Parse(e.TotalBytesToReceive.ToString());
                    double perc = receive / total * 100;
                    szLabelProgress.Text = $"{string.Format("{0:0}", perc)}%";
                    progressBar1.Value = int.Parse(Math.Truncate(perc).ToString());
                }
                catch(Exception)
                {
                    szLabelUpdateChecker.Text = "Error: Invalid URL!";
                    szLabelUpdateChecker.ForeColor = Color.Red;
                    webClient.CancelAsync();
                }
            }));
        }

        private void buttonPathChoose_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog saveFileDialog = new FolderBrowserDialog())
            {
                if(saveFileDialog.ShowDialog() ==  DialogResult.OK)
                {
                    textBoxPath.Text = saveFileDialog.SelectedPath + "\\";
                }
            }
        }
    }
}
   
