namespace Projeto_Final
{
    partial class FormEstadoDoPedido
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AssuntoComboBox = new System.Windows.Forms.ComboBox();
            this.SalasComboBox = new System.Windows.Forms.ComboBox();
            this.PesquisaBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ExitRegisterButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.AssuntoComboBox);
            this.panel2.Controls.Add(this.SalasComboBox);
            this.panel2.Controls.Add(this.PesquisaBtn);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.ExitRegisterButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 366);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Assunto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Salas:";
            // 
            // AssuntoComboBox
            // 
            this.AssuntoComboBox.FormattingEnabled = true;
            this.AssuntoComboBox.Items.AddRange(new object[] {
            "----- Sem filtro -----"});
            this.AssuntoComboBox.Location = new System.Drawing.Point(467, 40);
            this.AssuntoComboBox.Name = "AssuntoComboBox";
            this.AssuntoComboBox.Size = new System.Drawing.Size(121, 21);
            this.AssuntoComboBox.TabIndex = 12;
            this.AssuntoComboBox.Text = "----- Sem filtro -----";
            // 
            // SalasComboBox
            // 
            this.SalasComboBox.FormattingEnabled = true;
            this.SalasComboBox.Items.AddRange(new object[] {
            "----- Sem filtro -----"});
            this.SalasComboBox.Location = new System.Drawing.Point(467, 12);
            this.SalasComboBox.Name = "SalasComboBox";
            this.SalasComboBox.Size = new System.Drawing.Size(121, 21);
            this.SalasComboBox.TabIndex = 11;
            this.SalasComboBox.Text = "----- Sem filtro -----";
            // 
            // PesquisaBtn
            // 
            this.PesquisaBtn.Location = new System.Drawing.Point(256, 331);
            this.PesquisaBtn.Name = "PesquisaBtn";
            this.PesquisaBtn.Size = new System.Drawing.Size(75, 23);
            this.PesquisaBtn.TabIndex = 10;
            this.PesquisaBtn.Text = "Pesquisar";
            this.PesquisaBtn.UseVisualStyleBackColor = true;
            this.PesquisaBtn.Click += new System.EventHandler(this.PesquisaBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(177, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 231);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Estado";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Comentario";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Resposta";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Assunto";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sala";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Data";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Hora";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(254, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Concluidos";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(254, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Pendentes";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ExitRegisterButton
            // 
            this.ExitRegisterButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitRegisterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
            this.ExitRegisterButton.FlatAppearance.BorderSize = 0;
            this.ExitRegisterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(193)))));
            this.ExitRegisterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(193)))));
            this.ExitRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitRegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitRegisterButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitRegisterButton.Location = new System.Drawing.Point(533, 342);
            this.ExitRegisterButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitRegisterButton.Name = "ExitRegisterButton";
            this.ExitRegisterButton.Size = new System.Drawing.Size(65, 22);
            this.ExitRegisterButton.TabIndex = 6;
            this.ExitRegisterButton.Text = "X";
            this.ExitRegisterButton.UseVisualStyleBackColor = false;
            this.ExitRegisterButton.Click += new System.EventHandler(this.ExitRegisterButton_Click);
            // 
            // FormEstadoDoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel2);
            this.Name = "FormEstadoDoPedido";
            this.Text = "FormEstadoDoPedido";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button ExitRegisterButton;
        private System.Windows.Forms.ComboBox AssuntoComboBox;
        private System.Windows.Forms.ComboBox SalasComboBox;
        private System.Windows.Forms.Button PesquisaBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}