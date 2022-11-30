using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using LiberacaoCredito.Entidades;
using LiberacaoCredito.IRegra;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LiberacaoCredito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiberacaoCreditoController : ControllerBase
    {
        private readonly ILiberacaoRegra _liberacao;

        public LiberacaoCreditoController(ILiberacaoRegra liberacao)
        {
            _liberacao = liberacao;
        }

        [HttpPost]
        [Route("/ConsultaCredito")]
        ///<summary>
        ///Rotina responsável por fazer a consulta de crédito.
        /// </summary>
        public IActionResult Post([FromBody]RequisicaoLiberacao item)
        {
            try
            {
                if (!ModelState.IsValid)
                    throw new Exception("Erro");

                var resultado = _liberacao.VerificaLiberacaoCredito(item);

                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return BadRequest(new { erro = ex.Message });
            }
        }
    }
}
