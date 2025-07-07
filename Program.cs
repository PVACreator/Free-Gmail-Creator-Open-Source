using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BotModule;
using ChromeController;
using CommandLine;
using Serilog;

namespace GmailCreator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            Environment.SetEnvironmentVariable("BASEDIR", AppDomain.CurrentDomain.BaseDirectory);
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs/.log");
            var configuration = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console();
            if (args.Contains("--verbose"))
            {
                configuration.WriteTo
                    .File(path,
                    rollingInterval: RollingInterval.Day,
                    rollOnFileSizeLimit: true,
                    encoding: Encoding.UTF8);
            }
            Log.Logger = configuration.CreateLogger();

            try
            {
                var parser = new Parser(m =>
                {
                    m.IgnoreUnknownArguments = true;
                    m.HelpWriter = Console.Error;
                });
                var result = parser.ParseArguments<Options>(args);
                result.WithParsed(opts => RunOptions(opts));
                //Log.Information("Press the 'q' key to exit.");
                //while (Console.Read() != 'q')
                //{
                //    Log.Information("Press the 'q' key to exit.");
                //}
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        static int RunOptions(Options opts)
        {
            opts.UserDataDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, opts.UserDataDir);
            if (!Directory.Exists(opts.UserDataDir))
                Directory.CreateDirectory(opts.UserDataDir);
            var chrome = new Chrome();

            try
            {
                chrome.Init(opts.BrowserPath, opts.UserDataDir, null, args: new List<string>() { "--enable-extensions" }, language_ex: "en-US");

                GoogleUser user = new GoogleUser()
                {
                    PhoneKey = opts.PhoneKey,
                    UserName = opts.UserName,
                    Password = opts.Password,
                    FirstName = opts.FirstName,
                    LastName = opts.LastName,
                    Gender = opts.Gender,
                    Birthday = opts.Birthday,
                    RecoveryEmail = opts.RecoveryEmail
                };
                GoogleModule module = new GoogleModule(chrome, user);
                var result = module.Register();
                if (result.Success)
                {
                    Log.Information("Account registration successful");
                }
                else
                {
                    Log.Information("Account registration failed" + result.Error);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                try
                {
                    chrome.Dispose();
                }
                catch (Exception)
                {

                }
            }

            return 1;
        }
    }
}
