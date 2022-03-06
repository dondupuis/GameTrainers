using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTrainers
{
    public partial class Trainers : Form
    {

        Form1 frm1 = new Form1();
        AvailableTrainers atc = new AvailableTrainers();

        public Trainers()
        {
            InitializeComponent();
        }

        private void Trainers_Load(object sender, EventArgs e)
        {
            foreach (string trainer in atc.availibleTrainers)
            {
                lb_trainerlist.Items.Add(trainer);
            }
        }
    }
}
