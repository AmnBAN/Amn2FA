using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authenticator.Classes
{
    public class Utils
    {
        [DllImport("wtsapi32.dll", SetLastError = true)]
        static extern bool WTSDisconnectSession(IntPtr hServer, int sessionId, bool bWait);

        const int WTS_CURRENT_SESSION = -1;
        static readonly IntPtr WTS_CURRENT_SERVER_HANDLE = IntPtr.Zero;


        [DllImport("user32")]
        public static extern UInt32 SendMessage
            (IntPtr hWnd, UInt32 msg, UInt32 wParam, UInt32 lParam);

        internal const int BCM_FIRST = 0x1600; //Normal button
        internal const int BCM_SETSHIELD = (BCM_FIRST + 0x000C); //Elevated button

        const string LOG_FILE_NAME = "Log.txt";
        public static void Log(string message)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,LOG_FILE_NAME );
            using (StreamWriter w = File.AppendText(path))
            {
                w.WriteLine(message);
            }
        }

        public static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static string GenerateSecret()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }

        public static Image GetImageFromBase64Url(string base64Url)
        {
            string qrCodeImageUrl = base64Url.Replace("data:image/png;base64,", string.Empty); ;
            byte[] imageBytes = Convert.FromBase64String(qrCodeImageUrl);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms, true);
            }
        }

        public static void LogOffUser()
        {
            WTSDisconnectSession(WTS_CURRENT_SERVER_HANDLE, WTS_CURRENT_SESSION, false);
        }

        public static void AddShieldToButton(Button b)
        {
            b.FlatStyle = FlatStyle.System;
            SendMessage(b.Handle, BCM_SETSHIELD, 0, 0xFFFFFFFF);
        }

    }
}
