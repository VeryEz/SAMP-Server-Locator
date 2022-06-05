using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace SampServerLocator
{
    public partial class FormServersList : Form
    {
        public FormServersList()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Files(*.txt)|*.txt", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        ofd.InitialDirectory = "C:\\Users\\" + Environment.UserName + "\\Desktop";
                        string[] lines = File.ReadAllLines(ofd.FileName);
                        richTextBox1.Lines = lines;
                    }
                }
            }
            catch (Exception erraddlist)
            {
                MessageBox.Show(erraddlist.Message, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
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
    }
}
