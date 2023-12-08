namespace MicroOndasDigital.Models
{
    public class ProgramasModel : EventArgs
    {
        public string? Nome { get; set; }
        public string? Alimento { get; set; }
        public int Tempo { get; set; }
        public int Potencia { get; set; }
        public string? AquecimentoString { get; set; }
        public string? Instrucoes { get; set; }

        public ProgramasModel(string nome, string alimento, int tempo, int potencia, string aquecimentoString, string instrucoes)
        {
            Nome = nome;
            Alimento = alimento;
            Tempo = tempo;
            Potencia = potencia;
            AquecimentoString = aquecimentoString;
            Instrucoes = instrucoes;
        }
    }
}
