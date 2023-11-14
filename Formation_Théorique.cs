using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_expertise_5A_Habilitation_Electrique
{
    public partial class Formation_Théorique : Form
    {
        public Formation_Théorique()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestB0 fati = new TestB0();
            fati.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Habilitation_Electrique fati = new Habilitation_Electrique();
            fati.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            TestBR fati = new TestBR();
            fati.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            TestB1 fati = new TestB1();
            fati.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            TestB2 fati = new TestB2();
            fati.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            TestBC fati = new TestBC();
            fati.Show();
            this.Hide();
        }
    }
}
