using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using Authenticator.Classes;

namespace Authenticator
{
    public partial class FrmBase : Form
    {
        protected readonly Classes.Authenticator authenticator;
        private int time;
        public FrmBase()
        {
            InitializeComponent();
        }
        public FrmBase(Classes.Authenticator _authenticator, int _time, Point timerLabel, Point settingButton) : this()
        {
            this.authenticator = _authenticator;
            this.time = _time;
            this.lblTimer.Location = timerLabel;
            this.btnSetting.Location = settingButton;

            this.timerLogOff.Enabled = true;
            this.timerLogOff.Interval = 1000;
            this.timerLogOff.Tick += TimerOnTick;
        }

        private void TimerOnTick(object sender, EventArgs e)
        {
            --time;
            this.lblTimer.Text = TimeSpan.FromSeconds(time).ToString(@"mm\:ss");
            if (time <= 0)
            {
                Utils.LogOffUser();
                Application.Exit();
            }
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (e.CloseReason == CloseReason.UserClosing);

        }

        private void BaseFrom_Load(object sender, EventArgs e)
        {
            Utils.AddShieldToButton(btnSetting);
        }

        public void ExecuteAsAdmin()
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SettingManager.exe");
                proc.StartInfo.UseShellExecute = true;
                //proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.Verb = "runas";
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                //proc.Exited += new EventHandler(Proc_Exited);
                //proc.ErrorDataReceived += Proc_ErrorDataReceived;
                //proc.CancelErrorRead();
                this.timerLogOff.Enabled = false;
                proc.Start();
                proc.WaitForExit();
                if (proc.ExitCode > 0)
                {
                    SettingManager.SetUserSecret(string.Empty);
                }

                Application.Restart();
            }
            catch (Exception)
            {
                this.timerLogOff.Enabled = true;
            }
            finally
            {
                this.timerLogOff.Enabled = true;
            }

        }

        private void Proc_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            //MessageBox.Show("haha");
        }

        private void Proc_Exited(object sender, EventArgs e)
        {
            //MessageBox.Show("haha");
            //this.timerLogOff.Enabled = true;
            //Application.Restart();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ExecuteAsAdmin();
        }
    }
}
