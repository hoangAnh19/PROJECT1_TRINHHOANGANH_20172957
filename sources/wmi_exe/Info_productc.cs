using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace wmi
{
    class Info_productc
    {
        public static void Main()
        {

            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_ComputerSystem");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Win32_ComputerSystem instance");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("SystemFamily: {0}", queryObj["SystemFamily"]);
                }
                Console.ReadLine();
            }
        }
    }
}
