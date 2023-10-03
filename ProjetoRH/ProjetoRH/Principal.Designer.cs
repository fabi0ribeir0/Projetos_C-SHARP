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
            this.TabControl = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabNovoFuncionario = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.tabFuncionariosAtivos = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.tabFeriasAgendadas = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.tabFeriasVencer = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.Desligamentos = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.TabControl.SuspendLayout();
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
            this.metroSetControlBox1.Location = new System.Drawing.Point(1039, 13);
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
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
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
            this.TabControl.Location = new System.Drawing.Point(15, 73);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 4;
            this.TabControl.SelectedTextColor = System.Drawing.Color.White;
            this.TabControl.Size = new System.Drawing.Size(1124, 532);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.Speed = 100;
            this.TabControl.Style = MetroSet_UI.Enums.Style.Light;
            this.TabControl.StyleManager = null;
            this.TabControl.TabIndex = 1;
            this.TabControl.ThemeAuthor = "Narwin";
            this.TabControl.ThemeName = "MetroLite";
            this.TabControl.UnselectedTextColor = System.Drawing.Color.Gray;
            this.TabControl.UseAnimation = false;
            // 
            // tabNovoFuncionario
            // 
            this.tabNovoFuncionario.BaseColor = System.Drawing.Color.White;
            this.tabNovoFuncionario.Font = null;
            this.tabNovoFuncionario.ImageIndex = 0;
            this.tabNovoFuncionario.ImageKey = null;
            this.tabNovoFuncionario.IsDerivedStyle = true;
            this.tabNovoFuncionario.Location = new System.Drawing.Point(4, 42);
            this.tabNovoFuncionario.Name = "tabNovoFuncionario";
            this.tabNovoFuncionario.Size = new System.Drawing.Size(1116, 486);
            this.tabNovoFuncionario.Style = MetroSet_UI.Enums.Style.Light;
            this.tabNovoFuncionario.StyleManager = null;
            this.tabNovoFuncionario.TabIndex = 0;
            this.tabNovoFuncionario.Text = "Novo Funcionario";
            this.tabNovoFuncionario.ThemeAuthor = "Narwin";
            this.tabNovoFuncionario.ThemeName = "MetroLite";
            this.tabNovoFuncionario.ToolTipText = null;
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
            this.tabFuncionariosAtivos.Size = new System.Drawing.Size(1116, 486);
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
            this.tabFeriasAgendadas.Size = new System.Drawing.Size(1116, 486);
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
            this.tabFeriasVencer.Size = new System.Drawing.Size(1116, 486);
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
            this.Desligamentos.Size = new System.Drawing.Size(1116, 486);
            this.Desligamentos.Style = MetroSet_UI.Enums.Style.Light;
            this.Desligamentos.StyleManager = null;
            this.Desligamentos.TabIndex = 4;
            this.Desligamentos.Text = "Desligamentos";
            this.Desligamentos.ThemeAuthor = "Narwin";
            this.Desligamentos.ThemeName = "MetroLite";
            this.Desligamentos.ToolTipText = null;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 676);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.metroSetControlBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto RH";
            this.TabControl.ResumeLayout(false);
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
    }
}

