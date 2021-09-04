using Google.Authenticator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Authenticator.Classes
{
    public class Authenticator
    {
        private readonly TwoFactorAuthenticator _authenticator;
        private string secret;

        public bool IsTowFactorEnabled
        {
            get
            {
                if (string.IsNullOrEmpty(SettingManager.GetUserSecret()))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public Authenticator()
        {
            Utils.Log($"[{DateTime.Now}] , user :{Environment.UserName} , is Admin : {Utils.IsAdministrator()}");
            this._authenticator = new TwoFactorAuthenticator();
        }

        public SetupCode GenerateSetup()
        {

            secret = Utils.GenerateSecret();
            var setupInfo = this._authenticator.GenerateSetupCode("windows login", Environment.UserName, this.secret, false, 3);

            return setupInfo;
        }

        public bool SaveSetup()
        {
            try
            {
                SettingManager.SetUserSecret(this.secret);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Validate(string Code)
        {
            var result = this._authenticator
                .ValidateTwoFactorPIN(SettingManager.GetUserSecret(), Code, TimeSpan.FromSeconds(SettingManager.GetTimeTolerance()));

            string currentCode = _authenticator.GetCurrentPIN(SettingManager.GetUserSecret());

            Utils.Log($"[{DateTime.Now}], user code : {Code} , current code : {currentCode} , is valid : {result} , user :{Environment.UserName} , is Admin : {Utils.IsAdministrator()}");

            return result;
        }

    }
}
