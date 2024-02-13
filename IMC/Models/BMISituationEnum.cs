
using System.ComponentModel;

namespace IMC.Models;

public enum BMISituationEnum
{
    [Description("Muito abaixo do peso")]
    MuitoAbaixoDoPeso,

    [Description("Abaixo do peso")]
    AbaixoDoPeso,

    [Description("Peso normal")]
    PesoNormal,

    [Description("Acima do peso")]
    AcimaDoPeso,

    [Description("Obesidade I")]
    ObesidadeI,

    [Description("Obesidade II (severa)")]
    ObesidadeII,

    [Description("Obesidade III (mórbida)")]
    ObesidadeIII
}
