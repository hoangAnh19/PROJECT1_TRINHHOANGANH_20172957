using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

//using System.Windows.Forms;
//<NoWarn>$(NoWarn),IDE1006</NoWarn>
namespace wmi_exe.wmi_exe
{
    class infobios
    {

        public static void Main()
        {

            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_BIOS");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Win32_BIOS instance");
                    Console.WriteLine("-----------------------------------");

                    if (queryObj["BIOSVersion"] == null)
                        Console.WriteLine("BIOSVersion: {0}", queryObj["BIOSVersion"]);
                    else
                    {
                        String[] arrBIOSVersion = (String[])(queryObj["BIOSVersion"]);
                        foreach (String arrValue in arrBIOSVersion)
                        {
                            Console.WriteLine("BIOSVersion: {0}", arrValue);
                        }

                    }
                }
                Console.ReadLine();
            }
        }
    }
}
                
                
            
          
        
    

