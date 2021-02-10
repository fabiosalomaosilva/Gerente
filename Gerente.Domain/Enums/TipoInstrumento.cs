﻿using System.ComponentModel;

namespace Gerente.Domain.Enums
{
    public enum TipoInstrumento
    {
        [Description("Contrato")]
        Contrato = 1,

        [Description("Ata de Registro de Preços")]
        AtaSrp = 2,
    }
}