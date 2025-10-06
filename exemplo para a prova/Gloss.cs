using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_para_a_prova
{
    internal class Gloss
    {
        // 5 Atributos
        protected string marca;
        string cor;
        float preco;
        int qntd;
        protected string sabor;

        // Construtores
        public Gloss()
        {
            marca = "Bela Cor";
            cor = "Transparente";
            preco = 25.0f;
            qntd = 50;
            sabor = "Frutas";
        } // Vazio

        // Intermediário 
        public Gloss(string novaMarca)
        {
            marca = novaMarca;
            cor = "Rosa Bebê";
            preco = 30.0f;
            qntd = 30;
            sabor = "Menta";
        }

        // Cheio
        public Gloss(string novaMarca, string novaCor, float novoPreco, int novaQntd, string novoSabor)
        {
            marca = novaMarca;
            cor = novaCor;
            preco = novoPreco;
            qntd = novaQntd;
            sabor = novoSabor;
        }

        // Gets e Sets Manuais
        public string GetMarca()
        { return marca; }

        public void SetMarca(string novaMarca)
        {
            if (novaMarca == "NaoInformada")
            {
                marca = "Genérica";
            }
            else
            {
                marca = novaMarca;
            }
        }

        public float GetPreco()
        { return preco; }

        public void SetPreco(float novoPreco)
        { preco = novoPreco; }

        public string GetCor() 
        { return cor; }

        public void SetCor(string novaCor) 
        { cor = novaCor; }

        // 2 Funções Virtual/Override
        public virtual void ExibirFicha()
        {
            Console.WriteLine($"Gloss: {marca}, Cor: {cor}, Preço: R${preco}.");
        }
        public virtual float CalcularPrecoComFrete(float frete)
        {
            return preco + frete;
        }

        // 2 Funções Polimórficas (Sobrecarga)
        public void AjustarPreco(float novoPreco)
        {
            preco = novoPreco;
            Console.WriteLine($"Preço ajustado para R${preco:F2}.");
        }
        public void AjustarPreco(float percentual, bool isAumento)
        {
            if (isAumento)
                preco *= (1 + percentual / 100);
            else
                preco *= (1 - percentual / 100);
        }

        // 3 Funções Simples/Estáticas
        public void Aplicar()
        {
            Console.WriteLine($"Aplicando o gloss de sabor {sabor}.");
        }
        public bool EstaEmPromocao(float descontoMinimo)
        {
            return preco * 0.8f < preco - descontoMinimo;
        }
        public float Vender(int quantidadeVendida)
        {
            if (qntd >= quantidadeVendida)
            {
                qntd -= quantidadeVendida;
                return preco * quantidadeVendida;
            }
            return 0.0f;
        }
        public void print()
        {
            Console.WriteLine($"Marca: {marca}, Cor: {cor}, Preço: {preco}, Quantidade: {qntd}, Sabor: {sabor}");
        }
    }
}
