using System;

class Produto {
    private string nome;
    private double preco;
    private int quantidadeEmEstoque;

    public Produto(string nome, double preco, int quantidadeEmEstoque) {
        this.nome = nome;
        this.preco = preco;
        this.quantidadeEmEstoque = quantidadeEmEstoque;
    }

    public void AdicionarUnidades(int unidades) {
        quantidadeEmEstoque += unidades;
    }

    public void RemoverUnidades(int unidades) {
        if (unidades <= quantidadeEmEstoque) {
            quantidadeEmEstoque -= unidades;
        } else {
            quantidadeEmEstoque = 0;
        }
    }

    public double CalcularValorTotal() {
        return preco * quantidadeEmEstoque;
    }

    public string GetNome() {
        return nome;
    }

    public double GetPreco() {
        return preco;
    }

    public int GetQuantidadeEmEstoque() {
        return quantidadeEmEstoque;
    }
}

class Program {
    static void Main(string[] args) {
        Produto produto = new Produto("Notebook", 2500.0, 10);
        Console.WriteLine("Valor total em estoque: R$" + produto.CalcularValorTotal());

        produto.AdicionarUnidades(5);
        Console.WriteLine("Quantidade em estoque após adição: " + produto.GetQuantidadeEmEstoque());

        produto.RemoverUnidades(3);
        Console.WriteLine("Quantidade em estoque após remoção: " + produto.GetQuantidadeEmEstoque());
    }
}