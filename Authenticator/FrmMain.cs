using Google.Authenticator;
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
using System.Configuration;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using Authenticator.Classes;
using System.Security.Principal;

namespace Authenticator
{
    public partial class FrmMain : FrmBase
    {
        public FrmMain(Classes.Authenticator _authenticator) : base(_authenticator
            , SettingManager.GetInitialTimer()
            , new Point(12, 240)
            , new Point(233, 234))
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            var setup = authenticator.GenerateSetup();
            this.picQrCode.Image = Utils.GetImageFromBase64Url(setup.QrCodeSetupImageUrl);
            this.lblManualEntryKey.Text = setup.ManualEntryKey;
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = e.CloseReason == CloseReason.UserClosing;
        }

        private void btnSaveTwoFactorSetup_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Please make sure to scan qr code or manually add key to authenticator app", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    {
                        authenticator.SaveSetup();
                        Application.Exit();
                        break;
                    }
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
