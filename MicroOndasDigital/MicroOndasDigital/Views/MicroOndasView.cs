using MicroOndasDigital.Views;

namespace MicroOndasDigital
{
    public partial class MicroOndasView : Form, IMicroOndasView
    {
        //private string Temporizador;
        private int Segundos;
        private bool Incrementar;

        public event EventHandler? InicializaoRapidaEvent;
        public event EventHandler? PausarAquecimentoEvent;
        public event EventHandler<string>? SelecionarProgramaEvent;

        public string TempoValue { get; set; }
        public string PotenciaValue { get => potenciaTextBox.Text; set => potenciaTextBox.Text = value; }
        public string Display { get => displayInfo.Text; set => displayInfo.Text = value; }
        public bool Pausar { get; set; }
        public bool Limpar { get; set; }

        public MicroOndasView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            //Valor default para pot�ncia
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
            //Evento click do bot�o iniciar
            iniciarButton.Click += delegate { 
                InicializaoRapidaEvent?.Invoke(this, EventArgs.Empty);

                if(Incrementar == false)
                    Segundos = int.Parse(TempoValue);

                if (Segundos is >= 1 and <= 120)
                {
                    if (Incrementar && Pausar != true && Segundos <= 90)
                        Segundos += 30;

                    //Iniciar o temporizador do micro-ondas
                    relogioLabel.Text = TempoFormatado(Segundos);
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show($"Valor fora do intervalo permitido, m�nimo 1s - m�ximo 120s");

                    if (Segundos <= 200)
                        timer1.Start();
                }

                Incrementar = true;
                Pausar = false;
                Limpar = true;
            };

            //Evento Click do bot�o pausar
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
                pontos += ".";

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
                MessageBox.Show("Aquecimento conclu�do");
            }
        }

        private void LimparDados()
        {
            displayInfo.Text = "";
            relogioLabel.Text = TempoFormatado(0);
            TempoValue = "0";
            PotenciaValue = "10";
            Segundos = 0;
            Incrementar = false;
        }

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

        //Sobrecarga do m�todo TempoFormatado
        private static string TempoFormatado(int segundos)
        {
            TimeSpan tempo = TimeSpan.FromSeconds(segundos);
            return tempo.ToString();
        }
    }
}