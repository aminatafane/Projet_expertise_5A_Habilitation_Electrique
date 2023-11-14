using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Path = System.IO.Path;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Projet_expertise_5A_Habilitation_Electrique
{
    public partial class Etude_du_schéma_électrique : Form
    {

        public String text00;
        public String text01;
        public String text02;
        public String text03;
        public String text04;
        public String text05;
        public String text06;
        public String text1;
        public string text11;
        public string text111;
        public String text12;
        public string text121;
        public string text13;
        public string text131;
        public String text2;
        public string text21;
        public string text211;
        public String text22;
        public string text221;
        public string text23;
        public string text231;
        public String text24;
        public string text241;
        public string text3;
        public String text31;
        public string text311;
        public string text32;
        public string text321;
        public String text33;
        public string text331;
        public string text4;
        public String text41;
        public string text411;
        public string text42;
        public string text421;
        public Etude_du_schéma_électrique()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GeneratePDF();
        }

        public void GeneratePDF()
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "choisir l'emplacement du fichier";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Reconnaissance générale.pdf";
            sfd.FileName = "Reconnaissance générale.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string strPath = sfd.FileName;
                if (Path.GetExtension(sfd.FileName).ToLower() != ".pdf")
                {
                    strPath += ".pdf";
                }




                //string outFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/fiche de formation.pdf";



                // création du fiche

                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(strPath, FileMode.Create));
                doc.Open();

                // palette de couleur

                BaseColor black = new BaseColor(0, 75, 155);
                BaseColor gris = new BaseColor(240, 240, 240);
                BaseColor blanc = new BaseColor(255, 255, 255);

                // police d'écriture

                Font policeTitre = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14f, iTextSharp.text.Font.BOLD, black);
                Font policeTh = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, iTextSharp.text.Font.BOLD, gris);
                //Font policeTh = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, 1, gris);


                // page pdf
                // remplir zone de txt


                Paragraph p1 = new Paragraph(" NOTE " + text03);
                p1.Alignment = Element.ALIGN_RIGHT;
                doc.Add(p1);


                Paragraph p2 = new Paragraph(" / " + text04);
                p2.Alignment = Element.ALIGN_RIGHT;
                doc.Add(p2);


                Paragraph p3 = new Paragraph(" NOM :     " + text05);
                p3.Alignment = Element.ALIGN_LEFT;
                doc.Add(p3);
                Paragraph p4 = new Paragraph("PRENOM :    " + text06);
                p4.Alignment = Element.ALIGN_LEFT;
                doc.Add(p4);




                Paragraph p5 = new Paragraph("Reconnaissance du matériel ", policeTitre);
                p5.Alignment = Element.ALIGN_CENTER;
                doc.Add(p5);



                Paragraph p6 = new Paragraph("1. Identifier puis examiner les trois parties fondamentales suivante:\r\n " + text1);
                p6.Alignment = Element.ALIGN_LEFT;
                doc.Add(p6);
                Paragraph p7 = new Paragraph("- Le pupitre d'automatisme " + text11);
                p7.Alignment = Element.ALIGN_LEFT;
                doc.Add(p7);

                Paragraph p8 = new Paragraph(" " + text111);
                p8.Alignment = Element.ALIGN_LEFT;
                doc.Add(p8);

                Paragraph p9 = new Paragraph("- La partie opérative  " + text12);
                p9.Alignment = Element.ALIGN_LEFT;
                doc.Add(p9);

                Paragraph p10 = new Paragraph("  " + text121);
                p10.Alignment = Element.ALIGN_LEFT;
                doc.Add(p10);


                Paragraph p11 = new Paragraph("- L'armoire électrique " + text13);
                p11.Alignment = Element.ALIGN_LEFT;
                doc.Add(p11);

                Paragraph p12 = new Paragraph(" " + text131);
                p12.Alignment = Element.ALIGN_LEFT;
                doc.Add(p12);

                Paragraph p13 = new Paragraph("2. Localiser au niveau de la partie opérative: " + text2);
                p13.Alignment = Element.ALIGN_LEFT;
                doc.Add(p13);


                Paragraph p14 = new Paragraph("- Le moteur de malaxage  " + text21);
                p14.Alignment = Element.ALIGN_LEFT;
                doc.Add(p14);

                Paragraph p15 = new Paragraph(" " + text211);
                p15.Alignment = Element.ALIGN_LEFT;
                doc.Add(p15);

                Paragraph p16 = new Paragraph("- Le moteur du couvercle  " + text22);
                p16.Alignment = Element.ALIGN_LEFT;
                doc.Add(p16);

                Paragraph p17 = new Paragraph(" " + text221);
                p17.Alignment = Element.ALIGN_LEFT;
                doc.Add(p17);

                Paragraph p18 = new Paragraph("- Les capteurs suivants: position pâle, niveau produit et thermo-rupteur\r\n " + text23);
                p18.Alignment = Element.ALIGN_LEFT;
                doc.Add(p18);

                Paragraph p19 = new Paragraph("  " + text231);
                p19.Alignment = Element.ALIGN_LEFT;
                doc.Add(p19);

                Paragraph p20 = new Paragraph("- Les différents boutons de commande et voyants de signalisation\r\n\r\n  " + text24);
                p20.Alignment = Element.ALIGN_LEFT;
                doc.Add(p20);

                Paragraph p21 = new Paragraph("   " + text241);
                p21.Alignment = Element.ALIGN_LEFT;
                doc.Add(p21);

                Paragraph p22 = new Paragraph("3. Localiser au niveau du pupitre:  " + text3);
                p22.Alignment = Element.ALIGN_LEFT;
                doc.Add(p22);

                Paragraph p23 = new Paragraph(" - L'automate programmable: type, module d'E/S , alimentation   " + text31);
                p23.Alignment = Element.ALIGN_LEFT;
                doc.Add(p23);

                Paragraph p24 = new Paragraph("   " + text311);
                p24.Alignment = Element.ALIGN_LEFT;
                doc.Add(p24);

                Paragraph p25 = new Paragraph(" - Le terminale de dialogue  " + text32);
                p25.Alignment = Element.ALIGN_LEFT;
                doc.Add(p25);

                Paragraph p26 = new Paragraph("   " + text321);
                p26.Alignment = Element.ALIGN_LEFT;
                doc.Add(p26);

                Paragraph p27 = new Paragraph(" - Les différents boutons de commande et voyants de signalisation\r\n\r\n  " + text33);
                p27.Alignment = Element.ALIGN_LEFT;
                doc.Add(p27);

                Paragraph p28 = new Paragraph("   " + text331);
                p28.Alignment = Element.ALIGN_LEFT;
                doc.Add(p28);


                Paragraph p29 = new Paragraph(" 4. Localiser et définir le rôle des élement de l'armoire électrique suivants (FOLIO 003):\r\n  " + text4);
                p29.Alignment = Element.ALIGN_LEFT;
                doc.Add(p29);


                Paragraph p30 = new Paragraph(" - Q0, Q1, T1, S0, L , SA0, S10, H01, H02, H03, H10 et H11\r\n  " + text41);
                p30.Alignment = Element.ALIGN_LEFT;
                doc.Add(p30);


                Paragraph p31 = new Paragraph("    " + text411);
                p31.Alignment = Element.ALIGN_LEFT;
                doc.Add(p31);

                Paragraph p32 = new Paragraph("- Les différents circuits de puissance du malaxeur, du couvercle et du chauffage. \r\nDécrire les différents constituants    " + text42);
                p32.Alignment = Element.ALIGN_LEFT;
                doc.Add(p32);


                Paragraph p33 = new Paragraph("    " + text411);
                p33.Alignment = Element.ALIGN_LEFT;
                doc.Add(p33);

                Paragraph p34 = new Paragraph("    " + TITRE1.Text);
                p34.Alignment = Element.ALIGN_CENTER;
                doc.Add(p34);

                Paragraph p35 = new Paragraph("    " + QSTBox5.Text);
                p35.Alignment = Element.ALIGN_LEFT;
                doc.Add(p35);
                Paragraph p36 = new Paragraph("    " + ANSBox5.Text);
                p36.Alignment = Element.ALIGN_LEFT;
                doc.Add(p36);
                Paragraph p37 = new Paragraph("    " + QSTBox6.Text);
                p37.Alignment = Element.ALIGN_LEFT;
                doc.Add(p37);
                Paragraph p38 = new Paragraph("    " + ANSBox6.Text);
                p38.Alignment = Element.ALIGN_LEFT;
                doc.Add(p38);
                Paragraph p39 = new Paragraph("    " + QSTBox7.Text);
                p39.Alignment = Element.ALIGN_LEFT;
                doc.Add(p39);
                Paragraph p40 = new Paragraph("    " + ANSBox7.Text);
                p40.Alignment = Element.ALIGN_LEFT;
                doc.Add(p40);
                Paragraph p41 = new Paragraph("    " + QSTBox8.Text);
                p41.Alignment = Element.ALIGN_LEFT;
                doc.Add(p41);
                Paragraph p42 = new Paragraph("    " + ANSBox8.Text);
                p42.Alignment = Element.ALIGN_LEFT;
                doc.Add(p42);
                Paragraph p43 = new Paragraph("    " + QSTBox9.Text);
                p43.Alignment = Element.ALIGN_LEFT;
                doc.Add(p43);
                Paragraph p44 = new Paragraph("    " + QSTBox91.Text);
                p44.Alignment = Element.ALIGN_LEFT;
                doc.Add(p44);
                Paragraph p45 = new Paragraph("    " + ANSBox91.Text);
                p45.Alignment = Element.ALIGN_LEFT;
                doc.Add(p45);
                Paragraph p46 = new Paragraph("    " + QSTBox92.Text);
                p46.Alignment = Element.ALIGN_LEFT;
                doc.Add(p46);
                Paragraph p47 = new Paragraph("    " + ANSBox92.Text);
                p47.Alignment = Element.ALIGN_LEFT;
                doc.Add(p47);
                Paragraph p48 = new Paragraph("    " + QSTBox10.Text);
                p48.Alignment = Element.ALIGN_LEFT;
                doc.Add(p48);
                Paragraph p49 = new Paragraph("    " + ANSBox10.Text);
                p49.Alignment = Element.ALIGN_LEFT;
                doc.Add(p49);
                Paragraph p50 = new Paragraph("    " + QSTBox1_1.Text);
                p50.Alignment = Element.ALIGN_LEFT;
                doc.Add(p50);
                Paragraph p51 = new Paragraph("    " + ANSBox1_1.Text);
                p51.Alignment = Element.ALIGN_LEFT;
                doc.Add(p51);
                Paragraph p52 = new Paragraph("    " + QSTBox1_2.Text);
                p52.Alignment = Element.ALIGN_LEFT;
                doc.Add(p52);
                Paragraph p53 = new Paragraph("    " + ANSBox1_2.Text);
                p53.Alignment = Element.ALIGN_LEFT;
                doc.Add(p53);
                Paragraph p54 = new Paragraph("    " + QSTBox1_3.Text);
                p54.Alignment = Element.ALIGN_LEFT;
                doc.Add(p54);
                Paragraph p55 = new Paragraph("    " + ANSBox1_3.Text);
                p55.Alignment = Element.ALIGN_LEFT;
                doc.Add(p55);
                Paragraph p56 = new Paragraph("    " + QSTBox14.Text);
                p56.Alignment = Element.ALIGN_LEFT;
                doc.Add(p56);
                Paragraph p57 = new Paragraph("    " + ANSBox14.Text);
                p57.Alignment = Element.ALIGN_LEFT;
                doc.Add(p57);
                Paragraph p58 = new Paragraph("    " + QSTBox15.Text);
                p58.Alignment = Element.ALIGN_LEFT;
                doc.Add(p58);


                Paragraph p59 = new Paragraph("    " + ANSBox15.Text);
                p59.Alignment = Element.ALIGN_LEFT;
                doc.Add(p59);


















                // fermer le document

                doc.Close();
                Process.Start(strPath);



            }

            // private void Etude_du_schéma_électrique_Load(object sender, EventArgs e)
            {
           

            }
        }
    }
}
