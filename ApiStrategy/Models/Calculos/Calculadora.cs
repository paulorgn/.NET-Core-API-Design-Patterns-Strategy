using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiStrategy.Models.Calculos
{
    public class Calculadora
    {
        private ICalculos _calculos;

        public Calculadora(ICalculos calculos)
        {
            this._calculos = calculos;
        }

        public decimal CalcularOperacaoBasica(OperacaoBasicaDTO operacao)
        {
            if (operacao == null)
            {
                throw new ArgumentException("Parâmetros inválidos");
            }

            var retorno = this._calculos.OperacaoBasica(operacao);

            return retorno;
        }
    }
}
