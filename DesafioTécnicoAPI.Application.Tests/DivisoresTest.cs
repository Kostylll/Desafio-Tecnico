using DesafioTécnicoApi.Application.Interfaces;
using DesafioTécnicoApi.Application.Services;

namespace DesafioTécnicoAPI.Application.Tests
{
    public class DivisoresTest
    {
        private readonly INumberService _service;
        public DivisoresTest()
        {
            _service = new NumberService();
        }

        [Fact]
        public async Task ObterDivisores()
        {
            List<int> divisoresEsperados = new List<int> { 1, 3, 5, 9, 15, 45 };

            int numero = 45;
            var divisores = await _service.ObterDivisores(numero);

            Assert.Equal(divisoresEsperados, divisores);
        }

        [Fact]
        public async Task ObterDivisoresPrimos()
        {
            List<int> divisoresPrimosEsperados = new List<int>  {1,3,5};
            List<int> divisores = new List<int> { 1, 3, 5, 9, 15, 45 };

            var result = await _service.ObterDivisoresPrimos(divisores);

            Assert.Equal(divisoresPrimosEsperados, result);
        }
    }
}