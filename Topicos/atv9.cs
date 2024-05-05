using System;

public interface IMetodoPagamento {
    void RealizarPagamento(decimal valor);
    bool VerificarStatusPagamento();
}

public class PagamentoCartaoCredito : IMetodoPagamento {
    private decimal limiteDisponivel;
    private decimal valorTotalPagamentos;

    public PagamentoCartaoCredito(decimal limiteDisponivel) {
        this.limiteDisponivel = limiteDisponivel;
        this.valorTotalPagamentos = 0;
    }

    public void RealizarPagamento(decimal valor) {
        if (valor <= limiteDisponivel - valorTotalPagamentos) {
            valorTotalPagamentos += valor;
            Console.WriteLine("Pagamento realizado com sucesso.");
        } else {
            throw new Exception("Limite de crédito excedido.");
        }
    }

    public bool VerificarStatusPagamento() {
        return valorTotalPagamentos > 0;
    }
}

public class PagamentoBoletoBancario : IMetodoPagamento {
    private bool pago;

    public void RealizarPagamento(decimal valor) {
        pago = true;
        Console.WriteLine("Boleto gerado com sucesso.");
    }

    public bool VerificarStatusPagamento() {
        return pago;
    }
}

public class PagamentoTransferenciaBancaria : IMetodoPagamento {
    private bool pago;

    public void RealizarPagamento(decimal valor) {
        pago = true;
        Console.WriteLine("Transferência realizada com sucesso.");
    }

    public bool VerificarStatusPagamento() {
        return pago;
    }
}

class Program {
    static void Main(string[] args) {
        IMetodoPagamento pagamento1 = new PagamentoCartaoCredito(5000);
        IMetodoPagamento pagamento2 = new PagamentoBoletoBancario();
        IMetodoPagamento pagamento3 = new PagamentoTransferenciaBancaria();

        try {
            pagamento1.RealizarPagamento(1000);
            Console.WriteLine($"Pagamento 1: Status {pagamento1.VerificarStatusPagamento() ? "Pago" : "Não pago"}");
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }

        pagamento2.RealizarPagamento(0);
        Console.WriteLine($"Pagamento 2: Status {pagamento2.VerificarStatusPagamento() ? "Pago" : "Não pago"}");

        pagamento3.RealizarPagamento(500);
        Console.WriteLine($"Pagamento 3: Status {pagamento3.VerificarStatusPagamento() ? "Pago" : "Não pago"}");
    }
}