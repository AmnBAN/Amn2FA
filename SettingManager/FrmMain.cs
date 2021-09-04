using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SettingManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.nudEnterCodeTime.Maximum = 600;
            this.nudInitialTimer.Maximum = 600;
            this.nudTimeTolerance.Maximum = 600;

            this.nudEnterCodeTime.Minimum = 1;
            this.nudInitialTimer.Minimum = 1;
            this.nudTimeTolerance.Minimum = 1;

            this.nudEnterCodeTime.Value = Authenticator.Classes.SettingManager.GetEnterCodeTimer();
            this.nudInitialTimer.Value = Authenticator.Classes.SettingManager.GetInitialTimer();
            this.nudTimeTolerance.Value = Authenticator.Classes.SettingManager.GetTimeTolerance();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Authenticator.Classes.SettingManager.InitRegistery(nudTimeTolerance.Value.ToString()
                , nudEnterCodeTime.Value.ToString()
                , nudInitialTimer.Value.ToString());
            int code = this.checkBoxResetCredential.Checked ? 1 : 0;
            Program.ExitCode = code;
            this.Close();
        }

        private void btnResetCredential_Click(object sender, EventArgs e)
        {
            //string user = Environment.UserName;
            //MessageBox.Show(user);
            //Authenticator.Classes.SettingManager.SetUserSecret("");

            //Process[] procs = Process.GetProcesses(); //Process.GetProcessesByName("Authenticator.exe");
            //foreach (var proc in procs)
            //{
            //    proc.Kill();
            //}
            //Authenticator.Classes.Utils.LogOffUser();
            //this.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
