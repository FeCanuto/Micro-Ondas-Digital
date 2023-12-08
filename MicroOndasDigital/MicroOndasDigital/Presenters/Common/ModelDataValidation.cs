using System.ComponentModel.DataAnnotations;


namespace MicroOndasDigital.Presenters.Common
{
    public class ModelDataValidation
    {
        public static IEnumerable<ValidationResult> ValidationErrors(object obj)
        {
            var resultado = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultado, true);
            return resultado;
        }
    }
}
