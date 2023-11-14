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
using static System.Net.Mime.MediaTypeNames;

namespace Projet_expertise_5A_Habilitation_Electrique
{
     
    public partial class KAForm : Form
    {
        string text;
        public KAForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            text = comboBox1.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Armoire fs = new Armoire();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void KAForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (text == "FOLIO 003")
            {
                FOLIO003 fra = new FOLIO003();
                fra.Size = new Size(1070, 660);
                fra.Show();
                this.Hide();
            }

            if (text == "FOLIO 005")
            {
                FOLIO005 fra = new FOLIO005();
                fra.Size = new Size(1070, 660);
                fra.Show();
                this.Hide();
            }

            if (text == "FOLIO 006")
            {
                FOLIO006 fr = new FOLIO006();
                fr.Size = new Size(1070, 660);
                fr.Show();
                this.Hide();
            }
            if (text == "FOLIO 007")
            {
                FOLIO007 f = new FOLIO007();
                f.Size = new Size(1070, 660);
                f.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.Contacteurs_auxiliaires);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }
    }
}
