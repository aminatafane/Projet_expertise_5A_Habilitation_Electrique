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
    public partial class FOLIO007 : Form
    {
        public FOLIO007()
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
    }
}
