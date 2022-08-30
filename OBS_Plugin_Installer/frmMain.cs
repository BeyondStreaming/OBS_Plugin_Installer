using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS_Plugin_Installer
{
    public partial class frmMain : Form
    {
        private bool bMessageWasShown = false;
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
        }

        private void btnMoveTransition_Click(object sender, EventArgs e)
        {
            CloseOBSMessage();

        }

        private void btnSourceCopy_Click(object sender, EventArgs e)
        {
            CloseOBSMessage();

        }

        private void btnFreeze_Click(object sender, EventArgs e)
        {
            CloseOBSMessage();

        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            CloseOBSMessage();

        }

        private void btnStreamFX_Click(object sender, EventArgs e)
        {
            CloseOBSMessage();

        }
    }
}
