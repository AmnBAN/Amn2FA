
namespace Authenticator
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picQrCode = new System.Windows.Forms.PictureBox();
            this.lblManualEntryKey = new System.Windows.Forms.Label();
            this.btnSaveTwoFactorSetup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picQrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // picQrCode
            // 
            this.picQrCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.picQrCode.Location = new System.Drawing.Point(0, 0);
            this.picQrCode.Name = "picQrCode";
            this.picQrCode.Size = new System.Drawing.Size(404, 176);
            this.picQrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picQrCode.TabIndex = 3;
            this.picQrCode.TabStop = false;
            // 
            // lblManualEntryKey
            // 
            this.lblManualEntryKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblManualEntryKey.Location = new System.Drawing.Point(0, 176);
            this.lblManualEntryKey.Name = "lblManualEntryKey";
            this.lblManualEntryKey.Padding = new System.Windows.Forms.Padding(2);
            this.lblManualEntryKey.Size = new System.Drawing.Size(404, 50);
            this.lblManualEntryKey.TabIndex = 4;
            this.lblManualEntryKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveTwoFactorSetup
            // 
            this.btnSaveTwoFactorSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveTwoFactorSetup.Location = new System.Drawing.Point(314, 234);
            this.btnSaveTwoFactorSetup.Name = "btnSaveTwoFactorSetup";
            this.btnSaveTwoFactorSetup.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTwoFactorSetup.TabIndex = 5;
            this.btnSaveTwoFactorSetup.Text = "Save";
            this.btnSaveTwoFactorSetup.UseVisualStyleBackColor = true;
            this.btnSaveTwoFactorSetup.Click += new System.EventHandler(this.btnSaveTwoFactorSetup_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.btnSaveTwoFactorSetup);
            this.Controls.Add(this.lblManualEntryKey);
            this.Controls.Add(this.picQrCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google 2FA";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQrCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picQrCode;
        private System.Windows.Forms.Label lblManualEntryKey;
        private System.Windows.Forms.Button btnSaveTwoFactorSetup;
    }
}

