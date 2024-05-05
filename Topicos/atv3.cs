//Sobrecarga de metodo: e quando voce tem metodos com mesmo nomes porem com parametros diferentes.

//Sobrescrita de metodo: e quando voce tem uma classe base com um metodo,e voce quer fazer uma implementacao desse metodo em uma classe derivada.


//Ex:


public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Desenhando uma forma");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Desenhando um círculo");
    }
}

public class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Desenhando um quadrado");
    }
}