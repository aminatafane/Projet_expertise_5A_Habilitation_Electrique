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
    public partial class Habilitation_Electrique : Form
    {
        private int childFormNumber = 0;

        public Habilitation_Electrique()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

           
        }

        private void viewMenu_Click(object sender, EventArgs e)
        {
            Formation_Théorique fati = new Formation_Théorique();
            fati.Show();
            // this.Hide();
           
        }

        private void Habilitation_Electrique_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolsMenu_Click(object sender, EventArgs e)
        {
            Fiche_pratique fs = new Fiche_pratique();
            fs.Show();
            fs.Size = new Size(1070, 660);
            // this.Hide();
          
        }

        private void editMenu_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.chapitr1);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void leRisqueÉlectriqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.chap2);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void analyseDuRisqueÉlectriqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.chap3);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void analyseDuRisqueÉlectriqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.chap4);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void habilitationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.chap7);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void interventionsBTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.chap73);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void laRégulémentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.chap5);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void délimitationDesZonesDaccèsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.CHAP6);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void travauxDordreNonÉlectriqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.chap71);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void laConsignationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.chap72);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void opéationsSpécifiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.chap74);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void systèmesHaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.chap75);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void systèmeHabilisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a temporal file
            string file = Path.GetTempFileName() + ".pdf";
            //write to file
            File.WriteAllBytes(file, Properties.Resources.Notice);

            //open with default viewer
            System.Diagnostics.Process.Start(file);
        }

        private void systèmeHabilisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void systèmeHabilisToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Habilis fs = new Habilis();
            fs.Show();
            fs.Size = new Size(1070, 660);
            // this.Hide();
        }

        private void comprendreLeSchémaÉlectriqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void partieToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Comprendre_le_schema_électrique fs = new Comprendre_le_schema_électrique();
            fs.Show();
            fs.Size = new Size(1070, 660);
            // this.Hide();
        }

        private void partieCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            partie_commande fs = new partie_commande();
            fs.Show();
            fs.Size = new Size(1070, 660);
            // this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void partieCommande2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
