using MicroOndasDigital.Models;
using MicroOndasDigital.Presenters.Common;
using MicroOndasDigital.Views;
using Newtonsoft.Json;

namespace MicroOndasDigital.Presenters
{
    public class MicroOndasPresenter
    {
        private readonly List<MicroOndasModel>? programasPre;

        IMicroOndasView View { get; set; }
        IAdicionarProgramaView AddView { get; set; }

        public MicroOndasPresenter(IMicroOndasView view, IAdicionarProgramaView addView)
        {
            this.AddView = addView;
            this.AddView.AdicionarProgramaEvent += AdicionarPrograma;

            this.View = view;
            this.View.InicializaoRapidaEvent += IniciarAquecimento;
            this.View.PausarAquecimentoEvent += PausarAquecimento;
            this.View.SelecionarProgramaEvent += SelecionarPrograma;
            this.View.Timer.Tick += new System.EventHandler(Timer_Tick);

            programasPre = new List<MicroOndasModel>
            {
                new MicroOndasModel(
                    "Pipoca",
                    "Pipoca",
                    210,
                    7,
                    "!",
                    "Observar o barulho de estouros do milho, " +
                    "caso houver um intervalo de mais de 10 segundos entre um estouro e outro, interrompa o aquecimento",
                    false
                ),
                new MicroOndasModel(
                    "Leite",
                    "Leite",
                    300,
                    5,
                    "@",
                    "Cuidado com aquecimento de líquidos, " +
                    "o choque térmico aliado ao movimento do recipiente pode causar fervura imediata causando risco de queimaduras",
                    false
                ),
                new MicroOndasModel(
                    "Carnes de boi",
                    "Carne em pedaço ou fatias",
                    840,
                    4,
                    "#",
                    "Interrompa o processo na metade e vire " +
                    "o conteúdo com a parte de baixo para cima para o descongelamento uniforme",
                    false
                ),
                new MicroOndasModel(
                    "Frango",
                    "Frango (qualquer corte)",
                    480,
                    7,
                    "$",
                    "Interrompa o processo na metade e vire " +
                    "o conteúdo com a parte de baixo para cima para o descongelamento uniforme",
                    false
                ),
                new MicroOndasModel(
                    "Feijão",
                    "Feijão congelado",
                    480,
                    9,
                    "%",
                    "Deixe o recipiente destampado e em casos de plástico, " +
                    "cuidado ao retirar o recipiente pois o mesmo pode perder resistência em altas temperaturas",
                    false
                )
            };
        }

        private void AdicionarPrograma(object? sender, EventArgs e)
        {
            MicroOndasModel novoPrograma = new MicroOndasModel(AddView.Nome,
                AddView.Alimento,
                int.Parse(AddView.TempoValue),
                int.Parse(AddView.PotenciaValue),
                AddView.StringAquecimento,
                AddView.Instrucoes,
                true);

            programasPre.Add(novoPrograma);

            string json = JsonConvert.SerializeObject(programasPre);
            string diretorio = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(diretorio, "..\\..\\..\\Archive");
            File.WriteAllText(path, json);

            MessageBox.Show($"Programa adicionado com sucesso");
        }

        //Lógica relacionada ao aquecimento
        private void IniciarAquecimento(object? sender, EventArgs e)
        {
            //Inicio Rápido
            if (this.View.TempoValue == "0")
                View.TempoValue = "30";

            //Conversão inicial da string tempo em int segundos 
            if (View.Incrementar == false)
                View.Segundos = int.Parse(View.TempoValue);

            //Se estiver dentro do intervalo permitido e não for um programa pre-definido
            if (View.Segundos is >= 1 and <= 120 && View.Predefinido == false)
            {
                /*Apenas Icrementar caso o programa não esteje pausado e o valor em segundos
                for menor ou igual a 90 para não estourar o valor limite de 2min*/
                if (View.Incrementar && View.Pausar != true && View.Segundos <= 90)
                    View.Segundos += 30;

                //Iniciar o temporizador do micro-ondas
                View.RelogioLabel.Text = TempoFormatado(View.Segundos);
                View.Timer.Start();
            }
            //Caso seja um programa pre-definido
            else if (View.Predefinido == true)
            {
                //Iniciar o temporizador do micro-ondas
                View.RelogioLabel.Text = TempoFormatado(View.Segundos);
                View.Timer.Start();
            }
            else
            {
                //Caso o usuário queira incrementar o tempo além do permitido
                MessageBox.Show($"Valor fora do intervalo permitido, mínimo 1s - máximo 120s");

                if (View.Segundos <= 200)
                    View.Timer.Start();
            }

            View.Incrementar = true;
            View.Pausar = false;
            View.Limpar = true;
        }

        //Decrementando o tempo do timer
        private void Timer_Tick(object? sender, EventArgs e)
        {
            int potencia = int.Parse(View.PotenciaValue);
            string stringAquecimento = "";

            /*Concatenando string informativa para dar ideia de processamento*/
            for (int i = 0; i < potencia; i++)
                stringAquecimento += View.StringAquecimento;

            if (View.Segundos > 0)
            {
                //Decrementando Segundos
                View.Segundos--;
                View.RelogioLabel.Text = TempoFormatado(View.Segundos);

                //String informativa do processo de aquecimento
                View.DisplayInfo.Text += stringAquecimento + " ";
            }
            else
            {
                View.Timer.Stop();
                LimparDados();
                MessageBox.Show("Aquecimento concluído");
            }
        }

        //Sobrecarga do método TempoFormatado
        private static string TempoFormatado(int segundos)
        {
            TimeSpan tempo = TimeSpan.FromSeconds(segundos);
            return tempo.ToString();
        }

        private void LimparDados()
        {
            //Restaurando dados a valores iniciais
            View.DisplayInfo.Text = "";
            View.RelogioLabel.Text = TempoFormatado(0);
            View.TempoValue = "0";
            View.Lock = false;
            View.PotenciaValue = "10";
            View.Segundos = 0;
            View.Incrementar = false;
            View.Predefinido = false;
        }


        private void PausarAquecimento(object? sender, EventArgs e)
        {
            //Setar Pausar como true caso esse evento seja invocado
            View.Pausar = true;
            View.Limpar = Toggle(View.Limpar);

            //Pausar timer
            View.Timer.Stop();

            //Caso o botão Pausar for precionado duas vezes
            if (View.Limpar == true)
            {
                LimparDados();
            }
        }

        //Trocando valores booleanos
        private static bool Toggle(bool value)
        {
            value = !value;
            return value;
        }

        private void SelecionarPrograma(object? sender, EventArgs e)
        {
            switch (View.StringAquecimento)
            {
                case "!":
                    if(!View.Predefinido)
                        ProgramasSettingAndDisplayInfo(0);
      
                    break;

                case "@":
                    if (!View.Predefinido)
                        ProgramasSettingAndDisplayInfo(1);

                    break;

                case "#":
                    if (!View.Predefinido)
                        ProgramasSettingAndDisplayInfo(2);
                    
                    break;

                case "$":
                    if (!View.Predefinido)
                        ProgramasSettingAndDisplayInfo(3);
                    
                    break;

                case "%":
                    if (!View.Predefinido)
                        ProgramasSettingAndDisplayInfo(4);
                   
                    break;
            }
        }

        private void ProgramasSettingAndDisplayInfo(int i)
        {
            View.Nome = programasPre[i].Nome;
            View.Alimento = programasPre[i].Alimento;
            View.Instrucoes = programasPre[i].Instrucoes;
            View.TempoValue = programasPre[i].Tempo.ToString();
            View.PotenciaValue = programasPre[i].Potencia.ToString();
            View.Predefinido = true;
            View.Lock = true;
            View.DisplayInfo.Text += "Programa: " + View.Nome + "\r\n";
            View.DisplayInfo.Text += "Alimento: " + View.Alimento + "\r\n";
            View.DisplayInfo.Text += "Instruções: " + View.Instrucoes + "\r\n";
        }


        //Usando validação para DataAnnotation do Model
        /*private static bool ValidateData(object obj)
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
        }*/

    }
}
