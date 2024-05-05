using System;

abstract class Curso {
    protected string nome;
    protected double[] notas;

    public Curso(string nome, int numeroDeAulas) {
        this.nome = nome;
        this.notas = new double[numeroDeAulas];
    }

    public abstract void CalcularMedia();

    public void AdicionarNota(int aula, double nota) {
        this.notas[aula] = nota;
    }

    public void GerarCertificado() {
        Console.WriteLine("Certificado de conclusão do curso de " + this.nome);
    }
}

class CursoIngles : Curso {
    public CursoIngles(int numeroDeAulas) : base("Inglês", numeroDeAulas) {}

    public override void CalcularMedia() {
        double soma = 0;
        for (int i = 0; i < this.notas.Length; i++) {
            soma += this.notas[i];
        }
        Console.WriteLine("Média de notas do curso de inglês: " + soma / this.notas.Length);
    }
}

class CursoEspanhol : Curso {
    public CursoEspanhol(int numeroDeAulas) : base("Espanhol", numeroDeAulas) {}

    public override void CalcularMedia() {
        double soma = 0;
        for (int i = 0; i < this.notas.Length; i++) {
            soma += this.notas[i];
        }
        Console.WriteLine("Média de notas do curso de espanhol: " + soma / this.notas.Length);
    }
}

class CursoFrances : Curso {
    public CursoFrances(int numeroDeAulas) : base("Francês", numeroDeAulas) {}

    public override void CalcularMedia() {
        double soma = 0;
        for (int i = 0; i < this.notas.Length; i++) {
            soma += this.notas[i];
        }
        Console.WriteLine("Média de notas do curso de francês: " + soma / this.notas.Length);
    }
}

class Program {
    static void Main(string[] args) {
        CursoIngles cursoIngles = new CursoIngles(10);
        cursoIngles.AdicionarNota(0, 8.5);
        cursoIngles.AdicionarNota(1, 9.0);
        cursoIngles.CalcularMedia();
        cursoIngles.GerarCertificado();

        CursoEspanhol cursoEspanhol = new CursoEspanhol(15);
        cursoEspanhol.AdicionarNota(0, 7.0);
        cursoEspanhol.AdicionarNota(1, 7.5);
        cursoEspanhol.AdicionarNota(2, 8.0);
        cursoEspanhol.CalcularMedia();
        cursoEspanhol.GerarCertificado();

        CursoFrances cursoFrances = new CursoFrances(20);
        cursoFrances.AdicionarNota(0, 8.5);
        cursoFrances.AdicionarNota(1, 9.0);
        cursoFrances.AdicionarNota(2, 9.5);
        cursoFrances.AdicionarNota(3, 10.0);
        cursoFrances.CalcularMedia();
        cursoFrances.GerarCertificado();
    }
}