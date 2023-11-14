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
    public partial class TestB1 : Form
    {
        int questionNumber = 1;
        int score;
        int totalQuestions;
        public TestB1()
        {
            InitializeComponent();
            PresentQuestion(questionNumber);

            totalQuestions = 31;
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

                    pictureBox1.Image = Properties.Resources.barre;

                    lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                                      " Question 1";
                    txtQuestion.Text = "Y a t-il une différnce apparente entre un jeu de barres hors tension et un jeu de barres sous tension";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;

                    break;

                case 2:
                    grpMultipleChoice.Visible = false;
                    grpimage.Visible = true;
                    pictureBox1.Visible = false;

                    txtQuestion.Text = " Pour les travaux au voisinage et les travaux sous tension, quels sont les" + Environment.NewLine +
                                   " équipements de protection individuelle ?";

                    lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                                   " Question 2";
                    pcBox1.Image = Properties.Resources.casque_isolant;
                    pcBox2.Image = Properties.Resources.casquette;
                    pcBox3.Image = Properties.Resources.gants;
                    pcBox4.Image = Properties.Resources.vetement_de_travail;
                    pcBox5.Image = Properties.Resources.lunettes_uv;
                    pcBox6.Image = Properties.Resources.chaussure_isolant;


                    // pictureBox1.Visible = false;
                    //  lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                    //                 " Question 2";

                    //txtQuestion.Text = "Le temps de passage du courant électrique dans le corps humain a t-il" +
                    //                 " de l'importance?";
                    //chkAnswer1.Visible = false;
                    //chkAnswer2.Text = "Oui";
                    //chkAnswer3.Text = "Non";
                    //chkAnswer4.Visible = false;

                    break;

                case 3:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.question_mark;

                    lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                                     " Question 3";
                    txtQuestion.Text = "Un monteur laisse tomber un outil métallique dans une armoire présentant des" +
                                       " pièces nues, accesibles et sous tension. Ce monteur court-il un risque: ";
                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "de bûlure";
                    chkAnswer2.Text = "de projections de particules";
                    chkAnswer3.Text = "d'inhalation de gaz nocifs";
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


                case 5:
                    pictureBox1.Image = Properties.Resources.question_mark;
                    lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                                     " Question 5";
                    txtQuestion.Text = "A partir de quelle tension le courant électrique alternatif devient-il dangereux sur mileu sec:";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "50";
                    chkAnswer3.Text = "25";
                    chkAnswer4.Visible = false;

                    break;


                case 6:
                    pictureBox1.Image = Properties.Resources.bt;
                    lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                                     " Question 6";
                    txtQuestion.Text = "En courant alternatif, quelles sont les limites des domaines de tension BT:";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "de 0 à 50 Volts";
                    chkAnswer2.Text = "au dessus de 1000 Volts";
                    chkAnswer3.Text = "de 51 à 1000 volts";
                    chkAnswer4.Visible = false;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.bt;
                    lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                                     " Question 7";
                    txtQuestion.Text = "En courant alternatif, quelles sont les limites des domaines de tension HTA:";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "au dessus de 50000 Volts";
                    chkAnswer2.Text = "de 1000 à 50000";
                    chkAnswer3.Text = "de 51 à 1000 volts";
                    chkAnswer4.Visible = false;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.DDR_8;
                    lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                                     " Question 8";
                    txtQuestion.Text = "Un dispositif différentiel à courant résiduel (DDR) à haute sensibilté de 30 mA protège:";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "les outils électriques";
                    chkAnswer2.Text = "les personnes utilisant ces outils";
                    chkAnswer3.Text = "les installations électriques";
                    chkAnswer4.Visible = false;

                    break;

                ///////////////////////////////////////////////

                case 9:


                    pictureBox1.Image = Properties.Resources.zone_png;

                    lblQuestion.Text = " Environnement -V oisinage" + Environment.NewLine +
                                     " Question 9";
                    txtQuestion.Text = "Vous vous approcher d'une installation en 400V alternatif dans un lical réservé" +
                                       " aux électriciens, à partir de quele distance des pièces nues accessibles et sous tension," +
                                       " devez-vous prendre des précautions particulières";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "1 m";
                    chkAnswer2.Text = "0,5 m";
                    chkAnswer3.Text = "0,3 m";
                    chkAnswer4.Visible = false;

                    break;


                case 10:

                    pictureBox1.Image = Properties.Resources.zone_png;
                    lblQuestion.Text = " Environnement -V oisinage" + Environment.NewLine +
                                     " Question 10";
                    txtQuestion.Text = "Vous êtes sur une plate-forme élévatrice, vous approchez d'une canalisation aérienne isolée," +
                                       " à partir de quelle distance devez-vous prendre certaines précautions:";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "à partir de 3m";
                    chkAnswer2.Text = "à partir de 1m";
                    chkAnswer3.Text = "0,3 m";
                    chkAnswer4.Visible = false;

                    break;

                case 11:

                    pictureBox1.Image = Properties.Resources.equipement_de_protection;
                    lblQuestion.Text = " Environnement -V oisinage" + Environment.NewLine +
                                     " Question 11";
                    txtQuestion.Text = "Quels sont les dispositifs ou équipements qui permettent d'éliminer les risques dus au voisinage ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "la consignation e l'ouvrage voisin";
                    chkAnswer2.Text = "la mise en place d'écrans";
                    chkAnswer3.Text = "la port de gants isolants";
                    chkAnswer4.Visible = false;

                    break;

                case 12:
                    pictureBox1.Image = Properties.Resources.question_mark;
                    lblQuestion.Text = " Environnement -V oisinage" + Environment.NewLine +
                                     " Question 12";
                    txtQuestion.Text = "Quel(s) dispositif(s) permet de supprimer temporairement le voisinage en BT?";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "plaque de tôle épaisse mise à la terre";
                    chkAnswer3.Text = "nappe en palstique isolant normalisé";
                    chkAnswer4.Visible = false;

                    break;
                /////////////////////////////////////////

                case 13:
                    pictureBox1.Image = Properties.Resources.question_mark;
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
                    pictureBox1.Image = Properties.Resources.question_mark;
                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                   " Question 14";
                    txtQuestion.Text = "Vous êtes salarié de l'entreprise, qui doit vous délivrer une habilitation ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "le formateur en sécurité";
                    chkAnswer2.Text = "l'employeur professionnel utilisateur";
                    chkAnswer3.Text = "le client";
                    chkAnswer4.Visible = false;

                    break;

                case 15:
                    pictureBox1.Image = Properties.Resources.question_mark;
                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                   " Question 15";
                    txtQuestion.Text = "Vous êtes intérimaire et vous trvaillez dans une entreprise, qui doit vous délivrer une habilitation ? ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "le formateur en sécurité";
                    chkAnswer2.Text = "l'employeur professionnel utilisateur";
                    chkAnswer3.Text = "le client";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = "L'agence d'intérim";

                    break;



                case 16:
                    pictureBox1.Image = Properties.Resources.HABILITAION_CASE_18;
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
                    pictureBox1.Image = Properties.Resources.b1_17_;
                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                   " Question 17";
                    txtQuestion.Text = "Quelle 2ème Lettre indique que la titulaire à été pour trailler au VOISINAGE" +
                                       "de pièces électrique nues, accessibles et sous tenion ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "V";
                    chkAnswer2.Text = "T";
                    chkAnswer3.Text = "E";
                    chkAnswer4.Visible = false;

                    break;

                case 18:
                    pictureBox1.Image = Properties.Resources.HABILITAION_CASE_18;
                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                   " Question 18";
                    txtQuestion.Text = "L'habilisation HT recouvre t-elle l'habilisation BT?";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;

                    break;

                case 19:
                    pictureBox1.Image = Properties.Resources.question_mark;
                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                   " Question 19";
                    txtQuestion.Text = "Pour travailler à 0,2 m d'une barre nue accessible sous tension 320V AC" +
                                       "vous devez être";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "habilité B0V";
                    chkAnswer2.Text = "habilité B1V";
                    chkAnswer3.Text = "non habilité et non surveillé par une personne habilitée";
                    chkAnswer4.Visible = false;

                    break;

                case 20:
                    grpMultipleChoice.Visible = false;
                    grpimage.Visible = true;
                    pictureBox1.Visible = false;
                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                   " Question 20";
                    txtQuestion.Text = "parmi les figures suivantes choisissez les équipements pour faire le balisage:";

                    pcBox1.Image = Properties.Resources.casque_isolant;
                    pcBox2.Image = Properties.Resources.scotch;
                    pcBox3.Image = Properties.Resources.gants;
                    pcBox4.Image = Properties.Resources.balisage_28_29;
                    pcBox5.Image = Properties.Resources.balisage_2;
                    pcBox6.Image = Properties.Resources.chaussure_isolant;




                    break;


                case 21:
                    grpimage.Visible = false;
                    grpMultipleChoice.Visible = true;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.CASE_20_21_B1V;
                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                   " Question 21";
                    txtQuestion.Text = "Habilité B1V pouvez-vous?";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "recevoir une 'attestation de conségnation' et la signer";
                    chkAnswer3.Text = "effectuer des manoeuvres de consignation en BT commandées par un charger de consignation  ";
                    chkAnswer4.Visible = false;

                    break;


                case 22:
                    pictureBox1.Image = Properties.Resources.case_22_habilité_b1_;
                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                   " Question 22";
                    txtQuestion.Text = "Habilité pouvez-vous être désigné surveillant de sécurité électrique en BT?";
                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "OUI";
                    chkAnswer3.Text = "NON";
                    chkAnswer4.Visible = false;

                    break;


                case 23:
                    pictureBox1.Image = Properties.Resources.question_mark;
                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                   " Question 23";
                    txtQuestion.Text = "Un dépannage électrique en présence de tension BT peut-il être effectué par" +
                                       "un électricien habilité B1V seul?";
                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "OUI";
                    chkAnswer3.Text = "NON";
                    chkAnswer4.Visible = false;

                    break;

                //////////////////////////////////////////////////////////////


                case 24:
                    pictureBox1.Image = Properties.Resources.question_mark;
                    lblQuestion.Text = " Exécution de travaux hors tension" + Environment.NewLine +
                                   " Question 24";
                    txtQuestion.Text = "Qui est responsable de la sécurité COLLECTIVE sur le chantier?";



                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "chacune des personnes";
                    chkAnswer2.Text = "le chargé de travaux";
                    chkAnswer3.Text = "le chargé d'exploitation";
                    chkAnswer4.Visible = false;

                    break;


                case 25:
                    pictureBox1.Image = Properties.Resources.question_mark;
                    lblQuestion.Text = " Exécution de travaux hors tension" + Environment.NewLine +
                " Question 25";
                    txtQuestion.Text = "Qui doit vérifier le bon état des matériel et des outillages collctifs?";



                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "le chargé d'intervention";
                    chkAnswer2.Text = "le chargé de travaux";
                    chkAnswer3.Text = "le chargé d'exploitation";
                    chkAnswer4.Visible = false;

                    break;


                case 26:
                    pictureBox1.Image = Properties.Resources.vat_26_;
                    lblQuestion.Text = " Exécution de travaux hors tension" + Environment.NewLine +
                " Question 26";
                    txtQuestion.Text = "Le fonctionnement du vérification d'absence de Tension doit-il être vérifié?";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "avant la VAT";
                    chkAnswer3.Text = "après la VAT";
                    chkAnswer4.Visible = false;

                    break;

                case 27:
                    pictureBox1.Image = Properties.Resources.malt_27_;
                    lblQuestion.Text = " Exécution de travaux hors tension" + Environment.NewLine +
                " Question 27";
                    txtQuestion.Text = "Une mise à la terre commence par la connexion du dispositif?";



                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "sur la partie électrique la plus proche";
                    chkAnswer2.Text = "sur le circuit de terre";
                    chkAnswer3.Text = "indifférement";
                    chkAnswer4.Visible = false;

                    break;


                case 28:
                    pictureBox1.Image = Properties.Resources.balisage_28_29;
                    lblQuestion.Text = " Exécution de travaux hors tension" + Environment.NewLine +
                " Question 28";
                    txtQuestion.Text = "Qui a la responsabilité de balisage de la zone de travail ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "le chargé d'exploitation";
                    chkAnswer2.Text = "le chargé d'intervention";
                    chkAnswer3.Text = "le chargé de consignation";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = "Le chargé des travaux";

                    break;


                case 29:

                    pictureBox1.Image = Properties.Resources.balisage_28_29;

                    lblQuestion.Text = " Exécution de travaux hors tension" + Environment.NewLine +
                " Question 29";
                    txtQuestion.Text = "Vous traailler dans une zone de travail balisée. Un de vos outils tombe à" +
                                        " l'extérieur de cette zone entre balisage et parties électrique en service." +
                                         " Que faites-vous ?";



                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "vous frachissez le balisage";
                    chkAnswer2.Text = "vous coupez le courant et ensuite franchissez le balisage";
                    chkAnswer3.Text = "vous en partez à votre chargé de travaux";
                    chkAnswer4.Visible = false;

                    break;

                case 30:
                    pictureBox1.Image = Properties.Resources.ORAGE;
                    lblQuestion.Text = " Exécution de travaux hors tension" + Environment.NewLine +
                " Question 30";
                    txtQuestion.Text = "En cas d'orage, dans quel(s) cas faut-il arrêter les travaux sur une installation" +
                                        " alimentée par un réseau";




                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "aérien et raccordé en souterrain";
                    chkAnswer2.Text = "souterrain raccordé en aérien";
                    chkAnswer3.Text = "souterrain et raccordé e souterrain";
                    chkAnswer4.Visible = false;

                    break;


                case 31:
                    pictureBox1.Image = Properties.Resources.CASE_20_21_B1V;
                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                   " Question 20";
                    txtQuestion.Text = "L'habilisation B1V permet-elle de travailler hors tension sur" +
                                       " un ouvrage BT au voisinage d'un câble HT isolé sous tension?";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
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

                    if ((checkBox1.Checked == true) && (checkBox3.Checked == true) && (checkBox4.Checked == true) && (checkBox6.Checked == true))
                    {

                        score++;
                    }

                    // if (chkAnswer2.Checked == true)
                    //    {
                    //
                    //      score++;
                    //    }

                    break;

                case 3:

                    if ((chkAnswer1.Checked == true) && (chkAnswer2.Checked == true) && (chkAnswer3.Checked == true))
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

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 6:

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 7:

                    if (chkAnswer1.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 8:

                    if (chkAnswer2.Checked == true)
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

                    if ((chkAnswer1.Checked == true) && (chkAnswer2.Checked == true) && (chkAnswer3.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 12:

                    if ((chkAnswer2.Checked == true) && (chkAnswer3.Checked == true))
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

                    if (chkAnswer2.Checked == true)
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

                    if (chkAnswer1.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 18:

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 19:

                    if ((chkAnswer1.Checked == true) && (chkAnswer2.Checked == true))
                    {
                        score++;
                    }

                    break;

                case 20:

                    if ((checkBox2.Checked == true) && (checkBox4.Checked == true) && (checkBox5.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 21:

                    if (chkAnswer3.Checked == true)
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

                    if (chkAnswer3.Checked == true)
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

                    if ((chkAnswer1.Checked == true) && (chkAnswer2.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 26:

                    if ((chkAnswer2.Checked == true) && (chkAnswer3.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 27:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 28:

                    if ((chkAnswer2.Checked == true) && (chkAnswer4.Checked == true))
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

                    if ((chkAnswer1.Checked == true) && (chkAnswer2.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 31:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

            }
        }

        private void TestB1_Load(object sender, EventArgs e)
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
                ScoreB1 fati = new ScoreB1();
                fati.Resultat = score;
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
    }
}
