using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumah_Sakit.Class
{
    class modulFungsi
    {
        public string search(string kata)
        {
            string result = "";
            for (int i = 0; i < kata.Length; i++)
            {
                char c = kata[i];
                if (c == '*' || c == '%' || c == '[' || c == ']')
                    result += ("[" + c + "]");
                else if (c == '\'')
                    result += "''";
                else result += c;
            }
            return result;
        }
    }
}