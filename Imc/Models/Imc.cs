using System.ComponentModel.DataAnnotations;
using Imc.Models.Enums;

namespace Imc.Models
{
    public class Imc
    {
        [Required(ErrorMessage = "Informe um valor de altura ex: 1,75")]
        [Range(1, 10, ErrorMessage = "Informe um valor valido")]
        public double? Altura { get; set; }

        [Required(ErrorMessage = "Peso deve ser informado")]
        [Range(1, 350, ErrorMessage = "Informe um valor de peso")]
        public int? Peso { get; set; }

        public bool Idoso { get; set; }

        public ESexo Sexo { get; set; } = 0;

        private DateTime Adicionado = DateTime.UtcNow;
        public string Inserido {
            get {
                TimeSpan diferenca = DateTime.UtcNow - Adicionado;
                if (diferenca.Minutes < 1)
                    return $"{diferenca.Seconds}s atrás";

                if (diferenca.TotalHours < 1)
                    return $"{diferenca.Minutes}m atrás";

                if (diferenca.TotalHours >= 1)
                    return $"{diferenca.Hours}h atrás";

                return diferenca.ToString("dd/MM/yyyy");
            }
        }

        public ImcResult Calcular()
        {
            var result = Math.Round(Convert.ToDouble((Peso / (Altura * Altura))),1);
            return GetResultImc(result);
        }

        private ImcResult GetResultImc(double imc)
        {
            const string Cuidado = "Cuidado você está {0}, dê uma atenção para sua saúde";
            const string Parabens = "Você está {0}, continue mantendo este estilo!";

            var ResultImc = new ImcResult();

            switch (imc)
            {
                case var value when value < 18.5:
                    ResultImc.Title = EImcStatus.Magreza.ToString();
                    ResultImc.Body = string.Format(Cuidado, ResultImc.Title);
                    ResultImc.Status = EStatusImc.Ruim;
                    break;

                case var value when value >= 18.5 && value < 25:
                    ResultImc.Title = EImcStatus.Normal.ToString();
                    ResultImc.Body = string.Format(Parabens, ResultImc.Title);
                    ResultImc.Status = EStatusImc.Bom;
                    break;

                case var value when value >= 25 && value < 30:
                    ResultImc.Title = EImcStatus.Sobrepeso.ToString();
                    ResultImc.Body = string.Format(Cuidado, ResultImc.Title);
                    ResultImc.Status = EStatusImc.Ruim;
                    break;

                case var value when value >= 30 && value < 40:
                    ResultImc.Title = EImcStatus.Obesidade.ToString();
                    ResultImc.Body = string.Format(Cuidado, ResultImc.Title);
                    ResultImc.Status = EStatusImc.Ruim;
                    break;

                default:
                    ResultImc.Title = "Obesidade Grave";
                    ResultImc.Body = string.Format(Cuidado, ResultImc.Title);
                    ResultImc.Status = EStatusImc.Ruim;
                    break;
            }

            return ResultImc;
        }

    }
}
