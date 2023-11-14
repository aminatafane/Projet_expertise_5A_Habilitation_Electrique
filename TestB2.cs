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
    public partial class TestB2 : Form
    {
        int questionNumber = 1;
        int score;
        int totalQuestions;
        public TestB2()
        {
            InitializeComponent();
            PresentQuestion(questionNumber);

            totalQuestions = 43;
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

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE2;

                    lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                                      " Question 2";
                    txtQuestion.Text = "Le temps de passage du courant électrique dans le corps humain a t-il" +
                                       " de l'importance?";
                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;

                    break;

                case 3:
                    grpMultipleChoice.Visible = false;
                    grpimage.Visible = true;
                    pictureBox1.Visible = false;

                    txtQuestion.Text = " Pour les travaux au voisinage et les travaux sous tension, quels sont les" + Environment.NewLine +
                                   " équipements de protection individuelle ?";

                    lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                                   " Question 3";
                    pcBox1.Image = Properties.Resources.casque_isolant;
                    pcBox2.Image = Properties.Resources.casquette;
                    pcBox3.Image = Properties.Resources.gants;
                    pcBox4.Image = Properties.Resources.vetement_de_travail;
                    pcBox5.Image = Properties.Resources.lunettes_uv;
                    pcBox6.Image = Properties.Resources.chaussure_isolant;

                    //grpMultipleChoice.Visible = true;
                    //       grpimage.Visible = false;
                    //
                    //     pictureBox1.Image = Properties.Resources.question_mark1;

                    //     lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                    //                       " Question 3";
                    //      txtQuestion.Text = "Un monteur laisse tomber un outil métallique dans une armoire présentant des" +
                    //                        " pièces nues, accesibles et sous tension. Ce monteur court-il un risque: ";
                    //     chkAnswer1.Visible = true;
                    //     chkAnswer1.Text = "de bûlure";
                    //    chkAnswer2.Text = "de projections de particules";
                    //   chkAnswer3.Text = "d'inhalation de gaz nocifs";
                    //   chkAnswer4.Visible = false;

                    break;

                case 4:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;
                    pictureBox1.Visible = true;

                    pictureBox1.Image = Properties.Resources.question_mark;

                    lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                                      " Question 4";
                    txtQuestion.Text = "En cas d'aacident d'origine électrique, quelle est la première opération " +
                                       " à effectuer:";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "secourir la victime";
                    chkAnswer2.Text = "couper ou faire couper le courant";
                    chkAnswer3.Text = "donner l'alerte";
                    chkAnswer4.Visible = false;

                    break;


                case 5:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

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

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

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

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.question_mark;

                    lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                                      " Question 7";
                    txtQuestion.Text = "En courant alternatif, quelles sont les limites des domaines de tension HTA:";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "au dessus de 50000 Volts";
                    chkAnswer2.Text = "de 1000 à 50000";
                    chkAnswer3.Text = "de 51 à 1000 volts";
                    chkAnswer4.Visible = false;

                    break;

                ///////////////////////////////////////////////

                case 8:

                    grpMultipleChoice.Visible = false;
                    grpimage.Visible = true;
                    pictureBox1.Visible = false;

                    txtQuestion.Text = " Un outil électrique de classe Il se reconnaît-il au sigle suivant :";

                    lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                                   " Question 8";
                    pcBox1.Image = Properties.Resources.CLASSE1;
                    pcBox2.Image = Properties.Resources.CLASSEE;
                    pcBox3.Image = Properties.Resources.CLASSE22;
                    pcBox4.Image = Properties.Resources.CLASSER;
                    pcBox5.Image = Properties.Resources.CLASSES;
                    pcBox6.Image = Properties.Resources.classe3;




                    break;

                case 9: ///

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.case9B2;

                    lblQuestion.Text = " Environnement - Voisinage" + Environment.NewLine +
                                      " Question 9";
                    txtQuestion.Text = "Sur chantier les outils électriques 240 V doivent-ils être branchés en aval " +
                                                    " d’un disjoncteur différentiel de sensibilité :";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "500 mA";
                    chkAnswer2.Text = "300 mA";
                    chkAnswer3.Text = "30 mA";
                    chkAnswer4.Visible = false;

                    break;


                /////////////////////////////////////////////////////////////////

                case 10:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.zone_png;

                    lblQuestion.Text = " Environnement - Voisinage" + Environment.NewLine +
                                      " Question 10";
                    txtQuestion.Text = "Vous vous approcher d'une installation en 400V alternatif dans un lical réservé" +
                                       " aux électriciens, à partir de quele distance des pièces nues accessibles et sous tension," +
                                       " devez-vous prendre des précautions particulières";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "1 m";
                    chkAnswer2.Text = "0,5 m";
                    chkAnswer3.Text = "0,3 m";
                    chkAnswer4.Visible = false;

                    break;

                case 11:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.zone_png;

                    lblQuestion.Text = " Environnement - Voisinage" + Environment.NewLine +
                                      " Question 11";
                    txtQuestion.Text = "Un B0V peut-il travailler à 0,2 m d’une barre nue, sous tension 230 V " +
                                       " alternatif ?";
                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;

                    break;

                case 12://///////?????????? photomultiple


                    grpMultipleChoice.Visible = false;
                    grpimage.Visible = true;
                    pictureBox1.Visible = false;

                    lblQuestion.Text = " Environnement - Voisinage" + Environment.NewLine +
                                             " Question 12";
                    txtQuestion.Text = "La suppression du voisinage peut être obtenue : ";

                    pcBox1.Image = Properties.Resources.CHOI1;
                    pcBox2.Image = Properties.Resources.CHOI2;
                    pcBox3.Image = Properties.Resources.CHOI3;
                    pcBox4.Image = Properties.Resources.CHOI4;
                    pcBox5.Image = Properties.Resources.CHOI5;
                    pcBox6.Image = Properties.Resources.CHOI6;


                    break;


                case 13:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;
                    pictureBox1.Visible = true;

                    pictureBox1.Image = Properties.Resources.zone_png;

                    lblQuestion.Text = " Environnement - Voisinage" + Environment.NewLine +
                                      " Question 13";
                    txtQuestion.Text = "Vous êtes sur une plate-forme élévatrice, vous approchez d'une canalisation aérienne isolée," +
                                       " à partir de quelle distance devez-vous prendre certaines précautions:";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "à partir de 3m";
                    chkAnswer2.Text = "à partir de 1m";
                    chkAnswer3.Text = "0,3 m";
                    chkAnswer4.Visible = false;

                    break;
                ///////////////////////////////////////////////////////////////////////////

                case 14:
                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.question_mark;

                    lblQuestion.Text = "Habilisation" + Environment.NewLine +
                                      " Question 14";

                    txtQuestion.Text = "Quel est le document principal qui vous précise les instructions de sécurité?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "la norme NFC 15-100";
                    chkAnswer2.Text = "les perscriptions UTE C 18-510";
                    chkAnswer3.Text = "le règlement interne de l'entreprise";
                    chkAnswer4.Visible = false;

                    break;

                case 15: //////

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.case15;

                    lblQuestion.Text = "Habilisation" + Environment.NewLine +
                                      " Question 15";

                    txtQuestion.Text = " Dans le recueil de prescriptions, quel chapitre développe particulièrement le rôle important du chargé de travaux ? ";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "chapitre 2";
                    chkAnswer2.Text = "chapitre 3";
                    chkAnswer3.Text = "chapitre 4";
                    chkAnswer4.Visible = false;

                    break;

                case 16:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.question_mark;

                    lblQuestion.Text = "Habilisation" + Environment.NewLine +
                                      " Question 16";

                    txtQuestion.Text = " L’habilitation doit-elle être précédée d’une formation ? ";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;

                    break;

                case 17://////

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE17;

                    lblQuestion.Text = "Habilisation" + Environment.NewLine +
                                      " Question 17";

                    txtQuestion.Text = "Vous êtes salarié de l'entreprise, qui doit vous délivrer une habilitation ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "le formateur en sécurité";
                    chkAnswer2.Text = "l'employeur professionnel utilisateur";
                    chkAnswer3.Text = "le client";
                    chkAnswer4.Visible = false;

                    break;

                case 18://///

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE18;

                    lblQuestion.Text = "Habilisation" + Environment.NewLine +
                                      " Question 18";

                    txtQuestion.Text = "L'habilitation est-elle ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "la désignation de l'employeur sur un chantier électrique";
                    chkAnswer2.Text = "la reconnaissance d'une qualification professionnelle";
                    chkAnswer3.Text = "la reconnaissance par votre employeur de votre capacité à travaller en sécurité";
                    chkAnswer4.Visible = false;

                    break;

                case 19://///

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE19;

                    lblQuestion.Text = "Habilisation" + Environment.NewLine +
                                      " Question 19";

                    txtQuestion.Text = "Quelle 2ème Lettre indique que la titulaire à été pour travailler au VOISINAGE" +
                                       "de pièces électrique nues, accessibles et sous tenion ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "V";
                    chkAnswer2.Text = "T";
                    chkAnswer3.Text = "E";
                    chkAnswer4.Visible = false;

                    break;

                /////////////////////////////////////////////////////////////////////////////

                case 20://///

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE20;

                    lblQuestion.Text = "Habilisation" + Environment.NewLine +
                                      " Question 20";

                    txtQuestion.Text = "L'habilisation B1V permet-elle de travailler hors tension sur" +
                                       " un ouvrage BT au voisinage d'un câble HT isolé sous tension?";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;

                    break;

                case 21://////

                    grpMultipleChoice.Visible = false;
                    grpimage.Visible = true;
                    pictureBox1.Visible = false;


                    //pictureBox1.Image = Properties.Resources.CASE21;

                    lblQuestion.Text = "Habilisation" + Environment.NewLine +
                                      " Question 21";

                    txtQuestion.Text = "Quelle est l’habilitation d’un électricien «Chargé de travaux» en BT?";

                    pcBox1.Image = Properties.Resources.B01;
                    pcBox2.Image = Properties.Resources.BS1;
                    pcBox3.Image = Properties.Resources.B11;
                    pcBox4.Image = Properties.Resources.BC2;
                    pcBox5.Image = Properties.Resources.BR1;
                    pcBox6.Image = Properties.Resources.B21;


                    break;

                case 22:///

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;
                    pictureBox1.Visible = true;

                    pictureBox1.Image = Properties.Resources.CASE22;

                    lblQuestion.Text = "Habilisation" + Environment.NewLine +
                                      " Question 22";

                    txtQuestion.Text = "Habilité B2, pouvez-vous recevoir et signer une attestation de consignation 3,3 kV ?";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "OUI";
                    chkAnswer3.Text = "NON";
                    chkAnswer4.Visible = false;

                    break;

                case 23:///

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE22;

                    lblQuestion.Text = "Habilisation" + Environment.NewLine +
                                      " Question 23";

                    txtQuestion.Text = "Habilité B2, pouvez-vous recevoir et signer une attestation de consignation BT?";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "OUI";
                    chkAnswer3.Text = "NON";
                    chkAnswer4.Visible = false;

                    break;

                case 24:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE24;

                    lblQuestion.Text = "Habilisation" + Environment.NewLine +
                                      " Question 24";

                    txtQuestion.Text = "Habilité B2, Pouvez-vous désigner un surveillant de sécurité électrique en BT habilité B1?";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "OUI";
                    chkAnswer3.Text = "NON";
                    chkAnswer4.Visible = false;

                    break;






                /////////////////////////////////////////



                case 25:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE25;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                      " Question 25";

                    txtQuestion.Text = "Que doit faire le chargé de travaux qui reçoit l’attestation de 1ère étape de consignation?";



                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = " la lire attentivement, demander éventuellement des éclaircissements et / ou des modifications";
                    chkAnswer2.Text = " la dater la signer la compléter en remettre le double au rédacteur";
                    chkAnswer3.Text = " se contenter de la signer «pour accord» en remettant le double au rédacteur";
                    chkAnswer4.Visible = false;

                    break;

                case 26:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE26;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                      " Question 26";
                    txtQuestion.Text = " Citez un des cas entraînant le réexamen de l’habilitation en cours d’année ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "Mutation";
                    chkAnswer2.Text = "changement de fonction";
                    chkAnswer3.Text = "restriction médicale";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = " absence prolongée (6 mois)";

                    break;


                //////////////////////////////////////////////////////////////

                case 27:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE27;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                      " Question 27";
                    txtQuestion.Text = "Pour des opérations d’ordre électrique, un chargé de travaux doit-il toujours être désign";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "OUI";
                    chkAnswer3.Text = "NON";
                    chkAnswer4.Visible = false;

                    break;
                case 28:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE28;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                      " Question 28";
                    txtQuestion.Text = "Pour des travaux électriques, quelle doit être son habilitation minimale de la qui personne peut" +
                                                "être «chargé de consignation» et «chargé de travaux» ?";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "B1V et BR";
                    chkAnswer2.Text = "B2 et BC";
                    chkAnswer3.Text = "B2 et B1";
                    chkAnswer4.Visible = false;

                    break;



                case 29:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE29;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                      " Question 29";
                    txtQuestion.Text = "Le personnel non-électricien peut-il effectuer?";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = " des travaux d’ordre électrique sous votre autorité";
                    chkAnswer3.Text = "des travaux non-électrique, leur surveillance, des manoeuvres permises";
                    chkAnswer4.Visible = false;

                    break;

                ///////////////////////////////////////////////////////////////////////

                case 30:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.case30;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                      " Question 30";
                    txtQuestion.Text = "Qui est responsable de la sécurité COLLECTIVE sur le chantier?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "chacune des personnes";
                    chkAnswer2.Text = "le surveillant de sécurité électrique";
                    chkAnswer3.Text = "le chargé de travaux";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = "le chargé d’exploitation";

                    break;

                case 31:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE31;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                      " Question 31";
                    txtQuestion.Text = " Qui vérifie le bon état des matériels, des outillages collectifs ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "le chargé d'exploitation";
                    chkAnswer2.Text = "le chargé d'intervention";
                    chkAnswer3.Text = "le chargé de consignation";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = "Le chargé des travaux";

                    break;

                case 32:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE32;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                      " Question 32";
                    txtQuestion.Text = "Dans le cas de travaux hors tension sur câble BT en conducteurs isolés," +
                                         "devez-vous, en tant que chargé de travaux, recevoir une attestation :";



                    chkAnswer1.Visible = false;
                    //     chkAnswer1.Text = "sur la partie électrique la plus proche";
                    chkAnswer2.Text = " de 1 ère étape de consignation ";
                    chkAnswer3.Text = " de consignation pour travaux";
                    chkAnswer4.Visible = false;

                    break;

                case 33:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.VAT;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                      " Question 33";
                    txtQuestion.Text = "Le fonctionnement du vérificateur d’absence de tension doit-il être vérifié?";


                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "avant la VAT";
                    chkAnswer3.Text = "après la VAT";
                    chkAnswer4.Visible = false;

                    break;

                case 34:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE34;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                      " Question 34";
                    txtQuestion.Text = "Une mise à la terre commence par la connexion du dispositif?";



                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "sur la partie électrique la plus proche";
                    chkAnswer2.Text = "sur le circuit de terre";
                    chkAnswer3.Text = "indifférement";
                    chkAnswer4.Visible = false;

                    break;

                /////////////////////////////////////////////////////////////////////////////////


                case 35:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE35;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                      " Question 35";
                    txtQuestion.Text = "La zone de travail est-elle délimitée par ?";


                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "le chargé de consignation";
                    chkAnswer3.Text = "le chargé de travaux";
                    chkAnswer4.Visible = false;

                    break;

                case 36:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BALISAGE;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                      " Question 36";
                    txtQuestion.Text = "Qui a la responsabilité de balisage de la zone de travail ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "le chargé d'exploitation";
                    chkAnswer2.Text = "le chargé d'intervention";
                    chkAnswer3.Text = "le chargé de consignation";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = "Le chargé des travaux";

                    break;

                case 37:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BALISAGE;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                      " Question 37";
                    txtQuestion.Text = "Le balisage de la zone de travail doit-il être considéré comme ?";


                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = " une indication";
                    chkAnswer3.Text = " une limite à ne pas franchir";
                    chkAnswer4.Visible = false;

                    break;

                case 38:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BALISAGE;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                      " Question 38";
                    txtQuestion.Text = "Vous travailler dans une zone de travail balisée. Un de vos outils tombe à" +
                                        " l'extérieur de cette zone entre balisage et parties électrique en service." +
                                         " Que faites-vous ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "vous frachissez le balisage";
                    chkAnswer2.Text = "vous coupez le courant et ensuite franchissez le balisage";
                    chkAnswer3.Text = "vous en partez à votre chargé de travaux";
                    chkAnswer4.Visible = false;

                    break;



                case 39:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE39;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                      " Question 39";
                    txtQuestion.Text = " Vous êtes chargé de travaux, à la fin des travaux devez-vous";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "vous assurez de la bonne exécution du travail ";
                    chkAnswer2.Text = "faire enlever tous les outils";
                    chkAnswer3.Text = "rassembler le personnel et interdire l’accès à la zone de travail";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = "enlever les balisages de la zone de travail";

                    break;

                case 40:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE39;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                      " Question 40";
                    txtQuestion.Text = " Vous êtes chargé de travaux, à la fin des travaux devez-vous";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = " déposer les MALT et CC mises en place par vos soins ";
                    chkAnswer2.Text = "déposer les MALT et CC mises en place par le chargé de consignation";
                    chkAnswer3.Text = " remettre au chargé de consignation l’avis de fin de travail";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = " informer le chargé d’exploitation";

                    break;

                case 41:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.ORAGE;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                      " Question 41";
                    txtQuestion.Text = " En cas d’orage, faut-il arrêter les travaux sur une installation raccordée à un réseau aérien";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "OUI";
                    chkAnswer3.Text = "NON";
                    chkAnswer4.Visible = false;
                    break;





                case 42:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.case42;

                    lblQuestion.Text = "Travaux hors tension" + Environment.NewLine +
                                      " Question 42";
                    txtQuestion.Text = "Après avoir reçu l’attestation de 1ère étape de consignation d’un ouvrage" +
                                        "BT qu’elles sont les opérations que le chargé de travaux doit exécuter" +
                                        "avant le début des travaux ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = ": Identification de l’ouvrage.";
                    chkAnswer2.Text = "Vérification de l’absence de tension,";
                    chkAnswer3.Text = "suivie de mise(s) à la terre et en court-circuit";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = "Effectuer la délimitation de la zone de travail";

                    break;


                case 43:
                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.DDR_8;

                    lblQuestion.Text = " Environnement - Voisinage" + Environment.NewLine +
                                      " Question 8";
                    txtQuestion.Text = "Un dispositif différentiel à courant résiduel (DDR) à haute sensibilté de 30 mA protège:";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "les outils électriques";
                    chkAnswer2.Text = "les personnes utilisant ces outils";
                    chkAnswer3.Text = "les installations électriques";
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

                    if (checkBox3.Checked == true)
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

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 12:

                    if ((checkBox1.Checked == true) && (checkBox2.Checked == true) && (checkBox4.Checked == true) && (checkBox5.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 13:

                    if (chkAnswer3.Checked == true)
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

                    if (chkAnswer2.Checked == true)
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

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 19:

                    if (chkAnswer1.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 20:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 21:

                    if (checkBox6.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 22:

                    if (chkAnswer3.Checked == true)
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

                    if ((chkAnswer1.Checked == true) && (chkAnswer2.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 26:

                    if ((chkAnswer1.Checked == true) && (chkAnswer2.Checked == true) && (chkAnswer3.Checked == true) && (chkAnswer4.Checked == true))
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

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 31:

                    if (chkAnswer4.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 32:

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 33:

                    if ((chkAnswer2.Checked == true) && (chkAnswer3.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 34:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 35:

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;


                case 36:

                    if ((chkAnswer2.Checked == true) && (chkAnswer4.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 37:

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 38:

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 39:

                    if ((chkAnswer1.Checked == true) && (chkAnswer2.Checked == true) && (chkAnswer3.Checked == true) && (chkAnswer4.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 40:

                    if ((chkAnswer2.Checked == true) && (chkAnswer4.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 41:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 42:

                    if ((chkAnswer1.Checked == true) && (chkAnswer2.Checked == true) && (chkAnswer3.Checked == true) && (chkAnswer4.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 43:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

            }
        }

        private void TestB2_Load(object sender, EventArgs e)
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
                ScoreB2 fati = new ScoreB2();
                fati.Resultat_B2 = score;
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
