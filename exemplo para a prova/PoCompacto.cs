using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exemplo_para_a_prova
{


    internal class PoCompacto : ContornoEmPo
    {
        // 5 Atributos (Herdados + 2 adicionais)
        // protected string marca; protected string nome; protected float preco;
        string funcao; // Selar ou Finalizar
        bool temFiltroSolar;
        // string tipoPele; int pesoGramas; eFrio; metodoAplicacao;

        // Construtores
        public PoCompacto() : base()
        {
            funcao = "Selar";
            temFiltroSolar = false;
            nome = "Pó Compacto";
        } // Vazio

        public PoCompacto(string novaMarca, string novaFuncao) : base(novaMarca)
        {
            funcao = novaFuncao;
            temFiltroSolar = false;
            nome = "Pó Compacto";
        } // Intermediário

        public PoCompacto(string novaMarca, string novoTipoPele, float novoPreco, string novoNome, int novoPeso, bool eTomFrio, string novoMetodo, string novaFuncao, bool temFPS)
            : base(novaMarca, novoTipoPele, novoPreco, novoNome, novoPeso, eTomFrio, novoMetodo)
        {
            funcao = novaFuncao;
            temFiltroSolar = temFPS;
        } // Cheio

        // Gets e Sets Manuais (apenas para os novos)
        public string GetFuncao() { return funcao; }
        public void SetFuncao(string novaFuncao) { funcao = novaFuncao; }

        public bool GetTemFiltroSolar() { return temFiltroSolar; }
        public void SetTemFiltroSolar(bool temFPS) { temFiltroSolar = temFPS; }

        // Override das Funções Virtual/Override
        public override void DescreverProduto() // Sobrescrita da classe avô (ProdutoMaquiagem)
        {
            Console.WriteLine($"Pó Compacto: Marca {marca}. Função: {funcao}. Tem FPS: {temFiltroSolar}.");
        }
        public override float CalcularMargem(float custo) // Sobrescrita da classe pai (ContornoEmPo)
        {
            // Margem de lucro maior se tiver FPS
            float margem = base.CalcularMargem(custo);
            return temFiltroSolar ? margem * 1.15f : margem;
        }

        // 2 Funções Polimórficas (Sobrecarga)
        public void AdicionarAoCarrinho()
        {
            Console.WriteLine($"Pó Compacto adicionado ao carrinho.");
        }
        public void AdicionarAoCarrinho(int quantidade)
        {
            Console.WriteLine($"{quantidade} Pó Compacto(s) adicionado(s) ao carrinho.");
        }

        // 3 Funções Simples
        public void SelarMaquiagem()
        {
            Console.WriteLine($"Usando o pó {funcao} para aumentar a durabilidade.");
        }
        public bool NecessitaReaplicacao(int horas)
        {
            return horas > 4;
        }
        public float DiminuirBrilho(float brilhoAtual)
        {
            return brilhoAtual * 0.2f;
        }
        public void print()
        {
            Console.WriteLine($"Marca: {marca}, Nome: {nome}, Preço: {preco}, Peso: {pesoGramas}, Tipo de Pele: {tipoPele}, Função: {funcao}, Tem Filtro Solar: {temFiltroSolar}");
        }
    }
}
