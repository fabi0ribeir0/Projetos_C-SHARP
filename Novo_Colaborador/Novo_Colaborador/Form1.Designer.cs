namespace Novo_Colaborador
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rbPR = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbRS = new System.Windows.Forms.RadioButton();
            this.rbSC = new System.Windows.Forms.RadioButton();
            this.chbTela = new System.Windows.Forms.CheckBox();
            this.chbCel = new System.Windows.Forms.CheckBox();
            this.chbNote = new System.Windows.Forms.CheckBox();
            this.chbChip = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtSolicitado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnProc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Eras Bold ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(82, 127);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(307, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Novo colaborador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Novo_Colaborador.Properties.Resources.logo_medicalway;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(12, 252);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(450, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // rbPR
            // 
            this.rbPR.AutoSize = true;
            this.rbPR.Location = new System.Drawing.Point(12, 358);
            this.rbPR.Name = "rbPR";
            this.rbPR.Size = new System.Drawing.Size(59, 17);
            this.rbPR.TabIndex = 3;
            this.rbPR.Text = "Paraná";
            this.rbPR.UseVisualStyleBackColor = true;
            this.rbPR.CheckedChanged += new System.EventHandler(this.rbPR_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Função";
            // 
            // txtFuncao
            // 
            this.txtFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncao.Location = new System.Drawing.Point(12, 300);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(450, 22);
            this.txtFuncao.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estado";
            // 
            // rbRS
            // 
            this.rbRS.AutoSize = true;
            this.rbRS.Location = new System.Drawing.Point(12, 422);
            this.rbRS.Name = "rbRS";
            this.rbRS.Size = new System.Drawing.Size(112, 17);
            this.rbRS.TabIndex = 5;
            this.rbRS.Text = "Rio Grande do Sul";
            this.rbRS.UseVisualStyleBackColor = true;
            this.rbRS.CheckedChanged += new System.EventHandler(this.rbRS_CheckedChanged);
            // 
            // rbSC
            // 
            this.rbSC.AutoSize = true;
            this.rbSC.Location = new System.Drawing.Point(12, 390);
            this.rbSC.Name = "rbSC";
            this.rbSC.Size = new System.Drawing.Size(95, 17);
            this.rbSC.TabIndex = 4;
            this.rbSC.Text = "Santa Catarina";
            this.rbSC.UseVisualStyleBackColor = true;
            this.rbSC.CheckedChanged += new System.EventHandler(this.rbSC_CheckedChanged);
            // 
            // chbTela
            // 
            this.chbTela.AutoSize = true;
            this.chbTela.Location = new System.Drawing.Point(262, 431);
            this.chbTela.Name = "chbTela";
            this.chbTela.Size = new System.Drawing.Size(93, 17);
            this.chbTela.TabIndex = 9;
            this.chbTela.Text = "Segunda Tela";
            this.chbTela.UseVisualStyleBackColor = true;
            // 
            // chbCel
            // 
            this.chbCel.AutoSize = true;
            this.chbCel.Location = new System.Drawing.Point(262, 407);
            this.chbCel.Name = "chbCel";
            this.chbCel.Size = new System.Drawing.Size(58, 17);
            this.chbCel.TabIndex = 8;
            this.chbCel.Text = "Celular";
            this.chbCel.UseVisualStyleBackColor = true;
            // 
            // chbNote
            // 
            this.chbNote.AutoSize = true;
            this.chbNote.Location = new System.Drawing.Point(262, 359);
            this.chbNote.Name = "chbNote";
            this.chbNote.Size = new System.Drawing.Size(73, 17);
            this.chbNote.TabIndex = 6;
            this.chbNote.Text = "Notebook";
            this.chbNote.UseVisualStyleBackColor = true;
            // 
            // chbChip
            // 
            this.chbChip.AutoSize = true;
            this.chbChip.Location = new System.Drawing.Point(262, 383);
            this.chbChip.Name = "chbChip";
            this.chbChip.Size = new System.Drawing.Size(47, 17);
            this.chbChip.TabIndex = 7;
            this.chbChip.Text = "Chip";
            this.chbChip.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Equipamentos";
            // 
            // txtMail
            // 
            this.txtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtMail.Location = new System.Drawing.Point(12, 476);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(450, 20);
            this.txtMail.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(425, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sugestão de E-mail (pode ser alterado caso não disponível)";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(165, 561);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(145, 38);
            this.btnEnviar.TabIndex = 12;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            this.btnEnviar.MouseEnter += new System.EventHandler(this.btnEnviar_MouseEnter);
            this.btnEnviar.MouseLeave += new System.EventHandler(this.btnEnviar_MouseLeave);
            // 
            // txtSolicitado
            // 
            this.txtSolicitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolicitado.Location = new System.Drawing.Point(12, 530);
            this.txtSolicitado.Name = "txtSolicitado";
            this.txtSolicitado.Size = new System.Drawing.Size(450, 22);
            this.txtSolicitado.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Solicitado por";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 197);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Data de inicio";
            // 
            // btnProc
            // 
            this.btnProc.BackColor = System.Drawing.Color.DarkBlue;
            this.btnProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProc.ForeColor = System.Drawing.Color.White;
            this.btnProc.Location = new System.Drawing.Point(262, 189);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(200, 38);
            this.btnProc.TabIndex = 17;
            this.btnProc.Text = "Procurar Solicitações";
            this.btnProc.UseVisualStyleBackColor = false;
            this.btnProc.MouseEnter += new System.EventHandler(this.btnProc_MouseEnter);
            this.btnProc.MouseLeave += new System.EventHandler(this.btnProc_MouseLeave);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(474, 611);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chbTela);
            this.Controls.Add(this.rbRS);
            this.Controls.Add(this.chbCel);
            this.Controls.Add(this.txtSolicitado);
            this.Controls.Add(this.chbNote);
            this.Controls.Add(this.chbChip);
            this.Controls.Add(this.rbPR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbSC);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFuncao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Formulário";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rbPR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbSC;
        private System.Windows.Forms.RadioButton rbRS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbNote;
        private System.Windows.Forms.CheckBox chbChip;
        private System.Windows.Forms.CheckBox chbCel;
        private System.Windows.Forms.CheckBox chbTela;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtSolicitado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnProc;
    }
}

