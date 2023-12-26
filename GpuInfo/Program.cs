using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Globalization;

namespace gpuInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hi();
            Gpu_info();
            Console.ReadLine();
        }
        public static void Hi()
        {
            Console.WriteLine("Called a method");
        }
        public static void Gpu_info()
        {
            //var searcher;
            using (var searcher = new ManagementObjectSearcher("select * from Win32_VideoController"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    Console.WriteLine("Name  -  " + obj["Name"]);
                    Console.WriteLine("DeviceID  -  " + obj["DeviceID"]);
                    //Console.WriteLine("AdapterRAM  -  " + obj["AdapterRAM"] );
                    //Console.WriteLine("AdapterDACType  -  " + obj["AdapterDACType"]);
                    //Console.WriteLine("Monochrome  -  " + obj["Monochrome"] );
                    //Console.WriteLine("InstalledDisplayDrivers  -  " + obj["InstalledDisplayDrivers"]);
                    //Console.WriteLine("DriverVersion  -  " + obj["DriverVersion"]);
                    Console.WriteLine("VideoProcessor  -  " + obj["VideoProcessor"]);
                    Console.WriteLine("VideoArchitecture  -  " + obj["VideoArchitecture"]);
                    //Console.WriteLine("VideoMemoryType  -  " + obj["VideoMemoryType"]);

                }

            }

        }
    }
}
