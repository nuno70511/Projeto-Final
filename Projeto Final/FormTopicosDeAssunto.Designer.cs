namespace Projeto_Final
{
    partial class FormTopicosDeAssunto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTopicosDeAssunto));
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AdicionarButton = new System.Windows.Forms.Button();
            this.AssuntoTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AssuntoLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.RetrocederButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(283, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 622);
            this.panel2.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AdicionarButton);
            this.groupBox1.Controls.Add(this.AssuntoTextBox);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.AssuntoLabel);
            this.groupBox1.Location = new System.Drawing.Point(32, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(665, 440);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // AdicionarButton
            // 
            this.AdicionarButton.BackColor = System.Drawing.Color.Transparent;
            this.AdicionarButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.AdicionarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(193)))));
            this.AdicionarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(193)))));
            this.AdicionarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdicionarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdicionarButton.Location = new System.Drawing.Point(279, 116);
            this.AdicionarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdicionarButton.Name = "AdicionarButton";
            this.AdicionarButton.Size = new System.Drawing.Size(135, 58);
            this.AdicionarButton.TabIndex = 25;
            this.AdicionarButton.Text = "Adicionar";
            this.AdicionarButton.UseVisualStyleBackColor = false;
            this.AdicionarButton.Click += new System.EventHandler(this.AdicionarButton_Click);
            // 
            // AssuntoTextBox
            // 
            this.AssuntoTextBox.Location = new System.Drawing.Point(174, 56);
            this.AssuntoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AssuntoTextBox.Multiline = true;
            this.AssuntoTextBox.Name = "AssuntoTextBox";
            this.AssuntoTextBox.Size = new System.Drawing.Size(419, 28);
            this.AssuntoTextBox.TabIndex = 24;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(88, 211);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(505, 180);
            this.listBox1.TabIndex = 23;
            // 
            // AssuntoLabel
            // 
            this.AssuntoLabel.AutoSize = true;
            this.AssuntoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssuntoLabel.Location = new System.Drawing.Point(83, 56);
            this.AssuntoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AssuntoLabel.Name = "AssuntoLabel";
            this.AssuntoLabel.Size = new System.Drawing.Size(90, 25);
            this.AssuntoLabel.TabIndex = 14;
            this.AssuntoLabel.Text = "Assunto:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.line1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.LogOutButton);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.RetrocederButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 622);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(78, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 29);
            this.label5.TabIndex = 41;
            this.label5.Text = "de Assunto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(95, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 29);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tópicos ";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
            this.line1.Location = new System.Drawing.Point(3, 119);
            this.line1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.line1.Multiline = true;
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(277, 10);
            this.line1.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(82, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 29);
            this.label13.TabIndex = 38;
            this.label13.Text = "Serviços";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
            this.textBox1.Location = new System.Drawing.Point(6, 207);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 10);
            this.textBox1.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(186, 591);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "ESMAD";
            // 
            // LogOutButton
            // 
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogOutButton.Location = new System.Drawing.Point(2, 349);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(280, 54);
            this.LogOutButton.TabIndex = 35;
            this.LogOutButton.Text = "LogOut";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(61, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 29);
            this.label12.TabIndex = 39;
            this.label12.Text = "de Informática";
            // 
            // RetrocederButton
            // 
            this.RetrocederButton.FlatAppearance.BorderSize = 0;
            this.RetrocederButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetrocederButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetrocederButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RetrocederButton.Location = new System.Drawing.Point(0, 263);
            this.RetrocederButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RetrocederButton.Name = "RetrocederButton";
            this.RetrocederButton.Size = new System.Drawing.Size(283, 54);
            this.RetrocederButton.TabIndex = 34;
            this.RetrocederButton.Text = "Retroceder";
            this.RetrocederButton.UseVisualStyleBackColor = true;
            this.RetrocederButton.Click += new System.EventHandler(this.RetrocederButton_Click_1);
            // 
            // FormTopicosDeAssunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 622);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTopicosDeAssunto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTopicosDeAssunto";
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AssuntoTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label AssuntoLabel;
        private System.Windows.Forms.Button AdicionarButton;
        private System.Windows.Forms.TextBox line1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button RetrocederButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}