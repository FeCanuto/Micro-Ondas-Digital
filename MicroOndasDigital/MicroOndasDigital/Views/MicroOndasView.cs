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
        public bool Pausar { get; set; }
        public bool Limpar { get; set; }



        public MicroOndasView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            //Valor default para potência
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
                    MessageBox.Show("Valor fora do intervalo permitido, mínimo 1s - máximo 120s");

                    if (Segundos <= 200)
                        timer1.Start();
                }

                Incrementar = true;
                Pausar = false;
            };

            //Evento Click do botão pausar
            pausarButton.Click += delegate { 
                PausarAquecimentoEvent?.Invoke(this, EventArgs.Empty);

                timer1.Stop();

                if(Limpar == true)
                {
                    relogioLabel.Text = TempoFormatado(0);
                    Segundos = 0;
                }
            };
        }

        //Decrementando o tempo do timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Segundos > 0)
            {
                Segundos--;
                relogioLabel.Text = TempoFormatado(Segundos);
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Aquecimento concluído");
            }
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

        //Sobrecarga do método TempoFormatado
        private static string TempoFormatado(int segundos)
        {
            TimeSpan tempo = TimeSpan.FromSeconds(segundos);
            return tempo.ToString();
        }
    }
}