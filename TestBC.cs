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
    public partial class TestBC : Form
    {


        int questionNumber = 1;
        int score;
        int totalQuestions;
        public TestBC()
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
                //connaissance générale:
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

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_15_26_29_40;

                    lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                                      " Question 3";
                    txtQuestion.Text = "Un risque électrique est-il de matière à provoquer";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "de bûlure";
                    chkAnswer2.Text = "de projections de particules";
                    chkAnswer3.Text = "d'inhalation de gaz nocifs";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = "d'électrocution";

                    break;

                case 4:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.question_mark;

                    lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                                      " Question 4";
                    txtQuestion.Text = "En cas d'accident d'origine électrique, quelle est la première opération " +
                                       " à effectuer:";

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



                ///////////////////////////////////////////////

                case 9:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;
                    pictureBox1.Visible = true;

                    pictureBox1.Image = Properties.Resources.zone_png;

                    lblQuestion.Text = " Environnement - Voisinage" + Environment.NewLine +
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

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.zone_png;

                    lblQuestion.Text = " Environnement - Voisinage" + Environment.NewLine +
                                      " Question 10";
                    txtQuestion.Text = "Habilité BC, pouvez-vous, sans être accompagné, vous approcher à 0.1 m d'un jeu de bar-res 400 V en service," +
                        " nu et accessible ? ";



                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "Oui";
                    chkAnswer2.Text = "Non";
                    chkAnswer3.Visible = false;
                    chkAnswer4.Visible = false;

                    break;

                case 11:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.zone_png;

                    lblQuestion.Text = " Environnement - Voisinage" + Environment.NewLine +
                                      " Question 11";
                    txtQuestion.Text = "Un B0V peut-il travailler, en ayant reçu un ordre préalable et avec ses EPI, à 0.2 m d'une barre nue " +
                        "sous tension 230 Valternatif ? ";




                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "Oui";
                    chkAnswer2.Text = "Non";
                    chkAnswer3.Visible = false;
                    chkAnswer4.Visible = false;

                    break;

                case 12:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.bc_12_13_14_16;

                    lblQuestion.Text = " Environnement - Voisinage" + Environment.NewLine +
                                      " Question 12";
                    txtQuestion.Text = "Quel est le document principal qui vous précise les instructions de sécurité ";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "la norme NF C 15-100";
                    chkAnswer2.Text = "les prescriptions UTE C 18-510";
                    chkAnswer3.Visible = true;
                    chkAnswer3.Text = "le règlement interne de l’entreprise";
                    chkAnswer4.Visible = false;

                    break;
                /////////////////////////////////////////

                case 13:
                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.bc_12_13_14_16;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 13";


                    txtQuestion.Text = "L'habilitation doit-elle être précédée d'une formation ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "Oui";
                    chkAnswer2.Text = "Non";
                    chkAnswer3.Visible = false;
                    chkAnswer4.Visible = false;

                    break;

                case 14:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.bc_12_13_14_16;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 14";


                    txtQuestion.Text = "Vous êtes salarié de l'entreprise, qui doit vous délivrer une habilitation ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "le formateur en sécurité";
                    chkAnswer2.Text = "l'employeur professionnel utilisateur";
                    chkAnswer3.Visible = true;
                    chkAnswer3.Text = "le client";
                    chkAnswer4.Visible = false;

                    break;

                case 15:
                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_15_26_29_40;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 15";
                    txtQuestion.Text = "Vous êtes intérimaire et vous trvaillez dans une entreprise, qui doit vous délivrer une habilitation  ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "le formateur en sécurité";
                    chkAnswer2.Text = "l'employeur professionnel utilisateur";
                    chkAnswer3.Visible = true;
                    chkAnswer3.Text = "le client";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = "L'agence d'intérim";

                    break;

                case 16:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.bc_12_13_14_16;

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

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_17;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 17";
                    txtQuestion.Text = "Quelle 2ème lettre  indique que la titulaire a été pour trailler au VOISINAGE" +
                                       "de pièces électrique nues, accessibles et sous tenion ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "V";
                    chkAnswer2.Text = "T";
                    chkAnswer3.Text = "E";
                    chkAnswer4.Visible = false;

                    break;

                case 18:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_18;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 18";
                    txtQuestion.Text = "Quelle est la première lettre caractérisant le domaine de tension des ouvrages sur" +
                                             "lesquels le titulaire peut travailler ou intervenir du domaine TBT";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "B";
                    chkAnswer3.Text = "H";
                    chkAnswer4.Visible = false;

                    break;

                case 19:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_19_21;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 19";
                    txtQuestion.Text = "Quel est l’indice NUMÉRIQUE définissant le niveau de l'habilitation d'un chargé de travaux  ";



                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "0";
                    chkAnswer2.Text = "1";
                    chkAnswer3.Text = "2";
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

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;
                    pictureBox1.Visible = true;

                    pictureBox1.Image = Properties.Resources.BC_19_21;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 21";
                    txtQuestion.Text = "En tant qu'habilité BC uniquement, peut-on vous demander de remplacer le chargé de travaux ?";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;

                    break;


                case 22:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_22_24_30_41;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 22";
                    txtQuestion.Text = "Habilité BC, pour une consignation pouvez-vous demander à une autre personne de réaliser" +
                                          " les manoeuvres que vous avez prévues ? ";
                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;

                    break;

                case 23:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_23_27_28;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 23";
                    txtQuestion.Text = "Habilité BC, pouvez-vous remettre à un chef de chantier maçon habilité B0V" +
                                              "une attestation de consignation pour travaux";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;

                    break;

                //////////////////////////////////////////////////////////////


                case 24:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_22_24_30_41;

                    lblQuestion.Text = " Activités" + Environment.NewLine +
                                      " Question 24";
                    txtQuestion.Text = "Vous êtes habilité chargé de consignation. Qui doit vous désigner pour" +
                                      " effectuer une consignation?";



                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "le chargé d'exploitation de l'installation où vous allez opérer";
                    chkAnswer2.Text = "le chargé de travaux";
                    chkAnswer3.Text = "le chef de l'établissement où vous allez opérer";
                    chkAnswer4.Visible = false;

                    break;


                case 25:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_25__PNG;

                    lblQuestion.Text = " Activités" + Environment.NewLine +
                                      " Question 25";
                    txtQuestion.Text = "Qui doit vérifier le bon état des matériel et des outillages collctifs?";



                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "le chargé d'intervention";
                    chkAnswer2.Text = "le chargé de travaux";
                    chkAnswer3.Text = "le chargé d'exploitation";
                    chkAnswer4.Visible = false;

                    break;


                case 26:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_15_26_29_40;

                    lblQuestion.Text = " Activités" + Environment.NewLine +
                                      " Question 26";
                    txtQuestion.Text = "Plusieurs équipes travaillent sur l'installation : Est-il recommandé de désigner" +
                                         " plusieurs chargés de consignation ? ";

                    chkAnswer1.Visible = false;
                    chkAnswer2.Text = "Oui";
                    chkAnswer3.Text = "Non";
                    chkAnswer4.Visible = false;

                    break;

                case 27:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_23_27_28;

                    lblQuestion.Text = " Activités" + Environment.NewLine +
                                      " Question 27";
                    txtQuestion.Text = "Par quels moyens peut-on transmettre une attestation de consignation :";



                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "de la main à la main ";
                    chkAnswer2.Text = " par téléphone, sans message particulier";
                    chkAnswer3.Text = "par message collationné ";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = "par télécopie aller-retour avec échange de n°";
                    break;


                case 28:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_23_27_28;

                    lblQuestion.Text = " Activités" + Environment.NewLine +
                                      " Question 28";
                    txtQuestion.Text = "Que DOIT faire le chargé de travaux qui reçoit l'attestation de consignation ?";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "la lire attentivement, demander éventuellement des éclaircissements notamment" +
                                        "sur les limites et/ou des modifications ";
                    chkAnswer2.Text = "la dater, la signer, la compléter, en remettre le double au rédacteur";
                    chkAnswer3.Text = "se contenter de la signer our accord, en remettant le double au rédacteur";
                    chkAnswer4.Visible = false;


                    break;


                case 29:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_15_26_29_40;

                    lblQuestion.Text = " Activités" + Environment.NewLine +
                                      " Question 29";
                    txtQuestion.Text = "La condamnation d'un appareil exige-t-elle une signalisation ? ";



                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "Oui";
                    chkAnswer2.Text = "Non";
                    chkAnswer3.Visible = false;
                    chkAnswer4.Visible = false;

                    break;

                case 30:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_22_24_30_41;

                    lblQuestion.Text = " Activités" + Environment.NewLine +
                                      " Question 30";
                    txtQuestion.Text = "À la fin des opérations, le chargé de consignation";




                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = " remet en service dès qu'il juge les opérations terminées ?";
                    chkAnswer2.Text = "remet en service quand le chargé de travaux lui dit avoir terminé";
                    chkAnswer3.Visible = true;
                    chkAnswer3.Text = "attend de recevoir l'avis de fin d'opération daté et signé ?";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = "avertir le chargé d'exploitation pour remise en service";

                    break;


                case 31:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_31_32;

                    lblQuestion.Text = " Activités" + Environment.NewLine +
                                      " Question 31";
                    txtQuestion.Text = " Pour toutes opérations sur des installations BT mises hors tension, est-il" +
                                                 "obligatoire de Vérifier l’Absence de Tension ";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = " Oui ";
                    chkAnswer2.Text = "Non";
                    chkAnswer3.Visible = false;
                    chkAnswer4.Visible = false;


                    break;

                case 32:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_31_32;

                    lblQuestion.Text = " Activités" + Environment.NewLine +
                                      " Question 32";
                    txtQuestion.Text = " Le fonctionnement du vérificateur d’absence de tension doit-il être vérifié :";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = " avant la VAT ";
                    chkAnswer2.Text = "après la VAT";
                    chkAnswer3.Visible = false;
                    chkAnswer4.Visible = false;


                    break;


                case 33:
                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_33_34_35_36_38;

                    lblQuestion.Text = " Activités" + Environment.NewLine +
                                      " Question 33";
                    txtQuestion.Text = "La mise en court-circuit et à la terre protège :";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "  des risques d’induction ";
                    chkAnswer2.Text = "des retours de tension intempestifs (groupe électrogène, moteur avec" +
                                        "charge entraînante)";
                    chkAnswer3.Visible = false;
                    chkAnswer4.Visible = false;


                    break;


                case 34:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_33_34_35_36_38;

                    lblQuestion.Text = " Activités" + Environment.NewLine +
                                      " Question 34";
                    txtQuestion.Text = "Une mise à la terre commence par la connexion du dispositif ";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = " sur la partie électrique la plus proche ";
                    chkAnswer2.Text = "sur le circuit de terre";
                    chkAnswer3.Visible = true;
                    chkAnswer3.Text = "indifféremment";
                    chkAnswer4.Visible = false;


                    break;

                case 35:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_33_34_35_36_38;

                    lblQuestion.Text = " Activités" + Environment.NewLine +
                                      " Question 35";
                    txtQuestion.Text = "Où doit-on effectuer la VAT, la mise à la terre et en court-circuit" +
                                                    "sur une installation BT ";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "  aussi près que possible du lieu de travail ";
                    chkAnswer2.Text = " sur tous les conducteurs actifs y compris le neutreaprès la VAT";
                    chkAnswer3.Visible = false;
                    chkAnswer4.Visible = false;


                    break;

                case 36:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_33_34_35_36_38;

                    lblQuestion.Text = " Activités" + Environment.NewLine +
                                      " Question 36";
                    txtQuestion.Text = "  Sur une installation BT, la pose des MALT / CC est-elle obligatoire ?";



                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = " Oui ";
                    chkAnswer2.Text = "Non";
                    chkAnswer3.Visible = false;
                    chkAnswer4.Visible = false;


                    break;


                case 37:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_37;

                    lblQuestion.Text = " Activités" + Environment.NewLine +
                                      " Question 37";
                    txtQuestion.Text = "Sur un câble isolé, les mises à la terre et en court-circuit (MALT et CC)" +
                                                           "sont posées :  ";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "  de part et d’autres du lieu de la zone de travail ";
                    chkAnswer2.Text = " aux points de séparation de l’ouvrage sur lequel l’opération est effectuée  ";
                    chkAnswer3.Visible = true;
                    chkAnswer3.Text = "au plus près de la zone de travail ";
                    chkAnswer4.Visible = false;


                    break;


                case 38:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_33_34_35_36_38;

                    lblQuestion.Text = " Activités" + Environment.NewLine +
                                      " Question 38";
                    txtQuestion.Text = " Faut-il impérativement mettre en place les MALT et CC :";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "sur un long câble BT ";
                    chkAnswer2.Text = "sur une installation avec risque de réalimentation BT";
                    chkAnswer3.Visible = true;
                    chkAnswer3.Text = " sur une installation avec risque de tension induite ";
                    chkAnswer4.Visible = false;


                    break;


                case 39:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.bcC_39;

                    lblQuestion.Text = " Activités" + Environment.NewLine +
                                      " Question 39";
                    txtQuestion.Text = "Existe-t-il un moyen sûr d’identifier UN câble parmi d’autres" +
                                                "câbles non repérés ";



                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = " Oui ";
                    chkAnswer2.Text = "Non";
                    chkAnswer3.Visible = false;
                    chkAnswer4.Visible = false;


                    break;

                case 40:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_15_26_29_40;

                    lblQuestion.Text = " Activités" + Environment.NewLine +
                                      " Question 40";
                    txtQuestion.Text = "Sur un câble souterrain BT votre équipe doit poser une boite de dérivation" +
                                     "le chargé de consignation peut-il vous remettre au chargé de travaux une attestation" +
                                           " de 1ère étape de consignation ?";



                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = " Oui ";
                    chkAnswer2.Text = "Non";
                    chkAnswer3.Visible = false;
                    chkAnswer4.Visible = false;


                    break;

                case 41:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_22_24_30_41;

                    lblQuestion.Text = " Activités" + Environment.NewLine +
                                      " Question 41";
                    txtQuestion.Text = "A la fin des opérations, le chargé de consignation :";


                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "remet en service dès qu’il juge les opérations terminées ";
                    chkAnswer2.Text = "remet en service quand le chargé de travaux lui dit avoir terminé";
                    chkAnswer3.Visible = true;
                    chkAnswer3.Text = "attend de recevoir l’avis de fin d’opération daté et signé ";
                    chkAnswer4.Visible = true;
                    chkAnswer4.Text = "avertir le chargé d’exploitation pour remise en service ";


                    break;

                case 42:
                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.DDR_8;

                    lblQuestion.Text = " connaissances générales" + Environment.NewLine +
                                      " Question 42";
                    txtQuestion.Text = "Un dispositif différentiel à courant résiduel (DDR) à haute sensibilté de 30 mA protège:";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "les outils électriques";
                    chkAnswer2.Text = "les personnes utilisant ces outils";
                    chkAnswer3.Text = "les installations électriques";
                    chkAnswer4.Visible = false;

                    break;


                case 43:

                    grpMultipleChoice.Visible = true;
                    grpimage.Visible = false;

                    pictureBox1.Image = Properties.Resources.BC_20;

                    lblQuestion.Text = " Habilitations" + Environment.NewLine +
                                      " Question 43";
                    txtQuestion.Text = " Quelle est l'habilitation d'un électricien Chargé d'interventions";

                    chkAnswer1.Visible = true;
                    chkAnswer1.Text = "BR";
                    chkAnswer2.Text = "BS";
                    chkAnswer3.Text = "BC";
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

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 3:

                    if ((chkAnswer1.Checked == true) && (chkAnswer2.Checked == true) && (chkAnswer3.Checked == true) && (chkAnswer4.Checked == true))
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

                    if (chkAnswer2.Checked == true)
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

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 11:

                    if (chkAnswer1.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 12:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 13:

                    if (chkAnswer1.Checked == true)
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

                    if ((chkAnswer1.Checked == true) && (chkAnswer3.Checked == true))
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

                    if (chkAnswer3.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 27:

                    if ((chkAnswer1.Checked == true) && (chkAnswer3.Checked == true) && (chkAnswer4.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 28:

                    if ((chkAnswer1.Checked == true) && (chkAnswer2.Checked == true))
                    {

                        score++;
                    }

                    break;


                case 29:

                    if (chkAnswer1.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 30:

                    if ((chkAnswer3.Checked == true) && (chkAnswer4.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 31:

                    if (chkAnswer1.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 32:

                    if ((chkAnswer1.Checked == true) && (chkAnswer2.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 33:

                    if ((chkAnswer1.Checked == true) && (chkAnswer2.Checked == true))
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

                    if ((chkAnswer1.Checked == true) && (chkAnswer2.Checked == true))
                    {

                        score++;
                    }

                    break;


                case 36:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 37:

                    if ((chkAnswer2.Checked == true) && (chkAnswer3.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 38:

                    if ((chkAnswer1.Checked == true) && (chkAnswer2.Checked == true) && (chkAnswer3.Checked == true))
                    {

                        score++;
                    }

                    break;

                case 39:

                    if (chkAnswer1.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 40:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;

                case 41:

                    if ((chkAnswer3.Checked == true) && (chkAnswer4.Checked == true))
                    {

                        score++;
                    }

                    break;


                case 42:

                    if (chkAnswer2.Checked == true)
                    {

                        score++;
                    }

                    break;


                case 43:

                    if (chkAnswer1.Checked == true)
                    {

                        score++;
                    }

                    break;

            }
        }


        private void TestBC_Load(object sender, EventArgs e)
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
                ScoreBC fati = new ScoreBC();
                fati.Resultat_BC = score;
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
