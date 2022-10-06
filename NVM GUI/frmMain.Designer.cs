namespace NVM_GUI
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.cbbNvmAvailableVersions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNvmInstall = new System.Windows.Forms.Button();
            this.gbNvm = new System.Windows.Forms.GroupBox();
            this.lblNvmInstalledVersion = new System.Windows.Forms.Label();
            this.gbNodeJs = new System.Windows.Forms.GroupBox();
            this.lblNodeJsUsingVersion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNodeJsUse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbNodeJsAvailableVersions = new System.Windows.Forms.ComboBox();
            this.niTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.gbNvm.SuspendLayout();
            this.gbNodeJs.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Installed";
            // 
            // cbbNvmAvailableVersions
            // 
            this.cbbNvmAvailableVersions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNvmAvailableVersions.FormattingEnabled = true;
            this.cbbNvmAvailableVersions.Location = new System.Drawing.Point(100, 20);
            this.cbbNvmAvailableVersions.Name = "cbbNvmAvailableVersions";
            this.cbbNvmAvailableVersions.Size = new System.Drawing.Size(151, 28);
            this.cbbNvmAvailableVersions.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Available";
            // 
            // btnNvmInstall
            // 
            this.btnNvmInstall.Location = new System.Drawing.Point(257, 19);
            this.btnNvmInstall.Name = "btnNvmInstall";
            this.btnNvmInstall.Size = new System.Drawing.Size(94, 29);
            this.btnNvmInstall.TabIndex = 4;
            this.btnNvmInstall.Text = "Install";
            this.btnNvmInstall.UseVisualStyleBackColor = true;
            this.btnNvmInstall.Click += new System.EventHandler(this.btnNvmInstall_Click);
            // 
            // gbNvm
            // 
            this.gbNvm.Controls.Add(this.lblNvmInstalledVersion);
            this.gbNvm.Controls.Add(this.label2);
            this.gbNvm.Controls.Add(this.btnNvmInstall);
            this.gbNvm.Controls.Add(this.label1);
            this.gbNvm.Controls.Add(this.cbbNvmAvailableVersions);
            this.gbNvm.Location = new System.Drawing.Point(12, 12);
            this.gbNvm.Name = "gbNvm";
            this.gbNvm.Size = new System.Drawing.Size(376, 102);
            this.gbNvm.TabIndex = 5;
            this.gbNvm.TabStop = false;
            this.gbNvm.Text = "NVM";
            // 
            // lblNvmInstalledVersion
            // 
            this.lblNvmInstalledVersion.AutoSize = true;
            this.lblNvmInstalledVersion.Location = new System.Drawing.Point(100, 57);
            this.lblNvmInstalledVersion.Name = "lblNvmInstalledVersion";
            this.lblNvmInstalledVersion.Size = new System.Drawing.Size(0, 20);
            this.lblNvmInstalledVersion.TabIndex = 5;
            // 
            // gbNodeJs
            // 
            this.gbNodeJs.Controls.Add(this.lblNodeJsUsingVersion);
            this.gbNodeJs.Controls.Add(this.label5);
            this.gbNodeJs.Controls.Add(this.btnNodeJsUse);
            this.gbNodeJs.Controls.Add(this.label3);
            this.gbNodeJs.Controls.Add(this.cbbNodeJsAvailableVersions);
            this.gbNodeJs.Enabled = false;
            this.gbNodeJs.Location = new System.Drawing.Point(12, 120);
            this.gbNodeJs.Name = "gbNodeJs";
            this.gbNodeJs.Size = new System.Drawing.Size(376, 105);
            this.gbNodeJs.TabIndex = 6;
            this.gbNodeJs.TabStop = false;
            this.gbNodeJs.Text = "NodeJs";
            // 
            // lblNodeJsUsingVersion
            // 
            this.lblNodeJsUsingVersion.AutoSize = true;
            this.lblNodeJsUsingVersion.Location = new System.Drawing.Point(100, 69);
            this.lblNodeJsUsingVersion.Name = "lblNodeJsUsingVersion";
            this.lblNodeJsUsingVersion.Size = new System.Drawing.Size(0, 20);
            this.lblNodeJsUsingVersion.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Using";
            // 
            // btnNodeJsUse
            // 
            this.btnNodeJsUse.Location = new System.Drawing.Point(257, 30);
            this.btnNodeJsUse.Name = "btnNodeJsUse";
            this.btnNodeJsUse.Size = new System.Drawing.Size(94, 29);
            this.btnNodeJsUse.TabIndex = 5;
            this.btnNodeJsUse.Text = "Use";
            this.btnNodeJsUse.UseVisualStyleBackColor = true;
            this.btnNodeJsUse.Click += new System.EventHandler(this.btnNodeJsUse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Available";
            // 
            // cbbNodeJsAvailableVersions
            // 
            this.cbbNodeJsAvailableVersions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNodeJsAvailableVersions.FormattingEnabled = true;
            this.cbbNodeJsAvailableVersions.Location = new System.Drawing.Point(100, 31);
            this.cbbNodeJsAvailableVersions.Name = "cbbNodeJsAvailableVersions";
            this.cbbNodeJsAvailableVersions.Size = new System.Drawing.Size(151, 28);
            this.cbbNodeJsAvailableVersions.TabIndex = 0;
            // 
            // niTrayIcon
            // 
            this.niTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("niTrayIcon.Icon")));
            this.niTrayIcon.Text = "NVM GUI";
            this.niTrayIcon.Visible = true;
            this.niTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niTrayIcon_MouseDoubleClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 239);
            this.Controls.Add(this.gbNodeJs);
            this.Controls.Add(this.gbNvm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "NVM GUI";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.gbNvm.ResumeLayout(false);
            this.gbNvm.PerformLayout();
            this.gbNodeJs.ResumeLayout(false);
            this.gbNodeJs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private ComboBox cbbNvmAvailableVersions;
        private Label label2;
        private Button btnNvmInstall;
        private GroupBox gbNvm;
        private GroupBox gbNodeJs;
        private ComboBox cbbNodeJsAvailableVersions;
        private Button btnNodeJsUse;
        private Label label3;
        private Label lblNvmInstalledVersion;
        private Label lblNodeJsUsingVersion;
        private Label label5;
        private NotifyIcon niTrayIcon;
    }
}