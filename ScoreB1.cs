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
    public partial class ScoreB1 : Form
    {
        public int Resultat;
        int percentage;
        public ScoreB1()
        {
            InitializeComponent();
        }

        void resultat(int sum, int percentage)
        {
            //TextResultB1.Text = "Test terminé!";//+ Environment.NewLine +
            TextScoreB1.Text = "  " + sum + " ";// "  questions correctes." + Environment.NewLine +
            TextPourcentageB1.Text = "  " + percentage + "%";// + Environment.NewLine +
                                                             //   "Cliquer Ok pour répéter le quiz!";

            if (percentage > 50)
            {
                textResultat.Text = "Valider ";
            }//   "Cliquer Ok pour répéter le quiz!";
            else
            {
                textResultat.Text = "Echouer ";
            }
        }

        private void ScoreB1_Load(object sender, EventArgs e)
        {
            percentage = (int)Math.Round((double)(Resultat * 100) / 31);
            resultat(Resultat, percentage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Habilitation_Electrique fati = new Habilitation_Electrique();
            fati.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textResultat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
