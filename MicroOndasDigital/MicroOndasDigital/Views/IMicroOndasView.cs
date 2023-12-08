
namespace MicroOndasDigital.Views
{
    public interface IMicroOndasView
    {
        string TempoValue { get; set; }
        string PotenciaValue { get; set; }
        bool Pausar { get; set; }
        bool Limpar { get; set; }

        //Eventos
        event EventHandler InicializaoRapidaEvent;
        event EventHandler PausarAquecimentoEvent;
        event EventHandler<string> SelecionarProgramaEvent;
    }
}
