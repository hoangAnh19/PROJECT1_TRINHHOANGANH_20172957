using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace _9.iff_else
{
    class SystemName
    {
        public static void Main()
        {

            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_Battery");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Win32_Battery instance");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("SystemName: {0}", queryObj["SystemName"]);
                }
                Console.ReadLine();
            }
        }
    }
}
