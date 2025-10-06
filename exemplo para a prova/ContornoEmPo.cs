using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_para_a_prova
{
    internal class ContornoEmPo : ProdutoMaquiagem
    {
        // 5 Atributos (3 herdados + 2 adicionais)
        // protected string marca; protected string nome; protected float preco;
        bool eFrio; // Se o tom é frio para contorno
        string metodoAplicacao;
        // string tipoPele; int pesoGramas;

        // Construtores
        public ContornoEmPo() : base()
        {
            eFrio = true;
            metodoAplicacao = "Pincel Chanfrado";
            nome = "Contorno";
        } // Vazio

        public ContornoEmPo(string novaMarca) : base(novaMarca)
        {
            eFrio = true;
            metodoAplicacao = "Pincel Chanfrado";
            nome = "Contorno";
        } // Intermediário

        public ContornoEmPo(string novaMarca, string novoTipoPele, float novoPreco, string novoNome, int novoPeso, bool eTomFrio, string novoMetodo)
            : base(novaMarca, novoTipoPele, novoPreco, novoNome, novoPeso)
        {
            eFrio = eTomFrio;
            metodoAplicacao = novoMetodo;
        } // Cheio

        // Gets e Sets Manuais (apenas para os novos)
        public bool GetEFrio() { return eFrio; }
        public void SetEFrio(bool eTomFrio) { eFrio = eTomFrio; }

        public string GetMetodoAplicacao() { return metodoAplicacao; }
        public void SetMetodoAplicacao(string novoMetodo) { metodoAplicacao = novoMetodo; }

        // Override das Funções Virtual/Override
        public override void DescreverProduto()
        {
            Console.WriteLine($"Contorno em Pó. Tonalidade {(eFrio ? "Fria (Esculpir)" : "Quente (Bronzear)")}.");
        }
        // Função Virtual Própria
        public virtual float CalcularMargem(float custo)
        {
            return preco - custo;
        }

        // 2 Funções Polimórficas (Sobrecarga)
        public void SugerirAplicacao()
        {
            Console.WriteLine($"Aplicar de forma sutil com {metodoAplicacao}.");
        }
        public void SugerirAplicacao(string formatoRosto)
        {
            SugerirAplicacao();
            Console.WriteLine($"Dica para o formato {formatoRosto}: Contorne suavemente.");
        }

        // 3 Funções Simples
        public void Escurecer(float percentual)
        {
            Console.WriteLine($"Tom escurecido em {percentual}%.");
        }
        public bool EIdealParaEsculpir()
        {
            return eFrio;
        }
        public string AreaDeAplicacao()
        {
            return "Abaixo das maçãs, laterais do nariz e testa.";
        }
        public void print()
        {
            Console.WriteLine($"Corretivo: {marca}, Preço: R${preco}.");
        }
    }
}
