using ex_pizza_14_05_21;
using System;
using Xunit;

namespace Teste_Pizza
{
    public class Pizza_Teste
    {
        [Fact]
        public void TestePrecoPizza2Ingredientes()
        {
            Pizza p = new Pizza("Mussarela");
            p.AdicionaIngrediente("mussarela");
            p.AdicionaIngrediente("azeitonas");
            Assert.Equal(30.0, p.GetPreco(), 0);
        }

        [Fact]
        public void testePrecoPizzaMaisDeSeisIngredientes()
        {
            Pizza p = new Pizza("Pizza Especial");
            p.AdicionaIngrediente("presunto");
            p.AdicionaIngrediente("azeitonas pretas");
            p.AdicionaIngrediente("mussarela");
            p.AdicionaIngrediente("cebola");
            p.AdicionaIngrediente("palmito");
            p.AdicionaIngrediente("oregano");
            p.AdicionaIngrediente("milho");
            p.AdicionaIngrediente("frango");
            Assert.Equal(60.0, p.GetPreco(), 0);
        }
    }
}
