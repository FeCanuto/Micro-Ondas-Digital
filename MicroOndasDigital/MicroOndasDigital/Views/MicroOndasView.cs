using MicroOndasDigital.Views;

namespace MicroOndasDigital
{
    public partial class MicroOndasView : Form, IMicroOndasView
    {
        private int Segundos;
        private bool Incrementar;
        private bool Predefinido;


        public event EventHandler? InicializaoRapidaEvent;
        public event EventHandler? PausarAquecimentoEvent;
        public event EventHandler? SelecionarProgramaEvent;

        public string Nome { get; set; } = string.Empty;
        public string Alimento { get; set; } = string.Empty;
        public string Instrucoes { get; set; } = string.Empty;
        public string TempoValue { get; set; } = string.Empty;
        public string PotenciaValue { get => potenciaTextBox.Text; set => potenciaTextBox.Text = value; }
        public string StringAquecimento { get; set; } = string.Empty;
        public bool Pausar { get; set; }
        public bool Limpar { get; set; }

        public MicroOndasView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            //Valores default
            StringAquecimento = ".";
            relogioLabel.Text = "00:00:00";
            TempoValue = "0";
            potenciaTextBox.Text = "10";
        }

        private void buttonNumber0_Click(object sender, EventArgs e)
        {
            TempoValue += int.Parse(buttonNumber0.Text);
            relogioLabel.Text = TempoFormatado(TempoValue);

        }

        private void buttonNumber1_Click(object sender, EventArgs e)
        {
            TempoValue += int.Parse(buttonNumber1.Text);
            relogioLabel.Text = TempoFormatado(TempoValue);
        }

        private void buttonNumber2_Click(object sender, EventArgs e)
        {
            TempoValue += int.Parse(buttonNumber2.Text);
            relogioLabel.Text = TempoFormatado(TempoValue);
        }

        private void buttonNumber3_Click(object sender, EventArgs e)
        {
            TempoValue += int.Parse(buttonNumber3.Text);
            relogioLabel.Text = TempoFormatado(TempoValue);
        }

        private void buttonNumber4_Click(object sender, EventArgs e)
        {
            TempoValue += int.Parse(buttonNumber4.Text);
            relogioLabel.Text = TempoFormatado(TempoValue);
        }

        private void buttonNumber5_Click(object sender, EventArgs e)
        {
            TempoValue += int.Parse(buttonNumber5.Text);
            relogioLabel.Text = TempoFormatado(TempoValue);
        }

        private void buttonNumber6_Click(object sender, EventArgs e)
        {
            TempoValue += int.Parse(buttonNumber6.Text);
            relogioLabel.Text = TempoFormatado(TempoValue);
        }

        private void buttonNumber7_Click(object sender, EventArgs e)
        {
            TempoValue += int.Parse(buttonNumber7.Text);
            relogioLabel.Text = TempoFormatado(TempoValue);
        }

        private void buttonNumber8_Click(object sender, EventArgs e)
        {
            TempoValue += int.Parse(buttonNumber8.Text);
            relogioLabel.Text = TempoFormatado(TempoValue);
        }

        private void buttonNumber9_Click(object sender, EventArgs e)
        {
            TempoValue += int.Parse(buttonNumber9.Text);
            relogioLabel.Text = TempoFormatado(TempoValue);
        }

        //Permitindo apenas digitos
        private void tempoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Permitindo apenas digitos
        private void potenciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Evento click do botão iniciar
            iniciarButton.Click += delegate { 
                InicializaoRapidaEvent?.Invoke(this, EventArgs.Empty);

                //Conversão inicial da string tempo em int segundos 
                if(Incrementar == false)
                    Segundos = int.Parse(TempoValue);

                //Se estiver dentro do intervalo permitido e não for um programa pre-definido
                if (Segundos is >= 1 and <= 120 && Predefinido == false)
                {
                    /*Apenas Icrementar caso o programa não esteje pausado e o valor em segundos
                    for menor ou igual a 90 para não estourar o valor limite de 2min*/
                    if (Incrementar && Pausar != true && Segundos <= 90)
                        Segundos += 30;

                    //Iniciar o temporizador do micro-ondas
                    relogioLabel.Text = TempoFormatado(Segundos);
                    timer1.Start();
                }
                //Caso seja um programa pre-definido
                else if (Predefinido == true)
                {
                    //Iniciar o temporizador do micro-ondas
                    relogioLabel.Text = TempoFormatado(Segundos);
                    timer1.Start();
                }
                else
                {
                    //Caso o usuário queira incrementar o tempo além do permitido
                    MessageBox.Show($"Valor fora do intervalo permitido, mínimo 1s - máximo 120s");

                    if (Segundos <= 200)
                        timer1.Start();
                }

                Incrementar = true;
                Pausar = false;
                Limpar = true;
            };

            //Evento Click do botão pausar
            pausarButton.Click += delegate { 
                PausarAquecimentoEvent?.Invoke(this, EventArgs.Empty);

                timer1.Stop();

                if(Limpar == true)
                {
                    LimparDados();
                }
            };
        }

        //Decrementando o tempo do timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            int potencia = int.Parse(PotenciaValue);
            string pontos = "";

            for (int i = 0; i < potencia; i++)
                pontos += StringAquecimento;

            if (Segundos > 0)
            {
                Segundos--;
                relogioLabel.Text = TempoFormatado(Segundos);

                //String informativa do processo de aquecimento
                displayInfo.Text += pontos + " ";
            }
            else
            {
                timer1.Stop();
                LimparDados();
                MessageBox.Show("Aquecimento concluído");
            }
        }

        private void LimparDados()
        {
            //Restaurando dados a valores iniciais
            displayInfo.Text = "";
            relogioLabel.Text = TempoFormatado(0);
            TempoValue = "0";
            PotenciaValue = "10";
            Segundos = 0;
            Incrementar = false;
            Predefinido = false;
        }

        //Formatando tempo
        private static string TempoFormatado(string segundos)
        {
            TimeSpan tempo;
            int sec = int.Parse(segundos);
            if (sec >= 60 && sec <= 100)
            {
                tempo = TimeSpan.FromMinutes(sec/60.0);
            }
            else
            {
                tempo = TimeSpan.FromSeconds(sec);
            }
            return tempo.ToString();
        }

        //Sobrecarga do método TempoFormatado
        private static string TempoFormatado(int segundos)
        {
            TimeSpan tempo = TimeSpan.FromSeconds(segundos);
            return tempo.ToString();
        }

        private void pipocaButton_Click(object sender, EventArgs e)
        {
            StringAquecimento = "!";
            SelecionarProgramaEvent?.Invoke(this, EventArgs.Empty);
            Predefinido = true;
            ProgramasInfo();
        }

        private void leiteButton_Click(object sender, EventArgs e)
        {
            StringAquecimento = "@";
            SelecionarProgramaEvent?.Invoke(this, EventArgs.Empty);
            Predefinido = true;
            ProgramasInfo();
        }

        private void feijaoButton_Click(object sender, EventArgs e)
        {
            StringAquecimento = "#";
            SelecionarProgramaEvent?.Invoke(this, EventArgs.Empty);
            Predefinido = true;
            ProgramasInfo();
        }

        private void boiButton_Click(object sender, EventArgs e)
        {
            StringAquecimento = "$";
            SelecionarProgramaEvent?.Invoke(this, EventArgs.Empty);
            Predefinido = true;
            ProgramasInfo();
        }

        private void nuggetsButton_Click(object sender, EventArgs e)
        {
            StringAquecimento = "%";
            SelecionarProgramaEvent?.Invoke(this, EventArgs.Empty);
            Predefinido = true;
            ProgramasInfo();
        }

        private void ProgramasInfo()
        {
            displayInfo.Text += "Programa: " + Nome + "\r\n";
            displayInfo.Text += "Alimento: " + Alimento + "\r\n";
            displayInfo.Text += "Instruções: " + Instrucoes + "\r\n";
        }
    }
}