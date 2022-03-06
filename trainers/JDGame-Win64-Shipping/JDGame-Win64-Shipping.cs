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

namespace GameTrainers.trainers.JDGame_Win64_Shipping
{

  
    public partial class JDGame_Win64_Shipping : Form
    {
  
        [DllImport("kernel32.dll")]
        static extern bool ReadProcessMemory(IntPtr handle, IntPtr addy, byte[] buffer, int size, ref int bytesRead);
        
        bool AoBactive = false;

        public string returnValue;

        Mem m = new Mem();
        public float AppVersion = 0.01f;

        public string savePath = Application.StartupPath + @"\\savelocations.txt";

        bool ProcOpen = false;
 


        public JDGame_Win64_Shipping()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            lbl_searchAob.Text = aobs.infAmmo_Org;
            //Aobscanner(searchAoB);
            if (lbl_searchAob.Text == aobs.infAmmo_Org)
            {
                Aobscanner(aobs.infAmmo_Org);

            }
            else
            {
                Aobscanner(aobs.infAmmo_aob);
            }

        }

        public void bgworker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (!m.OpenProcess("JDGame-Win64-Shipping"))
                {
                    Thread.Sleep(1000);
                    continue;
                }

                ProcOpen = true;


                if (cb_enableAob.Checked)
                {
                    //Aobscanner(searchAoB);
                    if (lbl_searchAob.Text == aobs.infAmmo_Org)
                    {
                        Aobscanner(aobs.infAmmo_Org);

                    }
                    else
                    {
                        Aobscanner(aobs.infAmmo_aob);
                    }

                    //lbl_searchAob.Text = searchAoB;
                    //JDGame-Win64-Shipping.UJDAmmoComponent::UpdateAmmo+37 - 89 8B B8 00 00 00
                    AoBactive = true;

                    if (lbl_AoBAddy.Text != "")
                    {
                        m.WriteMemory(lbl_AoBAddy.Text, "bytes", aobs.infAmmo_aob);
                        lbl_searchAob.Text = aobs.infAmmo_aob;
                    }
                    else if(!cb_enableAob.Checked)
                    {
                        AoBactive = false;
                        m.WriteMemory(lbl_AoBAddy.Text, "bytes", aobs.infAmmo_Org);
                    }
                    

                }

                Thread.Sleep(1000);
                bgworkerer.ReportProgress(0);
            }
        }

        public void bgworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                lbl_process.Text = "Trainer Loaded";
            }
        }

        public void bgworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgworkerer.RunWorkerAsync();
        }

        public void JDGame_Win64_Shipping_Load(object sender, EventArgs e)
        {
            bgworkerer.RunWorkerAsync();
        }

        // =====================


        public void Aobscanner(string _findAob) //string[] args
        {
            Process proc = Process.GetProcessesByName("JDGame-Win64-Shipping")[0];

            byte[] buffer = new byte[proc.MainModule.ModuleMemorySize];

            int bytesread = 0;

            ReadProcessMemory(proc.Handle, proc.MainModule.BaseAddress, buffer, buffer.Length, ref bytesread); // might require openprocess, idk 
            string signature = _findAob;
            var addy = sigscan(signature);
            returnValue = addy[0].ToString("X");
            lbl_AoBAddy.Text = returnValue;

         
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

        private void cb_enableAob_CheckedChanged(object sender, EventArgs e)
        {
            //Aobscanner(searchAoB);
            //lbl_searchAob.Text = searchAoB;
            if (lbl_searchAob.Text == aobs.infAmmo_Org)
            {
                Aobscanner(aobs.infAmmo_Org);

            }
            else
            {
                Aobscanner(aobs.infAmmo_aob);
            }
           

            if (cb_enableAob.Checked)
            {
                AoBactive = true;
                m.WriteMemory(lbl_AoBAddy.Text, "bytes", aobs.infAmmo_aob);
                lbl_searchAob.Text = aobs.infAmmo_aob;
            }
            else if(!cb_enableAob.Checked)
            {
                AoBactive = false;
                m.WriteMemory(lbl_AoBAddy.Text, "bytes", aobs.infAmmo_Org);
                lbl_searchAob.Text = aobs.infAmmo_Org;
            }
        }
    }
}
