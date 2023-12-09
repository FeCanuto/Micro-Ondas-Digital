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
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("! ->Pipoca");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("@ -> Leite");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("# -> Carnes de boi");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("$ -> Frango");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("% -> Feijão");
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
            this.pipocaButton = new System.Windows.Forms.Button();
            this.leiteButton = new System.Windows.Forms.Button();
            this.boiButton = new System.Windows.Forms.Button();
            this.nuggetsButton = new System.Windows.Forms.Button();
            this.feijaoButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.adicionarProgramaButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iniciarButton
            // 
            this.iniciarButton.BackColor = System.Drawing.Color.LightGreen;
            this.iniciarButton.Location = new System.Drawing.Point(442, 302);
            this.iniciarButton.Name = "iniciarButton";
            this.iniciarButton.Size = new System.Drawing.Size(75, 23);
            this.iniciarButton.TabIndex = 0;
            this.iniciarButton.Text = "Iniciar / 30s";
            this.iniciarButton.UseVisualStyleBackColor = false;
            // 
            // pausarButton
            // 
            this.pausarButton.BackColor = System.Drawing.Color.Tomato;
            this.pausarButton.Location = new System.Drawing.Point(339, 302);
            this.pausarButton.Name = "pausarButton";
            this.pausarButton.Size = new System.Drawing.Size(97, 23);
            this.pausarButton.TabIndex = 1;
            this.pausarButton.Text = "Pause/Cancel";
            this.pausarButton.UseVisualStyleBackColor = false;
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
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
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
            this.panel1.Location = new System.Drawing.Point(350, 93);
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
            // pipocaButton
            // 
            this.pipocaButton.Location = new System.Drawing.Point(349, 244);
            this.pipocaButton.Name = "pipocaButton";
            this.pipocaButton.Size = new System.Drawing.Size(53, 23);
            this.pipocaButton.TabIndex = 20;
            this.pipocaButton.Text = "Pipoca";
            this.pipocaButton.UseVisualStyleBackColor = true;
            this.pipocaButton.Click += new System.EventHandler(this.pipocaButton_Click);
            // 
            // leiteButton
            // 
            this.leiteButton.Location = new System.Drawing.Point(408, 244);
            this.leiteButton.Name = "leiteButton";
            this.leiteButton.Size = new System.Drawing.Size(53, 23);
            this.leiteButton.TabIndex = 21;
            this.leiteButton.Text = "Leite";
            this.leiteButton.UseVisualStyleBackColor = true;
            this.leiteButton.Click += new System.EventHandler(this.leiteButton_Click);
            // 
            // boiButton
            // 
            this.boiButton.Location = new System.Drawing.Point(350, 273);
            this.boiButton.Name = "boiButton";
            this.boiButton.Size = new System.Drawing.Size(52, 23);
            this.boiButton.TabIndex = 22;
            this.boiButton.Text = "Meat";
            this.boiButton.UseVisualStyleBackColor = true;
            this.boiButton.Click += new System.EventHandler(this.boiButton_Click);
            // 
            // nuggetsButton
            // 
            this.nuggetsButton.Location = new System.Drawing.Point(408, 273);
            this.nuggetsButton.Name = "nuggetsButton";
            this.nuggetsButton.Size = new System.Drawing.Size(53, 23);
            this.nuggetsButton.TabIndex = 23;
            this.nuggetsButton.Text = "Frango";
            this.nuggetsButton.UseVisualStyleBackColor = true;
            this.nuggetsButton.Click += new System.EventHandler(this.nuggetsButton_Click);
            // 
            // feijaoButton
            // 
            this.feijaoButton.Location = new System.Drawing.Point(467, 244);
            this.feijaoButton.Name = "feijaoButton";
            this.feijaoButton.Size = new System.Drawing.Size(53, 23);
            this.feijaoButton.TabIndex = 24;
            this.feijaoButton.Text = "Feijão";
            this.feijaoButton.UseVisualStyleBackColor = true;
            this.feijaoButton.Click += new System.EventHandler(this.feijaoButton_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.listView1.Location = new System.Drawing.Point(189, 183);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(126, 103);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // adicionarProgramaButton
            // 
            this.adicionarProgramaButton.Location = new System.Drawing.Point(467, 273);
            this.adicionarProgramaButton.Name = "adicionarProgramaButton";
            this.adicionarProgramaButton.Size = new System.Drawing.Size(53, 23);
            this.adicionarProgramaButton.TabIndex = 26;
            this.adicionarProgramaButton.Text = "Add";
            this.adicionarProgramaButton.UseVisualStyleBackColor = true;
            this.adicionarProgramaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MicroOndasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(543, 371);
            this.Controls.Add(this.adicionarProgramaButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.feijaoButton);
            this.Controls.Add(this.nuggetsButton);
            this.Controls.Add(this.boiButton);
            this.Controls.Add(this.leiteButton);
            this.Controls.Add(this.pipocaButton);
            this.Controls.Add(this.potenciaTextBox);
            this.Controls.Add(this.potenciaLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pausarButton);
            this.Controls.Add(this.iniciarButton);
            this.Name = "MicroOndasView";
            this.Text = "Micro-Ondas";
            this.panel1.ResumeLayout(false);
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
        private Button pipocaButton;
        private Button leiteButton;
        private Button boiButton;
        private Button nuggetsButton;
        private Button feijaoButton;
        private ListView listView1;

        partial void InitializeOtherComponents()
        {
            this.components = new System.ComponentModel.Container();
            this.RelogioLabel = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.DisplayInfo = new System.Windows.Forms.TextBox();

            // 
            // relogioLabel
            // 
            this.RelogioLabel.AutoSize = true;
            this.RelogioLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RelogioLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RelogioLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RelogioLabel.Location = new System.Drawing.Point(343, 6);
            this.RelogioLabel.Name = "relogioLabel";
            this.RelogioLabel.Size = new System.Drawing.Size(174, 51);
            this.RelogioLabel.TabIndex = 18;
            this.RelogioLabel.Text = "00:00:00";
            // 
            // timer1
            // 
            this.Timer.Interval = 1000;
            // 
            // displayInfo
            // 
            this.DisplayInfo.Location = new System.Drawing.Point(3, 6);
            this.DisplayInfo.Multiline = true;
            this.DisplayInfo.Name = "displayInfo";
            this.DisplayInfo.ReadOnly = true;
            this.DisplayInfo.Size = new System.Drawing.Size(323, 292);
            this.DisplayInfo.TabIndex = 19;

            //MicroOndasView
            this.Controls.Add(this.DisplayInfo);
            this.Controls.Add(this.RelogioLabel);
        }

        private Button adicionarProgramaButton;
    }

}