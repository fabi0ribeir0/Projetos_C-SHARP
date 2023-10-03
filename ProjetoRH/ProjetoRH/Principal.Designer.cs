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
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.styleManager1 = new MetroSet_UI.Components.StyleManager();
            this.TabControl = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabNovoFuncionario = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetComboBox1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.lvlNovoFuncionario = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtNome = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tabFuncionariosAtivos = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.tabFeriasAgendadas = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.tabFeriasVencer = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Desligamentos = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.TabControl.SuspendLayout();
            this.tabNovoFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(1282, 13);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = this.styleManager1;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLight";
            // 
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\Fabio\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Enums.Style.Light;
            this.styleManager1.ThemeAuthor = "Narwin";
            this.styleManager1.ThemeName = "MetroLight";
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
            this.TabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabControl.IsDerivedStyle = true;
            this.TabControl.ItemSize = new System.Drawing.Size(100, 38);
            this.TabControl.Location = new System.Drawing.Point(4, 84);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.SelectedTextColor = System.Drawing.Color.White;
            this.TabControl.Size = new System.Drawing.Size(1400, 812);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.Speed = 100;
            this.TabControl.Style = MetroSet_UI.Enums.Style.Light;
            this.TabControl.StyleManager = this.styleManager1;
            this.TabControl.TabIndex = 1;
            this.TabControl.ThemeAuthor = "Narwin";
            this.TabControl.ThemeName = "MetroLight";
            this.TabControl.UnselectedTextColor = System.Drawing.Color.Gray;
            this.TabControl.UseAnimation = false;
            // 
            // tabNovoFuncionario
            // 
            this.tabNovoFuncionario.BaseColor = System.Drawing.Color.White;
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel3);
            this.tabNovoFuncionario.Controls.Add(this.dateTimePicker1);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel2);
            this.tabNovoFuncionario.Controls.Add(this.metroSetComboBox1);
            this.tabNovoFuncionario.Controls.Add(this.lvlNovoFuncionario);
            this.tabNovoFuncionario.Controls.Add(this.metroSetLabel1);
            this.tabNovoFuncionario.Controls.Add(this.txtNome);
            this.tabNovoFuncionario.Font = null;
            this.tabNovoFuncionario.ImageIndex = 0;
            this.tabNovoFuncionario.ImageKey = null;
            this.tabNovoFuncionario.IsDerivedStyle = true;
            this.tabNovoFuncionario.Location = new System.Drawing.Point(4, 42);
            this.tabNovoFuncionario.Name = "tabNovoFuncionario";
            this.tabNovoFuncionario.Size = new System.Drawing.Size(1392, 766);
            this.tabNovoFuncionario.Style = MetroSet_UI.Enums.Style.Light;
            this.tabNovoFuncionario.StyleManager = this.styleManager1;
            this.tabNovoFuncionario.TabIndex = 0;
            this.tabNovoFuncionario.Text = "Novo Funcionario";
            this.tabNovoFuncionario.ThemeAuthor = "Narwin";
            this.tabNovoFuncionario.ThemeName = "MetroLite";
            this.tabNovoFuncionario.ToolTipText = null;
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(662, 81);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(662, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 23);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(430, 78);
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
            this.metroSetComboBox1.Location = new System.Drawing.Point(430, 104);
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
            // lvlNovoFuncionario
            // 
            this.lvlNovoFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlNovoFuncionario.Font = new System.Drawing.Font("Eras Bold ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNovoFuncionario.IsDerivedStyle = true;
            this.lvlNovoFuncionario.Location = new System.Drawing.Point(3, 13);
            this.lvlNovoFuncionario.Name = "lvlNovoFuncionario";
            this.lvlNovoFuncionario.Size = new System.Drawing.Size(602, 48);
            this.lvlNovoFuncionario.Style = MetroSet_UI.Enums.Style.Light;
            this.lvlNovoFuncionario.StyleManager = null;
            this.lvlNovoFuncionario.TabIndex = 7;
            this.lvlNovoFuncionario.Text = "Cadastrar novo Funcionário";
            this.lvlNovoFuncionario.ThemeAuthor = "Narwin";
            this.lvlNovoFuncionario.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(0, 75);
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
            this.txtNome.Location = new System.Drawing.Point(0, 101);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = false;
            this.txtNome.Size = new System.Drawing.Size(396, 29);
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
            this.tabFuncionariosAtivos.Size = new System.Drawing.Size(1392, 766);
            this.tabFuncionariosAtivos.Style = MetroSet_UI.Enums.Style.Light;
            this.tabFuncionariosAtivos.StyleManager = this.styleManager1;
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
            this.tabFeriasAgendadas.Size = new System.Drawing.Size(1392, 766);
            this.tabFeriasAgendadas.Style = MetroSet_UI.Enums.Style.Light;
            this.tabFeriasAgendadas.StyleManager = this.styleManager1;
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
            this.tabFeriasVencer.Size = new System.Drawing.Size(1392, 766);
            this.tabFeriasVencer.Style = MetroSet_UI.Enums.Style.Light;
            this.tabFeriasVencer.StyleManager = this.styleManager1;
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
            this.Desligamentos.Size = new System.Drawing.Size(1392, 766);
            this.Desligamentos.Style = MetroSet_UI.Enums.Style.Light;
            this.Desligamentos.StyleManager = this.styleManager1;
            this.Desligamentos.TabIndex = 4;
            this.Desligamentos.Text = "Desligamentos";
            this.Desligamentos.ThemeAuthor = "Narwin";
            this.Desligamentos.ThemeName = "MetroLite";
            this.Desligamentos.ToolTipText = null;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(1408, 900);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.metroSetControlBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderHeight = 30;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1408, 900);
            this.MinimumSize = new System.Drawing.Size(1408, 900);
            this.Name = "FrmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(13, 70, 13, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StyleManager = this.styleManager1;
            this.Text = "Projeto RH";
            this.TextColor = System.Drawing.Color.DarkGreen;
            this.ThemeName = "MetroDark";
            this.TabControl.ResumeLayout(false);
            this.tabNovoFuncionario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTabControl TabControl;
        private MetroSet_UI.Child.MetroSetSetTabPage tabNovoFuncionario;
        private MetroSet_UI.Child.MetroSetSetTabPage tabFuncionariosAtivos;
        private MetroSet_UI.Child.MetroSetSetTabPage tabFeriasAgendadas;
        private MetroSet_UI.Child.MetroSetSetTabPage tabFeriasVencer;
        private MetroSet_UI.Child.MetroSetSetTabPage Desligamentos;
        private MetroSet_UI.Components.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetTextBox txtNome;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel lvlNovoFuncionario;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
    }
}

