using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS_Plugin_Installer
{
    public partial class frmMain : Form
    {
        private bool bMessageWasShown = false;
        private Links lDownloadLinks;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CheckPlugins();
        }

        private void EnableButtons(bool IsEnabled)
        {
            btnOBSWS.Enabled = IsEnabled;
            btnMoveTransition.Enabled = IsEnabled;
            btnSourceCopy.Enabled = IsEnabled;
            btnFreeze.Enabled = IsEnabled;
            btnReplay.Enabled = IsEnabled;
            btnStreamFX.Enabled = IsEnabled;
        }

        private void txtOBSPath_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtOBSPath.Text))
            {
                EnableButtons(false);
            }
            else
            {
                EnableButtons(true);
            }
            CheckPlugins();
        }

        private void IsInstalled (PictureBox pb, bool IsInstalled)
        {
            if (IsInstalled) pb.Image = ilInstalled.Images[0];
            else pb.Image = ilInstalled.Images[1];
        }

        private static void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }

        private void CloseOBSMessage()
        {
            if (bMessageWasShown == false)
            {
                MessageBox.Show("Please make sure that your OBS is closed before continuing with the installation of the plugins!");
                bMessageWasShown = true;
            }
        }

        private void btnSelectOBSPath_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.Title = @"Please select your OBS64.exe / OBS32.exe file. By default it's in: C:\Program Files\obs-studio\bin\64bit";
                f.Filter = "OBS|obs*.exe";

                if (f.ShowDialog() == DialogResult.OK)
                {
                    txtOBSPath.Text = f.FileName.Replace(@"bin\64bit\obs64.exe", "").Replace(@"bin\32bit\obs32.exe", "");
                    CheckPlugins();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        #region "Load / Save Stuff"
        private void frmMain_Load(object sender, EventArgs e)
        {
            txtOBSPath.Text = Properties.Settings.Default.OBSPath;

            WebRequest request = WebRequest.Create("https://raw.githubusercontent.com/BeyondStreaming/OBS_Plugin_Installer/master/OBS_Plugin_Installer/OBSPlugins.txt");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            lDownloadLinks = JsonConvert.DeserializeObject<Links>(responseFromServer);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.OBSPath = txtOBSPath.Text;
            Properties.Settings.Default.Save();
        }
        #endregion
        private void CheckPlugins()
        {
            if (string.IsNullOrEmpty(txtOBSPath.Text)) return;
            if (!Directory.Exists(txtOBSPath.Text)) return;

            //OBSWS 4.9.1
            if (File.Exists(txtOBSPath.Text + @"obs-plugins\64bit\obs-websocket.dll") || File.Exists(txtOBSPath.Text + @"obs-plugins\32bit\obs-websocket.dll") || File.Exists(txtOBSPath.Text + @"obs-plugins\64bit\obs-websocket-compat.dll") || File.Exists(txtOBSPath.Text + @"obs-plugins\32bit\obs-websocket-compat.dll"))
            {
                IsInstalled(pbOBSWS, true);
            }
            else
            {
                IsInstalled(pbOBSWS, false);
            }

            //Move Transition
            if (File.Exists(txtOBSPath.Text + @"obs-plugins\64bit\move-transition.dll") || File.Exists(txtOBSPath.Text + @"obs-plugins\32bit\move-transition.dll"))
            {
                IsInstalled(pbMoveTransition, true);
            }
            else
            {
                IsInstalled(pbMoveTransition, false);
            }

            //Source Copy
            if (File.Exists(txtOBSPath.Text + @"obs-plugins\64bit\source-copy.dll") || File.Exists(txtOBSPath.Text + @"obs-plugins\32bit\source-copy.dll"))
            {
                IsInstalled(pbSourceCopy, true);
            }
            else
            {
                IsInstalled(pbSourceCopy, false);
            }

            //Freeze Filter
            if (File.Exists(txtOBSPath.Text + @"obs-plugins\64bit\freeze-filter.dll") || File.Exists(txtOBSPath.Text + @"obs -plugins\32bit\freeze-filter.dll"))
            {
                IsInstalled(pbFreeze, true);
            }
            else
            {
                IsInstalled(pbFreeze, false);
            }

            //Freeze Filter
            if (File.Exists(txtOBSPath.Text + @"obs-plugins\64bit\freeze-filter.dll") || File.Exists(txtOBSPath.Text + @"obs -plugins\32bit\freeze-filter.dll"))
            {
                IsInstalled(pbFreeze, true);
            }
            else
            {
                IsInstalled(pbFreeze, false);
            }

            //Replay Source
            if (File.Exists(txtOBSPath.Text + @"obs-plugins\64bit\replay-source.dll") || File.Exists(txtOBSPath.Text + @"obs -plugins\32bit\replay-source.dll"))
            {
                IsInstalled(pbReplay, true);
            }
            else
            {
                IsInstalled(pbReplay, false);
            }

            //StreamFX
            if (File.Exists(txtOBSPath.Text + @"obs-plugins\64bit\StreamFX.dll") || File.Exists(txtOBSPath.Text + @"obs-plugins\32bit\StreamFX.dll"))
            {
                IsInstalled(pbStreamFX, true);
            }
            else
            {
                IsInstalled(pbStreamFX, false);
            }
        }

        private void btnOBSWS_Click(object sender, EventArgs e)
        {
            CloseOBSMessage();
            Process.Start(lDownloadLinks.OBSWS);

            MessageBox.Show("Please wait until the download has finished, then press \"OK\" in this message box and select the downloaded ZIP file in the next step.");

            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Please select your OBS Websocket ZIP file";
            of.Filter = "OBS Websocket|obs*websocket*.zip";

            if (of.ShowDialog() == DialogResult.OK)
            {
                DoZipInstallation(of);

                if (File.Exists(txtOBSPath.Text + @"obs-plugins\64bit\obs-websocket.dll") || File.Exists(txtOBSPath.Text + @"obs-plugins\32bit\obs-websocket.dll") || File.Exists(txtOBSPath.Text + @"obs-plugins\64bit\obs-websocket-compat.dll") || File.Exists(txtOBSPath.Text + @"obs-plugins\32bit\obs-websocket-compat.dll"))
                {
                    MessageBox.Show("The installation of OBSWS 4.9.1 was completed successfully.");
                }
                else
                {
                    MessageBox.Show("Unfortunately there was an error with the installation of OBSWS 4.9.1, please try it again.");
                }
            }
        }

        private void btnMoveTransition_Click(object sender, EventArgs e)
        {
            CloseOBSMessage();
            Process.Start(lDownloadLinks.MoveTransition);

            MessageBox.Show("Please wait until the download has finished, then press \"OK\" in this message box and select the downloaded ZIP file in the next step.");

            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Please select your Move Transition ZIP file";
            of.Filter = "Move Transition|move-transition*.zip";

            if (of.ShowDialog() == DialogResult.OK)
            {
                DoZipInstallation(of);

                if (File.Exists(txtOBSPath.Text + @"obs-plugins\64bit\move-transition.dll") || File.Exists(txtOBSPath.Text + @"obs-plugins\32bit\move-transition.dll"))
                {
                    MessageBox.Show("The installation of the Move Transition Plugin was completed successfully.");
                }
                else
                {
                    MessageBox.Show("Unfortunately there was an error with the installation of the Move Transition plugin, please try it again.");
                }
            }
        }

        private void btnSourceCopy_Click(object sender, EventArgs e)
        {
            CloseOBSMessage();
            Process.Start(lDownloadLinks.SourceCopy);

            MessageBox.Show("Please wait until the download has finished, then press \"OK\" in this message box and select the downloaded ZIP file in the next step.");

            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Please select your Source Copy ZIP file";
            of.Filter = "Source Copy|source-copy*.zip";

            if (of.ShowDialog() == DialogResult.OK)
            {
                DoZipInstallation(of);

                if (File.Exists(txtOBSPath.Text + @"obs-plugins\64bit\source-copy.dll") || File.Exists(txtOBSPath.Text + @"obs-plugins\32bit\source-copy.dll"))
                {
                    MessageBox.Show("The installation of the Source Copy Plugin was completed successfully.");
                }
                else
                {
                    MessageBox.Show("Unfortunately there was an error with the installation of the Source Copy plugin, please try it again.");
                }
            }
        }

        private void btnFreeze_Click(object sender, EventArgs e)
        {
            CloseOBSMessage();
            Process.Start(lDownloadLinks.Freeze);

            MessageBox.Show("Please wait until the download has finished, then press \"OK\" in this message box and select the downloaded ZIP file in the next step.");

            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Please select your Freeze Filter ZIP file";
            of.Filter = "Freeze Filter|freeze-filter*.zip";

            if (of.ShowDialog() == DialogResult.OK)
            {
                DoZipInstallation(of);

                if (File.Exists(txtOBSPath.Text + @"obs-plugins\64bit\freeze-filter.dll") || File.Exists(txtOBSPath.Text + @"obs -plugins\32bit\freeze-filter.dll"))
                {
                    MessageBox.Show("The installation of the Freeze Filter Plugin was completed successfully.");
                }
                else
                {
                    MessageBox.Show("Unfortunately there was an error with the installation of the Freeze Filter plugin, please try it again.");
                }
            }
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            CloseOBSMessage();
            Process.Start(lDownloadLinks.Replay);

            MessageBox.Show("Please wait until the download has finished, then press \"OK\" in this message box and select the downloaded ZIP file in the next step.");

            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Please select your Replay Source ZIP file";
            of.Filter = "Replay Source|replay-source*.zip";

            if (of.ShowDialog() == DialogResult.OK)
            {
                DoZipInstallation(of);

                if (File.Exists(txtOBSPath.Text + @"obs-plugins\64bit\replay-source.dll") || File.Exists(txtOBSPath.Text + @"obs -plugins\32bit\replay-source.dll"))
                {
                    MessageBox.Show("The installation of the Replay Source Plugin was completed successfully.");
                }
                else
                {
                    MessageBox.Show("Unfortunately there was an error with the installation of the Replay Source plugin, please try it again.");
                }
            }
        }

        private void btnStreamFX_Click(object sender, EventArgs e)
        {
            CloseOBSMessage();
            Process.Start(lDownloadLinks.StreamFX);

            MessageBox.Show("Please wait until the download has finished, then press \"OK\" in this message box and select the downloaded file in the next step.");

            OpenFileDialog of = new OpenFileDialog();
            of.Title = @"Please select your Stream FX installer";
            of.Filter = "Stream FX|streamfx*.exe";
            try
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    Process.Start(of.FileName);
                    MessageBox.Show("Please finish the installation of StreamFX and then click on \"OK\" in this message box");
                }
                CheckPlugins();
                if (File.Exists(txtOBSPath.Text + @"obs-plugins\64bit\StreamFX.dll") || File.Exists(txtOBSPath.Text + @"obs-plugins\32bit\StreamFX.dll"))
                {
                    MessageBox.Show("The installation of the StreamFX Plugin was completed successfully.");
                }
                else
                {
                    MessageBox.Show("Unfortunately there was an error with the installation of the StreamFX plugin, if you pressed \"OK\" in the previous message before the installation was over, please finish the installation and hit \"Refresh\". In case this error persists, please try again and make sure to select the correct path in the installation.");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DoZipInstallation(OpenFileDialog of)
        {
            try
            {
                if (Directory.Exists("ZipInstaller"))
                {
                    Directory.Delete("ZipInstaller", true);
                }
                Directory.CreateDirectory("ZipInstaller");
                ZipFile.ExtractToDirectory(of.FileName, "ZipInstaller");
                CopyFilesRecursively("ZipInstaller", txtOBSPath.Text);
                CheckPlugins();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("If you need any help, feel free to join our awesome discord community and we will gladly help you out. Join now?", "Join discord?", MessageBoxButtons.YesNo))
            {
                Process.Start(lDownloadLinks.Discord);
            }

        }
    }

    public class Links
    {
        public string OBSWS;
        public string MoveTransition;
        public string StreamFX;
        public string Freeze;
        public string SourceCopy;
        public string Replay;
        public string Discord;
    }
}
