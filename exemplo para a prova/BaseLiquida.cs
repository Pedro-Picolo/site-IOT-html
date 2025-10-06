using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_para_a_prova
{
    internal class BaseLiquida : ProdutoMaquiagem
    {
        // 5 Atributos (3 herdados de ProdutoMaquiagem + 2)
        // protected string marca; protected string nome; protected float preco;
        string acabamento; // Fosco, Natural, Radiante
        int fatorProtecaoSolar;
        // string tipoPele; int pesoGramas;

        // Construtores
        public BaseLiquida() : base()
        {
            acabamento = "Natural";
            fatorProtecaoSolar = 15;
        } // Vazio

        public BaseLiquida(string novaMarca) : base(novaMarca)
        {
            acabamento = "Fosco";
            fatorProtecaoSolar = 30;
        } // Intermediário

        public BaseLiquida(string novaMarca, string novoTipoPele, float novoPreco, string novoNome, int novoPeso, string novoAcabamento, int novoFPS)
            : base(novaMarca, novoTipoPele, novoPreco, novoNome, novoPeso)
        {
            acabamento = novoAcabamento;
            fatorProtecaoSolar = novoFPS;
        } // Cheio

        // Gets e Sets Manuais (apenas para os novos atributos)
        public string GetAcabamento() { return acabamento; }
        public void SetAcabamento(string novoAcabamento) { acabamento = novoAcabamento; }

        public int GetFPS() { return fatorProtecaoSolar; }
        public void SetFPS(int novoFPS) { fatorProtecaoSolar = novoFPS; }

        // Override das Funções Virtual/Override
        public override void DescreverProduto() // Sobrescrita da classe avô
        {
            Console.WriteLine($"Base Líquida: {marca}. Acabamento: {acabamento}. FPS: {fatorProtecaoSolar}.");
        }
        // Função Virtual Própria
        public virtual string RecomendarCombinacao(string po)
        {
            return $"Recomenda-se selar a base {acabamento} com o pó {po}.";
        }

        // 2 Funções Polimórficas (Sobrecarga)
        public void CorrigirTom()
        {
            Console.WriteLine("Tom da base OK. Sem correções.");
        }
        public void CorrigirTom(string subtom)
        {
            if (subtom == "amarelo")
                Console.WriteLine("Sugestão: Neutralizar com corretor roxo.");
            else
                Console.WriteLine("Tom correto.");
        }

        // 3 Funções Simples
        public void RecomendarAplicador()
        {
            Console.WriteLine($"Base com acabamento {acabamento} deve ser aplicada com esponja.");
        }
        public bool EParaPeleOleosa()
        {
            return acabamento == "fosco";
        }
        public float CalcularCobertura(int camadas)
        {
            return camadas * 0.4f;
        }

        public void print()
        {
            Console.WriteLine($"Marca: {marca}, Nome: {nome}, Preço: {preco}, Tipo de Pele: {tipoPele}, Peso (g): {pesoGramas}, Acabamento: {acabamento}, FPS: {fatorProtecaoSolar}");
        }
    }
}
