using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_para_a_prova
{
    internal class Blush
    {
        
    // 5 Atributos
    protected string marca;
        string cor;
        float preco;
        int qntd;
        protected string embalagem;

        // Construtores
        public Blush()
        {
            marca = "Super Make";
            cor = "Pêssego";
            preco = 45.0f;
            qntd = 20;
            embalagem = "Pó Compacto";
        } // Vazio

        public Blush(string novaMarca, string novaCor)
        {
            marca = novaMarca;
            cor = novaCor;
            preco = 50.0f;
            qntd = 15;
            embalagem = "Creme";
        } // Intermediário

        public Blush(string novaMarca, string novaCor, float novoPreco, int novaQntd, string novaEmbalagem)
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

        public float GetPreco() { return preco; }
        public void SetPreco(float novoPreco) { preco = novoPreco; }

        public string GetEmbalagem() { return embalagem; }
        public void SetEmbalagem(string novaEmbalagem) { embalagem = novaEmbalagem; }

        // 2 Funções Virtual/Override
        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"Blush: {marca} na cor {cor}. Embalagem: {embalagem}.");
        }
        public virtual float CalcularPrecoFinal(float desconto)
        {
            return preco - desconto;
        }

        // 2 Funções Polimórficas (Sobrecarga)
        public void AumentarEstoque(int quantidade)
        {
            qntd += quantidade;
        }
        public void AumentarEstoque(int quantidade, string nota)
        {
            AumentarEstoque(quantidade);
            Console.WriteLine($"Nota de reposição: {nota}.");
        }

        // 3 Funções Simples
        public void Aplicar(string formato)
        {
            Console.WriteLine($"Aplicando o blush {cor} com pincel {formato}.");
        }
        public bool PrecisaDeReposicao()
        {
            return qntd < 10;
        }
        public string TipoDeAplicacao()
        {
            if (embalagem == "pó")
                return "Pincel grande.";
            return "Pontas dos dedos ou esponja.";
        }
        public void print()
        {
            Console.WriteLine($"Marca: {marca}, Cor: {cor}, Preço: R${preco}, Quantidade: {qntd}, Embalagem: {embalagem}.");
        }
    }
}
