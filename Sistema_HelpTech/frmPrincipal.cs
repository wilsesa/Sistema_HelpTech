using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_HelpTech
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUsuario usu = new frmUsuario();
            usu.Show();
        }
    }
}
