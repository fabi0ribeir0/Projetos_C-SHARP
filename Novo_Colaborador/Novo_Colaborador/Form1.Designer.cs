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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbSC = new System.Windows.Forms.RadioButton();
            this.rbRS = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.chbNote = new System.Windows.Forms.CheckBox();
            this.chbChip = new System.Windows.Forms.CheckBox();
            this.chbCel = new System.Windows.Forms.CheckBox();
            this.chbTela = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Eras Bold ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(196, 128);
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(658, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 232);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(397, 20);
            this.txtNome.TabIndex = 3;
            // 
            // rbPR
            // 
            this.rbPR.AutoSize = true;
            this.rbPR.Checked = true;
            this.rbPR.Location = new System.Drawing.Point(3, 7);
            this.rbPR.Name = "rbPR";
            this.rbPR.Size = new System.Drawing.Size(59, 17);
            this.rbPR.TabIndex = 5;
            this.rbPR.TabStop = true;
            this.rbPR.Text = "Paraná";
            this.rbPR.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Função";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbRS);
            this.panel1.Controls.Add(this.rbPR);
            this.panel1.Controls.Add(this.rbSC);
            this.panel1.Location = new System.Drawing.Point(12, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 9;
            // 
            // rbSC
            // 
            this.rbSC.AutoSize = true;
            this.rbSC.Location = new System.Drawing.Point(3, 39);
            this.rbSC.Name = "rbSC";
            this.rbSC.Size = new System.Drawing.Size(95, 17);
            this.rbSC.TabIndex = 6;
            this.rbSC.Text = "Santa Catarina";
            this.rbSC.UseVisualStyleBackColor = true;
            // 
            // rbRS
            // 
            this.rbRS.AutoSize = true;
            this.rbRS.Location = new System.Drawing.Point(3, 71);
            this.rbRS.Name = "rbRS";
            this.rbRS.Size = new System.Drawing.Size(112, 17);
            this.rbRS.TabIndex = 10;
            this.rbRS.Text = "Rio Grande do Sul";
            this.rbRS.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chbTela);
            this.panel2.Controls.Add(this.chbCel);
            this.panel2.Controls.Add(this.chbNote);
            this.panel2.Controls.Add(this.chbChip);
            this.panel2.Location = new System.Drawing.Point(288, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Equipamentos";
            // 
            // chbNote
            // 
            this.chbNote.AutoSize = true;
            this.chbNote.Location = new System.Drawing.Point(3, 8);
            this.chbNote.Name = "chbNote";
            this.chbNote.Size = new System.Drawing.Size(73, 17);
            this.chbNote.TabIndex = 12;
            this.chbNote.Text = "Notebook";
            this.chbNote.UseVisualStyleBackColor = true;
            // 
            // chbChip
            // 
            this.chbChip.AutoSize = true;
            this.chbChip.Location = new System.Drawing.Point(3, 32);
            this.chbChip.Name = "chbChip";
            this.chbChip.Size = new System.Drawing.Size(47, 17);
            this.chbChip.TabIndex = 13;
            this.chbChip.Text = "Chip";
            this.chbChip.UseVisualStyleBackColor = true;
            // 
            // chbCel
            // 
            this.chbCel.AutoSize = true;
            this.chbCel.Location = new System.Drawing.Point(3, 56);
            this.chbCel.Name = "chbCel";
            this.chbCel.Size = new System.Drawing.Size(58, 17);
            this.chbCel.TabIndex = 14;
            this.chbCel.Text = "Celular";
            this.chbCel.UseVisualStyleBackColor = true;
            // 
            // chbTela
            // 
            this.chbTela.AutoSize = true;
            this.chbTela.Location = new System.Drawing.Point(3, 80);
            this.chbTela.Name = "chbTela";
            this.chbTela.Size = new System.Drawing.Size(93, 17);
            this.chbTela.TabIndex = 15;
            this.chbTela.Text = "Segunda Tela";
            this.chbTela.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 483);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(397, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "E-mail";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbSC;
        private System.Windows.Forms.RadioButton rbRS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbNote;
        private System.Windows.Forms.CheckBox chbChip;
        private System.Windows.Forms.CheckBox chbCel;
        private System.Windows.Forms.CheckBox chbTela;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
    }
}

