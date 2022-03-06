using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTrainers.trainers.FarmingSimulator2019Game
{
    public partial class FarmingSimulator2019Game : Form
    {

        Mem m = new Mem();
        public float AppVersion = 0.0f;

        public string savePath = Application.StartupPath + @"\\savelocations.txt";

        bool ProcOpen = false;


        public FarmingSimulator2019Game()
        {
            InitializeComponent();
        }
        private void bgworker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (!m.OpenProcess("FarmingSimulator2019Game"))
                {
                    Thread.Sleep(1000);
                    continue;
                }

                ProcOpen = true;

                if (cb_unlmoney.Checked)
                {
                    m.WriteMemory("FarmingSimulator2019Game.exe+00AA3D10,60,258,70,38,98,0,7C8", "double", "500000000", "");
                }

                /*
                if (cb_bandages.Checked)
                {
                    //m.WriteMemory("game.exe+", "float", "99.99", "");
                }
  
                */
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

        public string line = "";

        private void FarmingSimulator2019Game_Load(object sender, EventArgs e)
        {
            bgworker.RunWorkerAsync();
        }
    }
}
