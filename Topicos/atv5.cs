#include <iostream>
#include <string>

class Produto {
private:
    std::string nome_;
    double preco_;
    int quantidadeEmEstoque_;

public:
    Produto(const std::string& nome, double preco, int quantidadeEmEstoque)
        : nome_(nome), preco_(preco), quantidadeEmEstoque_(quantidadeEmEstoque) {}

    void adicionarUnidades(int unidades) {
        quantidadeEmEstoque_ += unidades;
    }

    void removerUnidades(int unidades) {
        if (unidades <= quantidadeEmEstoque_) {
            quantidadeEmEstoque_ -= unidades;
        } else {
            quantidadeEmEstoque_ = 0;
        }
    }

    double calcularValorTotal() const {
        return preco_ * quantidadeEmEstoque_;
    }

    std::string getNome() const { return nome_; }
    double getPreco() const { return preco_; }
    int getQuantidadeEmEstoque() const { return quantidadeEmEstoque_; }
};

int main() {
    Produto produto("Notebook", 2500.0, 10);
    std::cout << "Valor total em estoque: R$" << produto.calcularValorTotal() << std::endl;

    produto.adicionarUnidades(5);
    std::cout << "Quantidade em estoque após adição: " << produto.getQuantidadeEmEstoque() << std::endl;

    produto.removerUnidades(3);
    std::cout << "Quantidade em estoque após remoção: " << produto.getQuantidadeEmEstoque() << std::endl;

    return 0;
}
