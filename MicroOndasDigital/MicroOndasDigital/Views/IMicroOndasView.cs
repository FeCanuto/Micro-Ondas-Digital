
namespace MicroOndasDigital.Views
{
    public interface IMicroOndasView
    {
        string Nome { get; set; }
        string Alimento { get; set; }
        string Instrucoes { get; set; }
        string TempoValue { get; set; }
        string PotenciaValue { get; set; }
        string StringAquecimento { get; set; }       
        bool Pausar { get; set; }
        bool Limpar { get; set; }
        int Segundos { get; set; }
        bool Incrementar { get; set; }
        bool Predefinido { get; set; }
        bool Lock { get; set; }

        System.Windows.Forms.Timer Timer { get; set; }
        Label RelogioLabel { get; set; }
        TextBox DisplayInfo { get; set; }

        //Eventos
        event EventHandler InicializaoRapidaEvent;
        event EventHandler PausarAquecimentoEvent;
        event EventHandler SelecionarProgramaEvent;
    }
}
