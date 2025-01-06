using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetBasic.Day3
{
    internal static class MyLib
    {
        public static int AddOne(this int i)
        {
            return i+=1;
        }

        public static int MinosOne(this int i)
        {
            return i -= 1;
        }
    }
}
