﻿using System;
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
    public partial class Q3Form : Form
    {
        string text;
        public Q3Form()
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

        private void Q3Form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (text == "FOLIO 004")
            {
                FOLIO004 fra = new FOLIO004();
                fra.Size = new Size(1070, 660);
                fra.Show();
                this.Hide();
            }
            if (text == "FOLIO 007")
            {
                FOLIO007 fr = new FOLIO007();
                fr.Size = new Size(1070, 660);
                fr.Show();
                this.Hide();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            text = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.Constituants_de_protection_Sectionneurs);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }
    }
}