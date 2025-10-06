using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_para_a_prova
{
    internal class Corretivo
    {
        // 5 Atributos
        protected string marca;
        string cor;
        float preco;
        int qntd;
        protected string embalagem;

        // Construtores
        public Corretivo()
        {
            marca = "Mega Cover";
            cor = "Bege";
            preco = 40.0f;
            qntd = 20;
            embalagem = "Líquido";
        } // Vazio

        public Corretivo(string novaMarca, string novaCor)
        {
            marca = novaMarca;
            cor = novaCor;
            preco = 45.0f;
            qntd = 15;
            embalagem = "Bastão";
        } // Intermediário

        public Corretivo(string novaMarca, string novaCor, float novoPreco, int novaQntd, string novaEmbalagem)
        {
            marca = novaMarca;
            cor = novaCor;
            preco = novoPreco;
            qntd = novaQntd;
            embalagem = novaEmbalagem;
        } // Cheio

        // Gets e Sets Manuais 
        public string GetMarca() { return marca; }
        public void SetMarca(string novaMarca) { marca = novaMarca; }

        public string GetCor() { return cor; }
        public void SetCor(string novaCor) { cor = novaCor; }

        public int GetQntd() { return qntd; }
        public void SetQntd(int novaQntd) { qntd = novaQntd; }

        // 2 Funções Virtual/Override
        public virtual void Apresentar()
        {
            Console.WriteLine($"Corretivo {marca}. Cor: {cor}.");
        }
        public virtual float CalcularPrecoComDescontoEImposto(float desconto, float imposto)
        {
            return (preco - desconto) * (1 + imposto);
        }

        // 2 Funções Polimórficas (Sobrecarga)
        public void AplicarDesconto()
        {
            preco *= 0.9f;
        }
        public void AplicarDesconto(float percentual)
        {
            preco *= (1 - percentual / 100);
        }

        // 3 Funções Simples
        public void Corrigir(string area)
        {
            Console.WriteLine($"Corrigindo {area} com o corretivo de cor {cor}.");
        }
        public bool EAntialergico()
        {
            return marca=="hipoalergênico";
        }
        public float ReajustarEstoque(int valor)
        {
            qntd += valor;
            return qntd;
        }
        public void print()
        {
            Console.WriteLine($"Corretivo: {marca}, Cor: {cor}, Preço: R${preco}, Quantidade: {qntd}, Embalagem: {embalagem}.");
        }
    }
}
