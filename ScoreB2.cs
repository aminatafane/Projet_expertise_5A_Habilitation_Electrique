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
    public partial class ScoreB2 : Form
    {

        public int Resultat_B2;
        int percentage;
        public ScoreB2()
        {
            InitializeComponent();
        }

        void resultat(int sum, int percentage)
        {
            //TextResultB1.Text = "Test terminé!";//+ Environment.NewLine +
            TextScoreB1.Text = " " + sum + " ";// "  questions correctes." + Environment.NewLine +
            TextPourcentageB1.Text = " " + percentage + "%";// + Environment.NewLine +
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
        private void ScoreB2_Load(object sender, EventArgs e)
        {
            percentage = (int)Math.Round((double)(Resultat_B2 * 100) / 43);
            resultat(Resultat_B2, percentage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Habilitation_Electrique fati = new Habilitation_Electrique();
            fati.Show();
            this.Hide();
        }
    }
}
