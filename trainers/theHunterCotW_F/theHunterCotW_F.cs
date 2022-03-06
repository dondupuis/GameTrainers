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
using GameTrainers;

namespace GameTrainers.trainers.theHunterCotW_F
{
    public partial class theHunterCotW_F : Form
    {
        //aobs gt_aob = new aobs();

        [DllImport("kernel32.dll")]
        static extern bool ReadProcessMemory(IntPtr handle, IntPtr addy, byte[] buffer, int size, ref int bytesRead);

        bool AoBactive = false;
        bool displayed = false;

        public string returnValue;

        Mem m = new Mem();
        public float AppVersion = 0.01f;
        bool ProcOpen = false;
        public Array skills;

        public theHunterCotW_F()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void theHunterCotW_F_Load(object sender, EventArgs e)
        {
            bgworker.RunWorkerAsync();

        }

        private void bgworker_DoWork(object sender, DoWorkEventArgs e)
        {
   

            while (true)
            {
                if (!m.OpenProcess("theHunterCotW_F"))
                {
                    Thread.Sleep(1000);
                    continue;
                }


                ProcOpen = true;

                float strlevel = m.ReadInt("theHunterCotW_F.exe+212A788,2D4");
                tb_level.Text = strlevel.ToString();

                float strxp = m.ReadInt("theHunterCotW_F.exe+212A788,2D8");
                tb_xp.Text = strxp.ToString();

                float strskillpoints = m.ReadInt("theHunterCotW_F.exe+212A788,2DC");
                tb_skillpoints.Text = strskillpoints.ToString();

                float strperkpoints = m.ReadInt("theHunterCotW_F.exe+212A788,2E0");
                tb_perkpoints.Text = strperkpoints.ToString();



             

                if (cb_onehitkill.Checked)
                {
                    lbl_searchAobonehitkill.Text = aobs.OneHitKill_Org;
                    string rv_onehitkill = returnValue;
                    lbl_onehitkillAoBAddy.Text = rv_onehitkill;
                    Aobscanner(aobs.OneHitKill_Org);


                    m.WriteMemory(rv_onehitkill, "bytes", aobs.OneHitKill_aob, "");

                }
                if (cb_scarednomove.Checked)
                {
                    lbl_searchAobscarednomove.Text = aobs.ScaredNoMove_Org;
                    string rv_scarednomove = returnValue;
                    lbl_scarednomoveAoBAddy.Text = rv_scarednomove;
                    Aobscanner(aobs.ScaredNoMove_Org);


                }
                if (cb_keeneyetimer.Checked)
                {
                    lbl_searchAobkeeneyetimer.Text = aobs.KeenEyeTimer_aob;
                    string rv_keeneyetimer = returnValue;
                    lbl_keeneyetimerAoBAddy.Text = rv_keeneyetimer;

                    Aobscanner(aobs.KeenEyeTimer_Org);
                }
                if (cb_keeneyedistance.Checked)
                {
                    lbl_searchAobkeeneyedistance.Text = aobs.KeenEyeDistance_aob;
                    string rv_keeneyedistance = returnValue;
                    //lbl_keeneyedistanceAoBAddy.Text = rv_keeneyedistance;
                    lbl_keeneyedistanceAoBAddy.Text = m.ReadInt(rv_keeneyedistance).ToString();

                    Aobscanner(aobs.KeenEyeDistance_Org);
                }

                if (cb_nodamage.Checked)
                {
                    m.WriteMemory("CrashRpt1403.dll+00019190,248,5A0,178,60,10,118,218", "int", "1150", "");
                }
                if (cb_unlmoney.Checked)
                {
                    m.WriteMemory("theHunterCotW_F.exe+212A788,368", "int", "99999999", "");
                }



                Thread.Sleep(1000);
                bgworker.ReportProgress(0);
            }
        }

        private void bgworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                lbl_process.Text = "Trainer Loaded";
            }

        }

        private void bgworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgworker.RunWorkerAsync();
        }




        public void Aobscanner(string _findAob) //string[] args
        {
            Process proc = Process.GetProcessesByName("theHunterCotW_F")[0];

            byte[] buffer = new byte[proc.MainModule.ModuleMemorySize];

            int bytesread = 0;

            ReadProcessMemory(proc.Handle, proc.MainModule.BaseAddress, buffer, buffer.Length, ref bytesread); // might require openprocess, idk 
            string signature = _findAob;
            var addy = sigscan(signature);
            returnValue = addy[0].ToString("X");
            //lbl_AoBAddy.Text = returnValue;


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

        private void cb_onehitkill_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb_onehitkill.Checked)
            {
                lbl_searchAobonehitkill.Text = aobs.OneHitKill_Org;
                string rv_onehitkill = returnValue;
                lbl_onehitkillAoBAddy.Text = rv_onehitkill;
                Aobscanner(aobs.OneHitKill_Org);

                m.WriteMemory(rv_onehitkill, "bytes", aobs.OneHitKill_Org, "");
            }
        }
    }
}
