using System;

public class Veiculo {
    public Veiculo(string marca, string modelo) {
        Marca = marca;
        Modelo = modelo;
    }

    public string Marca { get; }
    public string Modelo { get; }
}

public class Carro : Veiculo {
    public Carro(string marca, string modelo, int numeroPortas)
        : base(marca, modelo) {
        NumeroPortas = numeroPortas;
    }

    public int NumeroPortas { get; }
}

public class Moto : Veiculo {
    public Moto(string marca, string modelo, double cilindrada)
        : base(marca, modelo) {
        Cilindrada = cilindrada;
    }

    public double Cilindrada { get; }
}

public class Bicicleta : Veiculo {
    public Bicicleta(string marca, string modelo, int numeroMarchas)
        : base(marca, modelo) {
        NumeroMarchas = numeroMarchas;
    }

    public int NumeroMarchas { get; }
}

class Program {
    static void Main(string[] args) {
        var veiculos = new List<Veiculo> {
            new Carro("Ford", "Fiesta", 4),
            new Moto("Honda", "CBR600RR", 599),
            new Bicicleta("Giant", "Defy", 22)
        };

        foreach (var veiculo in veiculos) {
            if (veiculo is Carro carro) {
                Console.WriteLine($"Carro: Marca {carro.Marca}, Modelo {carro.Modelo}, Número de portas: {carro.NumeroPortas}");
            } else if (veiculo is Moto moto) {
                Console.WriteLine($"Moto: Marca {moto.Marca}, Modelo {moto.Modelo}, Cilindrada: {moto.Cilindrada}cc");
            } else if (veiculo is Bicicleta bicicleta) {
                Console.WriteLine($"Bicicleta: Marca {bicicleta.Marca}, Modelo {bicicleta.Modelo}, Número de marchas: {bicicleta.NumeroMarchas}");
            }
        }
    }
}