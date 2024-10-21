using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensionns
{
    internal static  class IntExtensionMethod
    {
        public static bool IsEven(this int num) => num % 2 == 0;

        public static bool IsOdd(this int num) => num % 2 !=0;

    }
}
