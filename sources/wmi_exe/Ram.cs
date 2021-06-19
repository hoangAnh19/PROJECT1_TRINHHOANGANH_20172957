using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace _9.iff_else
{
    class Ram
    {
        public static void Main()
        {


            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\CIMV2",
                "SELECT * FROM Win32_ComputerSystem");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Win32_ComputerSystem instance");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("TotalPhysicalMemory: {0}", queryObj["TotalPhysicalMemory"]);
            }
            Console.ReadLine();
        }
    }
}
