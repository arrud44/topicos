using System;

public interface IReserva {
    void ReservarVoo(int idVoo, string nomePassageiro);
    void CancelarReserva();
    bool VerificarStatusReserva();
}

public class ReservaVooRegular : IReserva {
    private int idVoo;
    private string nomePassageiro;
    private bool reservado;

    public void ReservarVoo(int idVoo, string nomePassageiro) {
        this.idVoo = idVoo;
        this.nomePassageiro = nomePassageiro;
        this.reservado = true;
        Console.WriteLine($"Reserva de voo regular realizada para o voo {idVoo} com sucesso.");
    }

    public void CancelarReserva() {
        if (reservado) {
            idVoo = 0;
            nomePassageiro = null;
            reservado = false;
            Console.WriteLine("Reserva de voo regular cancelada.");
        } else {
            Console.WriteLine("Reserva de voo regular não encontrada.");
        }
    }

    public bool VerificarStatusReserva() {
        return reservado;
    }
}

public class ReservaVooUpgrade : IReserva {
    private int idVoo;
    private string nomePassageiro;
    private bool reservado;
    private bool upgrade;

    public void ReservarVoo(int idVoo, string nomePassageiro) {
        this.idVoo = idVoo;
        this.nomePassageiro = nomePassageiro;
        this.reservado = true;
        this.upgrade = false;
        Console.WriteLine($"Reserva de voo com upgrade realizada para o voo {idVoo} com sucesso.");
    }

    public void CancelarReserva() {
        if (reservado) {
            idVoo = 0;
            nomePassageiro = null;
            reservado = false;
            upgrade = false;
            Console.WriteLine("Reserva de voo com upgrade cancelada.");
        } else {
            Console.WriteLine("Reserva de voo com upgrade não encontrada.");
        }
    }

    public void UpgradeClasse() {
        if (reservado && !upgrade) {
            upgrade = true;
            Console.WriteLine("Upgrade de classe realizado.");
        } else {
            Console.WriteLine("Upgrade de classe não disponível.");
        }
    }

    public bool VerificarStatusReserva() {
        return reservado;
    }
}

public class ReservaVooGrupo : IReserva {
    private int idVoo;
    private string nomePassageiro;
    private bool reservado;
    private int quantidadePassageiros;

    public void ReservarVoo(int idVoo, string nomePassageiro, int quantidadePassageiros) {
        this.idVoo = idVoo;
        this.nomePassageiro = nomePassageiro;
        this.quantidadePassageiros = quantidadePassageiros;
        this.reservado = true;
        Console.WriteLine($"Reserva de voo para grupo realizada para o voo {idVoo} com sucesso.");
    }

    public void CancelarReserva() {
        if (reservado) {
            idVoo = 0;
            nomePassageiro = null;
            reservado = false;
            quantidadePassageiros = 0;
            Console.WriteLine("Reserva de voo para grupo cancelada.");
        } else {
            Console.WriteLine("Reserva de voo para grupo não encontrada.");
        }
    }

    public bool VerificarStatusReserva() {
        return reservado;
    }
}

class Program {
    static void Main(string[] args) {
        IReserva reserva1 = new ReservaVooRegular();
        IReserva reserva2 = new ReservaVooUpgrade();
        IReserva reserva3 = new ReservaVooGrupo();

        reserva1.ReservarVoo(123, "João Silva");
        Console.WriteLine($"Reserva 1: Status {reserva1.VerificarStatusReserva() ? "Pago" : "Não pago"}");

        reserva2.ReservarVoo(456, "Maria Souza");
        Console.WriteLine($"Reserva 2: Status {reserva2.VerificarStatusReserva() ? "Pago" : "Não pago"}");

        reserva3.ReservarVoo(789, "Grupo Escola", 30);
        Console.WriteLine($"Reserva 3: Status {reserva3.VerificarStatusReserva() ? "Pago" : "Não pago"}");
    }
}