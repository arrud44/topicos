using System;

class ContaBancaria {
    protected double saldo;

    public ContaBancaria(double saldoInicial) {
        this.saldo = saldoInicial;
    }

    public void Depositar(double valor) {
        this.saldo += valor;
    }

    public void Sacar(double valor) {
        if (valor <= this.saldo) {
            this.saldo -= valor;
        } else {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

    public double GetSaldo() {
        return this.saldo;
    }
}

class ContaPoupanca : ContaBancaria {
    private double taxaDeJuros;

    public ContaPoupanca(double saldoInicial, double taxaDeJuros) : base(saldoInicial) {
        this.taxaDeJuros = taxaDeJuros;
    }

    public void CalcularJuros() {
        this.saldo += this.saldo * this.taxaDeJuros;
    }
}

class ContaEmpresarial : ContaBancaria {
    private double saldoMinimo;

    public ContaEmpresarial(double saldoInicial, double saldoMinimo) : base(saldoInicial) {
        this.saldoMinimo = saldoMinimo;
    }

    public void VerificarSaldoMinimo() {
        if (this.saldo < this.saldoMinimo) {
            Console.WriteLine("Saldo abaixo do mínimo.");
        }
    }
}

class Program {
    static void Main(string[] args) {
        ContaPoupanca contaPoupanca = new ContaPoupanca(5000.0, 0.05);
        contaPoupanca.Depositar(500.0);
        contaPoupanca.CalcularJuros();
        Console.WriteLine("Saldo da conta poupança: " + contaPoupanca.GetSaldo());

        ContaEmpresarial contaEmpresarial = new ContaEmpresarial(20000.0, 10000.0);
        contaEmpresarial.Depositar(3000.0);
        contaEmpresarial.VerificarSaldoMinimo();
        Console.WriteLine("Saldo da conta empresarial: " + contaEmpresarial.GetSaldo());
    }
}