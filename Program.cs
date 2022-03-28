using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AryxDevLibrary.utils;
using AryxDevLibrary.utils.logger;
using TemplateConsoleApp.business;
using TemplateConsoleApp.constant;
using TemplateConsoleApp.dto;

namespace TemplateConsoleApp
{
    internal class Program
    {
        private static readonly Logger Log = new Logger("log.log", Logger.LogLvl.NONE, Logger.LogLvl.DEBUG, "1 Mo");

        private AppConf _appConf = null;

        static void Main(string[] args)
        {
            Log.Debug("Start program...");

            ExceptionHandlingUtils.Logger = Log;


            ArgsParser argsParser = new ArgsParser();
            AppConf appConf = argsParser.ParseDirect(args);

            Program mainProgram = new Program();

            try
            {
                mainProgram.Launch(appConf);
                Environment.Exit(EnumExitCodes.OK.Index);
            }
            catch (Exception ex)
            {
                ExceptionHandlingUtils.LogAndEndsProgram(ex, EnumExitCodes.OK.Index, "Unexpected error");
            }
            finally
            {
                Log.Debug("End of the program");
            }

        }

        private void Launch(AppConf pConf)
        {
            _appConf = pConf;
            

            


        }
    }
}
