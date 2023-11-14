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
    public partial class TestB0 : Form
    {

        int questionNumber = 1;
        int score;
        int totalQuestions;
        public TestB0()
        {
            InitializeComponent();
            PresentQuestion(questionNumber);

            totalQuestions = 30;
        }

        void PresentQuestion(int qstNumber)
        {
            lblQuestion.Visible = true;
            txtQuestion.Visible = true;
            //grpMultipleChoice.Visible = true;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

            chkAnswer1.Checked = false;
            chkAnswer2.Checked = false;
            chkAnswer3.Checked = false;
            chkAnswer4.Checked = false;

            switch (qstNumber)
            {



                case 1:
                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASEB01;

                    lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                                      " Question 1";
                    txtQuestion.Text = "Le courant électrique est dangereux à partir d'une intensité de :";

                    chkAnswer1.Text = "5A";
                    chkAnswer2.Text = "500 mA";
                    chkAnswer3.Text = "50 mA";
                    chkAnswer4.Visible = false;

                    break;

                case 2:
                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASEB02;

                    lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                                                " Question 2";
                    txtQuestion.Text = "De votre propre initiative, pouvez-vous vous approcher d'un ouvrage électrique ?";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;

                    break;

                case 3:
                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.bt;
                    lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                                     " Question 3";

                    txtQuestion.Text = "Les ouvrages électriques sont classés en deux grands domaines de tension:  " +
                                       " la basse tension (BT) et la haute tension (HT). En courant alternatif, " +
                                        "quelles sont les limites de la BT ?";
                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "0 à 230 Volts";
                    chkAnswer2.Text = "0 à 500 Volts";
                    chkAnswer3.Text = "0 à 1000 Volts";
                    chkAnswer4.Visible = false;

                    break;


                case 4:

                    pictureBox1.Image = Properties.Resources.question_mark;
                    lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                                     " Question 4";
                    txtQuestion.Text = "En cas d'aacident d'origine électrique, quelle est la première opération " +
                                       " à effectuer:";

                    chkAnswer1.Text = "secourir la victime";
                    chkAnswer2.Text = "couper ou faire couper le courant";
                    chkAnswer3.Text = "donner l'alerte";
                    chkAnswer4.Visible = false;

                    break;

                /////////////////////////////////////////// Environnement - Voisinage//////////////////////////

                case 5:
                    pictureBox1.Image = Properties.Resources.CASEB05;
                    lblQuestion.Text = "Environnement -Voisinage" + Environment.NewLine +
                                     " Question 5";
                    txtQuestion.Text = "Comment reconnaissez-vous un local d'accès réservé aux électriciens :";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "par le fait que la porte soit fermée à clef. ";
                    chkAnswer3.Text = "au signal jaune posé sur la porte.";
                    chkAnswer4.Visible = false;

                    break;


                case 6:
                    pictureBox1.Image = Properties.Resources.CASEB06;
                    lblQuestion.Text = "Environnement -Voisinage" + Environment.NewLine +
                                     " Question 6";
                    txtQuestion.Text = "Avant d'ouvrir une tranchée faut-il se renseigner sur les ouvrages placés dans le sol ?";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "OUI";
                    chkAnswer3.Text = "NON";
                    chkAnswer4.Visible = false;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.zone_png;

                    lblQuestion.Text = " Environnement -Voisinage" + Environment.NewLine +
                                     " Question 7";
                    txtQuestion.Text = "A proximité d'un câble enterré, quelle est la distance d'approche à partir" +
                                          " de laquelle des précautions doivent être prises ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "1 m";
                    chkAnswer2.Text = "0,5 m";
                    chkAnswer3.Text = "0,3 m";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = "1,5 m";

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.CASEB08;

                    lblQuestion.Text = " Environnement -V oisinage" + Environment.NewLine +
                                     " Question 8";
                    txtQuestion.Text = "Habilité B0, pouvez-vous ouvrir une armoire électrique sans autorisation ?";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "OUI";
                    chkAnswer3.Text = "NON";
                    chkAnswer4.Visible = false;

                    break;



                case 9:

                    pictureBox1.Image = Properties.Resources.zone_png;

                    lblQuestion.Text = " Environnement -Voisinage" + Environment.NewLine +
                                     " Question 9";
                    txtQuestion.Text = "Quelle est la DISTANCE MINIMALE D'APPROCHE que vous devez maintenir entre une pièce " +
                                       " électrique nue, accessible, sous tension et toute autre partie de votre corps, ou tout outil, " +
                                       " ou matériau que vous manipulez (en basse tension) :";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "1 m";
                    chkAnswer2.Text = "0,5 m";
                    chkAnswer3.Text = "0,3 m";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = "0,7 m";

                    break;


                case 10:

                    pictureBox1.Image = Properties.Resources.zone_png;

                    lblQuestion.Text = " Environnement -Voisinage" + Environment.NewLine +
                                     " Question 10";
                    txtQuestion.Text = "Une habilitation B0 vous permet-elle de travailler à moins de 0,3m " +
                                       " de pièces conductrices sous tension ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "NON";
                    chkAnswer2.Text = "OUI, avec des gants de protection électrique basse tension";
                    chkAnswer3.Text = "OUI, au voisinage d'une tension de 50 à 1 000 volts.";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = "OUI, au voisinage d'une tension de plus de 1 000 volts";
                    break;



                case 11:



                    grpMultipleChoice.Visible = false;
                    grpimage.Visible = true;
                    pictureBox1.Visible = false;
                    lblQuestion.Text = " Environnement-Voisinage" + Environment.NewLine +
                                    " Question 11";
                    txtQuestion.Text = "Qui vérifie le bon état des matériels, des outillages collectifs ?";

                    pcBox1.Image = Properties.Resources.B01;
                    pcBox2.Image = Properties.Resources.B11;
                    pcBox3.Image = Properties.Resources.B21;
                    pcBox4.Image = Properties.Resources.BC2;
                    pcBox5.Image = Properties.Resources.BR1;
                    pcBox6.Image = Properties.Resources.BS1;

                    break;



                case 12:
                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;
                    pictureBox1.Visible = true;

                    pictureBox1.Image = Properties.Resources.CASEB012;

                    lblQuestion.Text = " Environnement-Voisinage" + Environment.NewLine +
                                     " Question 12";
                    txtQuestion.Text = "Qui vérifie le bon état des équipements de protection individuelle ?";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "Chaque utilisateur avant emploi.";
                    chkAnswer2.Text = "Chaque chargé de travaux avant emploi. ";
                    chkAnswer3.Text = "Chaque exploitant avant emploi.";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = "Chaque employeur avant emploi.";

                    break;
                /////////////////////////////////////////Habilitations

                case 13:

                    pictureBox1.Image = Properties.Resources.CASEB013;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                     " Question 13";
                    txtQuestion.Text = "Quel est le document principal qui vous précise les instructions de sécurité?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "la norme NFC 15-100";
                    chkAnswer2.Text = "les perscriptions UTE C 18-510";
                    chkAnswer3.Text = "le règlement interne de l'entreprise";
                    chkAnswer4.Visible = false;

                    break;

                case 14:

                    pictureBox1.Image = Properties.Resources.CASEB013;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                     " Question 14";
                    txtQuestion.Text = "Vous êtes salarié de l'entreprise, qui doit vous délivrer une habilitation B0 ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "le formateur en sécurité";
                    chkAnswer2.Text = "l'employeur professionnel utilisateur";
                    chkAnswer3.Text = "le client";
                    chkAnswer4.Visible = false;

                    break;

                case 15:

                    pictureBox1.Image = Properties.Resources.CASEB015;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                     " Question 15";
                    txtQuestion.Text = "Le balisage d'une zone de travail doit-il être considéré comme :";


                    chkAnswer1.Visible = false;
                    // chkAnswer1.Text = "le formateur en sécurité";
                    chkAnswer2.Text = "une indication.";
                    chkAnswer3.Text = "une limite à ne pas franchir.";
                    chkAnswer4.Visible = false;

                    break;

                case 16:

                    pictureBox1.Image = Properties.Resources.CASEB013;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                     " Question 16";
                    txtQuestion.Text = "L'habilitation est-elle ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "la désignation de l'employeur sur un chantier électrique";
                    chkAnswer2.Text = "la reconnaissance d'une qualification professionnelle";
                    chkAnswer3.Text = "la reconnaissance par votre employeur de votre capacité à travaller en sécurité";
                    chkAnswer4.Visible = false;

                    break;

                case 17:

                    pictureBox1.Image = Properties.Resources.CASEB013;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                     " Question 17";
                    txtQuestion.Text = "L'habilitation est-elle délivrée ?";



                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "pour une année.";
                    chkAnswer2.Text = "en fonction de l'aptitude médicale";
                    chkAnswer3.Text = "pour un temps illimité.";
                    chkAnswer4.Visible = false;

                    break;


                case 18:

                    pictureBox1.Image = Properties.Resources.CASEB018;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                     " Question 18";
                    txtQuestion.Text = "L'habilitation doit-elle dire précédée d'une formation aux risques électriques ?";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "OUI";
                    chkAnswer3.Text = "NON";
                    chkAnswer4.Visible = false;

                    break;

                //////////Travaux hors tension
                case 19:

                    pictureBox1.Image = Properties.Resources.CASEB015;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                     " Question 19";
                    txtQuestion.Text = "Vous travaillez dans une zone de travail balisée. Un de vos outils tombe à l'extérieur de " +
                                       "cette zone entre balisage et les parties électriques en service. Que faire ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "vous coupez le courant et ensuite franchissez le balisage. ";
                    chkAnswer2.Text = "vous franchissez le balisage.";
                    chkAnswer3.Text = "vous en parlez à votre chargé de travaux";
                    chkAnswer4.Visible = false;

                    break;

                case 20:

                    pictureBox1.Image = Properties.Resources.CASEB06;

                    lblQuestion.Text = " Travaux hors tension" + Environment.NewLine +
                                     " Question 20";
                    txtQuestion.Text = "Dans une tranchée, quand vous travaillez à l'aide d'une barre à mine, " +
                                       " y-a-t-il un risque électrique ?";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;

                    break;


                case 21:

                    pictureBox1.Image = Properties.Resources.CASEB021;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                     " Question 21";
                    txtQuestion.Text = "Habilité B0, je peux changer un fusible BT sous tension qui présente:";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "aucun de ces risques.";
                    chkAnswer2.Text = "un risque de contact direct avec une partie électrique.";
                    chkAnswer3.Text = "un risque de projection sans risque de contact direct. ";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = "Je ne dois pas le changer.";

                    break;


                case 22:

                    pictureBox1.Image = Properties.Resources.CASEB022;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                     " Question 22";
                    txtQuestion.Text = "L'habilitation B0 vous permet-elle d'être désigné pour entrer sans surveillance," +
                                       " dans un local d'accès réservé aux électriciens ?";
                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "OUI";
                    chkAnswer3.Text = "NON";
                    chkAnswer4.Visible = false;

                    break;

                case 23:

                    pictureBox1.Image = Properties.Resources.CASEB023;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                     " Question 23";
                    txtQuestion.Text = "Pour participer à un travail, vous faut-il, en complément à l'habilitation " +
                                       "avoir reçu un ordre de votre responsable ?";
                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "OUI";
                    chkAnswer3.Text = "NON";
                    chkAnswer4.Visible = false;


                    break;

                case 24:

                    pictureBox1.Image = Properties.Resources.CASEB024;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                     " Question 24";
                    txtQuestion.Text = "Qui est responsable de la sécurité COLLECTIVE sur le chantier?";



                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "chacune des personnes";
                    chkAnswer2.Text = "le chargé de travaux";
                    chkAnswer3.Text = "le chargé d'exploitation";
                    chkAnswer4.Visible = false;

                    break;



                case 25:

                    grpMultipleChoice.Visible = false;
                    grpimage.Visible = true;
                    pictureBox1.Visible = false;
                    lblQuestion.Text = " Travaux hors tension" + Environment.NewLine +
                                   " Question 25";

                    txtQuestion.Text = " Vous, non-électricien dans une équipe effectuant des travaux d’ordre électrique," + Environment.NewLine +
                                   "quelle est l’habilitation de la personne qui assure pour vous la direction des travaux ?";


                    pcBox1.Image = Properties.Resources.B01;
                    pcBox2.Image = Properties.Resources.B11;
                    pcBox3.Image = Properties.Resources.B21;
                    pcBox4.Image = Properties.Resources.BC2;
                    pcBox5.Image = Properties.Resources.BR1;
                    pcBox6.Image = Properties.Resources.BS1;

                    break;


                case 26:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.CASEB015;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                     " Question 26";
                    txtQuestion.Text = "Qui a la responsabilité de balisage de la zone de travail ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "le chargé d'exploitation";
                    chkAnswer2.Text = "le chargé d'intervention";
                    chkAnswer3.Text = "le chargé de consignation";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = "Le chargé des travaux";

                    break;




                case 27:

                    pictureBox1.Image = Properties.Resources.CASEB027;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                     " Question 27";
                    txtQuestion.Text = "En cas d'orage, dans quel(s) cas faut-il arrêter les travaux sur une installation" +
                                        " alimentée par un réseau";




                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "aérien et raccordé en souterrain";
                    chkAnswer2.Text = "souterrain raccordé en aérien";
                    chkAnswer3.Text = "souterrain et raccordé e souterrain";
                    chkAnswer4.Visible = false;

                    break;


                //////////////////////////////////////// Activités




                case 28:
                    pictureBox1.Image = Properties.Resources.CASEB015;

                    lblQuestion.Text = " Activités " + Environment.NewLine +
                                     " Question 28";
                    txtQuestion.Text = "En creusant une tranchée, vous découvrez un câble non signalé, que faites- vous ?";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "vous arrêtez les travaux et informez l'exploitant du réseau";
                    chkAnswer3.Text = "vous dégagez bien le câble afin d'essayer de le reconnaître.";
                    chkAnswer4.Visible = false;

                    break;

                case 29:

                    pictureBox1.Image = Properties.Resources.CASEB031;

                    lblQuestion.Text = " Activités " + Environment.NewLine +
                                     " Question 29";
                    txtQuestion.Text = "Vous avez reçu l'ordre de travailler dans une tranchée " +
                                       "à proximité d'un câble en bon état apparent. Vous pouvez :";


                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "déplacer le câble.";
                    chkAnswer3.Text = "travailler avec des outils à main tout près du câble.";
                    chkAnswer4.Visible = false;

                    break;


                case 30:

                    pictureBox1.Image = Properties.Resources.CASEB027;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                     " Question 30";
                    txtQuestion.Text = "comment reconnaissez-vous un ouvrage électrique SOUTERRAIN";





                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = " à la grosseur des câbles ";
                    chkAnswer2.Text = " à la couleur du grillage placé au-dessus du câble";
                    chkAnswer3.Text = " grâce aux indications données par l’exploitant du câble";
                    chkAnswer4.Visible = false;

                    break;


            }
        }
        void CheckAnswer(int qstNumber)
        {
            switch (qstNumber)
            {

                case 1:

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;


                case 2:

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }


                    break;

                case 3:

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 4:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 5:

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 6:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 7:

                    if (chkAnswer4.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 8:

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 9:

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 10:

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 11:

                    if ((checkBox2.Checked == true) && (checkBox5.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 12:

                    if (chkAnswer1.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 13:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;


                case 14:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 15:

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 16:

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 17:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 18:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 19:

                    if (chkAnswer3.Checked == true)
                    {
                        score++;
                    }

                    break;

                //////((checkBox2.Checked == true) && (checkBox4.Checked == true) && (checkBox5.Checked == true))

                case 20:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 21:

                    if (chkAnswer4.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 22:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 23:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 24:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 25:

                    if (checkBox3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 26:

                    if ((chkAnswer2.Checked == true) && (chkAnswer4.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 27:

                    if ((chkAnswer2.Checked == true) && (chkAnswer1.Checked == true))
                    {

                        score++;
                    }

                    break;



                case 28:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 29:

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 30:

                    if ((chkAnswer2.Checked == true) && (chkAnswer3.Checked == true))
                    {

                        score++;
                    }

                    break;

            }
        }



        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void TestB0_Load(object sender, EventArgs e)
        {
            score = 0;
            questionNumber = 0;

            btnCheckAnswer_Click(sender, e);
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            CheckAnswer(questionNumber);


            if (questionNumber == totalQuestions)
            {
                ScoreB0 fati = new ScoreB0();
                fati.Resultat_B0 = score;
                fati.ShowDialog();
                fati.Size = new Size(1070, 660);
                this.Hide();

            }

            else
            {
                questionNumber++;
                PresentQuestion(questionNumber);

            }

        }

        private void txtQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
