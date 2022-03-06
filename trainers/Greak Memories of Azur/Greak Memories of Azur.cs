using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Globalization;
using Memory;


namespace GameTrainers.trainers.Greak_Memories_of_Azur
{
    public partial class Greak_Memories_of_Azur : Form
    {



        [DllImport("kernel32.dll")]
        static extern bool ReadProcessMemory(IntPtr handle, IntPtr addy, byte[] buffer, int size, ref int bytesRead);

        bool AoBactive = false;

        public string returnValue;

        Mem m = new Mem();
        public float AppVersion = 0.01f;

        public string savePath = Application.StartupPath + @"\\savelocations.txt";

        bool ProcOpen = false;


        public Greak_Memories_of_Azur()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            //Aobscanner(searchAoB);


        }

        public void bgworker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (!m.OpenProcess("Greak Memories of Azur"))
                {
                    Thread.Sleep(1000);
                    continue;
                }

                ProcOpen = true;


                if (cb_onehithill.Checked)
                {
                    //Aobscanner(searchAoB);
                    //m.WriteMemory(lbl_AoBAddy.Text, "bytes", searchAoB);
                }
  

                Thread.Sleep(1000);
                bgworker.ReportProgress(0);
            }
        }

        public void bgworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                lbl_process.Text = "Trainer Loaded";
            }

            if (!cb_onehithill.Checked)
            {
                AoBactive = false;
                //m.WriteMemory(lbl_AoBAddy.Text, "bytes", searchAoB);
            }

            if (cb_jump.Checked)
            {
                Aobscanner(aobs.greakJump_Org);
                //m.WriteMemory(returnValue, "bytes", greakJump_aob);
                //MessageBox.Show(returnValue);
            }
            else
            {
                //Aobscanner(aobs.greakJump_aob);
                //m.WriteMemory(returnValue, "bytes", greakJump_Org);
                //MessageBox.Show(returnValue);
            }
        }

        public void bgworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgworker.RunWorkerAsync();
        }


        private void Greak_Memories_of_Azur_Load(object sender, EventArgs e)
        {
            bgworker.RunWorkerAsync();
        }

        public void Aobscanner(string _findAob) //string[] args
        {
            Process proc = Process.GetProcessesByName("Greak Memories of Azur")[0];

            byte[] buffer = new byte[proc.MainModule.ModuleMemorySize];

            int bytesread = 0;

            ReadProcessMemory(proc.Handle, proc.MainModule.BaseAddress, buffer, buffer.Length, ref bytesread); // might require openprocess, idk 
            string signature = _findAob;
            var addy = sigscan(signature);
            returnValue = addy[0].ToString("X");
            
            //lbl_AoBAddy.Text = returnValue;
            MessageBox.Show(returnValue);


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
