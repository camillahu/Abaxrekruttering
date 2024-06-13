using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering
{
    internal static class UserInterface
    {
        
        public static string RequestString(this string message)
        {
            var output = "";
            while (string.IsNullOrWhiteSpace(output))
            {
                Console.WriteLine(message);
                output = Console.ReadLine();
            }
            return output;
        }

        public static int RequestInt(this string message)
        {
            return Convert.ToInt32(message.RequestString());
        }

       
    }
}
