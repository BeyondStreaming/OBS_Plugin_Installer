namespace OBS_Plugin_Installer
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pbStreamFX = new System.Windows.Forms.PictureBox();
            this.pbOBSWS = new System.Windows.Forms.PictureBox();
            this.pbMoveTransition = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectOBSPath = new System.Windows.Forms.Button();
            this.btnFreeze = new System.Windows.Forms.Button();
            this.pbFreeze = new System.Windows.Forms.PictureBox();
            this.pbReplay = new System.Windows.Forms.PictureBox();
            this.pbSourceCopy = new System.Windows.Forms.PictureBox();
            this.btnOBSWS = new System.Windows.Forms.Button();
            this.btnMoveTransition = new System.Windows.Forms.Button();
            this.btnSourceCopy = new System.Windows.Forms.Button();
            this.btnReplay = new System.Windows.Forms.Button();
            this.btnStreamFX = new System.Windows.Forms.Button();
            this.txtOBSPath = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.ilInstalled = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbStreamFX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOBSWS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoveTransition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFreeze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSourceCopy)).BeginInit();
            this.SuspendLayout();
            // 
            // pbStreamFX
            // 
            this.pbStreamFX.Image = ((System.Drawing.Image)(resources.GetObject("pbStreamFX.Image")));
            this.pbStreamFX.Location = new System.Drawing.Point(690, 215);
            this.pbStreamFX.Name = "pbStreamFX";
            this.pbStreamFX.Size = new System.Drawing.Size(64, 64);
            this.pbStreamFX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStreamFX.TabIndex = 29;
            this.pbStreamFX.TabStop = false;
            // 
            // pbOBSWS
            // 
            this.pbOBSWS.Image = ((System.Drawing.Image)(resources.GetObject("pbOBSWS.Image")));
            this.pbOBSWS.Location = new System.Drawing.Point(313, 67);
            this.pbOBSWS.Name = "pbOBSWS";
            this.pbOBSWS.Size = new System.Drawing.Size(64, 64);
            this.pbOBSWS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOBSWS.TabIndex = 27;
            this.pbOBSWS.TabStop = false;
            // 
            // pbMoveTransition
            // 
            this.pbMoveTransition.Image = ((System.Drawing.Image)(resources.GetObject("pbMoveTransition.Image")));
            this.pbMoveTransition.Location = new System.Drawing.Point(313, 141);
            this.pbMoveTransition.Name = "pbMoveTransition";
            this.pbMoveTransition.Size = new System.Drawing.Size(64, 64);
            this.pbMoveTransition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMoveTransition.TabIndex = 26;
            this.pbMoveTransition.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(2, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "OBS Location";
            // 
            // btnSelectOBSPath
            // 
            this.btnSelectOBSPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.btnSelectOBSPath.Location = new System.Drawing.Point(690, 11);
            this.btnSelectOBSPath.Name = "btnSelectOBSPath";
            this.btnSelectOBSPath.Size = new System.Drawing.Size(64, 45);
            this.btnSelectOBSPath.TabIndex = 0;
            this.btnSelectOBSPath.Text = "...";
            this.btnSelectOBSPath.UseVisualStyleBackColor = true;
            this.btnSelectOBSPath.Click += new System.EventHandler(this.btnSelectOBSPath_Click);
            // 
            // btnFreeze
            // 
            this.btnFreeze.Enabled = false;
            this.btnFreeze.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btnFreeze.Location = new System.Drawing.Point(384, 67);
            this.btnFreeze.Name = "btnFreeze";
            this.btnFreeze.Size = new System.Drawing.Size(297, 64);
            this.btnFreeze.TabIndex = 4;
            this.btnFreeze.Text = "Freeze";
            this.btnFreeze.UseVisualStyleBackColor = true;
            this.btnFreeze.Click += new System.EventHandler(this.btnFreeze_Click);
            // 
            // pbFreeze
            // 
            this.pbFreeze.Image = ((System.Drawing.Image)(resources.GetObject("pbFreeze.Image")));
            this.pbFreeze.Location = new System.Drawing.Point(690, 67);
            this.pbFreeze.Name = "pbFreeze";
            this.pbFreeze.Size = new System.Drawing.Size(64, 64);
            this.pbFreeze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFreeze.TabIndex = 30;
            this.pbFreeze.TabStop = false;
            // 
            // pbReplay
            // 
            this.pbReplay.Image = ((System.Drawing.Image)(resources.GetObject("pbReplay.Image")));
            this.pbReplay.Location = new System.Drawing.Point(690, 141);
            this.pbReplay.Name = "pbReplay";
            this.pbReplay.Size = new System.Drawing.Size(64, 64);
            this.pbReplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReplay.TabIndex = 31;
            this.pbReplay.TabStop = false;
            // 
            // pbSourceCopy
            // 
            this.pbSourceCopy.Image = ((System.Drawing.Image)(resources.GetObject("pbSourceCopy.Image")));
            this.pbSourceCopy.Location = new System.Drawing.Point(314, 215);
            this.pbSourceCopy.Name = "pbSourceCopy";
            this.pbSourceCopy.Size = new System.Drawing.Size(64, 64);
            this.pbSourceCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSourceCopy.TabIndex = 32;
            this.pbSourceCopy.TabStop = false;
            // 
            // btnOBSWS
            // 
            this.btnOBSWS.Enabled = false;
            this.btnOBSWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btnOBSWS.Location = new System.Drawing.Point(7, 67);
            this.btnOBSWS.Name = "btnOBSWS";
            this.btnOBSWS.Size = new System.Drawing.Size(297, 64);
            this.btnOBSWS.TabIndex = 1;
            this.btnOBSWS.Text = "OBSWS 4.9.1";
            this.btnOBSWS.UseVisualStyleBackColor = true;
            this.btnOBSWS.Click += new System.EventHandler(this.btnOBSWS_Click);
            // 
            // btnMoveTransition
            // 
            this.btnMoveTransition.Enabled = false;
            this.btnMoveTransition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btnMoveTransition.Location = new System.Drawing.Point(7, 141);
            this.btnMoveTransition.Name = "btnMoveTransition";
            this.btnMoveTransition.Size = new System.Drawing.Size(297, 64);
            this.btnMoveTransition.TabIndex = 2;
            this.btnMoveTransition.Text = "Move Transition";
            this.btnMoveTransition.UseVisualStyleBackColor = true;
            this.btnMoveTransition.Click += new System.EventHandler(this.btnMoveTransition_Click);
            // 
            // btnSourceCopy
            // 
            this.btnSourceCopy.Enabled = false;
            this.btnSourceCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btnSourceCopy.Location = new System.Drawing.Point(7, 215);
            this.btnSourceCopy.Name = "btnSourceCopy";
            this.btnSourceCopy.Size = new System.Drawing.Size(297, 64);
            this.btnSourceCopy.TabIndex = 3;
            this.btnSourceCopy.Text = "Source Copy";
            this.btnSourceCopy.UseVisualStyleBackColor = true;
            this.btnSourceCopy.Click += new System.EventHandler(this.btnSourceCopy_Click);
            // 
            // btnReplay
            // 
            this.btnReplay.Enabled = false;
            this.btnReplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btnReplay.Location = new System.Drawing.Point(384, 141);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(297, 64);
            this.btnReplay.TabIndex = 5;
            this.btnReplay.Text = "Replay";
            this.btnReplay.UseVisualStyleBackColor = true;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // btnStreamFX
            // 
            this.btnStreamFX.Enabled = false;
            this.btnStreamFX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btnStreamFX.Location = new System.Drawing.Point(384, 215);
            this.btnStreamFX.Name = "btnStreamFX";
            this.btnStreamFX.Size = new System.Drawing.Size(297, 64);
            this.btnStreamFX.TabIndex = 6;
            this.btnStreamFX.Text = "StreamFX";
            this.btnStreamFX.UseVisualStyleBackColor = true;
            this.btnStreamFX.Click += new System.EventHandler(this.btnStreamFX_Click);
            // 
            // txtOBSPath
            // 
            this.txtOBSPath.Enabled = false;
            this.txtOBSPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.txtOBSPath.Location = new System.Drawing.Point(201, 12);
            this.txtOBSPath.Name = "txtOBSPath";
            this.txtOBSPath.Size = new System.Drawing.Size(480, 44);
            this.txtOBSPath.TabIndex = 17;
            this.txtOBSPath.TextChanged += new System.EventHandler(this.txtOBSPath_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(7, 289);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(747, 64);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ilInstalled
            // 
            this.ilInstalled.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilInstalled.ImageStream")));
            this.ilInstalled.TransparentColor = System.Drawing.Color.Transparent;
            this.ilInstalled.Images.SetKeyName(0, "Installed.png");
            this.ilInstalled.Images.SetKeyName(1, "NotInstalled.png");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(760, 360);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnStreamFX);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.btnSourceCopy);
            this.Controls.Add(this.btnMoveTransition);
            this.Controls.Add(this.btnOBSWS);
            this.Controls.Add(this.pbSourceCopy);
            this.Controls.Add(this.pbReplay);
            this.Controls.Add(this.pbFreeze);
            this.Controls.Add(this.pbStreamFX);
            this.Controls.Add(this.pbOBSWS);
            this.Controls.Add(this.pbMoveTransition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectOBSPath);
            this.Controls.Add(this.txtOBSPath);
            this.Controls.Add(this.btnFreeze);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Beyond Streaming - OBS Plugin Installer - by Chrizzz";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbStreamFX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOBSWS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoveTransition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFreeze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSourceCopy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStreamFX;
        private System.Windows.Forms.PictureBox pbOBSWS;
        private System.Windows.Forms.PictureBox pbMoveTransition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectOBSPath;
        private System.Windows.Forms.Button btnFreeze;
        private System.Windows.Forms.PictureBox pbFreeze;
        private System.Windows.Forms.PictureBox pbReplay;
        private System.Windows.Forms.PictureBox pbSourceCopy;
        private System.Windows.Forms.Button btnOBSWS;
        private System.Windows.Forms.Button btnMoveTransition;
        private System.Windows.Forms.Button btnSourceCopy;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Button btnStreamFX;
        private System.Windows.Forms.TextBox txtOBSPath;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ImageList ilInstalled;
    }
}

