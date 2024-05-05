//Heranca basicamente um atributo que faca com que a classe filha herde da classe pai,os atributos e metodos.A classe filha,pode herda da pai e pode atribuir mais coisas.

//Ex:


public abstract class Funcionario
{
    public string Nome { get; set; }
    public int Id { get; set; }
    public decimal Salario { get; set; }

    public abstract decimal CalcularSalario();
}

public class FuncionarioRegular : Funcionario
{
    public string Departamento { get; set; }

    public override decimal CalcularSalario()
    {
        return Salario;
    }
}

public class Gerente : Funcionario
{
    public string Departamento { get; set; }
    public decimal Bonus { get; set; }

    public override decimal CalcularSalario()
    {
        return Salario + Bonus;
    }
}

public class Diretor : Funcionario
{
    public string Departamento { get; set; }
    public decimal ParticipacaoLucros { get; set; }

    public override decimal CalcularSalario()
    {
        return Salario + ParticipacaoLucros;
    }
}