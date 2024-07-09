namespace Case3;

public class Duck
{
    public virtual void Fly()
    {
        Console.WriteLine("Flying");
    }
}

public class MallardDuck : Duck
{
    public override void Fly()
    {
        Console.WriteLine("MallardDuck is flying");
    }
}

public class RubberDuck : Duck  // pato de hule
{
    public override void Fly()
    {
       
    }
}