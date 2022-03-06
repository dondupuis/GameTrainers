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

namespace GameTrainers.trainers.AssultCube
{
    public partial class ac_client : Form
    {

        [DllImport("kernel32.dll")]
        static extern bool ReadProcessMemory(IntPtr handle, IntPtr addy, byte[] buffer, int size, ref int bytesRead);

        bool AoBactive = false;

        public string returnValue;

        Mem m = new Mem();
        public float AppVersion = 0.01f;

        public string savePath = Application.StartupPath + @"\\savelocations.txt";

        bool ProcOpen = false;
        public ac_client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }

        private void ac_client_Load(object sender, EventArgs e)
        {
            bgworker.RunWorkerAsync();
        }

        public void bgworker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (!m.OpenProcess("ac_client"))
                {
                    Thread.Sleep(1000);
                    continue;
                }

                ProcOpen = true;


            }

            Thread.Sleep(1000);
            bgworker.ReportProgress(0);
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
            bgworker.RunWorkerAsync();

        }


    }
}