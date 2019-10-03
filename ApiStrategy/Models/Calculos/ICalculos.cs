using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiStrategy.Models.Calculos
{
    public interface ICalculos
    {
        decimal OperacaoBasica(OperacaoBasicaDTO parametros);
    }
}
