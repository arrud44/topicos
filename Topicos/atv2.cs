//Interface basicamente,orienta o objeto do que ele deve fazer mais nao como ele deve fazer.

//Ex:


using System;

interface IPagamentoProcessador
{
    void ProcessarPagamento(decimal valor);
}

class ProcessadorCartaoCredito : IPagamentoProcessador
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine("Processando pagamento de " + valor + " usando Cartão de Crédito.");
        
    }
}

class ProcessadorPayPal : IPagamentoProcessador
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine("Processando pagamento de " + valor + " usando PayPal.");
        
    }
}

class ProcessadorTransferenciaBancaria : IPagamentoProcessador
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine("Processando pagamento de " + valor + " usando Transferência Bancária.");
        
    }
}

class FabricaProcessadorPagamento
{
    public static IPagamentoProcessador ObterProcessadorPagamento(string tipoProcessador)
    {
        switch (tipoProcessador)
        {
            case "CartaoCredito":
                return new ProcessadorCartaoCredito();
            case "PayPal":
                return new ProcessadorPayPal();
            case "TransferenciaBancaria":
                return new ProcessadorTransferenciaBancaria();
            default:
                throw new ArgumentException("Tipo de processador de pagamento inválido");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        IPagamentoProcessador processador = FabricaProcessadorPagamento.ObterProcessadorPagamento("CartaoCredito");
        processador.ProcessarPagamento(100);
    }
}