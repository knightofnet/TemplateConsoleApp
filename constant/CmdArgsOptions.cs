using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AryxDevLibrary.utils.cliParser;

namespace TemplateConsoleApp.constant
{
    internal static class CmdArgsOptions
    {
        public static readonly Option OptShowHelp = new Option()
        {
            ShortOpt = "h",
            LongOpt = "help",
            Description = "Show help",
            HasArgs = false,
            Name = "OptShowHelp",
            IsMandatory = false

        };

    }
}
