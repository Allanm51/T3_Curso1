using Alura.Adopet.Console.Servicos;
using System.Threading.Tasks;

namespace Alura.Adopet.Testes
{
    public class HttpClientPetTest
    {
        [Fact]
        public async Task ListaPetsDeveRetornarUmaListaVazia()
        {
            //Arange
            var clientePet = new HttpClientPet();

            //Act
            var lista = await clientePet.ListPetsAsync();

            //Assert
            Assert.NotNull(lista);
            Assert.NotEmpty(lista);
        }

        [Fact]
        public async Task QuandoAPIForaDeveRetornarUmaExcecao()
        {
            //Arrange
            var clientePet = new HttpClientPet(uri:"http://localhost:5000");

            //Act+Assert
            await Assert.ThrowsAnyAsync<Exception>(()=> clientePet.ListPetsAsync());
        }
    }
}
