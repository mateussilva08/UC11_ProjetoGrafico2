namespace UC11_ProjetoGrafico2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.comboBoxESTADO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxOBS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDATA = new System.Windows.Forms.DateTimePicker();
            this.checkBoxCASADO = new System.Windows.Forms.CheckBox();
            this.checkBoxSolteiro = new System.Windows.Forms.CheckBox();
            this.checkBoxViuvo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CADASTRAR = new System.Windows.Forms.TabPage();
            this.tabPagelimpar = new System.Windows.Forms.TabPage();
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonLIMPAR = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.CADASTRAR.SuspendLayout();
            this.tabPagelimpar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMasculino);
            this.groupBox1.Controls.Add(this.radioButtonFeminino);
            this.groupBox1.Location = new System.Drawing.Point(51, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gênero";
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Location = new System.Drawing.Point(138, 42);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFeminino.TabIndex = 0;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            this.radioButtonFeminino.CheckedChanged += new System.EventHandler(this.radioButtonFeminino_CheckedChanged);
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(22, 42);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 1;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            this.radioButtonMasculino.CheckedChanged += new System.EventHandler(this.radioButtonMasculino_CheckedChanged);
            // 
            // comboBoxESTADO
            // 
            this.comboBoxESTADO.FormattingEnabled = true;
            this.comboBoxESTADO.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco ",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.comboBoxESTADO.Location = new System.Drawing.Point(51, 244);
            this.comboBoxESTADO.Name = "comboBoxESTADO";
            this.comboBoxESTADO.Size = new System.Drawing.Size(265, 21);
            this.comboBoxESTADO.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxOBS);
            this.panel1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(51, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 179);
            this.panel1.TabIndex = 3;
            // 
            // textBoxOBS
            // 
            this.textBoxOBS.Location = new System.Drawing.Point(22, 46);
            this.textBoxOBS.Multiline = true;
            this.textBoxOBS.Name = "textBoxOBS";
            this.textBoxOBS.Size = new System.Drawing.Size(222, 116);
            this.textBoxOBS.TabIndex = 0;
            this.textBoxOBS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Observações";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePickerDATA
            // 
            this.dateTimePickerDATA.Location = new System.Drawing.Point(351, 163);
            this.dateTimePickerDATA.Name = "dateTimePickerDATA";
            this.dateTimePickerDATA.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDATA.TabIndex = 4;
            // 
            // checkBoxCASADO
            // 
            this.checkBoxCASADO.AutoSize = true;
            this.checkBoxCASADO.Location = new System.Drawing.Point(351, 246);
            this.checkBoxCASADO.Name = "checkBoxCASADO";
            this.checkBoxCASADO.Size = new System.Drawing.Size(62, 17);
            this.checkBoxCASADO.TabIndex = 5;
            this.checkBoxCASADO.Text = "Casado";
            this.checkBoxCASADO.UseVisualStyleBackColor = true;
            this.checkBoxCASADO.CheckedChanged += new System.EventHandler(this.checkBoxCASADO_CheckedChanged);
            // 
            // checkBoxSolteiro
            // 
            this.checkBoxSolteiro.AutoSize = true;
            this.checkBoxSolteiro.Location = new System.Drawing.Point(352, 287);
            this.checkBoxSolteiro.Name = "checkBoxSolteiro";
            this.checkBoxSolteiro.Size = new System.Drawing.Size(61, 17);
            this.checkBoxSolteiro.TabIndex = 6;
            this.checkBoxSolteiro.Text = "Solteiro";
            this.checkBoxSolteiro.UseVisualStyleBackColor = true;
            this.checkBoxSolteiro.CheckedChanged += new System.EventHandler(this.checkBoxSolteiro_CheckedChanged);
            // 
            // checkBoxViuvo
            // 
            this.checkBoxViuvo.AutoSize = true;
            this.checkBoxViuvo.Location = new System.Drawing.Point(351, 322);
            this.checkBoxViuvo.Name = "checkBoxViuvo";
            this.checkBoxViuvo.Size = new System.Drawing.Size(53, 17);
            this.checkBoxViuvo.TabIndex = 7;
            this.checkBoxViuvo.Text = "Viuvo";
            this.checkBoxViuvo.UseVisualStyleBackColor = true;
            this.checkBoxViuvo.CheckedChanged += new System.EventHandler(this.checkBoxViuvo_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estado Civil";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CADASTRAR);
            this.tabControl1.Controls.Add(this.tabPagelimpar);
            this.tabControl1.Location = new System.Drawing.Point(351, 366);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 9;
            // 
            // CADASTRAR
            // 
            this.CADASTRAR.Controls.Add(this.buttonCADASTRAR);
            this.CADASTRAR.Location = new System.Drawing.Point(4, 22);
            this.CADASTRAR.Name = "CADASTRAR";
            this.CADASTRAR.Padding = new System.Windows.Forms.Padding(3);
            this.CADASTRAR.Size = new System.Drawing.Size(192, 74);
            this.CADASTRAR.TabIndex = 0;
            this.CADASTRAR.Text = " Cadastrar";
            this.CADASTRAR.UseVisualStyleBackColor = true;
            // 
            // tabPagelimpar
            // 
            this.tabPagelimpar.Controls.Add(this.buttonLIMPAR);
            this.tabPagelimpar.Location = new System.Drawing.Point(4, 22);
            this.tabPagelimpar.Name = "tabPagelimpar";
            this.tabPagelimpar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagelimpar.Size = new System.Drawing.Size(192, 74);
            this.tabPagelimpar.TabIndex = 1;
            this.tabPagelimpar.Text = "Limpar";
            this.tabPagelimpar.UseVisualStyleBackColor = true;
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.Location = new System.Drawing.Point(59, 29);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(75, 23);
            this.buttonCADASTRAR.TabIndex = 0;
            this.buttonCADASTRAR.Text = "Cadastrar";
            this.buttonCADASTRAR.UseVisualStyleBackColor = true;
            this.buttonCADASTRAR.Click += new System.EventHandler(this.buttonCADASTRAR_Click);
            // 
            // buttonLIMPAR
            // 
            this.buttonLIMPAR.Location = new System.Drawing.Point(51, 29);
            this.buttonLIMPAR.Name = "buttonLIMPAR";
            this.buttonLIMPAR.Size = new System.Drawing.Size(75, 23);
            this.buttonLIMPAR.TabIndex = 0;
            this.buttonLIMPAR.Text = "Limpar";
            this.buttonLIMPAR.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxViuvo);
            this.Controls.Add(this.checkBoxSolteiro);
            this.Controls.Add(this.checkBoxCASADO);
            this.Controls.Add(this.dateTimePickerDATA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxESTADO);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.CADASTRAR.ResumeLayout(false);
            this.tabPagelimpar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.ComboBox comboBoxESTADO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxOBS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDATA;
        private System.Windows.Forms.CheckBox checkBoxCASADO;
        private System.Windows.Forms.CheckBox checkBoxSolteiro;
        private System.Windows.Forms.CheckBox checkBoxViuvo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CADASTRAR;
        private System.Windows.Forms.TabPage tabPagelimpar;
        private System.Windows.Forms.Button buttonCADASTRAR;
        private System.Windows.Forms.Button buttonLIMPAR;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

