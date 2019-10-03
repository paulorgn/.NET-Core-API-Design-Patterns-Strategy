using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiStrategy.Models.Calculos;
using ApiStrategy.Models.Operacoes;

namespace ApiStrategy.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculosController : ControllerBase
    {
        // GET: api/Calculos
        [HttpGet]
        public IEnumerable<string> Instrucoes()
        {
            return new string[] { "Envie um post para api/Calculos/Divisao com 2 parâmetros (numero1 e numero2) json no body" };
        }

        [HttpPost]
        public IEnumerable<string> Divisao([FromBody] OperacaoBasicaDTO parametros)
        {
            ICalculos calculos = new Divisao();
            var calculadora = new Calculadora(calculos);
            var retorno = calculadora.CalcularOperacaoBasica(parametros);
            return new string[] { retorno.ToString() };
        }

        [HttpPost]
        public IEnumerable<string> Soma([FromBody] OperacaoBasicaDTO parametros)
        {
            ICalculos calculos = new Soma();
            var calculadora = new Calculadora(calculos);
            var retorno = calculadora.CalcularOperacaoBasica(parametros);
            return new string[] { retorno.ToString() };
        }

        [HttpPost]
        public IEnumerable<string> Multiplicacao([FromBody] OperacaoBasicaDTO parametros)
        {
            ICalculos calculos = new Multiplicacao();
            var calculadora = new Calculadora(calculos);
            var retorno = calculadora.CalcularOperacaoBasica(parametros);
            return new string[] { retorno.ToString() };
        }

        [HttpPost]
        public IEnumerable<string> Subtracao([FromBody] OperacaoBasicaDTO parametros)
        {
            ICalculos calculos = new Subtracao();
            var calculadora = new Calculadora(calculos);
            var retorno = calculadora.CalcularOperacaoBasica(parametros);
            return new string[] { retorno.ToString() };
        }

        // GET: api/Calculos/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Calculos
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Calculos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
