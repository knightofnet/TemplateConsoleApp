using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateConsoleApp.constant
{
    internal sealed class EnumExitCodes
    {
        public static readonly EnumExitCodes OK = new EnumExitCodes(0, "All fine");
        public static readonly EnumExitCodes KO = new EnumExitCodes(1, "Unexpected errors");
      

        public static IEnumerable<EnumExitCodes> Values
        {
            get
            {
                yield return OK;
                yield return KO;



            }
        }

        public int Index { get; }
        public String Libelle { get; }


        private EnumExitCodes(int index, String libelle)
        {
            Index = index;
            Libelle = libelle;


        }
    }
}
