using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projet_expertise_5A_Habilitation_Electrique
{
    public partial class TacheBR : Form
    {
        public TacheBR()
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

        private void button1_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.BR_Tache_T1);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.BR_Tache_T2);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.BR_Tache_T3);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.BR_Tache_T4);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.BR_Tache_T5);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.BR_Tache_T6);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.BR_Tache_T7);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void TacheBR_Load(object sender, EventArgs e)
        {

        }
    }
}
