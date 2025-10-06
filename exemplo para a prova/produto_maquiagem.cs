using System;
public class ProdutoMaquiagem
{
    // Atributos
    protected string marca;
    protected string tipoPele;
    protected float preco;
    protected string nome;
    protected int pesoGramas;
    // Construtor Vazio 
    public ProdutoMaquiagem()
    {
        marca = "Sem Marca";
        tipoPele = "Normal";
        preco = 0.0f;
        nome = "Produto Genérico";
        pesoGramas = 15;
    }

    // Construtor Intermediário (com 1 parâmetro)
    public ProdutoMaquiagem(string novaMarca)
    {
        marca = novaMarca;
        tipoPele = "Normal";
        preco = 0.0f;
        nome = "Produto Genérico";
        pesoGramas = 15;
    }

    // Construtor Cheio
    public ProdutoMaquiagem(string novaMarca, string novoTipoPele, float novoPreco, string novoNome, int novoPeso)
    {
        marca = novaMarca;
        tipoPele = novoTipoPele;
        preco = novoPreco;
        nome = novoNome;
        pesoGramas = novoPeso;
    }
    // Gets e Sets Manuais 
    public string GetMarca()
    {
        return marca;
    }
    public void SetMarca(string novaMarca)
    {
        // Regra de validação no Set
        if (novaMarca == "marca branca")
        {
            marca = "Não Informada";
        }
        else
        {
            marca = novaMarca;
        }
    }

    // Get e Set para o 'nome'
    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string novoNome)
    {
        nome = novoNome;
    }

    // Função Virtual
    public virtual void DescreverProduto()
    {
        Console.WriteLine("Produto Base: {0}, Marca: {1}, Preço: R${2:F2}, Peso: {3}g", nome, marca, preco, pesoGramas);
    }

    // Função Simples (similar ao CalculaPreco, adaptada para Custo Total)
    public float CalculaCustoTotal()
    {
        float custoFinal = preco;

        // Se a marca for de luxo, aumenta o preço
        if (marca == "Luxo")
        {
            custoFinal += 20.0f;
        }

        // Regra de preço baseada no peso
        if (pesoGramas > 30) //grande
        {
            custoFinal += 15.0f; // Custo extra para embalagem maior
        }
        else
        {
            custoFinal += 5.0f; // Custo padrão de embalagem
        }

        return custoFinal;
    }

    public void print()
    {
        Console.WriteLine($"Produto: {nome}, Marca: {marca}, Preço: R${preco}, Peso: {pesoGramas}g, Tipo de Pele: {tipoPele}");
    }
}