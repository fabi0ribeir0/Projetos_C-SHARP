using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novo_Colaborador
{
    public partial class frmPrincipal : Form
    {
        private Color backgroundColor = Color.FromArgb(0xE7, 0xFE, 0xFB);

        
        public frmPrincipal()
        {
            InitializeComponent();
        }



        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.BackColor = backgroundColor;
        }
    }
}
