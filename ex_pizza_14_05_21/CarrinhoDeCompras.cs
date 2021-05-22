using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_pizza_14_05_21
{
    public class CarrinhoDeCompras
    {
        private double total_pagar = 0;
        private double valor_frete = 10;

        List<Pizza> carrinho = new List<Pizza>();


        public void AdicionarItens(Pizza p)
        {
            if (p.getTotalIngredientes() > 0)
            {
                carrinho.Add(p);
                total_pagar += p.GetPreco();
            }
            else
                Console.WriteLine("Pizza não incluída!!!");
        }

        //Quantas pizzas tem no carrinho?
        public int getTotalPizzasCarrinho()
        {
            return carrinho.Count();
        }

        //Qual o total a pagar pelo carrinho?
        public double getTotalPagarCarrinho()
        {
            return total_pagar;
        }

        //Qual o total a pagar pela compra?
        public double getTotalCompra()
        {
            return total_pagar + valor_frete;
        }
    }
}
