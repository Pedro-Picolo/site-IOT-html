using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_para_a_prova
{
    internal class Iluminador
    {
        // 5 Atributos
        protected string marca;
        string cor;
        float preco;
        int qntd;
        protected string brilho;

        // Construtores
        public Iluminador()
        {
            marca = "Glow Up";
            cor = "Prata";
            preco = 60.0f;
            qntd = 15;
            brilho = "Holográfico";
        } // Vazio

        public Iluminador(string novaMarca, string novoBrilho)
        {
            marca = novaMarca;
            cor = "Neutro";
            preco = 70.0f;
            qntd = 10;
            brilho = novoBrilho;
        } // Intermediário

        public Iluminador(string novaMarca, string novaCor, float novoPreco, int novaQntd, string novoBrilho)
        {
            marca = novaMarca;
            cor = novaCor;
            preco = novoPreco;
            qntd = novaQntd;
            brilho = novoBrilho;
        } // Cheio

        // Gets e Sets Manuais
        public string GetMarca() { return marca; }
        public void SetMarca(string novaMarca) { marca = novaMarca; }

        public float GetPreco() { return preco; }
        public void SetPreco(float novoPreco) { preco = novoPreco; }

        public string GetBrilho() { return brilho; }
        public void SetBrilho(string novoBrilho) { brilho = novoBrilho; }

        // 2 Funções Virtual/Override
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Iluminador: {marca}, Brilho: {brilho}.");
        }
        public virtual float AplicarDesconto(float percentual)
        {
            return preco * (1 - percentual / 100);
        }

        // 2 Funções Polimórficas (Sobrecarga)
        public void VenderItem()
        {
            if (qntd > 0) qntd--;
        }
        public void VenderItem(string cliente)
        {
            VenderItem();
            Console.WriteLine($"Venda registrada para o cliente: {cliente}.");
        }

        // 3 Funções Simples
        public void Realcar()
        {
            Console.WriteLine($"Realçando a pele com o iluminador {brilho}.");
        }
        public float Descontar(float valor)
        {
            preco -= valor;
            return preco;
        }
        public string SugerirUso()
        {
            if (brilho== "holográfico")
                return "Sugestão: Uso em eventos noturnos.";
            return "Sugestão: Uso diário casual.";
        }
        public void print()
        {
            Console.WriteLine($"Marca: {marca}, Cor: {cor}, Preço: {preco}, Quantidade: {qntd}, Brilho: {brilho}");
        }
    }
}
