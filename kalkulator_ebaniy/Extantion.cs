using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator_ebaniy
{
    static class Extantion
    {
        public static string ToSender(this object sender)
        {
            return sender.ToString().Replace("System.Windows.Forms.Button, Text: ", "");
        }
    }
}
