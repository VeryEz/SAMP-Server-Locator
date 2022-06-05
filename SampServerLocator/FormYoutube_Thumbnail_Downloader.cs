using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace SampServerLocator
{
    public partial class FormYoutube_Thumbnail_Downloader : Form
    {
        public FormYoutube_Thumbnail_Downloader()
        {
            InitializeComponent();
        }
        private bool bCustomLink = false;

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private WebClient webClient = null;
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (webClient.IsBusy)
            {
                DialogResult dialogResult = MessageBox.Show("Image is still loading, do you want to abort ?", "SA:MP Server Locator", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    pictureBox1.BackgroundImage = null;
                    buttonBigCameraImage.Visible = true;
                    webClient.CancelAsync();
                }
                return;
            }


            if (bCustomLink)
            {
                if (IsURLHTTP(metroTextBox1.Text) == false)
                {
                    MessageBox.Show("Invalid image URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(metroTextBox1.Text.Contains(".jpg") == false)
                {
                    MessageBox.Show("Custom Image URL must containt image format (.jpg) on the end of image link.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (IsURLHTTP(metroTextBox1.Text) == true)
                {
                    MessageBox.Show("Invalid image URL.\nYou need to input only video code not whole video url!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            if (string.IsNullOrEmpty(metroTextBox1.Text))
            {
                MessageBox.Show("Video code not found.", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (metroTextBox1.Text == "Insert Video code (not video link)")
            {
                MessageBox.Show("Wrong type of code.", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread thread = new Thread(() =>
            {
                try
                {
                    buttonBigCameraImage.Invoke((MethodInvoker)(() => buttonBigCameraImage.Visible = false));
                    byte[] imageByte = webClient.DownloadData(bCustomLink ? metroTextBox1.Text : "http://i3.ytimg.com/vi/" + $"{metroTextBox1.Text}" + "/maxresdefault.jpg");//$"{string.Format(@"http://i3.ytimg.com/vi/" + "{0}" + "/maxresdefault.jpg", metroTextBox1.Text)}");
                    MemoryStream memoryStream = new MemoryStream(imageByte);
                    if (pictureBox1.BackgroundImage == null)
                    {
                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.BackgroundImage = Image.FromStream(memoryStream)));
                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.BackgroundImageLayout = ImageLayout.Stretch));
                    }
                    else
                    {
                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.BackgroundImage = null));
                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.BackgroundImage = Image.FromStream(memoryStream)));
                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.BackgroundImageLayout = ImageLayout.Stretch));
                    }
                }
                catch (Exception err)
                {
                    Invoke(new MethodInvoker(delegate ()
                   {
                       if (buttonBigCameraImage.Visible == false)
                           buttonBigCameraImage.Visible = true;
                       MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }));
                }
            });
            thread.Start();
        }

        private void FormYoutube_Thumbnail_Downloader_Load(object sender, EventArgs e)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            webClient = new WebClient();
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

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For Example\nThis is full video URL: 'https://youtube.com/watch?v=K9HDhjDD2N8' \nNow Video code for this video is: K9HDhjDD2N8\nand that's what you need to insert.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bCustomLink)
            {
                button2.ForeColor = Color.White;
                metroTextBox1.Text = "Insert Video code (not video link)";
                button2.Text = "Custom Link";
                labelTitle.Text = "Youtube Thumbnail Catcher";
                bCustomLink = false;
            }
            else
            {
                bCustomLink = true;
                button2.ForeColor = Color.LightGreen;
                labelTitle.Text = "Image Downloader";
                button2.Text = "Video ID";
                metroTextBox1.Text = "Insert any image link from the internet";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackgroundImage == null)
            {
                MessageBox.Show("Invalid Image!", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (FolderBrowserDialog saveFileDialog = new FolderBrowserDialog())
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!bCustomLink)
                        pictureBox1.BackgroundImage.Save(saveFileDialog.SelectedPath + "\\" + metroTextBox1.Text + ".jpg", ImageFormat.Jpeg);
                    else pictureBox1.BackgroundImage.Save(saveFileDialog.SelectedPath + "\\" + Path.GetFileName(metroTextBox1.Text), ImageFormat.Jpeg);
                }
            }
        }
    }
}
