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
    public partial class Habilis : Form
    {
        public Habilis()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            Habilitation_Electrique fs = new Habilitation_Electrique();
            fs.Show();
           // fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Armoire fs = new Armoire();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pupitre fs = new Pupitre();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Malaxeur fs = new Malaxeur();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void Habilis_Load(object sender, EventArgs e)
        {

        }
    }
}
