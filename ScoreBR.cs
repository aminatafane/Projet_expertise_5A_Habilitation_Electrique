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
    public partial class ScoreBR : Form
    {

        public int Resultat_BR;
        int percentage;
        public ScoreBR()
        {
            InitializeComponent();
        }

        void resultat(int sum, int percentage)
        {
           // TextResultB1.Text = "Test terminé!";//+ Environment.NewLine +
            TextScoreB1.Text = "Score: " + sum + " ";// "  questions correctes." + Environment.NewLine +
            TextPourcentageB1.Text = "Pourcentage total  : " + percentage + "%";

            if (percentage > 50)
            {
                textResultat.Text = "Valider ";
            }//   "Cliquer Ok pour répéter le quiz!";
            else
            {
                textResultat.Text = "Echouer ";
            }
        }
        private void ScoreBR_Load(object sender, EventArgs e)
        {
            percentage = (int)Math.Round((double)(Resultat_BR * 100) / 44);
            resultat(Resultat_BR, percentage);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Habilitation_Electrique fati = new Habilitation_Electrique();
            fati.Show();
            this.Hide();
        }
    }
}
