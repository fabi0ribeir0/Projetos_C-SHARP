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
            this.txtRG = new MetroSet_UI.Controls.MetroSetTextBox();
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetComboBox1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtNome = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tabFuncionariosAtivos = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.tabFeriasAgendadas = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.tabFeriasVencer = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Desligamentos = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.ControlButon = new MetroSet_UI.Controls.MetroSetControlBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.metroSetLabel10 = new MetroSet_UI.Controls.MetroSetLabel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.metroSetLabel12 = new MetroSet_UI.Controls.MetroSetLabel();
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
            this.tabNovoFuncionario.Controls.Add(this.maskedTextBox1);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel12);
            this.tabNovoFuncionario.Controls.Add(this.mskTelefone);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel10);
            this.tabNovoFuncionario.Controls.Add(this.txtRG);
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
            this.tabNovoFuncionario.Controls.Add(this.dateTimePicker2);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel3);
            this.tabNovoFuncionario.Controls.Add(this.dateTimePicker1);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel2);
            this.tabNovoFuncionario.Controls.Add(this.metroSetComboBox1);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel1);
            this.tabNovoFuncionario.Controls.Add(this.txtNome);
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
            // txtRG
            // 
            this.txtRG.AutoCompleteCustomSource = null;
            this.txtRG.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtRG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtRG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtRG.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtRG.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtRG.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRG.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtRG.Image = null;
            this.txtRG.IsDerivedStyle = true;
            this.txtRG.Lines = null;
            this.txtRG.Location = new System.Drawing.Point(423, 104);
            this.txtRG.MaxLength = 32767;
            this.txtRG.Multiline = false;
            this.txtRG.Name = "txtRG";
            this.txtRG.ReadOnly = false;
            this.txtRG.Size = new System.Drawing.Size(124, 26);
            this.txtRG.Style = MetroSet_UI.Enums.Style.Light;
            this.txtRG.StyleManager = null;
            this.txtRG.TabIndex = 29;
            this.txtRG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRG.ThemeAuthor = "Narwin";
            this.txtRG.ThemeName = "MetroLite";
            this.txtRG.UseSystemPasswordChar = false;
            this.txtRG.WatermarkText = "";
            this.txtRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRG_KeyPress);
            // 
            // mskCpf
            // 
            this.mskCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.mskCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpf.Location = new System.Drawing.Point(571, 104);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(124, 26);
            this.mskCpf.TabIndex = 28;
            // 
            // metroSetLabel11
            // 
            this.metroSetLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel11.IsDerivedStyle = true;
            this.metroSetLabel11.Location = new System.Drawing.Point(571, 81);
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
            this.metroSetLabel9.Location = new System.Drawing.Point(423, 81);
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
            this.metroSetLabel8.Location = new System.Drawing.Point(689, 361);
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
            this.metroSetComboBox5.Location = new System.Drawing.Point(689, 387);
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
            this.metroSetLabel7.Location = new System.Drawing.Point(460, 361);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel7.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.TabIndex = 19;
            this.metroSetLabel7.Text = "Setor";
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
            "Auxiliar administrativo",
            "Auxiliar de vendas",
            "Auxiliar de marketing"});
            this.metroSetComboBox4.Location = new System.Drawing.Point(460, 387);
            this.metroSetComboBox4.Name = "metroSetComboBox4";
            this.metroSetComboBox4.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox4.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox4.Size = new System.Drawing.Size(201, 26);
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
            this.metroSetLabel6.Location = new System.Drawing.Point(3, 361);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 17;
            this.metroSetLabel6.Text = "Estado";
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
            this.metroSetComboBox3.Location = new System.Drawing.Point(3, 387);
            this.metroSetComboBox3.Name = "metroSetComboBox3";
            this.metroSetComboBox3.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox3.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox3.Size = new System.Drawing.Size(201, 26);
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
            this.metroSetLabel5.Location = new System.Drawing.Point(236, 361);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(110, 23);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 15;
            this.metroSetLabel5.Text = "Departamento";
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
            this.metroSetComboBox2.Location = new System.Drawing.Point(236, 387);
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
            this.metroSetLabel4.Location = new System.Drawing.Point(938, 242);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(157, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 13;
            this.metroSetLabel4.Text = "Data de Admissão";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(938, 268);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(134, 23);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.Value = new System.DateTime(2023, 10, 4, 9, 18, 38, 0);
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(774, 242);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(157, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 11;
            this.metroSetLabel3.Text = "Data de Nascimento";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(774, 268);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 23);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2023, 10, 4, 9, 18, 38, 0);
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(542, 242);
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
            this.metroSetComboBox1.Location = new System.Drawing.Point(542, 265);
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
            // txtNome
            // 
            this.txtNome.AutoCompleteCustomSource = null;
            this.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtNome.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNome.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtNome.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNome.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtNome.Image = null;
            this.txtNome.IsDerivedStyle = true;
            this.txtNome.Lines = null;
            this.txtNome.Location = new System.Drawing.Point(0, 104);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = false;
            this.txtNome.Size = new System.Drawing.Size(396, 26);
            this.txtNome.Style = MetroSet_UI.Enums.Style.Light;
            this.txtNome.StyleManager = null;
            this.txtNome.TabIndex = 0;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.ThemeAuthor = "Narwin";
            this.txtNome.ThemeName = "MetroLite";
            this.txtNome.UseSystemPasswordChar = false;
            this.txtNome.WatermarkText = "";
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
            // mskTelefone
            // 
            this.mskTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(713, 104);
            this.mskTelefone.Mask = "(00) 00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(124, 26);
            this.mskTelefone.TabIndex = 31;
            // 
            // metroSetLabel10
            // 
            this.metroSetLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel10.IsDerivedStyle = true;
            this.metroSetLabel10.Location = new System.Drawing.Point(713, 81);
            this.metroSetLabel10.Name = "metroSetLabel10";
            this.metroSetLabel10.Size = new System.Drawing.Size(124, 23);
            this.metroSetLabel10.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel10.StyleManager = null;
            this.metroSetLabel10.TabIndex = 30;
            this.metroSetLabel10.Text = "Telefone Pessoal";
            this.metroSetLabel10.ThemeAuthor = "Narwin";
            this.metroSetLabel10.ThemeName = "MetroLite";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(854, 104);
            this.maskedTextBox1.Mask = "(00) 00000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(124, 26);
            this.maskedTextBox1.TabIndex = 33;
            // 
            // metroSetLabel12
            // 
            this.metroSetLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel12.IsDerivedStyle = true;
            this.metroSetLabel12.Location = new System.Drawing.Point(854, 81);
            this.metroSetLabel12.Name = "metroSetLabel12";
            this.metroSetLabel12.Size = new System.Drawing.Size(124, 23);
            this.metroSetLabel12.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel12.StyleManager = null;
            this.metroSetLabel12.TabIndex = 32;
            this.metroSetLabel12.Text = "Telefone MW";
            this.metroSetLabel12.ThemeAuthor = "Narwin";
            this.metroSetLabel12.ThemeName = "MetroLite";
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
        private MetroSet_UI.Controls.MetroSetTextBox txtNome;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
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
        private MetroSet_UI.Controls.MetroSetTextBox txtRG;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel12;
    }
}

