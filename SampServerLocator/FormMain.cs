using System;
using System.Drawing;
using System.Drawing.Imaging;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Threading;
using SampQueryApi;
using System.Net;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;

enum eMapStyleTypeSet
{
    MAP_TYPE_REALISTIC = 1,
    MAP_TYPE_GOOGLE = 2
}

//ip providers
//https://ipinfo.io/
//https://ipapi.co/

// free icons https://material.io/resources/icons/?style=baseline
//http://lists.sa-mp.com/0.3.7/internet
//http://lists.sa-mp.com/0.3.7/hosted
//http://monitor.sacnr.com/list/masterlist.txt

namespace SampServerLocator
{
    public partial class FormMain : Form
    {

        [DllImport("user32.dll")]
        private static extern Int32 SystemParametersInfo(UInt32 action, UInt32 sParam, string szImgPath, UInt32 wParam);

        UInt32 WIN_SETWP = 0x14;
        UInt32 WIN_UPDWP = 0x01;
        UInt32 WIN_WPREGULAR = 0x02;

        public FormMain()
        {

            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("Same Process is already running.");
                return;
            }
            else InitializeComponent();

            if (ServicePointManager.Expect100Continue != true)
                ServicePointManager.Expect100Continue = true;
            if (ServicePointManager.SecurityProtocol != SecurityProtocolType.Tls12)
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public string ip_info_provider = "https://ipapi.co/";
        private bool IsImageAdded = false;
        private string get_selected_img_path;
        private string get_selected_img_name;
        private string get_current_address;
        private int map_style;
        private static FormSettings formSettings = new FormSettings();
        private static FormUpdate formUpdate = new FormUpdate();
        /*private string GetPCUserName()
        {
            return Environment.UserName;
        }*/

        private bool IsSAMPDLLPresent()
        {
            string gtapath = getGTAPathFromRegistry();
            string filepath = string.Format("{0}\\samp.dll", gtapath.Remove(gtapath.IndexOf("gta_sa.exe")));

            if (File.Exists(filepath))
                return true;

            return false;
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

        private void OpenUri(string uri)
        {
            Process.Start("explorer", uri);
        }

        private void SaveImageToFile(Image drawImage)
        {
            using (SaveFileDialog dialog = new SaveFileDialog() { Filter = "Images(*.jpg)|*.jpg|Images(*.png)|*.png", ValidateNames = true })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    drawImage.Save(dialog.FileName, dialog.Filter == "Images(*.jpg)" ? ImageFormat.Jpeg : ImageFormat.Png);
                }
            }
        }

        /* private int getCountOfFilesFromDir(string dirpath)
         {
             if (!Directory.Exists(dirpath))
                 return 0;
             else return Directory.GetFiles(dirpath).Length;
         }

         private void readFromFile(string file, string export)
         {
             if (file == null || export == null || new FileInfo(file).Extension != ".txt")
                 return;

             string[] lines = File.ReadAllLines(file);
             // Display the file contents by using a foreach loop.
             foreach (string line in lines)
             {
                 export = line;
             }
         }*/

        //"D" = prints name of the current day
        //"g" = prints date with clock
        private string getCurrentDate(string output_type)
        {
            DateTime dateTime = DateTime.Now;
            return dateTime.ToString(output_type);
        }

        /* private string getCurrentTime()
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
         */
        private int GetPortFromAddress(string addr)
        {
            string getresult = addr.Remove(0, addr.IndexOf(":") + ":".Length);
            return Convert.ToInt32(getresult);
        }

        private string getAddressFromString(string addr)
        {
            string getfinal = addr.Remove(addr.Length - (Convert.ToString(GetPortFromAddress(addr)).Length + 1));
            return getfinal.ToString();
        }

        private string GetWebDataFromURL(string url)
        {
            if (!IsURLHTTP(url))
                return null;

            try
            {
                HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();

                StreamReader responseStream = new StreamReader(objResponse.GetResponseStream());
                string responseRead = responseStream.ReadToEnd();

                responseStream.Close();
                responseStream.Dispose();

                return responseRead;
            }
            catch (Exception errurl)
            {
                MessageBox.Show(errurl.Message, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        private void ConnectToServer(string address, string PlayerName)
        {
            if (IsURLHTTP(address))
            {
                MessageBox.Show("Invalid samp server address!", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address input field cannot be empty", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var getgtapath = getGTAPathFromRegistry();
            var getserveraddr = getAddressFromString(address);
            var getserverport = GetPortFromAddress(address);

            if (PlayerName.Length >= 3 && PlayerName.Length <= 20)
            {
                Process.Start(getgtapath.Remove(getgtapath.IndexOf("gta_sa.exe")) + "samp.exe ", getserveraddr + ":" + getserverport + " -n" + PlayerName);
                if (formSettings.bMinimizeOnConnect == true)
                    WindowState = FormWindowState.Minimized; //after launching set form state to minimized
            }
            else
            {
                MessageBox.Show("Name can't be less than 3 characters or more than 20", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double GetLongitudeFromString(string strLong)
        {
            if (string.IsNullOrEmpty(strLong))
                return Convert.ToDouble(0);

            try
            {
                if (strLong == textBoxInputLongitude.Text)
                {
                    return Convert.ToDouble(strLong.ToString());
                }
                else
                {
                    var longi = strLong;
                    return Convert.ToDouble(longi.Remove(0, longi.IndexOf(": ") + 2));
                }
            }
            catch (Exception errlongi)
            {
                MessageBox.Show(errlongi.Message, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Convert.ToDouble(0);
        }

        private double GetAltitudeFromString(string strAlti)
        {
            if (string.IsNullOrEmpty(strAlti))
                return Convert.ToDouble(0);

            try
            {
                if (strAlti == textBoxInputAltitude.Text)
                {
                    return Convert.ToDouble(strAlti.ToString());
                }
                else
                {
                    var crap = strAlti;
                    return Convert.ToDouble(crap.Remove(0, crap.IndexOf(": ") + 2));
                }
            }
            catch (Exception erralti)
            {
                MessageBox.Show(erralti.Message, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Convert.ToDouble(0);
        }

        private void gMapSetMarketAndLocate(double altitude, double longitude)
        {
            try
            {
                PointLatLng pointLatLng = new PointLatLng(altitude, longitude);
                gMap.Position = pointLatLng;
                GMapMarker gMapMarker = new GMarkerGoogle(pointLatLng, GMarkerGoogleType.red_dot);
                gMapMarker.Size = new Size(25, 25);
                string getsrv = szLabelHostName.Text;
                gMapMarker.ToolTipText = getsrv.Replace("Hostname: ", "Server: ");
                GMapOverlay gMapOverlay = new GMapOverlay("markers");
                gMapOverlay.Markers.Clear();
                gMapOverlay.Markers.Add(gMapMarker);
                gMap.Overlays.Add(gMapOverlay);
            }
            catch (Exception)
            { }
        }

        /* private void CloseGTAWindow()
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
         }*/

        public string getPlayerNameFromRegistry() //+custom name
        {
            try
            {
                if (formSettings.bUseCustomName)
                {
                    if (formSettings.textBox_InputCustomName.Text.Length >= 3 && formSettings.textBox_InputCustomName.Text.Length <= 20)
                    {
                        return formSettings.textBox_InputCustomName.Text;
                    }
                    else
                    {
                        //MessageBox.Show("Name can't be less than 3 characters or more than 20", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return "";
                    }
                }
                else if (!formSettings.bUseCustomName)
                {
                    using (RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\SAMP", RegistryKeyPermissionCheck.Default))
                    {
                        if (key != null)
                        {
                            object name = key.GetValue("PlayerName");
                            if (name != null)
                            {
                                return name as string;
                            }
                        }
                    }
                }
            }
            catch (Exception ereg)
            {
                MessageBox.Show(ereg.Message, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return "";
        }

        private string getGTAPathFromRegistry()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\SAMP", RegistryKeyPermissionCheck.Default))
                {
                    if (key != null)
                    {
                        object path = key.GetValue("gta_sa_exe");
                        if (path != null)
                        {
                            return path as string;
                        }
                    }
                }
            }
            catch (Exception ereg)
            {
                MessageBox.Show(ereg.Message, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return "";
        }

        /*private void GetServerInfoFromQuery(string address, int port)
        {
            var sampQuery = new SampQuery(address, Convert.ToUInt16(port));
            SampServerInfoData data = sampQuery.GetServerInfo();
            SampServerRulesData dataRules = sampQuery.GetServerRules();

            //main info
            szLabelHostName.Text = "Hostname: " + data.HostName;
            szLabelGameMode.Text = "GameMode: " + data.GameMode;
            szLabelLanguage.Text = "Language: " + data.Language;
            szLabelPlayers.Text = "Players: Online - " + Convert.ToString(Convert.ToInt32(data.Players)) + " / Max - " + Convert.ToString(Convert.ToInt32(data.MaxPlayers));
            szPassword.Text = data.Password ? "Status: Locked" : "Status: Unlocked";
            szPing.Text = "Ping: " + Convert.ToString(data.ServerPing);

            //Rules
            szLabelMapName.Text = "Map Name: " + dataRules.MapName;
            szLabelSAMPVersion.Text = "Version: " + dataRules.Version;
            szLabelWeather.Text = "Weather: " + dataRules.Weather;
            //szLabelWorldTime.Text = "World Time: " + dataRules.WorldTime;
            szLagcomp.Text = dataRules.Lagcomp ? "Lagcomp: Enabled" : "Lagcomp: Disabled";
            szWeburl.Text = "Weburl: " + dataRules.Weburl;
        }*/

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelGetZoomLevel.Text = "Zoom: " + metroTrackBar_MapZoom.Value.ToString() + "%";
            gMap.MinZoom = 3;
            gMap.MaxZoom = 100;
            gMap.Zoom = 1;
            gMap.IgnoreMarkerOnMouseWheel = true;
            map_style = (int)eMapStyleTypeSet.MAP_TYPE_REALISTIC;
            gMap.MapProvider = map_style == (int)eMapStyleTypeSet.MAP_TYPE_REALISTIC ? GMapProviders.BingSatelliteMap : gMap.MapProvider = GMapProviders.GoogleMap;
            GMaps.Instance.MemoryCache.Clear();

            string[] images = Directory.GetFiles("C:\\Users\\" + Environment.UserName + "\\Documents\\GTA San Andreas User Files\\SAMP\\screens\\");
            get_selected_img_path = "C:\\Users\\" + Environment.UserName + "\\Documents\\GTA San Andreas User Files\\SAMP\\screens\\";
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Images:");

            for (int images_ = 0; images_ < images.Length; images_++)
            {
                FileInfo fileInfo = new FileInfo(images[images_]);
                if (fileInfo.Extension != ".png" || fileInfo.Extension != ".jpg")
                    dataTable.Rows.Add(fileInfo.Name);
            }
            dataGridView1.DataSource = dataTable;
        }

        private Image rotationimg;
        private void buttonImageRotate_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No image found", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                rotationimg = pictureBox1.Image;
                rotationimg.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = rotationimg;
            }
            catch (Exception errimgp)
            {
                MessageBox.Show(errimgp.Message, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonImageDelete_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No image found", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (File.Exists($"{get_selected_img_path + get_selected_img_name}"))
                    SystemParametersInfo(WIN_SETWP, 0, $"{get_selected_img_path + get_selected_img_name}", WIN_UPDWP | WIN_WPREGULAR);
                else MessageBox.Show($"{get_selected_img_path + get_selected_img_name}" + "\n" + "Such file doesn't exist!", "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception errimgn)
            {
                MessageBox.Show(errimgn.Message, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClearAddress_Click(object sender, EventArgs e)
        {
            if (textBox_Addr.Text != null)
                textBox_Addr.Clear();
        }

        private void buttonClearAltitudeBox_Click(object sender, EventArgs e)
        {
            if (textBoxInputAltitude.Text != null)
                textBoxInputAltitude.Clear();
        }

        private void buttonClearLongitudeBox_Click(object sender, EventArgs e)
        {
            if (textBoxInputLongitude.Text != null)
                textBoxInputLongitude.Clear();
        }

        private void buttonNextMapStyle_Click(object sender, EventArgs e)
        {
            if (map_style < 1)
                map_style = 1;
            else map_style--;

            gMap.MapProvider = map_style == (int)eMapStyleTypeSet.MAP_TYPE_REALISTIC ? GMapProviders.BingSatelliteMap : gMap.MapProvider = GMapProviders.GoogleMap;
        }

        private void buttonTakePicture_Click(object sender, EventArgs e)
        {
            if (gMap.Visible == false)
            {
                MessageBox.Show("Map must be visible.", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveImageToFile(gMap.ToImage());
        }

        private void buttonDelAllMarkers_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (GMapOverlay mapMarker in gMap.Overlays)
                {
                    mapMarker.Markers.Clear();
                }
                gMap.Refresh();
            }
            catch { }
        }

        private void gMapAddMarkerAtPos(double alti, double longit)
        {
            try
            {
                PointLatLng pointLatLng = new PointLatLng(alti, longit);
                gMap.Position = pointLatLng;
                GMapMarker gMapMarker = new GMarkerGoogle(pointLatLng, GMarkerGoogleType.orange_dot);
                gMapMarker.Size = new Size(25, 25);
                gMapMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                gMapMarker.ToolTipText = "Latitude: " + Convert.ToString(alti)
                    + "\n"
                    + "Longitude: " + Convert.ToString(longit);
                GMapOverlay mapOverlay = new GMapOverlay();
                mapOverlay.Markers.Add(gMapMarker);
                gMap.Overlays.Add(mapOverlay);
            }
            catch (Exception errmark)
            { MessageBox.Show(errmark.Message, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonAddMarker_Click(object sender, EventArgs e)
        {
            gMapAddMarkerAtPos(gMap.Position.Lat, gMap.Position.Lng);
        }

        private void buttonSaveGeoData_Click(object sender, EventArgs e)
        {
            if (szLabelGeoLatitude.Text == "Latitude:" ||
                szLabelGeoLongitude.Text == "Longitude:" ||
                szLabelGeoLocationName.Text == "City:")
            {
                MessageBox.Show("Click on button 'Refresh' near address input\nto receive and save\ngeo location information to file", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SaveFileDialog dialog = new SaveFileDialog() { Filter = "Text Files(*.txt)|*.txt|Settings Files(*.ini)|*.ini", ValidateNames = true })
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter file = new StreamWriter(dialog.FileName, true))
                        {
                            file.WriteLine("[" + getCurrentDate("g") + "]");
                            file.WriteLine(szLabelHostName.Text);
                            file.WriteLine(szLabelGeoLatitude.Text);
                            file.WriteLine(szLabelGeoLongitude.Text);
                            file.WriteLine(szLabelGeoLocationName.Text);
                            file.WriteLine(" ");

                            MessageBox.Show("Saved geo location from server " + szLabelHostName.Text, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception errs)
            {
                MessageBox.Show(errs.Message, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLocateServer_Click(object sender, EventArgs e)
        {
            if (szLabelGeoLatitude.Text == "Latitude:")
            {
                MessageBox.Show("Click on button 'Refresh' and wait for IP data to load from server\nThis may take few minutes depending on your internet speed.", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var alti = GetAltitudeFromString(szLabelGeoLatitude.Text);
            var lng = GetLongitudeFromString(szLabelGeoLongitude.Text);

            //MessageBox.Show(alti + "\n" + lng);
            gMapSetMarketAndLocate(alti, lng);
            gMap.Refresh();
        }

        private void szLabelGeoLongitude_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Addr.Text))
            {
                MessageBox.Show("Address input cannot be empty", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (szLabelGeoLongitude.Text == "Longitude:")
            {
                MessageBox.Show("Nothing to copy.", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            textBoxInputLongitude.Text = GetLongitudeFromString(szLabelGeoLongitude.Text).ToString();
            Clipboard.SetText(GetLongitudeFromString(szLabelGeoLongitude.Text).ToString());
        }

        private void szLabelGeoAltitude_Click(object sender, EventArgs e)
        {
            if (szLabelGeoLatitude.Text == "Latitude:")
            {
                MessageBox.Show("Nothing to copy.", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            textBoxInputAltitude.Text = GetAltitudeFromString(szLabelGeoLatitude.Text).ToString();
            Clipboard.SetText(GetAltitudeFromString(szLabelGeoLatitude.Text).ToString());
        }

        private bool IsCommandsEntered(string where, string getCmd)
        {
            if (string.IsNullOrEmpty(where) || string.IsNullOrEmpty(getCmd))
                return false;

            foreach (char c in where)
            {
                if (c.ToString() == "/")
                {
                    if (where == getCmd)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void textBox_SearchServer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;

            if (string.IsNullOrEmpty(textBox_InputCMD.Text))
            {
                DialogResult resmsg = MessageBox.Show("There's no any command to be executed.\nWould you like to see all commands ?", "SA:MP Server Locator", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resmsg == DialogResult.Yes)
                {
                    MessageBox.Show("Commands:\n"
                            + "/cmds - view all commands\n"
                            + "/time - check current time\n"
                            + "/time=day - shows the name of current day and month\n"
                            + "/copyaddr - copy address from address input box\n"
                            + "/map=memfree - erase used memory by map locator\n"
                            + "/map=pic - take a picture of the map\n"
                            + "/map=refresh\n"
                            + "/image=convert.png - convert selected image to .png format\n"
                            + "/image=convert.jpg - convert selected image to .jpg format\n"
                            + "/locate - enable location coordinates input\n"
                            + "/locate=has_coord - search for location\n"
                            + "/server=copyinfo - copy server info\n"
                            + "/server=website - open server website\n"
                            + "/game=path - copy gta path to clipboard\n"
                            + "/game=pname - copy your player name in game");
                }
                else if(resmsg == DialogResult.No)
                return;

                return;
            }

            if (IsCommandsEntered(textBox_InputCMD.Text, "/time"))
            {
                MessageBox.Show("Current time: " + getCurrentDate("g"));
            }
            else if (IsCommandsEntered(textBox_InputCMD.Text, "/time=day"))
            {
                MessageBox.Show("Current time: " + getCurrentDate("D"));
            }
            else if (IsCommandsEntered(textBox_InputCMD.Text, "/cmds"))
            {
                MessageBox.Show("Commands:\n"
                    + "/cmds - view all commands\n"
                    + "/time - check current time\n"
                    + "/time=day - shows the name of current day and month\n"
                    + "/copyaddr - copy address from address input box\n"
                    + "/map=memfree - erase used memory by map locator\n"
                    + "/map=pic - take a picture of the map\n"
                    + "/map=refresh\n"
                    + "/image=convert.png - convert selected image to .png format\n"
                    + "/image=convert.jpg - convert selected image to .jpg format\n"
                    + "/locate - enable location coordinates input\n"
                    + "/locate=has_coord - search for location\n"
                    + "/server=copyinfo - copy server info\n"
                    + "/server=website - open server website\n"
                    + "/game=path - copy gta path to clipboard\n"
                    + "/game=pname - copy your player name in game");
            }
            else if (IsCommandsEntered(textBox_InputCMD.Text, "/image=convert.jpg"))
            {
                if (get_selected_img_name.Contains(".jpg"))
                {
                    MessageBox.Show("This image is already in .jpg format\nto convert it to .png format use /image=convert.png", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                pictureBox1.Image.Save("C:\\Users\\" + Environment.UserName + "\\Desktop\\" + get_selected_img_name.Replace(".png", ".jpg"), ImageFormat.Png);
                MessageBox.Show("Saved as: " + get_selected_img_name.Replace(".png", ".jpg") + " at Desktop", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (IsCommandsEntered(textBox_InputCMD.Text, "/image=convert.png"))
            {
                if (get_selected_img_name.Contains(".png"))
                {
                    MessageBox.Show("This image is already in .png format\nto convert it to .jpg format use /image=convert.jpg", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                pictureBox1.Image.Save("C:\\Users\\" + Environment.UserName + "\\Desktop\\" + get_selected_img_name.Replace(".jpg", ".png"), ImageFormat.Png);
                MessageBox.Show("Saved as: " + get_selected_img_name.Replace(".jpg", ".png") + " at Desktop", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (IsCommandsEntered(textBox_InputCMD.Text, "/map=refresh"))
            {
                gMap.Refresh();
            }
            else if (IsCommandsEntered(textBox_InputCMD.Text, "/map=pic"))
            {
                SaveImageToFile(gMap.ToImage());
            }
            else if (IsCommandsEntered(textBox_InputCMD.Text, "/game=path"))
            {
                string getpath = getGTAPathFromRegistry();
                Clipboard.SetText(getpath.Remove(getpath.IndexOf("gta_sa.exe")));
                MessageBox.Show("Game path copied!" + "\n" + getpath);
            }
            else if (IsCommandsEntered(textBox_InputCMD.Text, "/game=pname"))
            {
                string nameget = getPlayerNameFromRegistry();

                if (nameget.Length == 0)
                {
                    MessageBox.Show("Name not valid, its too short or doesn't exist.", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (nameget.Length >= 3 && nameget.Length <= 20)
                {
                    Clipboard.SetText(nameget);
                    MessageBox.Show("Name copied!" + "\n" + nameget);
                }
                else
                {
                    MessageBox.Show("Name not valid, its either too short or too long.", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (IsCommandsEntered(textBox_InputCMD.Text, "/server=website"))
            {
                if (szWeburl.Text == "Weburl:")
                {
                    MessageBox.Show("Click on button Refresh to receive server data.", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    string url = szWeburl.Text;
                    OpenUri(url.Replace("Weburl: ", " "));
                }
                catch (Exception errurl)
                {
                    MessageBox.Show(errurl.Message, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (IsCommandsEntered(textBox_InputCMD.Text, "/server=copyinfo"))
            {
                if (textBox_Addr.Text.Length == 0)
                {
                    MessageBox.Show("Address input is empty...\ntry again", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Addr.Text = "51.254.85.134:7776";
                    return;
                }

                if (szLabelHostName.Text == "HostName:")
                {
                    MessageBox.Show("Click on button 'Refresh' to get server info.", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Clipboard.SetText("Address: " + textBox_Addr.Text + "\n"
                    + szLabelHostName.Text);
                MessageBox.Show("Copied info from " + szLabelHostName.Text.Replace("HostName: ", " ") + "\n" + "successfully!");
            }
            else if (IsCommandsEntered(textBox_InputCMD.Text, "/copyaddr"))
            {
                if (textBox_Addr.Text.Length == 0)
                {
                    MessageBox.Show("Address input is empty...\ntry again.", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_Addr.Text = "51.254.85.134:7776";
                    return;
                }

                Clipboard.SetText(textBox_Addr.Text);
                MessageBox.Show("Address copied!");
            }
            else if (IsCommandsEntered(textBox_InputCMD.Text, "/map=memfree"))
            {
                GMaps.Instance.MemoryCache.Clear();
                MessageBox.Show("Map memory cleared.");
            }
            else if (IsCommandsEntered(textBox_InputCMD.Text, "/locate=has_coord"))
            {
                if (textBoxInputAltitude.Text.Length == 0 || textBoxInputLongitude.Text.Length == 0)
                {
                    MessageBox.Show("Latitude & Longitude input cannot be empty", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (textBoxInputAltitude.Text == "Latitude:" || textBoxInputLongitude.Text == "Longitude:")
                {
                    MessageBox.Show("Latitude & Longitude input must contain double type", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //double alti = GetAltitudeFromString(textBoxInputAltitude.Text);
                //double longi = GetLongitudeFromString(textBoxInputLongitude.Text);
                gMapSetMarketAndLocate(Convert.ToDouble(textBoxInputAltitude.Text), Convert.ToDouble(textBoxInputLongitude.Text));
            }
            else
            {
                MessageBox.Show("Entered text cannot be recognized as command\nplease use '/' as first character on your text\nCommand not valid.", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void ShowMyIPInfo()
        {
            try
            {
                if (ip_info_provider == "https://ipinfo.io/")
                {
                    string ip = GetWebDataFromURL(ip_info_provider + "ip");
                    string slocation = GetWebDataFromURL(ip_info_provider + "loc");
                    string city = GetWebDataFromURL(ip_info_provider + "city");

                    string getaltitude = slocation;
                    string getlongi = slocation;
                    szLabelGeoLongitude.Text = "Longitude: " + getlongi.Remove(0, getlongi.IndexOf(",") + 1);
                    szLabelGeoLatitude.Text = "Latitude: " + getaltitude.Remove(getaltitude.IndexOf(","), getlongi.Remove(0, getlongi.IndexOf(",") + 1).Length);
                    szLabelGeoLocationName.Text = "Location: " + city.ToString();

                    textBoxInputAltitude.Text = getaltitude.Remove(getaltitude.IndexOf(","), getlongi.Remove(0, getlongi.IndexOf(",") + 1).Length);
                    textBoxInputLongitude.Text = getlongi.Remove(0, getlongi.IndexOf(",") + 1);

                    MessageBox.Show("Your Address Info:" + "\n"
                        + "IP: " + ip.ToString()
                        + "Coordinates: " + slocation.ToString()
                        + "City: " + city.ToString());

                }
                else
                {
                    string ip = GetWebDataFromURL(ip_info_provider + "ip");
                    string glat = GetWebDataFromURL(ip_info_provider + "latitude");
                    string glong = GetWebDataFromURL(ip_info_provider + "longitude");
                    string city = GetWebDataFromURL(ip_info_provider + "city");


                    szLabelGeoLongitude.Text = "Longitude: " + glong;
                    szLabelGeoLatitude.Text = "Latitude: " + glat;
                    szLabelGeoLocationName.Text = "Location: " + city;

                    textBoxInputAltitude.Text = glat;
                    textBoxInputLongitude.Text = glong;

                    MessageBox.Show("Your Address Info:" + "\n"
                        + "IP: " + ip.ToString() + "\n"
                        + "Latitude: " + glat + "\n" + "Longitude: " + glong + "\n"
                        + "City: " + city);

                }
            }
            catch (Exception errhost)
            {
                MessageBox.Show(errhost.Message, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*private void getIPInfoFromAddress(string address)
          {
              try
              {
                  string city = GetWebDataFromURL("https://ipinfo.io/" + address + "/city");
                  string locatione = GetWebDataFromURL("https://ipinfo.io/" + address + "/loc");
                  string country = GetWebDataFromURL("https://ipinfo.io/" + address + "/country");
                  string timezone = GetWebDataFromURL("https://ipinfo.io/" + address + "/timezone");

                  if (locatione != null)
                  {
                      MessageBox.Show("Server: " + szLabelHostName.Text + "\nInformation:\n"
                          + "Coordinate: " + locatione.ToString()
                          + "City: " + city.ToString()
                          + "Country: " + country.ToString()
                          + "Timezone: " + timezone.ToString());
                  }
              }
              catch (Exception errhost)
              {
                  MessageBox.Show(errhost.Message, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
          }*/

        private void buttonIPInfo_Click(object sender, EventArgs e)
        {

                    ShowMyIPInfo();

           // thrr.Start();
        }
        #region GUIMovement
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

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (formSettings.Visible)
                formSettings.Visible = false;

            Application.Exit();
        }

        private void metroTrackBar_MapZoom_ValueChanged(object sender, EventArgs e)
        {
            labelGetZoomLevel.Text = "Zoom: " + metroTrackBar_MapZoom.Value.ToString() + "%";
            gMap.Zoom = metroTrackBar_MapZoom.Value;
        }

        private Thread thr;
        void UpdateServerInfo()
        {
            try
            {
                if (!IsURLHTTP(textBox_Addr.Text))
                {
                    string getaddr = getAddressFromString(textBox_Addr.Text);
                    int getport = GetPortFromAddress(textBox_Addr.Text);

                    if (formSettings.bRefreshServerQuery == true)
                    {
                        var sampQuery = new SampQuery(getaddr, Convert.ToUInt16(getport));
                        SampServerInfoData data = sampQuery.GetServerInfo();
                        SampServerRulesData dataRules = sampQuery.GetServerRules();

                        //main info
                        szLabelHostName.Invoke((MethodInvoker)(() => szLabelHostName.Text = "Hostname: " + data.HostName));
                        szLabelGameMode.Invoke((MethodInvoker)(() => szLabelGameMode.Text = "GameMode: " + data.GameMode));
                        szLabelLanguage.Invoke((MethodInvoker)(() => szLabelLanguage.Text = "Language: " + data.Language));
                        szLabelPlayers.Invoke((MethodInvoker)(() => szLabelPlayers.Text = "Players: Online - " + Convert.ToString(Convert.ToInt32(data.Players)) + " / Max - " + Convert.ToString(Convert.ToInt32(data.MaxPlayers))));
                        szPassword.Invoke((MethodInvoker)(() => szPassword.Text = data.Password ? "Status: Locked" : "Status: Unlocked"));
                        szPing.Invoke((MethodInvoker)(() => szPing.Text = "Ping: " + Convert.ToString(data.ServerPing)));

                        szLabelMapName.Invoke((MethodInvoker)(() => szLabelMapName.Text = "Map Name: " + dataRules.MapName));
                        szLabelSAMPVersion.Invoke((MethodInvoker)(() => szLabelSAMPVersion.Text = "Version: " + dataRules.Version));
                        szLabelWeather.Invoke((MethodInvoker)(() => szLabelWeather.Text = "Weather: " + dataRules.Weather));
                        szLagcomp.Invoke((MethodInvoker)(() => szLagcomp.Text = dataRules.Lagcomp ? "Lagcomp: Enabled" : "Lagcomp: Disabled"));
                        szWeburl.Invoke((MethodInvoker)(() => szWeburl.Text = "Weburl: " + dataRules.Weburl));
                    }

                    if (formSettings.bRefreshIPInfo == true)
                    {
                        if (get_current_address == textBox_Addr.Text)
                        {
                                string city = GetWebDataFromURL(ip_info_provider + getaddr + "/city");
                                szLabelGeoLocationName.Invoke((MethodInvoker)(() => szLabelGeoLocationName.Text = "City: " + city));

                                if (ip_info_provider == "https://ipapi.co/")
                                {
                                    string getalti = GetWebDataFromURL(ip_info_provider + getaddr + "/latitude");
                                    szLabelGeoLatitude.Invoke((MethodInvoker)(() => szLabelGeoLatitude.Text = "Latitude: " + getalti));
                                    string getlongi = GetWebDataFromURL(ip_info_provider + getaddr + "/longitude");
                                    szLabelGeoLongitude.Invoke((MethodInvoker)(() => szLabelGeoLongitude.Text = "Longitude: " + getlongi));
                                }
                                else if (ip_info_provider == "https://ipinfo.io/")
                                {
                                    string getloc = null;
                                    getloc = GetWebDataFromURL(ip_info_provider + getaddr + "/loc");

                                    string getlong = getloc.Remove(0, getloc.IndexOf(",") + 1);
                                    string getlat = "";

                                    szLabelGeoLatitude.Invoke((MethodInvoker)(() => szLabelGeoLatitude.Text = "Latitude: " + getlat.Insert(0, getloc.Remove(getloc.IndexOf(",")))));
                                    szLabelGeoLongitude.Invoke((MethodInvoker)(() => szLabelGeoLongitude.Text = "Longitude: " + getlong));
                                }

                                string timezone = GetWebDataFromURL(ip_info_provider + getaddr + "/timezone");
                                labelTimeZone.Invoke((MethodInvoker)(() => labelTimeZone.Text = "Timezone: " + timezone));

                        }
                    }
                }
                else
                {
                    if (textBox_Addr.Text != "51.254.85.134:7776")
                    {
                        textBox_Addr.Text = "51.254.85.134:7776";
                        if (get_current_address != textBox_Addr.Text)
                            get_current_address = textBox_Addr.Text;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel_info_MouseHover(object sender, EventArgs e)
        {
            /*if (string.IsNullOrEmpty(textBox_Addr.Text))
            {
                MessageBox.Show("Server update failed\nAddress input cannot be empty", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                thr = new Thread(new ThreadStart(UpdateServerInfo));
                if (!thr.IsAlive)
                    thr.Start();
                else
                {
                    thr.Abort();
                    thr.Start();
                }

                if (get_current_address != textBox_Addr.Text)
                {
                    get_current_address = textBox_Addr.Text;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void buttonLocateCustom_Click(object sender, EventArgs e)
        {
            if (textBoxInputAltitude.Text == "Latitude" || textBoxInputLongitude.Text == "Longitude")
            {
                MessageBox.Show("This button uses parameter from input boxes\nLatitude & Longitude!", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var alti = GetAltitudeFromString(textBoxInputAltitude.Text);
            var lng = GetLongitudeFromString(textBoxInputLongitude.Text);
            gMapSetMarketAndLocate(alti, lng);
        }

        private void buttonCopyServerInfo_Click(object sender, EventArgs e)
        {
            if (textBox_Addr.Text.Length != 0)
            {
                Clipboard.SetText(textBox_Addr.Text, TextDataFormat.UnicodeText);
                MessageBox.Show("Address copied!", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Nothing to copy.", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonLoadImageDialog_Click(object sender, EventArgs e)
        {
            if (buttonBigCameraImage.Visible)
                buttonBigCameraImage.Visible = false;

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Images(*.jpg)|*.jpg|Images(*.png)|*.png|All Files(*.*)|*.*", ValidateNames = true, Multiselect = false })
            {
                try
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        ofd.InitialDirectory = "C:\\Users\\" + Environment.UserName + "\\Documents\\GTA San Andreas User Files\\SAMP\\screens\\";
                        Bitmap bitmap = new Bitmap(ofd.FileName);
                        FileInfo file = new FileInfo(ofd.FileName);
                        if (get_selected_img_name != file.Name)
                            get_selected_img_name = file.Name;
                        var pic = pictureBox1.Image;
                        pictureBox1.Image = bitmap;
                        labelImgName.Text = "Name: " + file.Name;
                        toolTip1.SetToolTip(labelImgName, file.Name);
                        labelImgName.Location = new Point(panelForImagesList.Width - labelImgName.Text.Length * 6, 7);
                        labelImgResolution.Text = "W: " + pictureBox1.Image.Size.Width.ToString() + " H: " + pictureBox1.Image.Size.Height.ToString();
                        if (get_selected_img_path != file.DirectoryName)
                        {
                            get_selected_img_path = file.DirectoryName + "\\";
                            IsImageAdded = false;
                        }
                        if (!IsImageAdded)
                        {
                            string[] images = Directory.GetFiles(get_selected_img_path);
                            DataTable dataTable = new DataTable();
                            dataTable.Columns.Add("Images:");

                            for (int images_ = 0; images_ < images.Length; images_++)
                            {
                                FileInfo fileInfo = new FileInfo(images[images_]);
                                if (fileInfo.Extension == ".png" || fileInfo.Extension == ".jpg")
                                    dataTable.Rows.Add(fileInfo.Name);
                            }
                            dataGridView1.DataSource = dataTable;
                            IsImageAdded = true;
                        }
                        pic?.Dispose();
                    }
                }
                catch (Exception errimgload)
                {
                    MessageBox.Show(errimgload.Message, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonShowSettings_Click(object sender, EventArgs e)
        {
            if (formSettings.Visible != true)
                formSettings.Visible = true;
            else formSettings.Visible = false;
        }

        private void buttonConnectToServer_Click(object sender, EventArgs e)
        {
            if (textBox_Addr.Text.Length == 0)
            {
                MessageBox.Show("Address input must contain some server address", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsURLHTTP(textBox_Addr.Text)) //is http
            {
                MessageBox.Show("This type of address cannot be used!", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (formSettings.textBox_InputCustomName.Text == "Input new name")
            {
                MessageBox.Show("Detected invalid parameter.\nEdit your custom name from settings", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ConnectToServer(textBox_Addr.Text, getPlayerNameFromRegistry());
        }

        private static FormServersList ServersList = new FormServersList();
        private void buttonServersListOpen_Click(object sender, EventArgs e)
        {
            if (ServersList.Visible == false)
                ServersList.Visible = true;
            else ServersList.Visible = false;
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            if (dataGridView1.Size.Width != 10)
                dataGridView1.Size = new Size(10, 321);
        }

        private void dataGridView1_MouseHover(object sender, EventArgs e)
        {
            if (dataGridView1.Size.Width != 150)
                dataGridView1.Size = new Size(150, 321);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (buttonBigCameraImage.Visible)
                buttonBigCameraImage.Visible = false;

            string names = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FileInfo fileInfo = new FileInfo(names);
            if (fileInfo.Extension != ".png" && fileInfo.Extension != ".jpg")
            {
                MessageBox.Show("Image preview system only support images which are .png or in .jpeg format", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (File.Exists(get_selected_img_path + names) == false)
            {
                MessageBox.Show("Selected file does not exist anymore!", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (get_selected_img_name != names)
                get_selected_img_name = names;

            Image img;
            img = Image.FromFile(get_selected_img_path + names);
            pictureBox1.Image = img;
            labelImgName.Text = "Name: " + names;
            toolTip1.SetToolTip(labelImgName, names);
            labelImgResolution.Text = "W: " + pictureBox1.Image.Size.Width.ToString() + " H: " + pictureBox1.Image.Size.Height.ToString();
        }

        private void buttonRotateImg_MouseEnter(object sender, EventArgs e)
        {
            if (buttonRotateImg.Location != new Point(0, 113))
                buttonRotateImg.Location = new Point(0, 113);
        }

        private void buttonRotateImg_MouseLeave(object sender, EventArgs e)
        {
            if (buttonRotateImg.Location != new Point(-15, 113))
                buttonRotateImg.Location = new Point(-15, 113);
        }

        private void buttonDeleteImg_MouseEnter(object sender, EventArgs e)
        {
            if (buttonWallpaperImg.Location != new Point(0, 196))
                buttonWallpaperImg.Location = new Point(0, 196);
        }

        private void buttonDeleteImg_MouseLeave(object sender, EventArgs e)
        {
            if (buttonWallpaperImg.Location != new Point(-15, 196))
                buttonWallpaperImg.Location = new Point(-15, 196);
        }

        private void buttonCreditsOpen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By: _=Gigant=_\nThanks to Mavi_ for C# SampQuery", "Software Development", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Addr.Text))
            {
                MessageBox.Show("Server update failed\nAddress input cannot be empty", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                thr = new Thread(new ThreadStart(UpdateServerInfo));
                if (!thr.IsAlive)
                    thr.Start();
                else
                {
                    thr.Abort();
                    thr.Start();
                }

                if (get_current_address != textBox_Addr.Text)
                    get_current_address = textBox_Addr.Text;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonHelpMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help menu is not included in this version.");
        }

        private void buttonCheckUpdates_Click(object sender, EventArgs e)
        {

            if (formUpdate.Visible == false)
                formUpdate.Visible = true;
            else formUpdate.Visible = false;
        }

        private static FormYoutube_Thumbnail_Downloader formYoutube = new FormYoutube_Thumbnail_Downloader();
        private void buttonYoutube_Click(object sender, EventArgs e)
        {
            if (formYoutube.Visible)
                formYoutube.Visible = false;
            else formYoutube.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e) //open img folder and select if img still exists
        {
            if(pictureBox1.Image == null)
            {
                MessageBox.Show("Invalid Image!", "SA:MP Server Locator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (File.Exists(get_selected_img_path + get_selected_img_name) == false)
            {
                DialogResult dialogResult = MessageBox.Show("Image with this name couldn't be found\nPress OK to open path only.", "SA:MP Server Locator", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                    Process.Start("explorer.exe", get_selected_img_path);
            }
            else Process.Start("explorer.exe", "/select, " + (get_selected_img_path + get_selected_img_name));
        }
    }
}
