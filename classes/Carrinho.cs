using System;
using System.Collections.Generic;

namespace Nova_pasta.classes
{
    public class Carrinho
    {   
        // Atributo para armazenar o valor total dos produtos no carrinho 
        public float ValorTotal { get; set; }

        //  Criamos a lista de produtos, e a chamamos de carrinho
        List<Produto> carrinho = new List<Produto>();

        // Método para adicionar o "_produto" à lista "carrinho"
        public void AdicionarProduto(Produto _produto){
                carrinho.Add(_produto);
        }
        
        // null = sem conteúdo
        public void MostrarProdutos(){
            if(carrinho != null){
                foreach (Produto item in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{item.Codigo}, {item.Nome}, {item.Preco} ");
                    Console.ResetColor();

                }
                MostrarTotal();
            }
        }

        public void RemoverProduto(Produto _produto) {
            carrinho.Remove(_produto);

        }
            public void MostrarTotal(){
                ValorTotal = 0;
                if(carrinho != null){
                    foreach (var item in carrinho)
                    {
                        ValorTotal += item.Preco;
                    } 
                    Console.WriteLine($"O total do carrinho é: R${ValorTotal}");
                } else {
                    Console.WriteLine("Seu carrinho está Vazio:");
                }
            }

            public void AlterarItem(int _codigo_procurado, Produto _novoProduto){
                carrinho.Find(produto => produto.Codigo == _codigo_procurado).Nome = _novoProduto.Nome;
                carrinho.Find(produto => produto.Codigo == _codigo_procurado).Preco = _novoProduto.Preco;

            }
    }
}