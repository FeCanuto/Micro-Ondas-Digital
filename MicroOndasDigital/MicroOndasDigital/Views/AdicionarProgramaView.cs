namespace MicroOndasDigital.Views
{
    public partial class AdicionarProgramaView : Form, IAdicionarProgramaView
    {

        public AdicionarProgramaView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public string Nome { get => nomeTextBox.Text; set => nomeTextBox.Text = value; }
        public string Alimento { get => alimentoTextBox.Text; set => alimentoTextBox.Text = value; }
        public string Instrucoes { get => descricaoTextBox.Text; set => descricaoTextBox.Text = value; }
        public string TempoValue { get => tempoTextBox.Text; set => tempoTextBox.Text = value; }
        public string PotenciaValue { get => potenciaTextBox.Text; set => potenciaTextBox.Text = value; }
        public string StringAquecimento { get => stringTextBox.Text; set => stringTextBox.Text = value; }

        public event EventHandler? AdicionarProgramaEvent;

        private void AssociateAndRaiseViewEvents()
        {
            adicionarProgramButton.Click += delegate { AdicionarProgramaEvent?.Invoke(this, EventArgs.Empty); };
        }
                        
        private void cancelarButton_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void potenciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tempoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
