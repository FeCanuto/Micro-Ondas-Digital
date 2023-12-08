using MicroOndasDigital.Models;
using MicroOndasDigital.Presenters.Common;
using MicroOndasDigital.Views;

namespace MicroOndasDigital.Presenters
{
    public class MicroOndasPresenter
    {
        IMicroOndasView View { get; set; }
        MicroOndasModel Micro = new();


        public MicroOndasPresenter(IMicroOndasView view)
        {
            this.View = view;
            this.View.InicializaoRapidaEvent += IniciarAquecimento;
            this.View.PausarAquecimentoEvent += PausarAquecimento;
            this.View.SelecionarProgramaEvent += SelecionarPrograma;
        }


        //Lógica relacionada ao aquecimento
        private void IniciarAquecimento(object? sender, EventArgs e)
        {
            //Inicio Rápido
            if (this.View.TempoValue == "0")
            {
                Micro.Tempo = 30;
                Micro.Potencia = int.Parse(this.View.PotenciaValue);
                if (ValidateData(Micro))
                    return;

                View.TempoValue = Micro.Tempo.ToString();
                View.PotenciaValue = Micro.Potencia.ToString();
            }

            Micro.Tempo = int.Parse(this.View.TempoValue);
            Micro.Potencia = int.Parse(this.View.PotenciaValue);
            if (ValidateData(Micro))
                return;

            View.TempoValue = Micro.Tempo.ToString();
            View.PotenciaValue = Micro.Potencia.ToString();
        }

        private void PausarAquecimento(object? sender, EventArgs e)
        {
            View.Pausar = true;
            View.Limpar = Toggle(View.Limpar);
        }

        private void SelecionarPrograma(object? sender, string e)
        {
            throw new NotImplementedException();
        }

        //Trocando valores booleanos
        private static bool Toggle(bool value)
        {
            value = !value;
            return value;
        }

        //Usando validação para DataAnnotation do Model
        private static bool ValidateData(object obj)
        {
            var erros = ModelDataValidation.ValidationErrors(obj);
            foreach (var error in erros)
            {
                MessageBox.Show((error.ErrorMessage));
            }

            if (erros.Any())
            {
                return true;
            }

            return false;
        }

    }
}
