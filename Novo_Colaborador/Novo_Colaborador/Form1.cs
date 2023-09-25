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

        private string estado = "";

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

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;

            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                estado = selectedRadioButton.Text; // Use o texto do botão de rádio como o estado
            }

            MessageBox.Show(estado);


            //try
            //{
            //    // Configurar o cliente de email SMTP
            //    SmtpClient smtpClient = new SmtpClient("smtp.office365.com");
            //    smtpClient.Port = 587;
            //    smtpClient.Credentials = new System.Net.NetworkCredential("crm@medicalway.com.br", "UNS@mw1315");
            //    smtpClient.EnableSsl = true;

            //    // Criar uma mensagem de email
            //    MailMessage mensagem = new MailMessage();
            //    mensagem.From = new MailAddress("crm@medicalway.com.br");
            //    mensagem.To.Add("fabio@medicalway.com.br"); // Endereço de email do destinatário
            //    //mensagem.To.Add("fabio@medicalway.com.br"); // Endereço de email do segundo destinatário
            //    //mensagem.CC.Add("rh@medicalway.com.br"); //Em cópia
            //    //mensagem.CC.Add("vanessa@medicalway.com.br"); //Em cópia

            //    mensagem.Subject = $"Novo colaborador - {txtNome}"; // Assunto do email
            //    mensagem.Body = $"Bom dia/tarde a todos" +
            //        $"\n @ti favor ciar acessos para novo colaborador\n" +
            //        $"Nome:  {txtNome.Text} Função: {txtFuncao.Text} estado: " +
            //        $"\n Sugestão de e-mail: {txtMail.Text}\n" +
            //        $"Providenciar os equipamentos:  {itens}" +
            //        $"\nPula linha"; // Corpo do email

            //    // Anexar arquivos, se necessário
            //    // mensagem.Attachments.Add(new Attachment("caminho/do/arquivo.pdf"));

            //    // Enviar o email
            //    smtpClient.Send(mensagem);

            //    MessageBox.Show("Email enviado com sucesso!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Ocorreu um erro ao enviar o email: " + ex.Message);
            //}
        }

    }
}
