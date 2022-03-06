using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace GameTrainers.trainers.TheInfected_Win64_Shipping
{
    public partial class TheInfected_Win64_Shipping : Form
    {

        Mem m = new Mem();
        public float AppVersion = 0.00f;
        bool ProcOpen = false;


        public TheInfected_Win64_Shipping()
        {
            InitializeComponent();
        }

        private void TheInfected_Win64_Shipping_Load(object sender, EventArgs e)
        {
            bgworker.RunWorkerAsync();
        }

        private void bgworker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                if (!m.OpenProcess("TheInfected-Win64-Shipping"))
                {
                    Thread.Sleep(1000);
                    continue;
                }

                ProcOpen = true;


                if (cb_health.Checked)
                {
                    m.WriteMemory("TheInfected-Win64-Shipping.exe+03405658,148,0,98,98,218,18,BEC", "float", "99.99", "");
                }
                if (cb_stamina.Checked)
                {
                    m.WriteMemory("TheInfected-Win64-Shipping.exe+033E4FC0,30,298,6A8,E8,118,708,CC", "float", "49.99", "");
                }
                if (cb_hydration.Checked)
                {
                    m.WriteMemory("TheInfected-Win64-Shipping.exe+02FDA090,B00,20,798,540,A0,210,6D4", "float", "99.99", "");
                }
                if (cb_arrows.Checked)
                {
                    m.WriteMemory("TheInfected-Win64-Shipping.exe+03402AC0,20,20,940,4A8,3F0,0,368", "int", "50", "");
                }
                if (cb_energy.Checked)
                {
                    m.WriteMemory("TheInfected-Win64-Shipping.exe+033C3900,F8,840,A0,640,A0,6D0,564", "float", "99.99", "");
                }
                /*if (cb_protien.Checked)
                {
                    m.WriteMemory("TheInfected-Win64-Shipping.exe+033943B0,18,110,678,940,118,6D0,4D0", "float", "99.99", "");
                }*/
                if (cb_carbs.Checked)
                {
                    m.WriteMemory("TheInfected-Win64-Shipping.exe+033F2C30,0,20,710,A0,198,210,758", "float", "99.99", "");
                }
                /*if (cb_fat.Checked)
                {
                    m.WriteMemory("TheInfected-Win64-Shipping.exe+02FDA090,B00,20,50,700,2E0,438,15C", "float", "99.99", "");
                }*/
                if (cb_vitamins.Checked)
                {
                    m.WriteMemory("TheInfected-Win64-Shipping.exe+033E4A18,0,A0,50,6B0,20,6CB,760", "float", "99.99", "");
                }
                /*if (cb_plus1tosun.Checked)
                {
                    m.WriteMemory("TheInfected-Win64-Shipping.exe+02FDA090,B30,20,468,640,20,6D0,5AC", "float", "99.99", "");
                }*/
                if (cb_nobackpackweight.Checked)
                {
                    m.WriteMemory("TheInfected-Win64-Shipping.exe+02FDA090,AD0,8B0,8,20,50,C0C", "int", "1", "");
                }

                Thread.Sleep(1000);
                bgworker.ReportProgress(0);
            }
        }
        private void bgworker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                lbl_process.Text = "Trainer Loaded";
            }
        }

        private void bgworker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            bgworker.RunWorkerAsync();
        }

        public string line = "";


    }
}
