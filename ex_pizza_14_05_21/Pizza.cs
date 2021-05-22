using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_pizza_14_05_21
{
     public class Pizza
    {
        public string Sabor { get; set; }

        public double Preco { get; set; }

        public int Indice { get; set; }

        public int NumeroIngredientes { get; set; }

        public int TotalIngredientes = 0;

        public static int TotalPizzas;

        private Dictionary<int, string> _ingredientes = new Dictionary<int, string>();

        // metodo construtor: ações feitas quando a classe é criada
        public Pizza(string sabor)
        {
            this.Sabor = sabor;
            TotalPizzas++;
        }

        public void AdicionaIngrediente(String ingrediente)
        {
            if (_ingredientes.Count <= 8)
                _ingredientes.Add(Indice++, ingrediente);
            //total_ingredientes++; 
            else
                Console.WriteLine("Pizza já atingiu o limite de ingredientes.");
        }

        public void RemoverIngredientes(String ingrediente)
        {
            if (_ingredientes.ContainsValue(ingrediente))
            {
                //_ingredientes.(ingrediente);
                var item = _ingredientes.First(kvp => kvp.Value == ingrediente);
                _ingredientes.Remove(item.Key);
            }
        }

        public int getTotalIngredientes()
        {
            return _ingredientes.Count();
        }

        public int GetTotalPizzas()
        {
            return TotalPizzas;
        }

        public double GetPreco()
        {
            if (_ingredientes.Count() <= 2)
            {
                Preco = 30.00;
            }
            else if (_ingredientes.Count() <= 5)
            {
                Preco = 45.00;
            }
            else
            {
                Preco = 60.00;
            }
            return Preco;
        }

        public void listarIngredientes()
        {
            for (int i = 0; i < _ingredientes.Count(); i++)
                Console.WriteLine(i + 1 + " - " + _ingredientes[i]);
        }
        public String getSabor()
        {
            return Sabor;
        }
        public void setSabor(String novosabor)
        {
            Sabor = novosabor;
        }

    }
}
