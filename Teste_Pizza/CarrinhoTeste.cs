using ex_pizza_14_05_21;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Teste_Pizza
{
    public class CarrinhoTeste
    {
		[Fact]
		public void TesteTotalPizzasNoCarrinho()
		{
			CarrinhoDeCompras c = new CarrinhoDeCompras();
			Pizza p1 = new Pizza("Portuguesa");
			p1.AdicionaIngrediente("presunto");
			p1.AdicionaIngrediente("azeitonas pretas");
			p1.AdicionaIngrediente("mussarela");
			p1.AdicionaIngrediente("cebola");

			Pizza p2 = new Pizza("Mossarela");
			p2.AdicionaIngrediente("mussarela");
			p2.AdicionaIngrediente("azeitonas");

			Pizza p3 = new Pizza("Vento");

			c.AdicionarItens(p1);
			c.AdicionarItens(p2);
			c.AdicionarItens(p3);
			Assert.Equal(2, c.getTotalPizzasCarrinho());
		}
		[Fact]
		public void TesteValorTotalCarrinho()
		{
			CarrinhoDeCompras c = new CarrinhoDeCompras();
			Pizza p1 = new Pizza("Portuguesa");
			p1.AdicionaIngrediente("presunto");
			p1.AdicionaIngrediente("azeitonas pretas");
			p1.AdicionaIngrediente("mussarela");
			p1.AdicionaIngrediente("cebola");

			Pizza p2 = new Pizza("Mossarela");
			p2.AdicionaIngrediente("mussarela");
			p2.AdicionaIngrediente("azeitonas");

			Pizza p3 = new Pizza("Pizza Especial");
			p3.AdicionaIngrediente("presunto");
			p3.AdicionaIngrediente("azeitonas pretas");
			p3.AdicionaIngrediente("mussarela");
			p3.AdicionaIngrediente("cebola");
			p3.AdicionaIngrediente("palmito");
			p3.AdicionaIngrediente("oregano");
			p3.AdicionaIngrediente("milho");
			p3.AdicionaIngrediente("frango");

			c.AdicionarItens(p1);
			c.AdicionarItens(p2);
			c.AdicionarItens(p3);
			Assert.Equal(135.0, c.getTotalPagarCarrinho(), 0);
		}
	}
}
