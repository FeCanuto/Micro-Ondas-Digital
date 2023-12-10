namespace MicroOndasDigital.Views
{
    partial class AdicionarProgramaView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descricaoLabel = new System.Windows.Forms.Label();
            this.potenciaLabel = new System.Windows.Forms.Label();
            this.tempoLabel = new System.Windows.Forms.Label();
            this.alimentoLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.adicionarProgramButton = new System.Windows.Forms.Button();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.potenciaTextBox = new System.Windows.Forms.TextBox();
            this.tempoTextBox = new System.Windows.Forms.TextBox();
            this.alimentoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.stringTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.descricaoLabel);
            this.panel1.Controls.Add(this.potenciaLabel);
            this.panel1.Controls.Add(this.tempoLabel);
            this.panel1.Controls.Add(this.alimentoLabel);
            this.panel1.Controls.Add(this.nomeLabel);
            this.panel1.Controls.Add(this.cancelarButton);
            this.panel1.Controls.Add(this.adicionarProgramButton);
            this.panel1.Controls.Add(this.descricaoTextBox);
            this.panel1.Controls.Add(this.potenciaTextBox);
            this.panel1.Controls.Add(this.tempoTextBox);
            this.panel1.Controls.Add(this.alimentoTextBox);
            this.panel1.Controls.Add(this.nomeTextBox);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 370);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "String";
            // 
            // stringTextBox
            // 
            this.stringTextBox.Location = new System.Drawing.Point(9, 172);
            this.stringTextBox.MaxLength = 1;
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(97, 23);
            this.stringTextBox.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Adicionar novo programa";
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.AutoSize = true;
            this.descricaoLabel.Location = new System.Drawing.Point(11, 211);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(58, 15);
            this.descricaoLabel.TabIndex = 37;
            this.descricaoLabel.Text = "Descrição";
            // 
            // potenciaLabel
            // 
            this.potenciaLabel.AutoSize = true;
            this.potenciaLabel.Location = new System.Drawing.Point(131, 94);
            this.potenciaLabel.Name = "potenciaLabel";
            this.potenciaLabel.Size = new System.Drawing.Size(53, 15);
            this.potenciaLabel.TabIndex = 36;
            this.potenciaLabel.Text = "Potência";
            // 
            // tempoLabel
            // 
            this.tempoLabel.AutoSize = true;
            this.tempoLabel.Location = new System.Drawing.Point(11, 94);
            this.tempoLabel.Name = "tempoLabel";
            this.tempoLabel.Size = new System.Drawing.Size(43, 15);
            this.tempoLabel.TabIndex = 35;
            this.tempoLabel.Text = "Tempo";
            // 
            // alimentoLabel
            // 
            this.alimentoLabel.AutoSize = true;
            this.alimentoLabel.Location = new System.Drawing.Point(128, 36);
            this.alimentoLabel.Name = "alimentoLabel";
            this.alimentoLabel.Size = new System.Drawing.Size(56, 15);
            this.alimentoLabel.TabIndex = 34;
            this.alimentoLabel.Text = "Alimento";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(8, 36);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(40, 15);
            this.nomeLabel.TabIndex = 33;
            this.nomeLabel.Text = "Nome";
            // 
            // cancelarButton
            // 
            this.cancelarButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cancelarButton.Location = new System.Drawing.Point(75, 339);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 32;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // adicionarProgramButton
            // 
            this.adicionarProgramButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.adicionarProgramButton.Location = new System.Drawing.Point(156, 339);
            this.adicionarProgramButton.Name = "adicionarProgramButton";
            this.adicionarProgramButton.Size = new System.Drawing.Size(75, 23);
            this.adicionarProgramButton.TabIndex = 31;
            this.adicionarProgramButton.Text = "Adicionar";
            this.adicionarProgramButton.UseVisualStyleBackColor = false;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(8, 229);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(220, 104);
            this.descricaoTextBox.TabIndex = 30;
            // 
            // potenciaTextBox
            // 
            this.potenciaTextBox.Location = new System.Drawing.Point(131, 112);
            this.potenciaTextBox.Name = "potenciaTextBox";
            this.potenciaTextBox.Size = new System.Drawing.Size(97, 23);
            this.potenciaTextBox.TabIndex = 29;
            this.potenciaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.potenciaTextBox_KeyPress);
            // 
            // tempoTextBox
            // 
            this.tempoTextBox.Location = new System.Drawing.Point(8, 112);
            this.tempoTextBox.Name = "tempoTextBox";
            this.tempoTextBox.Size = new System.Drawing.Size(103, 23);
            this.tempoTextBox.TabIndex = 28;
            this.tempoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tempoTextBox_KeyPress);
            // 
            // alimentoTextBox
            // 
            this.alimentoTextBox.Location = new System.Drawing.Point(128, 54);
            this.alimentoTextBox.Name = "alimentoTextBox";
            this.alimentoTextBox.Size = new System.Drawing.Size(100, 23);
            this.alimentoTextBox.TabIndex = 27;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(8, 54);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(103, 23);
            this.nomeTextBox.TabIndex = 26;
            // 
            // AdicionarProgramaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(490, 375);
            this.Controls.Add(this.panel1);
            this.Name = "AdicionarProgramaView";
            this.Text = "AdicionarProgramaView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label descricaoLabel;
        private Label potenciaLabel;
        private Label tempoLabel;
        private Label alimentoLabel;
        private Label nomeLabel;
        private Button cancelarButton;
        private Button adicionarProgramButton;
        private TextBox descricaoTextBox;
        private TextBox potenciaTextBox;
        private TextBox tempoTextBox;
        private TextBox alimentoTextBox;
        private TextBox nomeTextBox;
        private Label label2;
        private TextBox stringTextBox;
    }
}