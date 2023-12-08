using MicroOndasDigital.Views;

namespace MicroOndasDigital
{
    partial class MicroOndasView : IMicroOndasView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.iniciarButton = new System.Windows.Forms.Button();
            this.pausarButton = new System.Windows.Forms.Button();
            this.buttonNumber2 = new System.Windows.Forms.Button();
            this.buttonNumber0 = new System.Windows.Forms.Button();
            this.buttonNumber1 = new System.Windows.Forms.Button();
            this.buttonNumber5 = new System.Windows.Forms.Button();
            this.buttonNumber3 = new System.Windows.Forms.Button();
            this.buttonNumber4 = new System.Windows.Forms.Button();
            this.buttonNumber8 = new System.Windows.Forms.Button();
            this.buttonNumber6 = new System.Windows.Forms.Button();
            this.buttonNumber7 = new System.Windows.Forms.Button();
            this.buttonNumber9 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.potenciaLabel = new System.Windows.Forms.Label();
            this.potenciaTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.relogioLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iniciarButton
            // 
            this.iniciarButton.Location = new System.Drawing.Point(420, 281);
            this.iniciarButton.Name = "iniciarButton";
            this.iniciarButton.Size = new System.Drawing.Size(75, 23);
            this.iniciarButton.TabIndex = 0;
            this.iniciarButton.Text = "Iniciar";
            this.iniciarButton.UseVisualStyleBackColor = true;
            // 
            // pausarButton
            // 
            this.pausarButton.Location = new System.Drawing.Point(339, 281);
            this.pausarButton.Name = "pausarButton";
            this.pausarButton.Size = new System.Drawing.Size(75, 23);
            this.pausarButton.TabIndex = 1;
            this.pausarButton.Text = "Pausar";
            this.pausarButton.UseVisualStyleBackColor = true;
            // 
            // buttonNumber2
            // 
            this.buttonNumber2.Location = new System.Drawing.Point(65, 79);
            this.buttonNumber2.Name = "buttonNumber2";
            this.buttonNumber2.Size = new System.Drawing.Size(28, 23);
            this.buttonNumber2.TabIndex = 2;
            this.buttonNumber2.Text = "2";
            this.buttonNumber2.UseVisualStyleBackColor = true;
            this.buttonNumber2.Click += new System.EventHandler(this.buttonNumber2_Click);
            // 
            // buttonNumber0
            // 
            this.buttonNumber0.Location = new System.Drawing.Point(65, 108);
            this.buttonNumber0.Name = "buttonNumber0";
            this.buttonNumber0.Size = new System.Drawing.Size(28, 23);
            this.buttonNumber0.TabIndex = 3;
            this.buttonNumber0.Text = "0";
            this.buttonNumber0.UseVisualStyleBackColor = true;
            this.buttonNumber0.Click += new System.EventHandler(this.buttonNumber0_Click);
            // 
            // buttonNumber1
            // 
            this.buttonNumber1.Location = new System.Drawing.Point(18, 79);
            this.buttonNumber1.Name = "buttonNumber1";
            this.buttonNumber1.Size = new System.Drawing.Size(28, 23);
            this.buttonNumber1.TabIndex = 5;
            this.buttonNumber1.Text = "1";
            this.buttonNumber1.UseVisualStyleBackColor = true;
            this.buttonNumber1.Click += new System.EventHandler(this.buttonNumber1_Click);
            // 
            // buttonNumber5
            // 
            this.buttonNumber5.Location = new System.Drawing.Point(65, 50);
            this.buttonNumber5.Name = "buttonNumber5";
            this.buttonNumber5.Size = new System.Drawing.Size(28, 23);
            this.buttonNumber5.TabIndex = 6;
            this.buttonNumber5.Text = "5";
            this.buttonNumber5.UseVisualStyleBackColor = true;
            this.buttonNumber5.Click += new System.EventHandler(this.buttonNumber5_Click);
            // 
            // buttonNumber3
            // 
            this.buttonNumber3.Location = new System.Drawing.Point(111, 79);
            this.buttonNumber3.Name = "buttonNumber3";
            this.buttonNumber3.Size = new System.Drawing.Size(28, 23);
            this.buttonNumber3.TabIndex = 7;
            this.buttonNumber3.Text = "3";
            this.buttonNumber3.UseVisualStyleBackColor = true;
            this.buttonNumber3.Click += new System.EventHandler(this.buttonNumber3_Click);
            // 
            // buttonNumber4
            // 
            this.buttonNumber4.Location = new System.Drawing.Point(18, 50);
            this.buttonNumber4.Name = "buttonNumber4";
            this.buttonNumber4.Size = new System.Drawing.Size(28, 23);
            this.buttonNumber4.TabIndex = 8;
            this.buttonNumber4.Text = "4";
            this.buttonNumber4.UseVisualStyleBackColor = true;
            this.buttonNumber4.Click += new System.EventHandler(this.buttonNumber4_Click);
            // 
            // buttonNumber8
            // 
            this.buttonNumber8.Location = new System.Drawing.Point(65, 21);
            this.buttonNumber8.Name = "buttonNumber8";
            this.buttonNumber8.Size = new System.Drawing.Size(28, 23);
            this.buttonNumber8.TabIndex = 9;
            this.buttonNumber8.Text = "8";
            this.buttonNumber8.UseVisualStyleBackColor = true;
            this.buttonNumber8.Click += new System.EventHandler(this.buttonNumber8_Click);
            // 
            // buttonNumber6
            // 
            this.buttonNumber6.Location = new System.Drawing.Point(111, 50);
            this.buttonNumber6.Name = "buttonNumber6";
            this.buttonNumber6.Size = new System.Drawing.Size(28, 23);
            this.buttonNumber6.TabIndex = 10;
            this.buttonNumber6.Text = "6";
            this.buttonNumber6.UseVisualStyleBackColor = true;
            this.buttonNumber6.Click += new System.EventHandler(this.buttonNumber6_Click);
            // 
            // buttonNumber7
            // 
            this.buttonNumber7.Location = new System.Drawing.Point(18, 21);
            this.buttonNumber7.Name = "buttonNumber7";
            this.buttonNumber7.Size = new System.Drawing.Size(28, 23);
            this.buttonNumber7.TabIndex = 11;
            this.buttonNumber7.Text = "7";
            this.buttonNumber7.UseVisualStyleBackColor = true;
            this.buttonNumber7.Click += new System.EventHandler(this.buttonNumber7_Click);
            // 
            // buttonNumber9
            // 
            this.buttonNumber9.Location = new System.Drawing.Point(111, 21);
            this.buttonNumber9.Name = "buttonNumber9";
            this.buttonNumber9.Size = new System.Drawing.Size(28, 23);
            this.buttonNumber9.TabIndex = 9;
            this.buttonNumber9.Text = "9";
            this.buttonNumber9.UseVisualStyleBackColor = true;
            this.buttonNumber9.Click += new System.EventHandler(this.buttonNumber9_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonNumber9);
            this.panel1.Controls.Add(this.buttonNumber2);
            this.panel1.Controls.Add(this.buttonNumber7);
            this.panel1.Controls.Add(this.buttonNumber0);
            this.panel1.Controls.Add(this.buttonNumber6);
            this.panel1.Controls.Add(this.buttonNumber1);
            this.panel1.Controls.Add(this.buttonNumber8);
            this.panel1.Controls.Add(this.buttonNumber5);
            this.panel1.Controls.Add(this.buttonNumber4);
            this.panel1.Controls.Add(this.buttonNumber3);
            this.panel1.Location = new System.Drawing.Point(339, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 145);
            this.panel1.TabIndex = 12;
            // 
            // potenciaLabel
            // 
            this.potenciaLabel.AutoSize = true;
            this.potenciaLabel.Location = new System.Drawing.Point(339, 67);
            this.potenciaLabel.Name = "potenciaLabel";
            this.potenciaLabel.Size = new System.Drawing.Size(53, 15);
            this.potenciaLabel.TabIndex = 14;
            this.potenciaLabel.Text = "Potência";
            // 
            // potenciaTextBox
            // 
            this.potenciaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.potenciaTextBox.Location = new System.Drawing.Point(395, 64);
            this.potenciaTextBox.MaxLength = 2;
            this.potenciaTextBox.Name = "potenciaTextBox";
            this.potenciaTextBox.Size = new System.Drawing.Size(100, 23);
            this.potenciaTextBox.TabIndex = 16;
            this.potenciaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.potenciaTextBox_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 292);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // relogioLabel
            // 
            this.relogioLabel.AutoSize = true;
            this.relogioLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.relogioLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.relogioLabel.Location = new System.Drawing.Point(332, 6);
            this.relogioLabel.Name = "relogioLabel";
            this.relogioLabel.Size = new System.Drawing.Size(174, 51);
            this.relogioLabel.TabIndex = 18;
            this.relogioLabel.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MicroOndasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 322);
            this.Controls.Add(this.relogioLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.potenciaTextBox);
            this.Controls.Add(this.potenciaLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pausarButton);
            this.Controls.Add(this.iniciarButton);
            this.Name = "MicroOndasView";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button iniciarButton;
        private Button pausarButton;
        private Button buttonNumber0;
        private Button buttonNumber1;
        private Button buttonNumber2;
        private Button buttonNumber3;
        private Button buttonNumber4;
        private Button buttonNumber5;
        private Button buttonNumber6;
        private Button buttonNumber7;
        private Button buttonNumber8;
        private Button buttonNumber9;
        private Panel panel1;
        private Label potenciaLabel;
        private TextBox potenciaTextBox;
        private PictureBox pictureBox1;
        private Label relogioLabel;
        private System.Windows.Forms.Timer timer1;

        public event EventHandler IniciarAquecimento;
        public event EventHandler PausarAquecimento;
        public event EventHandler<string> SelecionarPrograma;
    }
}