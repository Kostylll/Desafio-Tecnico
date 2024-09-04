using DesafioTécnicoApi.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTécnicoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NumberController : Controller
    {
        private readonly INumberService _numberService;

        public NumberController(INumberService numberService)
        {
            _numberService = numberService;
        }

        [HttpPost]
        public async Task<IActionResult>  GetNumber (int numero)
        {
            var numerosDivisores = await _numberService.ObterDivisores(numero);
            var numerosPrimos = await _numberService.ObterDivisoresPrimos(numerosDivisores);

            return Json(new
            {
                Numero_de_entrada = numero,
                Numeros_divisores = numerosDivisores,
                divisores_primos = numerosPrimos
            });
        }
    }
}
