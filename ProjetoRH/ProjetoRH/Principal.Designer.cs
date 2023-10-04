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
            this.tabNovoFuncionario = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetLabel17 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.metroSetLabel16 = new MetroSet_UI.Controls.MetroSetLabel();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.metroSetLabel15 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel14 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.metroSetLabel13 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.mskFoneMW = new System.Windows.Forms.MaskedTextBox();
            this.metroSetLabel12 = new MetroSet_UI.Controls.MetroSetLabel();
            this.mskFonePessoal = new System.Windows.Forms.MaskedTextBox();
            this.metroSetLabel10 = new MetroSet_UI.Controls.MetroSetLabel();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.metroSetLabel11 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel9 = new MetroSet_UI.Controls.MetroSetLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroSetLabel8 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetComboBox5 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetComboBox4 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetComboBox3 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetComboBox2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.dtAdmissao = new System.Windows.Forms.DateTimePicker();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetComboBox1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.tabFuncionariosAtivos = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.tabFeriasAgendadas = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.tabFeriasVencer = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Desligamentos = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.ControlButon = new MetroSet_UI.Controls.MetroSetControlBox();
            this.cmbEstadoMora = new MetroSet_UI.Controls.MetroSetComboBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.metroSetLabel18 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtMailP = new System.Windows.Forms.TextBox();
            this.metroSetLabel19 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtMailMW = new System.Windows.Forms.TextBox();
            this.metroSetLabel20 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel21 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtCTPS = new System.Windows.Forms.TextBox();
            this.txtPIS = new System.Windows.Forms.TextBox();
            this.metroSetLabel22 = new MetroSet_UI.Controls.MetroSetLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroSetLabel23 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel24 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetComboBox6 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.metroSetLabel25 = new MetroSet_UI.Controls.MetroSetLabel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.metroSetLabel26 = new MetroSet_UI.Controls.MetroSetLabel();
            this.TabControl.SuspendLayout();
            this.tabNovoFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.TabControl.AnimateTime = 200;
            this.TabControl.BackgroundColor = System.Drawing.Color.White;
            this.TabControl.Controls.Add(this.tabNovoFuncionario);
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
            // tabNovoFuncionario
            // 
            this.tabNovoFuncionario.BaseColor = System.Drawing.Color.White;
            this.tabNovoFuncionario.Controls.Add(this.textBox3);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel26);
            this.tabNovoFuncionario.Controls.Add(this.textBox2);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel25);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel24);
            this.tabNovoFuncionario.Controls.Add(this.metroSetComboBox6);
            this.tabNovoFuncionario.Controls.Add(this.textBox1);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel23);
            this.tabNovoFuncionario.Controls.Add(this.txtPIS);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel22);
            this.tabNovoFuncionario.Controls.Add(this.txtCTPS);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel21);
            this.tabNovoFuncionario.Controls.Add(this.txtMailMW);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel20);
            this.tabNovoFuncionario.Controls.Add(this.txtMailP);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel19);
            this.tabNovoFuncionario.Controls.Add(this.txtBairro);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel18);
            this.tabNovoFuncionario.Controls.Add(this.cmbEstadoMora);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel17);
            this.tabNovoFuncionario.Controls.Add(this.txtCidade);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel16);
            this.tabNovoFuncionario.Controls.Add(this.mskCEP);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel15);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel14);
            this.tabNovoFuncionario.Controls.Add(this.txtNumero);
            this.tabNovoFuncionario.Controls.Add(this.txtEndereco);
            this.tabNovoFuncionario.Controls.Add(this.txtNome);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel13);
            this.tabNovoFuncionario.Controls.Add(this.txtRG);
            this.tabNovoFuncionario.Controls.Add(this.mskFoneMW);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel12);
            this.tabNovoFuncionario.Controls.Add(this.mskFonePessoal);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel10);
            this.tabNovoFuncionario.Controls.Add(this.mskCpf);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel11);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel9);
            this.tabNovoFuncionario.Controls.Add(this.label1);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel8);
            this.tabNovoFuncionario.Controls.Add(this.metroSetComboBox5);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel7);
            this.tabNovoFuncionario.Controls.Add(this.metroSetComboBox4);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel6);
            this.tabNovoFuncionario.Controls.Add(this.metroSetComboBox3);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel5);
            this.tabNovoFuncionario.Controls.Add(this.metroSetComboBox2);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel4);
            this.tabNovoFuncionario.Controls.Add(this.dtAdmissao);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel3);
            this.tabNovoFuncionario.Controls.Add(this.dtNascimento);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel2);
            this.tabNovoFuncionario.Controls.Add(this.metroSetComboBox1);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel1);
            this.tabNovoFuncionario.Font = null;
            this.tabNovoFuncionario.ImageIndex = 0;
            this.tabNovoFuncionario.ImageKey = null;
            this.tabNovoFuncionario.IsDerivedStyle = true;
            this.tabNovoFuncionario.Location = new System.Drawing.Point(4, 42);
            this.tabNovoFuncionario.Name = "tabNovoFuncionario";
            this.tabNovoFuncionario.Size = new System.Drawing.Size(1263, 766);
            this.tabNovoFuncionario.Style = MetroSet_UI.Enums.Style.Light;
            this.tabNovoFuncionario.StyleManager = null;
            this.tabNovoFuncionario.TabIndex = 0;
            this.tabNovoFuncionario.Text = "Novo Funcionario";
            this.tabNovoFuncionario.ThemeAuthor = "Narwin";
            this.tabNovoFuncionario.ThemeName = "MetroLite";
            this.tabNovoFuncionario.ToolTipText = null;
            // 
            // metroSetLabel17
            // 
            this.metroSetLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel17.IsDerivedStyle = true;
            this.metroSetLabel17.Location = new System.Drawing.Point(924, 149);
            this.metroSetLabel17.Name = "metroSetLabel17";
            this.metroSetLabel17.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel17.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel17.StyleManager = null;
            this.metroSetLabel17.TabIndex = 45;
            this.metroSetLabel17.Text = "Estado";
            this.metroSetLabel17.ThemeAuthor = "Narwin";
            this.metroSetLabel17.ThemeName = "MetroLite";
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(783, 173);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(135, 26);
            this.txtCidade.TabIndex = 44;
            // 
            // metroSetLabel16
            // 
            this.metroSetLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel16.IsDerivedStyle = true;
            this.metroSetLabel16.Location = new System.Drawing.Point(783, 149);
            this.metroSetLabel16.Name = "metroSetLabel16";
            this.metroSetLabel16.Size = new System.Drawing.Size(78, 23);
            this.metroSetLabel16.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel16.StyleManager = null;
            this.metroSetLabel16.TabIndex = 43;
            this.metroSetLabel16.Text = "Cidade";
            this.metroSetLabel16.ThemeAuthor = "Narwin";
            this.metroSetLabel16.ThemeName = "MetroLite";
            // 
            // mskCEP
            // 
            this.mskCEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.mskCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCEP.Location = new System.Drawing.Point(680, 173);
            this.mskCEP.Mask = "00,000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(97, 26);
            this.mskCEP.TabIndex = 42;
            // 
            // metroSetLabel15
            // 
            this.metroSetLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel15.IsDerivedStyle = true;
            this.metroSetLabel15.Location = new System.Drawing.Point(678, 150);
            this.metroSetLabel15.Name = "metroSetLabel15";
            this.metroSetLabel15.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel15.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel15.StyleManager = null;
            this.metroSetLabel15.TabIndex = 41;
            this.metroSetLabel15.Text = "CEP";
            this.metroSetLabel15.ThemeAuthor = "Narwin";
            this.metroSetLabel15.ThemeName = "MetroLite";
            // 
            // metroSetLabel14
            // 
            this.metroSetLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel14.IsDerivedStyle = true;
            this.metroSetLabel14.Location = new System.Drawing.Point(611, 150);
            this.metroSetLabel14.Name = "metroSetLabel14";
            this.metroSetLabel14.Size = new System.Drawing.Size(42, 23);
            this.metroSetLabel14.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel14.StyleManager = null;
            this.metroSetLabel14.TabIndex = 40;
            this.metroSetLabel14.Text = "Nº";
            this.metroSetLabel14.ThemeAuthor = "Narwin";
            this.metroSetLabel14.ThemeName = "MetroLite";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(611, 173);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(63, 26);
            this.txtNumero.TabIndex = 39;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(0, 173);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(398, 26);
            this.txtEndereco.TabIndex = 38;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(0, 104);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(398, 26);
            this.txtNome.TabIndex = 37;
            // 
            // metroSetLabel13
            // 
            this.metroSetLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel13.IsDerivedStyle = true;
            this.metroSetLabel13.Location = new System.Drawing.Point(0, 148);
            this.metroSetLabel13.Name = "metroSetLabel13";
            this.metroSetLabel13.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel13.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel13.StyleManager = null;
            this.metroSetLabel13.TabIndex = 36;
            this.metroSetLabel13.Text = "Endereço";
            this.metroSetLabel13.ThemeAuthor = "Narwin";
            this.metroSetLabel13.ThemeName = "MetroLite";
            // 
            // txtRG
            // 
            this.txtRG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Location = new System.Drawing.Point(404, 104);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(130, 26);
            this.txtRG.TabIndex = 34;
            // 
            // mskFoneMW
            // 
            this.mskFoneMW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.mskFoneMW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFoneMW.Location = new System.Drawing.Point(800, 104);
            this.mskFoneMW.Mask = "(00) 00000-0000";
            this.mskFoneMW.Name = "mskFoneMW";
            this.mskFoneMW.Size = new System.Drawing.Size(124, 26);
            this.mskFoneMW.TabIndex = 33;
            // 
            // metroSetLabel12
            // 
            this.metroSetLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel12.IsDerivedStyle = true;
            this.metroSetLabel12.Location = new System.Drawing.Point(800, 81);
            this.metroSetLabel12.Name = "metroSetLabel12";
            this.metroSetLabel12.Size = new System.Drawing.Size(124, 23);
            this.metroSetLabel12.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel12.StyleManager = null;
            this.metroSetLabel12.TabIndex = 32;
            this.metroSetLabel12.Text = "Telefone MW";
            this.metroSetLabel12.ThemeAuthor = "Narwin";
            this.metroSetLabel12.ThemeName = "MetroLite";
            // 
            // mskFonePessoal
            // 
            this.mskFonePessoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.mskFonePessoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFonePessoal.Location = new System.Drawing.Point(670, 104);
            this.mskFonePessoal.Mask = "(00) 00000-0000";
            this.mskFonePessoal.Name = "mskFonePessoal";
            this.mskFonePessoal.Size = new System.Drawing.Size(124, 26);
            this.mskFonePessoal.TabIndex = 31;
            // 
            // metroSetLabel10
            // 
            this.metroSetLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel10.IsDerivedStyle = true;
            this.metroSetLabel10.Location = new System.Drawing.Point(670, 81);
            this.metroSetLabel10.Name = "metroSetLabel10";
            this.metroSetLabel10.Size = new System.Drawing.Size(124, 23);
            this.metroSetLabel10.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel10.StyleManager = null;
            this.metroSetLabel10.TabIndex = 30;
            this.metroSetLabel10.Text = "Telefone Pessoal";
            this.metroSetLabel10.ThemeAuthor = "Narwin";
            this.metroSetLabel10.ThemeName = "MetroLite";
            // 
            // mskCpf
            // 
            this.mskCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.mskCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpf.Location = new System.Drawing.Point(540, 104);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(124, 26);
            this.mskCpf.TabIndex = 28;
            // 
            // metroSetLabel11
            // 
            this.metroSetLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel11.IsDerivedStyle = true;
            this.metroSetLabel11.Location = new System.Drawing.Point(540, 81);
            this.metroSetLabel11.Name = "metroSetLabel11";
            this.metroSetLabel11.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel11.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel11.StyleManager = null;
            this.metroSetLabel11.TabIndex = 27;
            this.metroSetLabel11.Text = "CPF";
            this.metroSetLabel11.ThemeAuthor = "Narwin";
            this.metroSetLabel11.ThemeName = "MetroLite";
            // 
            // metroSetLabel9
            // 
            this.metroSetLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel9.IsDerivedStyle = true;
            this.metroSetLabel9.Location = new System.Drawing.Point(404, 81);
            this.metroSetLabel9.Name = "metroSetLabel9";
            this.metroSetLabel9.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel9.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel9.StyleManager = null;
            this.metroSetLabel9.TabIndex = 23;
            this.metroSetLabel9.Text = "RG";
            this.metroSetLabel9.ThemeAuthor = "Narwin";
            this.metroSetLabel9.ThemeName = "MetroLite";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Eras Bold ITC", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(170)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar colaborador";
            // 
            // metroSetLabel8
            // 
            this.metroSetLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel8.IsDerivedStyle = true;
            this.metroSetLabel8.Location = new System.Drawing.Point(702, 628);
            this.metroSetLabel8.Name = "metroSetLabel8";
            this.metroSetLabel8.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel8.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel8.StyleManager = null;
            this.metroSetLabel8.TabIndex = 21;
            this.metroSetLabel8.Text = "Setor";
            this.metroSetLabel8.ThemeAuthor = "Narwin";
            this.metroSetLabel8.ThemeName = "MetroLite";
            // 
            // metroSetComboBox5
            // 
            this.metroSetComboBox5.AllowDrop = true;
            this.metroSetComboBox5.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox5.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetComboBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox5.CausesValidation = false;
            this.metroSetComboBox5.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetComboBox5.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetComboBox5.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetComboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox5.FormattingEnabled = true;
            this.metroSetComboBox5.IsDerivedStyle = true;
            this.metroSetComboBox5.ItemHeight = 20;
            this.metroSetComboBox5.Items.AddRange(new object[] {
            "Auxiliar administrativo",
            "Auxiliar de vendas",
            "Auxiliar de marketing"});
            this.metroSetComboBox5.Location = new System.Drawing.Point(702, 654);
            this.metroSetComboBox5.Name = "metroSetComboBox5";
            this.metroSetComboBox5.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox5.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox5.Size = new System.Drawing.Size(201, 26);
            this.metroSetComboBox5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetComboBox5.StyleManager = null;
            this.metroSetComboBox5.TabIndex = 20;
            this.metroSetComboBox5.ThemeAuthor = "Narwin";
            this.metroSetComboBox5.ThemeName = "MetroLite";
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel7.IsDerivedStyle = true;
            this.metroSetLabel7.Location = new System.Drawing.Point(0, 360);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel7.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.TabIndex = 19;
            this.metroSetLabel7.Text = "Empresa";
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroLite";
            // 
            // metroSetComboBox4
            // 
            this.metroSetComboBox4.AllowDrop = true;
            this.metroSetComboBox4.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox4.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetComboBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox4.CausesValidation = false;
            this.metroSetComboBox4.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetComboBox4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetComboBox4.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox4.FormattingEnabled = true;
            this.metroSetComboBox4.IsDerivedStyle = true;
            this.metroSetComboBox4.ItemHeight = 20;
            this.metroSetComboBox4.Items.AddRange(new object[] {
            "Dicome",
            "Medicalway"});
            this.metroSetComboBox4.Location = new System.Drawing.Point(0, 386);
            this.metroSetComboBox4.Name = "metroSetComboBox4";
            this.metroSetComboBox4.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox4.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox4.Size = new System.Drawing.Size(232, 26);
            this.metroSetComboBox4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetComboBox4.StyleManager = null;
            this.metroSetComboBox4.TabIndex = 18;
            this.metroSetComboBox4.ThemeAuthor = "Narwin";
            this.metroSetComboBox4.ThemeName = "MetroLite";
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel6.IsDerivedStyle = true;
            this.metroSetLabel6.Location = new System.Drawing.Point(778, 292);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(201, 23);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 17;
            this.metroSetLabel6.Text = "Centro de custo  Estado";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroLite";
            // 
            // metroSetComboBox3
            // 
            this.metroSetComboBox3.AllowDrop = true;
            this.metroSetComboBox3.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox3.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetComboBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox3.CausesValidation = false;
            this.metroSetComboBox3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetComboBox3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetComboBox3.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox3.FormattingEnabled = true;
            this.metroSetComboBox3.IsDerivedStyle = true;
            this.metroSetComboBox3.ItemHeight = 20;
            this.metroSetComboBox3.Items.AddRange(new object[] {
            "Paraná",
            "Santa Catarina",
            "Rio Grande do Sul"});
            this.metroSetComboBox3.Location = new System.Drawing.Point(778, 318);
            this.metroSetComboBox3.Name = "metroSetComboBox3";
            this.metroSetComboBox3.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox3.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox3.Size = new System.Drawing.Size(165, 26);
            this.metroSetComboBox3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetComboBox3.StyleManager = null;
            this.metroSetComboBox3.TabIndex = 16;
            this.metroSetComboBox3.ThemeAuthor = "Narwin";
            this.metroSetComboBox3.ThemeName = "MetroLite";
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(571, 292);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(206, 23);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 15;
            this.metroSetLabel5.Text = "Centro de custo Departamento";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // metroSetComboBox2
            // 
            this.metroSetComboBox2.AllowDrop = true;
            this.metroSetComboBox2.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetComboBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox2.CausesValidation = false;
            this.metroSetComboBox2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetComboBox2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetComboBox2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox2.FormattingEnabled = true;
            this.metroSetComboBox2.IsDerivedStyle = true;
            this.metroSetComboBox2.ItemHeight = 20;
            this.metroSetComboBox2.Items.AddRange(new object[] {
            "Auxiliar administrativo",
            "Auxiliar de vendas",
            "Auxiliar de marketing"});
            this.metroSetComboBox2.Location = new System.Drawing.Point(571, 318);
            this.metroSetComboBox2.Name = "metroSetComboBox2";
            this.metroSetComboBox2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox2.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox2.Size = new System.Drawing.Size(201, 26);
            this.metroSetComboBox2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetComboBox2.StyleManager = null;
            this.metroSetComboBox2.TabIndex = 14;
            this.metroSetComboBox2.ThemeAuthor = "Narwin";
            this.metroSetComboBox2.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(992, 147);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(157, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 13;
            this.metroSetLabel4.Text = "Data de Admissão";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // dtAdmissao
            // 
            this.dtAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAdmissao.Location = new System.Drawing.Point(992, 173);
            this.dtAdmissao.Name = "dtAdmissao";
            this.dtAdmissao.Size = new System.Drawing.Size(134, 23);
            this.dtAdmissao.TabIndex = 12;
            this.dtAdmissao.Value = new System.DateTime(2023, 10, 4, 9, 18, 38, 0);
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(930, 81);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(146, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 11;
            this.metroSetLabel3.Text = "Data de Nascimento";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // dtNascimento
            // 
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(930, 105);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(134, 23);
            this.dtNascimento.TabIndex = 10;
            this.dtNascimento.Value = new System.DateTime(2023, 10, 4, 9, 18, 38, 0);
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(928, 602);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 9;
            this.metroSetLabel2.Text = "Função";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetComboBox1
            // 
            this.metroSetComboBox1.AllowDrop = true;
            this.metroSetComboBox1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox1.CausesValidation = false;
            this.metroSetComboBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetComboBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetComboBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox1.FormattingEnabled = true;
            this.metroSetComboBox1.IsDerivedStyle = true;
            this.metroSetComboBox1.ItemHeight = 20;
            this.metroSetComboBox1.Items.AddRange(new object[] {
            "Auxiliar administrativo",
            "Auxiliar de vendas",
            "Auxiliar de marketing"});
            this.metroSetComboBox1.Location = new System.Drawing.Point(928, 625);
            this.metroSetComboBox1.Name = "metroSetComboBox1";
            this.metroSetComboBox1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox1.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox1.Size = new System.Drawing.Size(201, 26);
            this.metroSetComboBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetComboBox1.StyleManager = null;
            this.metroSetComboBox1.TabIndex = 8;
            this.metroSetComboBox1.ThemeAuthor = "Narwin";
            this.metroSetComboBox1.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(0, 81);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 4;
            this.metroSetLabel1.Text = "Nome";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // tabFuncionariosAtivos
            // 
            this.tabFuncionariosAtivos.BaseColor = System.Drawing.Color.White;
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
            this.tabFuncionariosAtivos.Text = "Funcionarios ativos";
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
            // cmbEstadoMora
            // 
            this.cmbEstadoMora.AllowDrop = true;
            this.cmbEstadoMora.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbEstadoMora.BackColor = System.Drawing.Color.Transparent;
            this.cmbEstadoMora.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbEstadoMora.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbEstadoMora.CausesValidation = false;
            this.cmbEstadoMora.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbEstadoMora.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbEstadoMora.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbEstadoMora.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEstadoMora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoMora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbEstadoMora.FormattingEnabled = true;
            this.cmbEstadoMora.IsDerivedStyle = true;
            this.cmbEstadoMora.ItemHeight = 20;
            this.cmbEstadoMora.Items.AddRange(new object[] {
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
            this.cmbEstadoMora.Location = new System.Drawing.Point(924, 173);
            this.cmbEstadoMora.Name = "cmbEstadoMora";
            this.cmbEstadoMora.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbEstadoMora.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbEstadoMora.Size = new System.Drawing.Size(62, 26);
            this.cmbEstadoMora.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbEstadoMora.StyleManager = null;
            this.cmbEstadoMora.TabIndex = 46;
            this.cmbEstadoMora.ThemeAuthor = "Narwin";
            this.cmbEstadoMora.ThemeName = "MetroLite";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(404, 173);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(201, 26);
            this.txtBairro.TabIndex = 48;
            // 
            // metroSetLabel18
            // 
            this.metroSetLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel18.IsDerivedStyle = true;
            this.metroSetLabel18.Location = new System.Drawing.Point(404, 148);
            this.metroSetLabel18.Name = "metroSetLabel18";
            this.metroSetLabel18.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel18.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel18.StyleManager = null;
            this.metroSetLabel18.TabIndex = 47;
            this.metroSetLabel18.Text = "Bairro";
            this.metroSetLabel18.ThemeAuthor = "Narwin";
            this.metroSetLabel18.ThemeName = "MetroLite";
            // 
            // txtMailP
            // 
            this.txtMailP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtMailP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMailP.Location = new System.Drawing.Point(0, 242);
            this.txtMailP.Name = "txtMailP";
            this.txtMailP.Size = new System.Drawing.Size(398, 26);
            this.txtMailP.TabIndex = 50;
            // 
            // metroSetLabel19
            // 
            this.metroSetLabel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel19.IsDerivedStyle = true;
            this.metroSetLabel19.Location = new System.Drawing.Point(0, 217);
            this.metroSetLabel19.Name = "metroSetLabel19";
            this.metroSetLabel19.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel19.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel19.StyleManager = null;
            this.metroSetLabel19.TabIndex = 49;
            this.metroSetLabel19.Text = "E-mail pessoal";
            this.metroSetLabel19.ThemeAuthor = "Narwin";
            this.metroSetLabel19.ThemeName = "MetroLite";
            // 
            // txtMailMW
            // 
            this.txtMailMW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtMailMW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMailMW.Location = new System.Drawing.Point(404, 242);
            this.txtMailMW.Name = "txtMailMW";
            this.txtMailMW.Size = new System.Drawing.Size(398, 26);
            this.txtMailMW.TabIndex = 52;
            // 
            // metroSetLabel20
            // 
            this.metroSetLabel20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel20.IsDerivedStyle = true;
            this.metroSetLabel20.Location = new System.Drawing.Point(404, 217);
            this.metroSetLabel20.Name = "metroSetLabel20";
            this.metroSetLabel20.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel20.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel20.StyleManager = null;
            this.metroSetLabel20.TabIndex = 51;
            this.metroSetLabel20.Text = "E-mail MW";
            this.metroSetLabel20.ThemeAuthor = "Narwin";
            this.metroSetLabel20.ThemeName = "MetroLite";
            // 
            // metroSetLabel21
            // 
            this.metroSetLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel21.IsDerivedStyle = true;
            this.metroSetLabel21.Location = new System.Drawing.Point(808, 217);
            this.metroSetLabel21.Name = "metroSetLabel21";
            this.metroSetLabel21.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel21.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel21.StyleManager = null;
            this.metroSetLabel21.TabIndex = 53;
            this.metroSetLabel21.Text = "CTPS";
            this.metroSetLabel21.ThemeAuthor = "Narwin";
            this.metroSetLabel21.ThemeName = "MetroLite";
            // 
            // txtCTPS
            // 
            this.txtCTPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtCTPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCTPS.Location = new System.Drawing.Point(808, 242);
            this.txtCTPS.Name = "txtCTPS";
            this.txtCTPS.Size = new System.Drawing.Size(135, 26);
            this.txtCTPS.TabIndex = 54;
            // 
            // txtPIS
            // 
            this.txtPIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtPIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPIS.Location = new System.Drawing.Point(949, 242);
            this.txtPIS.Name = "txtPIS";
            this.txtPIS.Size = new System.Drawing.Size(135, 26);
            this.txtPIS.TabIndex = 56;
            // 
            // metroSetLabel22
            // 
            this.metroSetLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel22.IsDerivedStyle = true;
            this.metroSetLabel22.Location = new System.Drawing.Point(949, 217);
            this.metroSetLabel22.Name = "metroSetLabel22";
            this.metroSetLabel22.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel22.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel22.StyleManager = null;
            this.metroSetLabel22.TabIndex = 55;
            this.metroSetLabel22.Text = "PIS";
            this.metroSetLabel22.ThemeAuthor = "Narwin";
            this.metroSetLabel22.ThemeName = "MetroLite";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(167, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 26);
            this.textBox1.TabIndex = 58;
            // 
            // metroSetLabel23
            // 
            this.metroSetLabel23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel23.IsDerivedStyle = true;
            this.metroSetLabel23.Location = new System.Drawing.Point(167, 295);
            this.metroSetLabel23.Name = "metroSetLabel23";
            this.metroSetLabel23.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel23.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel23.StyleManager = null;
            this.metroSetLabel23.TabIndex = 57;
            this.metroSetLabel23.Text = "Nome da mãe";
            this.metroSetLabel23.ThemeAuthor = "Narwin";
            this.metroSetLabel23.ThemeName = "MetroLite";
            // 
            // metroSetLabel24
            // 
            this.metroSetLabel24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel24.IsDerivedStyle = true;
            this.metroSetLabel24.Location = new System.Drawing.Point(0, 292);
            this.metroSetLabel24.Name = "metroSetLabel24";
            this.metroSetLabel24.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel24.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel24.StyleManager = null;
            this.metroSetLabel24.TabIndex = 60;
            this.metroSetLabel24.Text = "Escolaridade";
            this.metroSetLabel24.ThemeAuthor = "Narwin";
            this.metroSetLabel24.ThemeName = "MetroLite";
            // 
            // metroSetComboBox6
            // 
            this.metroSetComboBox6.AllowDrop = true;
            this.metroSetComboBox6.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox6.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetComboBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox6.CausesValidation = false;
            this.metroSetComboBox6.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetComboBox6.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetComboBox6.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetComboBox6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox6.FormattingEnabled = true;
            this.metroSetComboBox6.IsDerivedStyle = true;
            this.metroSetComboBox6.ItemHeight = 20;
            this.metroSetComboBox6.Items.AddRange(new object[] {
            "Ensino médio incompleto",
            "Ensino médio compléto",
            "Ensino técnico incompleto",
            "Ensino técnico completo",
            "Ensino superior incompleto",
            "Ensino superior completo",
            "Pós Graduação"});
            this.metroSetComboBox6.Location = new System.Drawing.Point(0, 318);
            this.metroSetComboBox6.Name = "metroSetComboBox6";
            this.metroSetComboBox6.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox6.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox6.Size = new System.Drawing.Size(161, 26);
            this.metroSetComboBox6.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetComboBox6.StyleManager = null;
            this.metroSetComboBox6.TabIndex = 59;
            this.metroSetComboBox6.ThemeAuthor = "Narwin";
            this.metroSetComboBox6.ThemeName = "MetroLite";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(255, 461);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(398, 26);
            this.textBox2.TabIndex = 62;
            // 
            // metroSetLabel25
            // 
            this.metroSetLabel25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel25.IsDerivedStyle = true;
            this.metroSetLabel25.Location = new System.Drawing.Point(255, 438);
            this.metroSetLabel25.Name = "metroSetLabel25";
            this.metroSetLabel25.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel25.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel25.StyleManager = null;
            this.metroSetLabel25.TabIndex = 61;
            this.metroSetLabel25.Text = "Nome da mãe";
            this.metroSetLabel25.ThemeAuthor = "Narwin";
            this.metroSetLabel25.ThemeName = "MetroLite";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(949, 317);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(294, 26);
            this.textBox3.TabIndex = 64;
            // 
            // metroSetLabel26
            // 
            this.metroSetLabel26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel26.IsDerivedStyle = true;
            this.metroSetLabel26.Location = new System.Drawing.Point(949, 294);
            this.metroSetLabel26.Name = "metroSetLabel26";
            this.metroSetLabel26.Size = new System.Drawing.Size(156, 23);
            this.metroSetLabel26.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel26.StyleManager = null;
            this.metroSetLabel26.TabIndex = 63;
            this.metroSetLabel26.Text = "Centro de custo setor";
            this.metroSetLabel26.ThemeAuthor = "Narwin";
            this.metroSetLabel26.ThemeName = "MetroLite";
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
            this.tabNovoFuncionario.ResumeLayout(false);
            this.tabNovoFuncionario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private MetroSet_UI.Controls.MetroSetTabControl TabControl;
        private MetroSet_UI.Child.MetroSetSetTabPage tabNovoFuncionario;
        private MetroSet_UI.Child.MetroSetSetTabPage tabFuncionariosAtivos;
        private MetroSet_UI.Child.MetroSetSetTabPage tabFeriasAgendadas;
        private MetroSet_UI.Child.MetroSetSetTabPage tabFeriasVencer;
        private MetroSet_UI.Child.MetroSetSetTabPage Desligamentos;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private System.Windows.Forms.DateTimePicker dtAdmissao;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel8;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox3;
        private System.Windows.Forms.Label label1;
        private MetroSet_UI.Controls.MetroSetControlBox ControlButon;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel9;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel11;
        private System.Windows.Forms.MaskedTextBox mskFonePessoal;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel10;
        private System.Windows.Forms.MaskedTextBox mskFoneMW;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel12;
        private System.Windows.Forms.TextBox txtRG;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel13;
        private System.Windows.Forms.TextBox txtNome;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel14;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel15;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel17;
        private System.Windows.Forms.TextBox txtCidade;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel16;
        private MetroSet_UI.Controls.MetroSetComboBox cmbEstadoMora;
        private System.Windows.Forms.TextBox txtBairro;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel18;
        private System.Windows.Forms.TextBox txtMailMW;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel20;
        private System.Windows.Forms.TextBox txtMailP;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel19;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel21;
        private System.Windows.Forms.TextBox txtCTPS;
        private System.Windows.Forms.TextBox txtPIS;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel22;
        private System.Windows.Forms.TextBox textBox1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel23;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel24;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox6;
        private System.Windows.Forms.TextBox textBox2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel25;
        private System.Windows.Forms.TextBox textBox3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel26;
    }
}

