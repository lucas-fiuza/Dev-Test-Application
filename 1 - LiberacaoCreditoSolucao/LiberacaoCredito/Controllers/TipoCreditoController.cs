using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LiberacaoCredito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoCreditoController : ControllerBase
    {
        [HttpGet]
        [Route("/ListaCredito")]
        public IActionResult Get()
        {  
            try
            {
                List<object> item = new List<object>();

                item.Add(new { value = "Consignado", viewValue = "Consignado" });
                item.Add(new { value = "Direto", viewValue = "Direto" });
                item.Add(new { value = "Pessoa_Fisica", viewValue = "Pessoa Física" });
                item.Add(new { value = "Pessoa_Juridica", viewValue = "Pessoa Jurídica" });
                item.Add(new { value = "Imobiliario", viewValue = "Imobiliário" });


                return Ok(item);
            }
            catch (Exception ex)
            {

                return BadRequest(new { erro = ex.Message});
            }
        }
    }
}
