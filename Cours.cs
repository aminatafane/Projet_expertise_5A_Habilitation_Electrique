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
    public partial class Cours : Form
    {
        public Cours()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Habilitation_Electrique fs = new Habilitation_Electrique();
            fs.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void Cours_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create a temporal file
           // string file = Path.GetTempFileName() + ".pdf";
            //write to file
           // File.WriteAllBytes(file, Properties.Resources.chapitr1);

            //open with default viewer
           // System.Diagnostics.Process.Start(file);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //create a temporal file
           // string file = Path.GetTempFileName() + ".pdf";
            //write to file
           // File.WriteAllBytes(file, Properties.Resources.chap3);

            //open with default viewer
           // System.Diagnostics.Process.Start(file);
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            Habilitation_Electrique fs = new Habilitation_Electrique();
            fs.Show();
            this.Hide();
        }
    }
}
