using MicroOndasDigital.Models;
using MicroOndasDigital.Presenters.Common;
using MicroOndasDigital.Views;

namespace MicroOndasDigital.Presenters
{
    public class MicroOndasPresenter
    {
        private List<ProgramasModel> programasPre;

        IMicroOndasView View { get; set; }
        MicroOndasModel Micro = new();

        public MicroOndasPresenter(IMicroOndasView view)
        {
            this.View = view;
            this.View.InicializaoRapidaEvent += IniciarAquecimento;
            this.View.PausarAquecimentoEvent += PausarAquecimento;
            this.View.SelecionarProgramaEvent += SelecionarPrograma;

            programasPre = new List<ProgramasModel>
            {
            new ProgramasModel("Pipoca", "Pipoca", 210, 7, "!", $"Observar o barulho de estouros do milho," +
                $" caso houver um intervalo de mais de 10 segundos entre um estouro e outro, interrompa o aquecimento"),
            new ProgramasModel("Leite", "Leite", 300, 5, "@", $"Cuidado com aquecimento de líquidos, " +
                $"o choque térmico aliado ao movimento do recipiente pode causar fervura imediata causando risco de queimaduras"),
            new ProgramasModel("Carnes de boi", "Carne em pedaço ou fatias", 840, 4, "#", $" Interrompa o processo na metade e vire" +
                $" o conteúdo com a parte de baixo para cima para o descongelamento uniforme"),
            new ProgramasModel("Frango", "Frango (qualquer corte)", 480, 7, "$", $" Interrompa o processo na metade e vire" +
                $" o conteúdo com a parte de baixo para cima para o descongelamento uniforme"),
            new ProgramasModel("Feijão", "Feijão congelado", 480, 9, "%", $"  Deixe o recipiente destampado e em casos de plástico, " +
                $"cuidado ao retirar o recipiente pois o mesmo pode perder resistência em altas temperaturas")
            };
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

        private void SelecionarPrograma(object? sender, EventArgs e)
        {
            switch (View.StringAquecimento)
            {
                case "!":
                    View.Nome = programasPre[0].Nome;
                    View.Alimento = programasPre[0].Alimento;
                    View.Instrucoes = programasPre[0].Instrucoes;
                    View.TempoValue = programasPre[0].Tempo.ToString();
                    View.PotenciaValue = programasPre[0].Potencia.ToString();
                    break;
                case "@":
                    View.Nome = programasPre[1].Nome;
                    View.Alimento = programasPre[1].Alimento;
                    View.Instrucoes = programasPre[1].Instrucoes;
                    View.TempoValue = programasPre[1].Tempo.ToString();
                    View.PotenciaValue = programasPre[1].Potencia.ToString();
                    break;
                case "#":
                    View.Nome = programasPre[2].Nome;
                    View.Alimento = programasPre[2].Alimento;
                    View.Instrucoes = programasPre[2].Instrucoes;
                    View.TempoValue = programasPre[2].Tempo.ToString();
                    View.PotenciaValue = programasPre[2].Potencia.ToString();
                    break;
                case "$":
                    View.Nome = programasPre[3].Nome;
                    View.Alimento = programasPre[3].Alimento;
                    View.Instrucoes = programasPre[3].Instrucoes;
                    View.TempoValue = programasPre[3].Tempo.ToString();
                    View.PotenciaValue = programasPre[3].Potencia.ToString();
                    break;
                case "%":
                    View.Nome = programasPre[4].Nome;
                    View.Alimento = programasPre[4].Alimento;
                    View.Instrucoes = programasPre[4].Instrucoes;
                    View.TempoValue = programasPre[4].Tempo.ToString();
                    View.PotenciaValue = programasPre[4].Potencia.ToString();
                    break;
            }
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
