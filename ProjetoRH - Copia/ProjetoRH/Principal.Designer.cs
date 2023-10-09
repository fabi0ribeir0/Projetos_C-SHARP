namespace ProjetoRH
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.TabControl = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabFuncionariosAtivos = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.tabFeriasAgendadas = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.tabFeriasVencer = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Desligamentos = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.ControlButon = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabDadosBasicos = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabAdmissao = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.tabContratoExp = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.tabHorario = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.metroSetLabel30 = new MetroSet_UI.Controls.MetroSetLabel();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.metroSetLabel31 = new MetroSet_UI.Controls.MetroSetLabel();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.metroSetLabel32 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel33 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel34 = new MetroSet_UI.Controls.MetroSetLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroSetLabel35 = new MetroSet_UI.Controls.MetroSetLabel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.metroSetLabel36 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel37 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetComboBox7 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel38 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetComboBox8 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.metroSetLabel39 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetComboBox9 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel40 = new MetroSet_UI.Controls.MetroSetLabel();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.metroSetLabel41 = new MetroSet_UI.Controls.MetroSetLabel();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.metroSetLabel42 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel43 = new MetroSet_UI.Controls.MetroSetLabel();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.metroSetLabel44 = new MetroSet_UI.Controls.MetroSetLabel();
            this.TabControl.SuspendLayout();
            this.tabFuncionariosAtivos.SuspendLayout();
            this.metroSetTabControl1.SuspendLayout();
            this.tabDadosBasicos.SuspendLayout();
            this.tabAdmissao.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.TabControl.AnimateTime = 200;
            this.TabControl.BackgroundColor = System.Drawing.Color.White;
            this.TabControl.Controls.Add(this.tabFuncionariosAtivos);
            this.TabControl.Controls.Add(this.tabFeriasAgendadas);
            this.TabControl.Controls.Add(this.tabFeriasVencer);
            this.TabControl.Controls.Add(this.Desligamentos);
            this.TabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.TabControl.IsDerivedStyle = true;
            this.TabControl.ItemSize = new System.Drawing.Size(100, 38);
            this.TabControl.Location = new System.Drawing.Point(4, 84);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.SelectedTextColor = System.Drawing.Color.White;
            this.TabControl.Size = new System.Drawing.Size(1271, 812);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.Speed = 100;
            this.TabControl.Style = MetroSet_UI.Enums.Style.Light;
            this.TabControl.StyleManager = null;
            this.TabControl.TabIndex = 1;
            this.TabControl.ThemeAuthor = "Narwin";
            this.TabControl.ThemeName = "MetroLight";
            this.TabControl.UnselectedTextColor = System.Drawing.Color.Gray;
            this.TabControl.UseAnimation = false;
            // 
            // tabFuncionariosAtivos
            // 
            this.tabFuncionariosAtivos.BaseColor = System.Drawing.Color.White;
            this.tabFuncionariosAtivos.Controls.Add(this.label2);
            this.tabFuncionariosAtivos.Controls.Add(this.metroSetTabControl1);
            this.tabFuncionariosAtivos.Font = null;
            this.tabFuncionariosAtivos.ImageIndex = 0;
            this.tabFuncionariosAtivos.ImageKey = null;
            this.tabFuncionariosAtivos.IsDerivedStyle = true;
            this.tabFuncionariosAtivos.Location = new System.Drawing.Point(4, 42);
            this.tabFuncionariosAtivos.Name = "tabFuncionariosAtivos";
            this.tabFuncionariosAtivos.Size = new System.Drawing.Size(1263, 766);
            this.tabFuncionariosAtivos.Style = MetroSet_UI.Enums.Style.Light;
            this.tabFuncionariosAtivos.StyleManager = null;
            this.tabFuncionariosAtivos.TabIndex = 1;
            this.tabFuncionariosAtivos.Text = "Novo Colaborador";
            this.tabFuncionariosAtivos.ThemeAuthor = "Narwin";
            this.tabFuncionariosAtivos.ThemeName = "MetroLite";
            this.tabFuncionariosAtivos.ToolTipText = null;
            // 
            // tabFeriasAgendadas
            // 
            this.tabFeriasAgendadas.BaseColor = System.Drawing.Color.White;
            this.tabFeriasAgendadas.Font = null;
            this.tabFeriasAgendadas.ImageIndex = 0;
            this.tabFeriasAgendadas.ImageKey = null;
            this.tabFeriasAgendadas.IsDerivedStyle = true;
            this.tabFeriasAgendadas.Location = new System.Drawing.Point(4, 42);
            this.tabFeriasAgendadas.Name = "tabFeriasAgendadas";
            this.tabFeriasAgendadas.Size = new System.Drawing.Size(1263, 766);
            this.tabFeriasAgendadas.Style = MetroSet_UI.Enums.Style.Light;
            this.tabFeriasAgendadas.StyleManager = null;
            this.tabFeriasAgendadas.TabIndex = 2;
            this.tabFeriasAgendadas.Text = "Férias agendadas";
            this.tabFeriasAgendadas.ThemeAuthor = "Narwin";
            this.tabFeriasAgendadas.ThemeName = "MetroLite";
            this.tabFeriasAgendadas.ToolTipText = null;
            // 
            // tabFeriasVencer
            // 
            this.tabFeriasVencer.BaseColor = System.Drawing.Color.White;
            this.tabFeriasVencer.Font = null;
            this.tabFeriasVencer.ImageIndex = 0;
            this.tabFeriasVencer.ImageKey = null;
            this.tabFeriasVencer.IsDerivedStyle = true;
            this.tabFeriasVencer.Location = new System.Drawing.Point(4, 42);
            this.tabFeriasVencer.Name = "tabFeriasVencer";
            this.tabFeriasVencer.Size = new System.Drawing.Size(1263, 766);
            this.tabFeriasVencer.Style = MetroSet_UI.Enums.Style.Light;
            this.tabFeriasVencer.StyleManager = null;
            this.tabFeriasVencer.TabIndex = 3;
            this.tabFeriasVencer.Text = "Férias a vencer";
            this.tabFeriasVencer.ThemeAuthor = "Narwin";
            this.tabFeriasVencer.ThemeName = "MetroLite";
            this.tabFeriasVencer.ToolTipText = null;
            // 
            // Desligamentos
            // 
            this.Desligamentos.BaseColor = System.Drawing.Color.White;
            this.Desligamentos.Font = null;
            this.Desligamentos.ImageIndex = 0;
            this.Desligamentos.ImageKey = null;
            this.Desligamentos.IsDerivedStyle = true;
            this.Desligamentos.Location = new System.Drawing.Point(4, 42);
            this.Desligamentos.Name = "Desligamentos";
            this.Desligamentos.Size = new System.Drawing.Size(1263, 766);
            this.Desligamentos.Style = MetroSet_UI.Enums.Style.Light;
            this.Desligamentos.StyleManager = null;
            this.Desligamentos.TabIndex = 4;
            this.Desligamentos.Text = "Desligamentos";
            this.Desligamentos.ThemeAuthor = "Narwin";
            this.Desligamentos.ThemeName = "MetroLite";
            this.Desligamentos.ToolTipText = null;
            // 
            // ControlButon
            // 
            this.ControlButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlButon.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ControlButon.CloseHoverForeColor = System.Drawing.Color.White;
            this.ControlButon.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.ControlButon.DisabledForeColor = System.Drawing.Color.DimGray;
            this.ControlButon.IsDerivedStyle = true;
            this.ControlButon.Location = new System.Drawing.Point(1164, 27);
            this.ControlButon.MaximizeBox = true;
            this.ControlButon.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ControlButon.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.ControlButon.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.ControlButon.MinimizeBox = true;
            this.ControlButon.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ControlButon.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.ControlButon.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.ControlButon.Name = "ControlButon";
            this.ControlButon.Size = new System.Drawing.Size(100, 25);
            this.ControlButon.Style = MetroSet_UI.Enums.Style.Light;
            this.ControlButon.StyleManager = null;
            this.ControlButon.TabIndex = 2;
            this.ControlButon.Text = "metroSetControlBox1";
            this.ControlButon.ThemeAuthor = "Narwin";
            this.ControlButon.ThemeName = "MetroLight";
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Controls.Add(this.tabDadosBasicos);
            this.metroSetTabControl1.Controls.Add(this.tabAdmissao);
            this.metroSetTabControl1.Controls.Add(this.tabContratoExp);
            this.metroSetTabControl1.Controls.Add(this.tabHorario);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetTabControl1.IsDerivedStyle = true;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl1.Location = new System.Drawing.Point(0, 65);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 1;
            this.metroSetTabControl1.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Size = new System.Drawing.Size(1263, 701);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 100;
            this.metroSetTabControl1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTabControl1.StyleManager = null;
            this.metroSetTabControl1.TabIndex = 0;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroLite";
            this.metroSetTabControl1.UnselectedTextColor = System.Drawing.Color.Gray;
            this.metroSetTabControl1.UseAnimation = false;
            // 
            // tabDadosBasicos
            // 
            this.tabDadosBasicos.BaseColor = System.Drawing.Color.White;
            this.tabDadosBasicos.Controls.Add(this.textBox10);
            this.tabDadosBasicos.Controls.Add(this.metroSetLabel39);
            this.tabDadosBasicos.Controls.Add(this.metroSetComboBox9);
            this.tabDadosBasicos.Controls.Add(this.metroSetLabel40);
            this.tabDadosBasicos.Controls.Add(this.textBox11);
            this.tabDadosBasicos.Controls.Add(this.metroSetLabel41);
            this.tabDadosBasicos.Controls.Add(this.maskedTextBox4);
            this.tabDadosBasicos.Controls.Add(this.metroSetLabel42);
            this.tabDadosBasicos.Controls.Add(this.metroSetLabel43);
            this.tabDadosBasicos.Controls.Add(this.textBox12);
            this.tabDadosBasicos.Controls.Add(this.textBox13);
            this.tabDadosBasicos.Controls.Add(this.metroSetLabel44);
            this.tabDadosBasicos.Controls.Add(this.textBox7);
            this.tabDadosBasicos.Controls.Add(this.textBox8);
            this.tabDadosBasicos.Controls.Add(this.maskedTextBox1);
            this.tabDadosBasicos.Controls.Add(this.metroSetLabel30);
            this.tabDadosBasicos.Controls.Add(this.maskedTextBox2);
            this.tabDadosBasicos.Controls.Add(this.metroSetLabel31);
            this.tabDadosBasicos.Controls.Add(this.maskedTextBox3);
            this.tabDadosBasicos.Controls.Add(this.metroSetLabel32);
            this.tabDadosBasicos.Controls.Add(this.metroSetLabel33);
            this.tabDadosBasicos.Controls.Add(this.metroSetLabel34);
            this.tabDadosBasicos.Controls.Add(this.dateTimePicker1);
            this.tabDadosBasicos.Controls.Add(this.metroSetLabel35);
            this.tabDadosBasicos.Font = null;
            this.tabDadosBasicos.ImageIndex = 0;
            this.tabDadosBasicos.ImageKey = null;
            this.tabDadosBasicos.IsDerivedStyle = true;
            this.tabDadosBasicos.Location = new System.Drawing.Point(4, 42);
            this.tabDadosBasicos.Name = "tabDadosBasicos";
            this.tabDadosBasicos.Size = new System.Drawing.Size(1255, 655);
            this.tabDadosBasicos.Style = MetroSet_UI.Enums.Style.Light;
            this.tabDadosBasicos.StyleManager = null;
            this.tabDadosBasicos.TabIndex = 0;
            this.tabDadosBasicos.Text = "DADOS BÁSICOS";
            this.tabDadosBasicos.ThemeAuthor = "Narwin";
            this.tabDadosBasicos.ThemeName = "MetroLite";
            this.tabDadosBasicos.ToolTipText = null;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Eras Bold ITC", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(170)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(388, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cadastrar colaborador";
            // 
            // tabAdmissao
            // 
            this.tabAdmissao.BaseColor = System.Drawing.Color.White;
            this.tabAdmissao.Controls.Add(this.textBox9);
            this.tabAdmissao.Controls.Add(this.metroSetLabel36);
            this.tabAdmissao.Controls.Add(this.metroSetLabel37);
            this.tabAdmissao.Controls.Add(this.metroSetComboBox7);
            this.tabAdmissao.Controls.Add(this.metroSetLabel38);
            this.tabAdmissao.Controls.Add(this.metroSetComboBox8);
            this.tabAdmissao.Font = null;
            this.tabAdmissao.ImageIndex = 0;
            this.tabAdmissao.ImageKey = null;
            this.tabAdmissao.IsDerivedStyle = true;
            this.tabAdmissao.Location = new System.Drawing.Point(4, 42);
            this.tabAdmissao.Name = "tabAdmissao";
            this.tabAdmissao.Size = new System.Drawing.Size(1255, 655);
            this.tabAdmissao.Style = MetroSet_UI.Enums.Style.Light;
            this.tabAdmissao.StyleManager = null;
            this.tabAdmissao.TabIndex = 1;
            this.tabAdmissao.Text = "ADMISSÃO";
            this.tabAdmissao.ThemeAuthor = "Narwin";
            this.tabAdmissao.ThemeName = "MetroLite";
            this.tabAdmissao.ToolTipText = null;
            // 
            // tabContratoExp
            // 
            this.tabContratoExp.BaseColor = System.Drawing.Color.White;
            this.tabContratoExp.Font = null;
            this.tabContratoExp.ImageIndex = 0;
            this.tabContratoExp.ImageKey = null;
            this.tabContratoExp.IsDerivedStyle = true;
            this.tabContratoExp.Location = new System.Drawing.Point(4, 42);
            this.tabContratoExp.Name = "tabContratoExp";
            this.tabContratoExp.Size = new System.Drawing.Size(1255, 655);
            this.tabContratoExp.Style = MetroSet_UI.Enums.Style.Light;
            this.tabContratoExp.StyleManager = null;
            this.tabContratoExp.TabIndex = 2;
            this.tabContratoExp.Text = "CONTRATO DE EXPERIÊNCIA";
            this.tabContratoExp.ThemeAuthor = "Narwin";
            this.tabContratoExp.ThemeName = "MetroLite";
            this.tabContratoExp.ToolTipText = null;
            // 
            // tabHorario
            // 
            this.tabHorario.BaseColor = System.Drawing.Color.White;
            this.tabHorario.Font = null;
            this.tabHorario.ImageIndex = 0;
            this.tabHorario.ImageKey = null;
            this.tabHorario.IsDerivedStyle = true;
            this.tabHorario.Location = new System.Drawing.Point(4, 42);
            this.tabHorario.Name = "tabHorario";
            this.tabHorario.Size = new System.Drawing.Size(1255, 655);
            this.tabHorario.Style = MetroSet_UI.Enums.Style.Light;
            this.tabHorario.StyleManager = null;
            this.tabHorario.TabIndex = 3;
            this.tabHorario.Text = "HORÁRIO";
            this.tabHorario.ThemeAuthor = "Narwin";
            this.tabHorario.ThemeName = "MetroLite";
            this.tabHorario.ToolTipText = null;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(0, 41);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(460, 26);
            this.textBox7.TabIndex = 49;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(166, 288);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(130, 26);
            this.textBox8.TabIndex = 48;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(767, 41);
            this.maskedTextBox1.Mask = "(00) 00000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(125, 26);
            this.maskedTextBox1.TabIndex = 47;
            // 
            // metroSetLabel30
            // 
            this.metroSetLabel30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel30.IsDerivedStyle = true;
            this.metroSetLabel30.Location = new System.Drawing.Point(767, 18);
            this.metroSetLabel30.Name = "metroSetLabel30";
            this.metroSetLabel30.Size = new System.Drawing.Size(124, 23);
            this.metroSetLabel30.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel30.StyleManager = null;
            this.metroSetLabel30.TabIndex = 46;
            this.metroSetLabel30.Text = "Telefone MW";
            this.metroSetLabel30.ThemeAuthor = "Narwin";
            this.metroSetLabel30.ThemeName = "MetroLite";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(622, 41);
            this.maskedTextBox2.Mask = "(00) 00000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(125, 26);
            this.maskedTextBox2.TabIndex = 45;
            // 
            // metroSetLabel31
            // 
            this.metroSetLabel31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel31.IsDerivedStyle = true;
            this.metroSetLabel31.Location = new System.Drawing.Point(622, 18);
            this.metroSetLabel31.Name = "metroSetLabel31";
            this.metroSetLabel31.Size = new System.Drawing.Size(124, 23);
            this.metroSetLabel31.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel31.StyleManager = null;
            this.metroSetLabel31.TabIndex = 44;
            this.metroSetLabel31.Text = "Telefone Pessoal";
            this.metroSetLabel31.ThemeAuthor = "Narwin";
            this.metroSetLabel31.ThemeName = "MetroLite";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox3.Location = new System.Drawing.Point(480, 41);
            this.maskedTextBox3.Mask = "000,000,000-00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(125, 26);
            this.maskedTextBox3.TabIndex = 43;
            // 
            // metroSetLabel32
            // 
            this.metroSetLabel32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel32.IsDerivedStyle = true;
            this.metroSetLabel32.Location = new System.Drawing.Point(480, 18);
            this.metroSetLabel32.Name = "metroSetLabel32";
            this.metroSetLabel32.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel32.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel32.StyleManager = null;
            this.metroSetLabel32.TabIndex = 42;
            this.metroSetLabel32.Text = "CPF";
            this.metroSetLabel32.ThemeAuthor = "Narwin";
            this.metroSetLabel32.ThemeName = "MetroLite";
            // 
            // metroSetLabel33
            // 
            this.metroSetLabel33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel33.IsDerivedStyle = true;
            this.metroSetLabel33.Location = new System.Drawing.Point(166, 265);
            this.metroSetLabel33.Name = "metroSetLabel33";
            this.metroSetLabel33.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel33.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel33.StyleManager = null;
            this.metroSetLabel33.TabIndex = 41;
            this.metroSetLabel33.Text = "RG";
            this.metroSetLabel33.ThemeAuthor = "Narwin";
            this.metroSetLabel33.ThemeName = "MetroLite";
            // 
            // metroSetLabel34
            // 
            this.metroSetLabel34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel34.IsDerivedStyle = true;
            this.metroSetLabel34.Location = new System.Drawing.Point(912, 18);
            this.metroSetLabel34.Name = "metroSetLabel34";
            this.metroSetLabel34.Size = new System.Drawing.Size(146, 23);
            this.metroSetLabel34.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel34.StyleManager = null;
            this.metroSetLabel34.TabIndex = 40;
            this.metroSetLabel34.Text = "Data de Nascimento";
            this.metroSetLabel34.ThemeAuthor = "Narwin";
            this.metroSetLabel34.ThemeName = "MetroLite";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(912, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 23);
            this.dateTimePicker1.TabIndex = 39;
            this.dateTimePicker1.Value = new System.DateTime(2023, 10, 4, 9, 18, 38, 0);
            // 
            // metroSetLabel35
            // 
            this.metroSetLabel35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel35.IsDerivedStyle = true;
            this.metroSetLabel35.Location = new System.Drawing.Point(0, 18);
            this.metroSetLabel35.Name = "metroSetLabel35";
            this.metroSetLabel35.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel35.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel35.StyleManager = null;
            this.metroSetLabel35.TabIndex = 38;
            this.metroSetLabel35.Text = "Nome";
            this.metroSetLabel35.ThemeAuthor = "Narwin";
            this.metroSetLabel35.ThemeName = "MetroLite";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(556, 129);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(211, 26);
            this.textBox9.TabIndex = 70;
            // 
            // metroSetLabel36
            // 
            this.metroSetLabel36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel36.IsDerivedStyle = true;
            this.metroSetLabel36.Location = new System.Drawing.Point(556, 105);
            this.metroSetLabel36.Name = "metroSetLabel36";
            this.metroSetLabel36.Size = new System.Drawing.Size(156, 23);
            this.metroSetLabel36.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel36.StyleManager = null;
            this.metroSetLabel36.TabIndex = 69;
            this.metroSetLabel36.Text = "Centro de custo setor";
            this.metroSetLabel36.ThemeAuthor = "Narwin";
            this.metroSetLabel36.ThemeName = "MetroLite";
            // 
            // metroSetLabel37
            // 
            this.metroSetLabel37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel37.IsDerivedStyle = true;
            this.metroSetLabel37.Location = new System.Drawing.Point(385, 103);
            this.metroSetLabel37.Name = "metroSetLabel37";
            this.metroSetLabel37.Size = new System.Drawing.Size(165, 23);
            this.metroSetLabel37.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel37.StyleManager = null;
            this.metroSetLabel37.TabIndex = 68;
            this.metroSetLabel37.Text = "Centro de custo  Estado";
            this.metroSetLabel37.ThemeAuthor = "Narwin";
            this.metroSetLabel37.ThemeName = "MetroLite";
            // 
            // metroSetComboBox7
            // 
            this.metroSetComboBox7.AllowDrop = true;
            this.metroSetComboBox7.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox7.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetComboBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox7.CausesValidation = false;
            this.metroSetComboBox7.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetComboBox7.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetComboBox7.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetComboBox7.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox7.FormattingEnabled = true;
            this.metroSetComboBox7.IsDerivedStyle = true;
            this.metroSetComboBox7.ItemHeight = 20;
            this.metroSetComboBox7.Items.AddRange(new object[] {
            "Paraná",
            "Santa Catarina",
            "Rio Grande do Sul"});
            this.metroSetComboBox7.Location = new System.Drawing.Point(385, 129);
            this.metroSetComboBox7.Name = "metroSetComboBox7";
            this.metroSetComboBox7.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox7.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox7.Size = new System.Drawing.Size(165, 26);
            this.metroSetComboBox7.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetComboBox7.StyleManager = null;
            this.metroSetComboBox7.TabIndex = 67;
            this.metroSetComboBox7.ThemeAuthor = "Narwin";
            this.metroSetComboBox7.ThemeName = "MetroLite";
            // 
            // metroSetLabel38
            // 
            this.metroSetLabel38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel38.IsDerivedStyle = true;
            this.metroSetLabel38.Location = new System.Drawing.Point(178, 103);
            this.metroSetLabel38.Name = "metroSetLabel38";
            this.metroSetLabel38.Size = new System.Drawing.Size(206, 23);
            this.metroSetLabel38.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel38.StyleManager = null;
            this.metroSetLabel38.TabIndex = 66;
            this.metroSetLabel38.Text = "Centro de custo Departamento";
            this.metroSetLabel38.ThemeAuthor = "Narwin";
            this.metroSetLabel38.ThemeName = "MetroLite";
            // 
            // metroSetComboBox8
            // 
            this.metroSetComboBox8.AllowDrop = true;
            this.metroSetComboBox8.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox8.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetComboBox8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox8.CausesValidation = false;
            this.metroSetComboBox8.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetComboBox8.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetComboBox8.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetComboBox8.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox8.FormattingEnabled = true;
            this.metroSetComboBox8.IsDerivedStyle = true;
            this.metroSetComboBox8.ItemHeight = 20;
            this.metroSetComboBox8.Items.AddRange(new object[] {
            "Auxiliar administrativo",
            "Auxiliar de vendas",
            "Auxiliar de marketing"});
            this.metroSetComboBox8.Location = new System.Drawing.Point(178, 129);
            this.metroSetComboBox8.Name = "metroSetComboBox8";
            this.metroSetComboBox8.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox8.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox8.Size = new System.Drawing.Size(201, 26);
            this.metroSetComboBox8.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetComboBox8.StyleManager = null;
            this.metroSetComboBox8.TabIndex = 65;
            this.metroSetComboBox8.ThemeAuthor = "Narwin";
            this.metroSetComboBox8.ThemeName = "MetroLite";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(480, 154);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(185, 26);
            this.textBox10.TabIndex = 61;
            // 
            // metroSetLabel39
            // 
            this.metroSetLabel39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel39.IsDerivedStyle = true;
            this.metroSetLabel39.Location = new System.Drawing.Point(480, 129);
            this.metroSetLabel39.Name = "metroSetLabel39";
            this.metroSetLabel39.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel39.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel39.StyleManager = null;
            this.metroSetLabel39.TabIndex = 60;
            this.metroSetLabel39.Text = "Bairro";
            this.metroSetLabel39.ThemeAuthor = "Narwin";
            this.metroSetLabel39.ThemeName = "MetroLite";
            // 
            // metroSetComboBox9
            // 
            this.metroSetComboBox9.AllowDrop = true;
            this.metroSetComboBox9.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox9.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetComboBox9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox9.CausesValidation = false;
            this.metroSetComboBox9.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetComboBox9.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetComboBox9.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetComboBox9.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox9.FormattingEnabled = true;
            this.metroSetComboBox9.IsDerivedStyle = true;
            this.metroSetComboBox9.ItemHeight = 20;
            this.metroSetComboBox9.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.metroSetComboBox9.Location = new System.Drawing.Point(1039, 154);
            this.metroSetComboBox9.Name = "metroSetComboBox9";
            this.metroSetComboBox9.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox9.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox9.Size = new System.Drawing.Size(62, 26);
            this.metroSetComboBox9.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetComboBox9.StyleManager = null;
            this.metroSetComboBox9.TabIndex = 59;
            this.metroSetComboBox9.ThemeAuthor = "Narwin";
            this.metroSetComboBox9.ThemeName = "MetroLite";
            // 
            // metroSetLabel40
            // 
            this.metroSetLabel40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel40.IsDerivedStyle = true;
            this.metroSetLabel40.Location = new System.Drawing.Point(1039, 130);
            this.metroSetLabel40.Name = "metroSetLabel40";
            this.metroSetLabel40.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel40.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel40.StyleManager = null;
            this.metroSetLabel40.TabIndex = 58;
            this.metroSetLabel40.Text = "Estado";
            this.metroSetLabel40.ThemeAuthor = "Narwin";
            this.metroSetLabel40.ThemeName = "MetroLite";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(884, 155);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(135, 26);
            this.textBox11.TabIndex = 57;
            // 
            // metroSetLabel41
            // 
            this.metroSetLabel41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel41.IsDerivedStyle = true;
            this.metroSetLabel41.Location = new System.Drawing.Point(884, 131);
            this.metroSetLabel41.Name = "metroSetLabel41";
            this.metroSetLabel41.Size = new System.Drawing.Size(78, 23);
            this.metroSetLabel41.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel41.StyleManager = null;
            this.metroSetLabel41.TabIndex = 56;
            this.metroSetLabel41.Text = "Cidade";
            this.metroSetLabel41.ThemeAuthor = "Narwin";
            this.metroSetLabel41.ThemeName = "MetroLite";
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.maskedTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox4.Location = new System.Drawing.Point(767, 154);
            this.maskedTextBox4.Mask = "00,000-000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(97, 26);
            this.maskedTextBox4.TabIndex = 55;
            // 
            // metroSetLabel42
            // 
            this.metroSetLabel42.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel42.IsDerivedStyle = true;
            this.metroSetLabel42.Location = new System.Drawing.Point(765, 131);
            this.metroSetLabel42.Name = "metroSetLabel42";
            this.metroSetLabel42.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel42.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel42.StyleManager = null;
            this.metroSetLabel42.TabIndex = 54;
            this.metroSetLabel42.Text = "CEP";
            this.metroSetLabel42.ThemeAuthor = "Narwin";
            this.metroSetLabel42.ThemeName = "MetroLite";
            // 
            // metroSetLabel43
            // 
            this.metroSetLabel43.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel43.IsDerivedStyle = true;
            this.metroSetLabel43.Location = new System.Drawing.Point(684, 128);
            this.metroSetLabel43.Name = "metroSetLabel43";
            this.metroSetLabel43.Size = new System.Drawing.Size(42, 23);
            this.metroSetLabel43.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel43.StyleManager = null;
            this.metroSetLabel43.TabIndex = 53;
            this.metroSetLabel43.Text = "Nº";
            this.metroSetLabel43.ThemeAuthor = "Narwin";
            this.metroSetLabel43.ThemeName = "MetroLite";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(684, 154);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(63, 26);
            this.textBox12.TabIndex = 52;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(0, 155);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(460, 26);
            this.textBox13.TabIndex = 51;
            // 
            // metroSetLabel44
            // 
            this.metroSetLabel44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel44.IsDerivedStyle = true;
            this.metroSetLabel44.Location = new System.Drawing.Point(0, 130);
            this.metroSetLabel44.Name = "metroSetLabel44";
            this.metroSetLabel44.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel44.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel44.StyleManager = null;
            this.metroSetLabel44.TabIndex = 50;
            this.metroSetLabel44.Text = "Endereço";
            this.metroSetLabel44.ThemeAuthor = "Narwin";
            this.metroSetLabel44.ThemeName = "MetroLite";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(1280, 900);
            this.Controls.Add(this.ControlButon);
            this.Controls.Add(this.TabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderHeight = 30;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 900);
            this.MinimumSize = new System.Drawing.Size(1280, 900);
            this.Name = "FrmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(13, 70, 13, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto RH";
            this.TextColor = System.Drawing.Color.DarkGreen;
            this.ThemeName = "MetroDark";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.TabControl.ResumeLayout(false);
            this.tabFuncionariosAtivos.ResumeLayout(false);
            this.metroSetTabControl1.ResumeLayout(false);
            this.tabDadosBasicos.ResumeLayout(false);
            this.tabDadosBasicos.PerformLayout();
            this.tabAdmissao.ResumeLayout(false);
            this.tabAdmissao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private MetroSet_UI.Controls.MetroSetTabControl TabControl;
        private MetroSet_UI.Child.MetroSetSetTabPage tabFuncionariosAtivos;
        private MetroSet_UI.Child.MetroSetSetTabPage tabFeriasAgendadas;
        private MetroSet_UI.Child.MetroSetSetTabPage tabFeriasVencer;
        private MetroSet_UI.Child.MetroSetSetTabPage Desligamentos;
        private MetroSet_UI.Controls.MetroSetControlBox ControlButon;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private MetroSet_UI.Child.MetroSetSetTabPage tabDadosBasicos;
        private System.Windows.Forms.Label label2;
        private MetroSet_UI.Child.MetroSetSetTabPage tabAdmissao;
        private MetroSet_UI.Child.MetroSetSetTabPage tabContratoExp;
        private MetroSet_UI.Child.MetroSetSetTabPage tabHorario;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel30;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel31;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel32;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel33;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel34;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel35;
        private System.Windows.Forms.TextBox textBox9;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel36;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel37;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox7;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel38;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox8;
        private System.Windows.Forms.TextBox textBox10;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel39;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox9;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel40;
        private System.Windows.Forms.TextBox textBox11;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel41;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel42;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel43;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel44;
    }
}

