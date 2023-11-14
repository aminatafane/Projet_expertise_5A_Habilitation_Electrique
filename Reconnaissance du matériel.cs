using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projet_expertise_5A_Habilitation_Electrique
{
    public partial class Reconnaissance_du_matériel : Form


    {
        string Title;
        string note;
        string notee;
        string nom;
        string nomm;
        string prenom;
        string prenomm;
        string tex1;
        string tex11;
        string ans11;
        string tex12;
        string ans12;
        string tex13;
        string ans13;
        string tex2;
        string tex21;
        string ans21;
        string tex22;
        string ans22;
        string tex23;
        string ans23;
        string tex24;
        string ans24;
        string tex3;
        string tex31;
        string ans31;
        string tex32;
        string ans32;
        string tex33;
        string ans33;
        string tex4;
        string tex41;
        string ans41;
        string tex42;
        string ans42;
        public Reconnaissance_du_matériel()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            prenomm = PRENOMM.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fiche_pratique fs = new Fiche_pratique();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Etude_du_schéma_électrique fo = new  Etude_du_schéma_électrique();
            fo.text00 = nom;
            fo.text01 = prenom;
            fo.text02 = Title;
            fo.text03 = note;
            fo.text04 = notee;
            fo.text05 = nomm;
            fo.text06 = prenomm;
            fo.text1 = tex1;
            fo.text11 = tex11;
            fo.text111 = ans11;
            fo.text12 = tex12;
            fo.text121 = ans12;
            fo.text13 = tex13;
            fo.text131 = ans13;
            fo.text2 = tex2;
            fo.text21 = tex21;
            fo.text211 = ans21;
            fo.text22 = tex22;
            fo.text221 = ans22;
            fo.text23 = tex23;
            fo.text231 = ans23;
            fo.text24 = tex24;
            fo.text241 = ans24;
            fo.text3 = tex3;
            fo.text31 = tex31;
            fo.text311 = ans31;
            fo.text32 = tex32;
            fo.text321 = ans32;
            fo.text33 = tex33;
            fo.text331 = ans33;
            fo.text4 = tex4;
            fo.text41 = tex41;
            fo.text411 = ans41;
            fo.text42 = tex42;
            fo.text421 = ans42;
            fo.ShowDialog();
            fo.Show();
            //fs.Size = new Size(1070, 660);
            this.Hide();
        }

        private void Reconnaissance_du_matériel_Load(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            ans42 = ANSBox42.Text;
        }

       private void QSRBox1_TextChanged(object sender, EventArgs e)
        {
            tex1 = QSTBox1.Text;
        }

        private void QSTBox11_TextChanged(object sender, EventArgs e)
        {
            tex11 = QSTBox11.Text;
        }

        private void QSTBox12_TextChanged(object sender, EventArgs e)
        {
            tex12 = QSTBox12.Text;
        }

        private void QSTBox13_TextChanged(object sender, EventArgs e)
        {
            tex13 = QSTBox13.Text;
        }

        private void QSTBox2_TextChanged(object sender, EventArgs e)
        {
            tex2 = QSTBox2.Text;
        }

        private void QSTBox21_TextChanged(object sender, EventArgs e)
        {
            tex21 = QSTBox21.Text;
        }

        private void QSTBox22_TextChanged(object sender, EventArgs e)
        {
            tex22 = QSTBox22.Text;
        }

        private void QSTBox23_TextChanged(object sender, EventArgs e)
        {
            tex23 = QSTBox23.Text;
        }

        private void QSTBox24_TextChanged(object sender, EventArgs e)
        {
            tex24 = QSTBox24.Text;
        }

        private void ASTBox3_TextChanged(object sender, EventArgs e)
        {
            tex3 = QSTBox3.Text;
        }

        private void QSTBox31_TextChanged(object sender, EventArgs e)
        {
            tex31 = QSTBox31.Text;
        }

        private void QSTBox32_TextChanged(object sender, EventArgs e)
        {
            tex32 = QSTBox32.Text;
        }

        private void QSTBox33_TextChanged(object sender, EventArgs e)
        {
            tex33 = QSTBox33.Text;
        }

        private void QSTBox4_TextChanged(object sender, EventArgs e)
        {
            tex4 = QSTBox4.Text;
        }

        private void QSTBox41_TextChanged(object sender, EventArgs e)
        {
            tex41 = QSTBox41.Text;
        }

        private void QSTBox42_TextChanged(object sender, EventArgs e)
        {
            tex42 = QSTBox42.Text;
        }

        private void NOM_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PRENOM_TextChanged(object sender, EventArgs e)
        {
            prenom = PRENOM.Text;
        }

        private void NOTE_TextChanged(object sender, EventArgs e)
        {
            note = NOTE.Text;
        }

        private void ANSBox11_TextChanged(object sender, EventArgs e)
        {
            ans11 = ANSBox11.Text;
        }

        private void ANSBox12_TextChanged(object sender, EventArgs e)
        {
            ans12 = ANSBox12.Text;
        }

        private void ANSBox13_TextChanged(object sender, EventArgs e)
        {
            ans13 = ANSBox13.Text;
        }

        private void ANSBox21_TextChanged(object sender, EventArgs e)
        {
            ans21 = ANSBox21.Text;
        }

        private void ANSBox22_TextChanged(object sender, EventArgs e)
        {
            ans22 = ANSBox22.Text;
        }

        private void ANSBox23_TextChanged(object sender, EventArgs e)
        {
            ans23 = ANSBox23.Text;
        }

        private void ANSBox24_TextChanged(object sender, EventArgs e)
        {
            ans24 = ANSBox24.Text;
        }

        private void ANSBox31_TextChanged(object sender, EventArgs e)
        {
            ans31 = ANSBox31.Text;
        }

        private void ANSBox32_TextChanged(object sender, EventArgs e)
        {
            ans32 = ANSBox32.Text;
        }

        private void ANSBox33_TextChanged(object sender, EventArgs e)
        {
            ans33 = ANSBox33.Text;
        }

        private void ANSBox41_TextChanged(object sender, EventArgs e)
        {
            ans41 = ANSBox41.Text;
        }

        private void TITRE_TextChanged(object sender, EventArgs e)
        {
            Title = TITRE.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Fiche_pratique fs = new Fiche_pratique();
            fs.Show();
            fs.Size = new Size(1070, 660);
            this.Hide();
        }
    }
}
