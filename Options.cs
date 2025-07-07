using System;
using CommandLine;

namespace GmailCreator
{
    internal class Options
    {
        [Option("verbose", Default = false, HelpText = "Enable logs")]
        public bool Verbose { get; set; }

        [Option("BrowserPath", Required = true, Default = null, HelpText = "The local path of chrome.exe, Ex: C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe")]
        public string BrowserPath { get; set; }

        [Option("UserDataDir", Required = true, Default = null, HelpText = "The local directory of chrome UserData")]
        public string UserDataDir { get; set; }

        [Option("PhoneKey", Required = true, Default = null, HelpText = "Telephony services API. website address: https://daisysms.com/")]
        public string PhoneKey { get; set; }

        [Option("UserName", Required = true, Default = null)]
        public string UserName { get; set; }

        [Option("Password", Required = true, Default = null)]
        public string Password { get; set; }

        [Option("FirstName", Required = true, Default = "shu")]
        public string FirstName { get; set; }

        [Option("LastName", Required = true, Default = "li")]
        public string LastName { get; set; }

        [Option("Gender", Default = null, HelpText = "Male: 1, Female: 0")]
        public int Gender { get; set; }

        [Option("Birthday", Default = null, HelpText = "Ex: 1997-04-01")]
        public DateTime Birthday { get; set; }

        [Option("RecoveryEmail", Default = null)]
        public string RecoveryEmail { get; set; }
    }
}
