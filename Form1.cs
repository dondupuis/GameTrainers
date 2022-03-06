using System.ComponentModel;
using System.Diagnostics;
using Memory;
using System.Net;
using System;
using System.Text;

//Trainer Files
using GameTrainers.trainers.FarmingSimulator2019Game;
using GameTrainers.trainers.JDGame_Win64_Shipping;
using GameTrainers.trainers.theHunterCotW_F;
using GameTrainers.trainers.TheInfected_Win64_Shipping;
using GameTrainers.trainers.Cristales;
using GameTrainers.trainers.Greak_Memories_of_Azur;
using GameTrainers.trainers.DrugDealerSimulator_Win64_Shipping;
using GameTrainers.trainers.AssultCube;



namespace GameTrainers
{
    public partial class Form1 : Form
    {
        //Load the Trainers from array
        AvailableTrainers atc = new AvailableTrainers();
        //Load Memory.dll
        Mem m = new Mem();

        public string LOADTRAINER = "";
        public float AppVersion = 0.0461f;
        public Process[] processlist;
        public string savePath = Application.StartupPath + @"\\savelocations.txt";
        bool ProcOpen = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_version.Text = AppVersion.ToString();
            processlist = Process.GetProcesses();
            lbl_trainerCount.Text = atc.availibleTrainers.Length.ToString();

            ProcOpen = true;
            CheckForUpdate("https://github.com/dondupuis/GameTrainers/blob/main/currentversion");


            foreach (string trainer in atc.availibleTrainers)
            {
                foreach (Process process in processlist)
                {
                    if (process.ProcessName == trainer)
                    {
                        cb_games.Items.Add(trainer);
                        LOADTRAINER = trainer;
                        cb_games.SelectedItem = LOADTRAINER;
                    }
                }
            }
        }

        private void btn_launch_Click(object sender, EventArgs e)
        {
            switch (LOADTRAINER)
            {
                case "theHunterCotW_F":
                    theHunterCotW_F cotW_F = new theHunterCotW_F();
                    cotW_F.ShowDialog();
                    break;

                case "TheInfected-Win64-Shipping":
                    TheInfected_Win64_Shipping theInfected_Win64_ = new TheInfected_Win64_Shipping();
                    theInfected_Win64_.ShowDialog();
                    break;

                case "FarmingSimulator2019Game":
                    FarmingSimulator2019Game farmingSimulator2019 = new FarmingSimulator2019Game();
                    farmingSimulator2019.ShowDialog();
                    break;

                case "JDGame-Win64-Shipping":
                    JDGame_Win64_Shipping jDGame_Win64_ = new JDGame_Win64_Shipping();
                    jDGame_Win64_.ShowDialog();
                    break;

                case "Cristales":
                    Cristales cristales = new Cristales();
                    cristales.ShowDialog();
                    break;

                case "Greak Memories of Azur":
                    Greak_Memories_of_Azur _Memories_Of_Azur = new Greak_Memories_of_Azur();
                    _Memories_Of_Azur.ShowDialog();
                    break;

                case "DrugDealerSimulator-Win64-Shipping":
                    DrugDealerSimulator_Win64_Shipping drugDealerSimulator_ = new DrugDealerSimulator_Win64_Shipping();
                    drugDealerSimulator_.ShowDialog();
                    break;

                case "ac_client":
                    ac_client ac_Client = new ac_client();
                    ac_Client.ShowDialog();
                    break;

                    default:
                    break;
            }
        }
        public static void CheckForUpdate(string _url)
        {
            //WebClient wc = new WebClient();
            //byte[] data = wc.DownloadData(_url);
            //string body = Encoding.ASCII.GetString(data);
            //string header = wc.ResponseHeaders.ToString();

            //<td id="LC1" class="blob-code blob-code-inner js-file-line">0.0461</td>
            //MessageBox.Show(body);
        }

        private void bgworker_DoWork(object sender, DoWorkEventArgs e)
        {

            while (true)
            {


                Thread.Sleep(1000);
                bgworker.ReportProgress(0);
            }
        }

        private void bgworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                //lbl_process.Text = "Trainer Loaded";
            }
        }

        private void bgworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgworker.RunWorkerAsync();
        }

        private void lbl_trainersshow_Click_1(object sender, EventArgs e)
        {
            Trainers trainers = new Trainers();
            trainers.ShowDialog();
        }






    }
}