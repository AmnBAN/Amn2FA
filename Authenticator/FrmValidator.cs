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
    public partial class FrmValidator : FrmBase
    {
        public FrmValidator(Classes.Authenticator _authenticator) : base(_authenticator
            , SettingManager.GetEnterCodeTimer()
            , new Point(12, 60)
            , new Point(216, 55))
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Validate();
                e.Handled = true;
            }
        }
        private void Validate()
        {
            var result = this.authenticator
                .Validate(txtCode.Text);

            if (result)
            {
                //MessageBox.Show("Valid", "Code Validation Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("InValid Code", "Code Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //authenticator.LogOffUser();
                //this.Close();
            }
        }
    }
}
