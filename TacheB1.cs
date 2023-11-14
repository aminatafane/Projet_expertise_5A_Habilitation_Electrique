using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projet_expertise_5A_Habilitation_Electrique
{
    public partial class TacheB1 : Form
    {
        public TacheB1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Fiche_pratique fs = new Fiche_pratique();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.B1V_Tache_T2);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.B1V_Tache_T1);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.B1V_Tache_T3);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.B1V_Tache_T4);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void TacheB1_Load(object sender, EventArgs e)
        {

        }
    }
}
