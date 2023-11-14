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
    public partial class Q1Form : Form
    {
        public Q1Form()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Armoire fs = new Armoire();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void Q1Form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FOLIO003 fra = new FOLIO003();
            fra.Size = new Size(1070, 660);
            fra.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.Disjoncteurs_Compact_NS100_à_NS630);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }
    }
}
