using MicroOndasDigital.Views;

namespace MicroOndasDigital
{
    public partial class MicroOndasView : Form, IMicroOndasView
    {       
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
        public int Segundos { get; set; }
        public bool Incrementar { get; set; }
        public bool Predefinido { get; set; }
        public bool Lock { get; set; }

        public System.Windows.Forms.Timer Timer { get; set; }
        public Label RelogioLabel { get; set; }
        public TextBox DisplayInfo { get; set; }
        partial void InitializeOtherComponents();

        public MicroOndasView()
        {
            InitializeComponent();
            InitializeOtherComponents();
            AssociateAndRaiseViewEvents();

            //Valores default
            StringAquecimento = ".";
            TempoValue = "0";
            potenciaTextBox.Text = "10";
        }

        private void buttonNumber0_Click(object sender, EventArgs e)
        {
            TempoValue += int.Parse(buttonNumber0.Text);
            RelogioLabel.Text = TempoFormatado(TempoValue);
        }

        private void buttonNumber1_Click(object sender, EventArgs e)
        {
            TempoValue += int.Parse(buttonNumber1.Text);
            RelogioLabel.Text = TempoFormatado(TempoValue);
        }

        private void buttonNumber2_Click(object sender, EventArgs e)
        {
            TempoValue += int.Parse(buttonNumber2.Text);
            RelogioLabel.Text = TempoFormatado(TempoValue);
        }

        private void buttonNumber3_Click(object sender, EventArgs e)
        {
            TempoValue += int.Parse(buttonNumber3.Text);
            RelogioLabel.Text = TempoFormatado(TempoValue);
        }

        private void buttonNumber4_Click(object sender, EventArgs e)
        {
            TempoValue += int.Parse(buttonNumber4.Text);
            RelogioLabel.Text = TempoFormatado(TempoValue);
        }

        private void buttonNumber5_Click(object sender, EventArgs e)
        {
            TempoValue += int.Parse(buttonNumber5.Text);
            RelogioLabel.Text = TempoFormatado(TempoValue);
        }

        private void buttonNumber6_Click(object sender, EventArgs e)
        {
            TempoValue += int.Parse(buttonNumber6.Text);
            RelogioLabel.Text = TempoFormatado(TempoValue);
        }

        private void buttonNumber7_Click(object sender, EventArgs e)
        {
            TempoValue += int.Parse(buttonNumber7.Text);
            RelogioLabel.Text = TempoFormatado(TempoValue);
        }

        private void buttonNumber8_Click(object sender, EventArgs e)
        {
            TempoValue += int.Parse(buttonNumber8.Text);
            RelogioLabel.Text = TempoFormatado(TempoValue);
        }

        private void buttonNumber9_Click(object sender, EventArgs e)
        {
            TempoValue += int.Parse(buttonNumber9.Text);
            RelogioLabel.Text = TempoFormatado(TempoValue);
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
            iniciarButton.Click += delegate { InicializaoRapidaEvent?.Invoke(this, EventArgs.Empty);};

            //Evento Click do botão pausar
            pausarButton.Click += delegate { PausarAquecimentoEvent?.Invoke(this, EventArgs.Empty);};
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

        private void pipocaButton_Click(object sender, EventArgs e)
        {
            StringAquecimento = "!";
            SelecionarProgramaEvent?.Invoke(this, EventArgs.Empty);
        }

        private void leiteButton_Click(object sender, EventArgs e)
        {
            StringAquecimento = "@";
            SelecionarProgramaEvent?.Invoke(this, EventArgs.Empty);
        }

        private void feijaoButton_Click(object sender, EventArgs e)
        {
            StringAquecimento = "%";
            SelecionarProgramaEvent?.Invoke(this, EventArgs.Empty);
        }

        private void boiButton_Click(object sender, EventArgs e)
        {
            StringAquecimento = "#";
            SelecionarProgramaEvent?.Invoke(this, EventArgs.Empty);
        }

        private void nuggetsButton_Click(object sender, EventArgs e)
        {
            StringAquecimento = "$";
            SelecionarProgramaEvent?.Invoke(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}