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
    public partial class Fiche_pratique : Form
    {
        public Fiche_pratique()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Habilitation_Electrique fs = new Habilitation_Electrique();
            fs.Show();
           // fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TacheB0 fs = new TacheB0();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            TacheB1 fs = new TacheB1();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            TacheB2 fs = new TacheB2();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            TacheBC fs = new TacheBC();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            TacheBR fs = new TacheBR();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reconnaissance_du_matériel fs = new Reconnaissance_du_matériel();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void Fiche_pratique_Load(object sender, EventArgs e)
        {

        }
    }
}
