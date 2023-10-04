using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRH
{
    public partial class FrmPrincipal : MetroSetForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ControlButon.Location = new Point(1164, 27);
            txtRG.MaxLength = 
        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Apenas numeros
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Ignora caracteres que não numero

                e.Handled = true;
            }
        }
    }
}
