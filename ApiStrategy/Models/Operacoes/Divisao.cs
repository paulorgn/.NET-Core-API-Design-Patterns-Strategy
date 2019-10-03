using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiStrategy.Models.Calculos;

namespace ApiStrategy.Models.Operacoes
{
    public class Divisao : ICalculos
    {
        public decimal OperacaoBasica(OperacaoBasicaDTO parametros) => parametros.numero1 / parametros.numero2;
    }
}
