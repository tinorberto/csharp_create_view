namespace WindowsFormsApplication6
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Abreviatura = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.generatebutton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.typeGeomcomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.schemaTextBox = new System.Windows.Forms.TextBox();
            this.refreshComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.findColumnsBox1 = new System.Windows.Forms.CheckBox();
            this.tableNameTextBox = new System.Windows.Forms.TextBox();
            this.tableOwnertextBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentários = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeGridButton = new System.Windows.Forms.Button();
            this.comentButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkImmediate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informações para camada";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(91, 35);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(223, 20);
            this.nametextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // Abreviatura
            // 
            this.Abreviatura.AutoSize = true;
            this.Abreviatura.Location = new System.Drawing.Point(320, 38);
            this.Abreviatura.Name = "Abreviatura";
            this.Abreviatura.Size = new System.Drawing.Size(61, 13);
            this.Abreviatura.TabIndex = 6;
            this.Abreviatura.Text = "Abreviatura";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(382, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // generatebutton
            // 
            this.generatebutton.Location = new System.Drawing.Point(323, 713);
            this.generatebutton.Name = "generatebutton";
            this.generatebutton.Size = new System.Drawing.Size(75, 23);
            this.generatebutton.TabIndex = 7;
            this.generatebutton.Text = "Gerar Script";
            this.generatebutton.UseVisualStyleBackColor = true;
            this.generatebutton.Click += new System.EventHandler(this.generatebutton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(42, 567);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(496, 140);
            this.resultTextBox.TabIndex = 8;
            this.resultTextBox.Text = "";
            // 
            // typeGeomcomboBox
            // 
            this.typeGeomcomboBox.FormattingEnabled = true;
            this.typeGeomcomboBox.Items.AddRange(new object[] {
            "MULTIPOINT",
            "MULTILINE",
            "MULTIPOLYGON ",
            "POINT",
            "LINE",
            "POLYGON",
            "NENHUM"});
            this.typeGeomcomboBox.Location = new System.Drawing.Point(127, 157);
            this.typeGeomcomboBox.Name = "typeGeomcomboBox";
            this.typeGeomcomboBox.Size = new System.Drawing.Size(121, 21);
            this.typeGeomcomboBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo de geometria";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Esquema";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // schemaTextBox
            // 
            this.schemaTextBox.Location = new System.Drawing.Point(91, 73);
            this.schemaTextBox.Name = "schemaTextBox";
            this.schemaTextBox.Size = new System.Drawing.Size(223, 20);
            this.schemaTextBox.TabIndex = 12;
            // 
            // refreshComboBox
            // 
            this.refreshComboBox.FormattingEnabled = true;
            this.refreshComboBox.Items.AddRange(new object[] {
            "SEMANAL",
            "DIARIO",
            "MENSAL"});
            this.refreshComboBox.Location = new System.Drawing.Point(127, 121);
            this.refreshComboBox.Name = "refreshComboBox";
            this.refreshComboBox.Size = new System.Drawing.Size(121, 21);
            this.refreshComboBox.TabIndex = 13;
            this.refreshComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Atualização";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // findColumnsBox1
            // 
            this.findColumnsBox1.AutoSize = true;
            this.findColumnsBox1.Location = new System.Drawing.Point(32, 194);
            this.findColumnsBox1.Name = "findColumnsBox1";
            this.findColumnsBox1.Size = new System.Drawing.Size(143, 17);
            this.findColumnsBox1.TabIndex = 15;
            this.findColumnsBox1.Text = "Buscar nome das coluna";
            this.findColumnsBox1.UseVisualStyleBackColor = true;
            // 
            // tableNameTextBox
            // 
            this.tableNameTextBox.Location = new System.Drawing.Point(291, 217);
            this.tableNameTextBox.Name = "tableNameTextBox";
            this.tableNameTextBox.Size = new System.Drawing.Size(130, 20);
            this.tableNameTextBox.TabIndex = 16;
            // 
            // tableOwnertextBox2
            // 
            this.tableOwnertextBox2.Location = new System.Drawing.Point(155, 217);
            this.tableOwnertextBox2.Name = "tableOwnertextBox2";
            this.tableOwnertextBox2.Size = new System.Drawing.Size(130, 20);
            this.tableOwnertextBox2.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Esquema e nome tabela";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.View,
            this.Comentários});
            this.dataGrid.Location = new System.Drawing.Point(42, 258);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(496, 274);
            this.dataGrid.TabIndex = 19;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Tabela";
            this.Nome.Name = "Nome";
            // 
            // View
            // 
            this.View.HeaderText = "View";
            this.View.Name = "View";
            // 
            // Comentários
            // 
            this.Comentários.HeaderText = "Comentário";
            this.Comentários.Name = "Comentários";
            // 
            // removeGridButton
            // 
            this.removeGridButton.Location = new System.Drawing.Point(392, 538);
            this.removeGridButton.Name = "removeGridButton";
            this.removeGridButton.Size = new System.Drawing.Size(146, 23);
            this.removeGridButton.TabIndex = 20;
            this.removeGridButton.Text = "Remover Linhas";
            this.removeGridButton.UseVisualStyleBackColor = true;
            this.removeGridButton.Click += new System.EventHandler(this.removeGridButton_Click);
            // 
            // comentButton
            // 
            this.comentButton.Location = new System.Drawing.Point(404, 713);
            this.comentButton.Name = "comentButton";
            this.comentButton.Size = new System.Drawing.Size(134, 23);
            this.comentButton.TabIndex = 21;
            this.comentButton.Text = "Gerar comentários";
            this.comentButton.UseVisualStyleBackColor = true;
            this.comentButton.Click += new System.EventHandler(this.comentButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Limpar Tabela";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkImmediate
            // 
            this.checkImmediate.AutoSize = true;
            this.checkImmediate.Location = new System.Drawing.Point(323, 76);
            this.checkImmediate.Name = "checkImmediate";
            this.checkImmediate.Size = new System.Drawing.Size(100, 17);
            this.checkImmediate.TabIndex = 23;
            this.checkImmediate.Text = "Build Immediate";
            this.checkImmediate.UseVisualStyleBackColor = true;
            this.checkImmediate.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 747);
            this.Controls.Add(this.checkImmediate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comentButton);
            this.Controls.Add(this.removeGridButton);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableOwnertextBox2);
            this.Controls.Add(this.tableNameTextBox);
            this.Controls.Add(this.findColumnsBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.refreshComboBox);
            this.Controls.Add(this.schemaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeGeomcomboBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.generatebutton);
            this.Controls.Add(this.Abreviatura);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Gerador Script IDE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Abreviatura;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button generatebutton;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.ComboBox typeGeomcomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox schemaTextBox;
        private System.Windows.Forms.ComboBox refreshComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox findColumnsBox1;
        private System.Windows.Forms.TextBox tableNameTextBox;
        private System.Windows.Forms.TextBox tableOwnertextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn View;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentários;
        private System.Windows.Forms.Button removeGridButton;
        private System.Windows.Forms.Button comentButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkImmediate;
    }
}

