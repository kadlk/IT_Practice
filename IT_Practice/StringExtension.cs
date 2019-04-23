using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Practice
{
    public static class StringExtension
    {
        
        public static string StringDelete(this String forstr)
        {
            forstr = forstr.Substring(0, 5) + " :";
            return forstr;
         }
    }
}
