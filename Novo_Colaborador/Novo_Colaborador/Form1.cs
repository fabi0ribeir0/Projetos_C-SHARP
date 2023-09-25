using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novo_Colaborador
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        
        private Color backgroundColor = Color.FromArgb(0xE7, 0xFE, 0xFB);

        public void limpar()
        {
            txtNome.Clear();
            txtFuncao.Clear();
            txtMail.Clear();
            chbCel.Checked = false;
            chbChip.Checked = false;
            chbNote.Checked = false;
            chbTela.Checked = false;
            rbPR.Checked = true;
        }

        static string RemoverAcentos(string mail)
        {
            // Remove acentos usando uma expressão regular
            string semAcentos = Regex.Replace(mail, "[áàâãäÁÀÂÃÄ]", "a");
            semAcentos = Regex.Replace(semAcentos, "[éèêëÉÈÊË]", "e");
            semAcentos = Regex.Replace(semAcentos, "[íìîïÍÌÎÏ]", "i");
            semAcentos = Regex.Replace(semAcentos, "[óòôõöÓÒÔÕÖ]", "o");
            semAcentos = Regex.Replace(semAcentos, "[úùûüÚÙÛÜ]", "u");
            semAcentos = Regex.Replace(semAcentos, "[çÇ]", "c");
            return semAcentos;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.BackColor = backgroundColor;
            lblTitulo.ForeColor = Color.FromArgb(0x08, 0x95, 0x89);
        }


        private void btnEnviar_MouseEnter(object sender, EventArgs e)
        {
            btnEnviar.BackColor = Color.White;
            btnEnviar.ForeColor = Color.FromArgb(0x00, 0x64, 0x00);
        }

        private void btnEnviar_MouseLeave(object sender, EventArgs e)
        {
            btnEnviar.ForeColor = Color.White;
            btnEnviar.BackColor = Color.FromArgb(0x00, 0x64, 0x00);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enviou");
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                string inputString = txtNome.Text;
                string mail;

                // Divida a string em palavras usando espaço como delimitador
                string[] palavras = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Crie um array com o número de elementos correspondente ao número de palavras
                string[] arrayDePalavras = new string[palavras.Length];

                int numeroDePalavras = palavras.Length;

                // Copie as palavras para o novo array
                Array.Copy(palavras, arrayDePalavras, palavras.Length);


                if (numeroDePalavras > 1)
                {
                    if (arrayDePalavras[1] == "DA" || arrayDePalavras[1] == "DE" || arrayDePalavras[1] == "DO" || arrayDePalavras[1] == "DAS" || arrayDePalavras[1] == "DOS")
                    {
                        mail = arrayDePalavras[0] + "." + arrayDePalavras[2];
                    }
                    else { mail = arrayDePalavras[0] + "." + arrayDePalavras[1]; }

                }
                else { mail = arrayDePalavras[0]; }

                string resultado = RemoverAcentos(mail);

                txtMail.Text = resultado + "@medicalway.com.br";
            }

        }
    }
}
