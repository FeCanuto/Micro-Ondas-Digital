﻿namespace MicroOndasDigital.Models
{
    public class ProgramasModel : EventArgs
    {
        public string? Nome { get; set; }
        public string? Alimento { get; set; }
        public int Tempo { get; set; }
        public int Potencia { get; set; }
        public string? StringAquecimento { get; set; }
        public string? Instrucoes { get; set; }
    }
}
