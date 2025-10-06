using exemplo_para_a_prova;

class Program
{
    static void Main()
    {
        ProdutoMaquiagem produto_maquiagem = new ProdutoMaquiagem("Maybelline", "Oleosa", 29.90f, "Fit Me", 30);
        produto_maquiagem.print();

        Gloss gloss = new Gloss();
        gloss.print();

        Blush blush = new Blush();
        blush.print();

        Iluminador iluminador = new Iluminador();
        iluminador.print();

        Corretivo corretivo = new Corretivo();
        corretivo.print();

        BaseLiquida base_liquida = new BaseLiquida();
        base_liquida.print();

        ContornoEmPo contorno = new ContornoEmPo();
        contorno.print();

        PoCompacto po = new PoCompacto();
        po.print();
    }
}