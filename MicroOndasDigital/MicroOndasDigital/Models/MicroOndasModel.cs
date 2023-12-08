using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MicroOndasDigital.Models
{
    public class MicroOndasModel
    {
        //Variáveis
        private int tempo;
        private int potencia;
        private bool pausa;

        //Propriedades
        [DisplayName("Tempo")]
        //[Range(1, 120, ErrorMessage = "O tempo do Micro-ondas deve estar entre 1 e 120 segundos")]
        public int Tempo { get => tempo; set => tempo = value; }

        [DisplayName("Potencia")]
        [DefaultValue(10)]
        //[Range(1,10,ErrorMessage = "A potência do Micro-ondas deve estar entre 1 e 10")]
        public int Potencia { get => potencia; set => potencia = value; }

        [DisplayName("Pausar")]
        [DefaultValue(false)]
        public bool Pausar { get => pausa; set => pausa = value; }

    }
}
