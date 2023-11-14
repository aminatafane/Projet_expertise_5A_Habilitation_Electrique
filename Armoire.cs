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
    public partial class Armoire : Form
    {
        public Armoire()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Habilis fs = new Habilis();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Q1Form fs = new Q1Form();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            KAForm fs = new KAForm();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Q10Form fs = new Q10Form();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Q2Form fs = new Q2Form();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Q3Form fs = new Q3Form();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            KM1Form fs = new KM1Form();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            KM2122Form fs = new KM2122Form();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            KM3Form fs = new KM3Form();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            A10Form fs = new A10Form();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            F2Form fs = new F2Form();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }
    }
}
