using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps_learnng
{
    internal class Overload
    {
       public Overload() {
         static void DisplayMessage(string message = "default", int repeatCount = 2)
            {
                for (int i = 0; i < repeatCount; i++)
                {
                    Console.WriteLine(message);
                }
            }

           DisplayMessage(repeatCount: 2, message: "hello");
        }
        
    }
}
