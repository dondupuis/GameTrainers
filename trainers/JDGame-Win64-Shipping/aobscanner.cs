using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;
using GameTrainers.trainers.JDGame_Win64_Shipping;

namespace GameTrainers.trainers.JDGame_Win64_Shipping
{
    public class aobscanner
    {
        [DllImport("kernel32.dll")]

        static extern bool ReadProcessMemory(IntPtr handle, IntPtr addy, byte[] buffer, int size, ref int bytesRead);

        public string returnValue;
        public object lbl_AoBAddy;

        public aobscanner() //string[] args
        {
            Process proc = Process.GetProcessesByName("JDGame-Win64-Shipping")[0];

            byte[] buffer = new byte[proc.MainModule.ModuleMemorySize];

            int bytesread = 0;

            ReadProcessMemory(proc.Handle, proc.MainModule.BaseAddress, buffer, buffer.Length, ref bytesread); // might require openprocess, idk 
            
            string signature = "89 8B B8 00 00 00 80 B8";
            var addy = sigscan(signature);

            
            //Console.WriteLine(addy[0].ToString("X"));
            //Console.ReadLine();
            //MessageBox.Show(addy[0].ToString("X"));
            returnValue = addy[0].ToString("X");
            //JDGame_Win64_Shipping.lbl_AoBAddy.Text = returnValue;

            int[] transformarray(string sig)
            {
                var bytes = sig.Split(' ');
                int[] intlist = new int[bytes.Length];

                for (int i = 0; i < intlist.Length; i++)
                {
                    if (bytes[i] == "??")
                        intlist[i] = -1;
                    else
                        intlist[i] = int.Parse(bytes[i], NumberStyles.HexNumber);
                }
                return intlist;
            }

            List<IntPtr> sigscan(string sig)
            {
                var intlist = transformarray(sig);
                var results = new List<IntPtr>();

                for (int a = 0; a < buffer.Length; a++)
                {
                    for (int b = 0; b < intlist.Length; b++)
                    {
                        if (intlist[b] != -1 && intlist[b] != buffer[a + b])
                            break;
                        if (b + 1 == intlist.Length)
                        {
                            var result = new IntPtr(a + (Int64)proc.MainModule.BaseAddress);
                            results.Add(result);
                        }
                    }


                }
                
                return results;

            }

        }



    }
}
