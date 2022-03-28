using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AryxDevLibrary.utils.cliParser;
using TemplateConsoleApp.constant;
using TemplateConsoleApp.dto;

namespace TemplateConsoleApp.business
{
    internal class ArgsParser : CliParser<AppConf>
    {
        public ArgsParser()
        {
            AddOption(CmdArgsOptions.OptShowHelp);
        }

        public override AppConf ParseDirect(string[] args)
        {
            return Parse(args, ParseTrt);

        }

        private AppConf ParseTrt(Dictionary<string, Option> arg)
        {
            AppConf conf = new AppConf();

            if (HasOption(CmdArgsOptions.OptShowHelp, arg))
            {
                conf.ShowHelp = true;
            }

            // ...

            return conf;

        }
    }
}
