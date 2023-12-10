namespace MicroOndasDigital.Views
{
    public interface IAdicionarProgramaView
    {
        string Nome { get; set; }
        string Alimento { get; set; }
        string Instrucoes { get; set; }
        string TempoValue { get; set; }
        string PotenciaValue { get; set; }
        string StringAquecimento { get; set; }

        event EventHandler AdicionarProgramaEvent;

    }
}
