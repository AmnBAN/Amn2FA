using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace Authenticator.Classes
{
    public class SettingManager
    {
        public const string INIT_TIMER_KEY = "Initial Timer";
        public const string ENTER_CODE_TIMER_KEY = "Enter Code Timer";
        public const string TIME_TOLERANCE_KEY = "Time Tolerance";
        public static readonly string REGISTRY_KEY = "SOFTWARE\\Authenticator" ;

        public static int GetInitialTimer()
        {
            return int.Parse(GetValue(INIT_TIMER_KEY, "300").ToString());
        }

        public static int GetEnterCodeTimer()
        {
            return int.Parse(GetValue(ENTER_CODE_TIMER_KEY, "60").ToString());
        }

        public static int GetTimeTolerance()
        {
            return int.Parse(GetValue(TIME_TOLERANCE_KEY, 300).ToString());
        }

        public static object GetValue(string key, object defaultValue)
        {
            var sk = Registry.ClassesRoot.OpenSubKey(REGISTRY_KEY);
            if (sk == null)
            {
                return defaultValue;
            }
            return sk.GetValue(key, defaultValue);
        }

        public static void SetValue(string key, object value)
        {
            var sk = Registry.ClassesRoot.OpenSubKey(REGISTRY_KEY,true);
            sk.SetValue(key, value);
        }

        public static string GetUserSecret()
        {
            return Properties.Settings.Default.Secret;
        }
        public static void SetUserSecret(string secret)
        {
            Properties.Settings.Default.Secret = secret;
            Properties.Settings.Default.Save();
        }

        public static void InitRegistery(string timeTolerance="300",string enterCodeTimer="60",string initTimer="300")
        {
            var sk = Registry.ClassesRoot.OpenSubKey(REGISTRY_KEY,true);
            if (sk == null)
            {
                sk = Registry.ClassesRoot.CreateSubKey(REGISTRY_KEY);
            }
            SetValue(TIME_TOLERANCE_KEY, timeTolerance);
            SetValue(ENTER_CODE_TIMER_KEY, enterCodeTimer);
            SetValue(INIT_TIMER_KEY, initTimer);
        }
    }
}
