using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace _9.iff_else
{
    class background
    {
        public static void Main()
        {
            ManagementObjectSearcher searcher =
                      new ManagementObjectSearcher("root\\CIMV2",
                      "SELECT * FROM Win32_Desktop");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Win32_Desktop instance");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Wallpaper: {0}", queryObj["Wallpaper"]);
            }
            Console.ReadLine();
        }
    }
}
