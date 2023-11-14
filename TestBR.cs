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
    public partial class TestBR : Form
    {

        int questionNumber = 1;
        int score;
        int totalQuestions;
        public TestBR()
        {
            InitializeComponent();
            PresentQuestion(questionNumber);

            totalQuestions = 44;
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

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BR8;

                    lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                                      " Question 8";
                    txtQuestion.Text = " Une INTERVENTION est-elle une opération électrique :";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "préparée à l’avance ";
                    chkAnswer2.Text = "non préparée à l’avance, de courte durée sur une installation ou un" +
                                               "équipement BT ";
                    chkAnswer3.Visible = false;
                    chkAnswer4.Visible = false;

                    break;

                ///////////////////////////////////////////////

                case 9:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE26;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 9";
                    txtQuestion.Text = "Pour vos opérations d’ordre électrique, quel est le document principal qui" +
                                                "vous précise les instructions de sécurité ?";
                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "UTE C 18-510";
                    chkAnswer2.Text = "NFC 15-100";
                    chkAnswer3.Visible = true;
                    chkAnswer3.Text = "le règlement interne de l'entreprise";
                    chkAnswer4.Visible = false;

                    break;


                case 10:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE22;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 10";
                    txtQuestion.Text = "L’habilitation doit-elle être précédée d’une formation ";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "Oui";
                    chkAnswer2.Text = "Non";
                    chkAnswer3.Visible = false;
                    chkAnswer4.Visible = false;

                    break;

                case 11:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE22;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 11";
                    txtQuestion.Text = "Qui délivre une habilitation?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = " le formateur en sécurité";
                    chkAnswer2.Text = "l’agence d’intérim pour le personnel intérimaires";
                    chkAnswer3.Visible = true;
                    chkAnswer3.Text = " l’employeur professionnel utilisateur";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = "le client";

                    break;

                case 12:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE26;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 12";
                    txtQuestion.Text = "L'habilitation est-elle ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "la désignation de l'employeur sur un chantier électrique";
                    chkAnswer2.Text = "la reconnaissance d'une qualification professionnelle";
                    chkAnswer3.Text = "la reconnaissance par votre employeur de votre capacité à travaller en sécurité";
                    chkAnswer4.Visible = false;

                    break;
                /////////////////////////////////////////

                case 13:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE19;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 13";
                    txtQuestion.Text = "Quelle est la LETTRE d’habilitation, définissant le domaine de tension et" +
                                             "correspondant aux travaux hors tension en BT ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "H";
                    chkAnswer2.Text = "B";
                    chkAnswer3.Visible = false;
                    chkAnswer4.Visible = false;

                    break;

                case 14:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BR14;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 14";
                    txtQuestion.Text = "Quelle est l’indice NUMERIQUE (chiffre) définissant le niveau de l’habilitation :" +
                                                 "d’un électricien exécutant";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = " 0";
                    chkAnswer2.Text = "1";
                    chkAnswer3.Visible = true;
                    chkAnswer3.Text = "2";
                    chkAnswer4.Visible = false;

                    break;

                case 15:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE21;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 15";
                    txtQuestion.Text = "Quelle 2ème Lettre indique que la titulaire à été pour trailler au VOISINAGE" +
                                       "de pièces électrique nues, accessibles et sous tenion ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "V";
                    chkAnswer2.Text = "T";
                    chkAnswer3.Text = "E";
                    chkAnswer4.Visible = false;

                    break;

                case 16:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE19;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 16";
                    txtQuestion.Text = "L’habilitation suffit-elle pour effectuer une intervention ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "Oui";
                    chkAnswer2.Text = "Non";
                    chkAnswer3.Visible = false;
                    chkAnswer4.Visible = false;



                    break;

                case 17:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BR17;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 17";
                    txtQuestion.Text = "Pour être désigné chargé d’intervention peut-on être :";



                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = " mécanicien ";
                    chkAnswer2.Text = "électromécanicien";
                    chkAnswer3.Visible = false;
                    chkAnswer4.Visible = false;


                    break;

                case 18:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE19;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 18";
                    txtQuestion.Text = "L’habilitation BR recouvre-t-elle l’habilitation B1?";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Visible = true;
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;

                    break;

                case 19:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BR19;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 19";
                    txtQuestion.Text = "L’habilitation BR permet-elle d’intervenir en présence de tension sur un" +
                                         "ouvrage BT au voisinage d’un ouvrage HT, nu accessible et sous tension ";


                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;

                    break;

                case 20:// IMAGE

                    grpMultipleChoice.Visible = false;
                    grpimage.Visible = true;
                    pictureBox1.Visible = false;


                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 20";
                    txtQuestion.Text = "Quelle est l’habilitation d’un électricien Chargé d’interventions?";

                    pcBox1.Image = Properties.Resources.B01;
                    pcBox2.Image = Properties.Resources.BC2;
                    pcBox3.Image = Properties.Resources.B11;
                    pcBox4.Image = Properties.Resources.BR1;
                    pcBox5.Image = Properties.Resources.B21;
                    pcBox6.Image = Properties.Resources.BS1;


                    break;


                case 21:

                    pictureBox1.Visible = true;
                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BR21;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 21";
                    txtQuestion.Text = "Un habilité BR peut-il avoir des électriciens sous ses ordres ?";


                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;


                    break;


                case 22:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BR22;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 22";
                    txtQuestion.Text = "Un chargé d’intervention peut-il désigner un surveillant de sécurité électrique ?";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;

                    break;

                case 23:// PHOTO

                    grpMultipleChoice.Visible = false;
                    grpimage.Visible = true;
                    pictureBox1.Visible = false;

                    // pictureBox1.Image = Properties.Resources.bt;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 23";
                    txtQuestion.Text = "Qui est responsable de la sécurité COLLECTIVE sur le lieu de l’intervention ?";

                    pcBox1.Image = Properties.Resources.B01;
                    pcBox2.Image = Properties.Resources.BC2;
                    pcBox3.Image = Properties.Resources.B11;
                    pcBox4.Image = Properties.Resources.BR1;
                    pcBox5.Image = Properties.Resources.B21;
                    pcBox6.Image = Properties.Resources.BS1;
                    break;

                //////////////////////////////////////////////////////////////


                case 24:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.CASE29;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 24";
                    txtQuestion.Text = "Sur le chantier êtes-vous responsable de votre propre sécurité ?";


                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;

                    break;


                case 25:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.matériel_25_;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 25";
                    txtQuestion.Text = "Etes-vous responsable du port de vos protections «INDIVIDUELLES» ?";



                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;

                    break;


                case 26:// PHOTO

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.BR26;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 26";
                    txtQuestion.Text = "Quel est l’équipement minimal d’un chargé d’interventions en protections individuelles?";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "Coiffure non conductrice";
                    chkAnswer2.Text = "Tapis isolant";
                    chkAnswer3.Text = " Matériels normalisés de VAT";
                    chkAnswer4.Visible = false;

                    break;

                case 27:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BR27;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 27";
                    txtQuestion.Text = "Habilité BR, pouvez-vous consigner une partie d’installation pour votre" +
                                             "propre compte ?";



                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;

                    break;


                case 28:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BR28;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 28";
                    txtQuestion.Text = "Habilité BR, pouvez-vous consigner une partie d’installation pour un tiers" +
                                             "chargé de travaux?";


                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;

                    break;


                case 29:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BR29;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 29";
                    txtQuestion.Text = "Habilité BR, pouvez-vous recevoir l’attestation de consignation concernant" +
                                             "le remplacement d’un disjoncteur 690 V ?";




                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;

                    break;

                case 30:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BR30;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 30";
                    txtQuestion.Text = "La condamnation en position d’ouverture des organes de manoeuvre est-elle" +
                                                    "obligatoire en BT? ";




                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;
                    break;

                case 31:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BR31;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 31";
                    txtQuestion.Text = "En BT, est-il obligatoire de vérifier l’absence de tension avant toute" +
                                              "opération hors tension ? ";


                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;
                    break;

                case 32:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.VAT;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 32";
                    txtQuestion.Text = " Le fonctionnement du vérificateur d’absence de tension doit-il être vérifié?";


                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "avant la VAT";
                    chkAnswer3.Text = "après la VAT";
                    chkAnswer4.Visible = false;
                    break;

                case 33:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE34;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 33";
                    txtQuestion.Text = " Une mise à la terre commence par la connexion du dispositif ";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "sur le circuit de terre";
                    chkAnswer2.Text = "sur les circuits actifs";
                    chkAnswer3.Text = " Indifféremment";
                    chkAnswer4.Visible = false;
                    break;

                case 34:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE34;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 34";
                    txtQuestion.Text = "La mise à la terre et en CC est-elle toujours obligatoire en BT?";


                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;
                    break;

                case 35:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BALISAGE;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 35";
                    txtQuestion.Text = "Qui fait baliser la zone de travail dans tous les plans nécessaires ?";


                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = " le chargé d’exploitation ";
                    chkAnswer3.Text = "le chargé d’intervention";
                    chkAnswer4.Visible = false;
                    break;

                case 36:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BALISAGE;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 36";
                    txtQuestion.Text = " Le balisage de la zone de travail doit-il être considéré comme  ?";


                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = " une indication  ";
                    chkAnswer3.Text = " une limite à ne pas franchir ";
                    chkAnswer4.Visible = false;
                    break;

                case 37:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.ORAGE;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 37";
                    txtQuestion.Text = "En cas d’orage, faut-il arrêter les travaux dans un poste d’usine ?";


                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;
                    break;

                case 38:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.zone_png;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 38";
                    txtQuestion.Text = " En vous approchant d’une installation en 400 V alternatif dans un local, à" +
                                          "partir de quelle distance des pièces sous tension, nues et accessibles" +
                                                    "devez-vous prendre des précautions particulières ";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = " à partir de 1 m ";
                    chkAnswer2.Text = " à partir de 0.5 m ";
                    chkAnswer3.Text = " à partir de 0.3 m ";
                    chkAnswer4.Visible = false;
                    break;

                case 39:
                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.zone_png;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 39";
                    txtQuestion.Text = " Dans une nacelle élévatrice, en vous approchant d’un réseau BTA, nu" +
                                         "accessible et sous tension, à partir de quelle distance du conducteur" +
                                                " le plus proche devez-vous prendre certaines précautions  ";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = " à partir de 0.30 m ";
                    chkAnswer2.Text = " à partir de 1 m ";
                    chkAnswer3.Text = " à partir de 3 m ";
                    chkAnswer4.Visible = false;
                    break;

                case 40:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BR40;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 40";
                    txtQuestion.Text = "Un chargé d’intervention peut-il effectuer en présence de tension :?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = " des dépannages sur installations HT";
                    chkAnswer2.Text = "des déconnexions et connexions sur un circuit à 400 V";

                    chkAnswer3.Text = "des déconnexions et connexions sur un circuit à 690 V";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = "des remplacements de fusibles BT";

                    break;

                case 41:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BR41;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 41";
                    txtQuestion.Text = " Suite à la fusion d’un fusible aM 10 A, que faire :";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = " le remplacer par un fusible aM de même calibre ";
                    chkAnswer2.Text = "rechercher la cause ";
                    chkAnswer3.Text = " le remplacer par un fusible gl de 30 A ";
                    chkAnswer4.Visible = false;
                    break;

                case 42:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.CASE19;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 42";
                    txtQuestion.Text = "Sur un normal-secours, pouvez-vous débrancher un câble de 25 mm2 de" +
                                            "circuit de puissance sans consignation préalable  ?";


                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;
                    break;

                case 43:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BR43;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 43";
                    txtQuestion.Text = "Habilité BR, pour localiser la panne, pouvez-vous brancher un shunt" +
                                               "entre deux bornes d’une même phase d’un circuit 690 V ?";


                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;
                    break;

                case 44:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BR44;

                    lblQuestion.Text = " Exécution d’interventions" + Environment.NewLine +
                                      " Question 44";
                    txtQuestion.Text = "Habilité BR, pouvez-vous, dans une armoire BT, remplacer un relais" +
                                            "défectueux en le maintenant sous tension?";


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

                    if (chkAnswer1.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 10:

                    if (chkAnswer1.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 11:

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 12:

                    if (chkAnswer3.Checked == true)
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

                    if (chkAnswer1.Checked == true)
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

                case 20:

                    if (checkBox4.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 21:

                    if (chkAnswer2.Checked == true)
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

                    if (checkBox4.Checked == true)
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

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 26:

                    if ((chkAnswer1.Checked == true) && (chkAnswer2.Checked == true))
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

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;


                case 29:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 30:

                    if (chkAnswer2.Checked == true)
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

                case 32:

                    if ((chkAnswer2.Checked == true) && (chkAnswer3.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 33:

                    if (chkAnswer1.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 34:

                    if (chkAnswer3.Checked == true)
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

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 37:

                    if (chkAnswer2.Checked == true)
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

                    if ((chkAnswer1.Checked == true) && (chkAnswer3.Checked == true))
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

                    if ((chkAnswer1.Checked == true) && (chkAnswer2.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 42:

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 43:

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 44:

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

            }
        }
        private void TestBR_Load(object sender, EventArgs e)
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
                ScoreBR fati = new ScoreBR();
                fati.Resultat_BR = score;
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
