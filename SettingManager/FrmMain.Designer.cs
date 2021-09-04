
namespace SettingManager
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblInitialTimer = new System.Windows.Forms.Label();
            this.nudInitialTimer = new System.Windows.Forms.NumericUpDown();
            this.nudEnterCodeTime = new System.Windows.Forms.NumericUpDown();
            this.lblEnterCodeTimer = new System.Windows.Forms.Label();
            this.nudTimeTolerance = new System.Windows.Forms.NumericUpDown();
            this.lblTimeTolerance = new System.Windows.Forms.Label();
            this.checkBoxResetCredential = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnterCodeTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeTolerance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(336, 88);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblInitialTimer
            // 
            this.lblInitialTimer.AutoSize = true;
            this.lblInitialTimer.Location = new System.Drawing.Point(12, 9);
            this.lblInitialTimer.Name = "lblInitialTimer";
            this.lblInitialTimer.Size = new System.Drawing.Size(66, 13);
            this.lblInitialTimer.TabIndex = 1;
            this.lblInitialTimer.Text = "Initial Timer :";
            // 
            // nudInitialTimer
            // 
            this.nudInitialTimer.Location = new System.Drawing.Point(110, 7);
            this.nudInitialTimer.Name = "nudInitialTimer";
            this.nudInitialTimer.Size = new System.Drawing.Size(301, 20);
            this.nudInitialTimer.TabIndex = 3;
            // 
            // nudEnterCodeTime
            // 
            this.nudEnterCodeTime.Location = new System.Drawing.Point(110, 33);
            this.nudEnterCodeTime.Name = "nudEnterCodeTime";
            this.nudEnterCodeTime.Size = new System.Drawing.Size(301, 20);
            this.nudEnterCodeTime.TabIndex = 5;
            // 
            // lblEnterCodeTimer
            // 
            this.lblEnterCodeTimer.AutoSize = true;
            this.lblEnterCodeTimer.Location = new System.Drawing.Point(12, 35);
            this.lblEnterCodeTimer.Name = "lblEnterCodeTimer";
            this.lblEnterCodeTimer.Size = new System.Drawing.Size(95, 13);
            this.lblEnterCodeTimer.TabIndex = 4;
            this.lblEnterCodeTimer.Text = "Enter Code Timer :";
            // 
            // nudTimeTolerance
            // 
            this.nudTimeTolerance.Location = new System.Drawing.Point(110, 62);
            this.nudTimeTolerance.Name = "nudTimeTolerance";
            this.nudTimeTolerance.Size = new System.Drawing.Size(301, 20);
            this.nudTimeTolerance.TabIndex = 7;
            // 
            // lblTimeTolerance
            // 
            this.lblTimeTolerance.AutoSize = true;
            this.lblTimeTolerance.Location = new System.Drawing.Point(12, 64);
            this.lblTimeTolerance.Name = "lblTimeTolerance";
            this.lblTimeTolerance.Size = new System.Drawing.Size(87, 13);
            this.lblTimeTolerance.TabIndex = 6;
            this.lblTimeTolerance.Text = "Time Tolerance :";
            // 
            // checkBoxResetCredential
            // 
            this.checkBoxResetCredential.AutoSize = true;
            this.checkBoxResetCredential.Location = new System.Drawing.Point(15, 92);
            this.checkBoxResetCredential.Name = "checkBoxResetCredential";
            this.checkBoxResetCredential.Size = new System.Drawing.Size(98, 17);
            this.checkBoxResetCredential.TabIndex = 8;
            this.checkBoxResetCredential.Text = "reset credential";
            this.checkBoxResetCredential.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 113);
            this.Controls.Add(this.checkBoxResetCredential);
            this.Controls.Add(this.nudTimeTolerance);
            this.Controls.Add(this.lblTimeTolerance);
            this.Controls.Add(this.nudEnterCodeTime);
            this.Controls.Add(this.lblEnterCodeTimer);
            this.Controls.Add(this.nudInitialTimer);
            this.Controls.Add(this.lblInitialTimer);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnterCodeTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeTolerance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblInitialTimer;
        private System.Windows.Forms.NumericUpDown nudInitialTimer;
        private System.Windows.Forms.NumericUpDown nudEnterCodeTime;
        private System.Windows.Forms.Label lblEnterCodeTimer;
        private System.Windows.Forms.NumericUpDown nudTimeTolerance;
        private System.Windows.Forms.Label lblTimeTolerance;
        private System.Windows.Forms.CheckBox checkBoxResetCredential;
    }
}

