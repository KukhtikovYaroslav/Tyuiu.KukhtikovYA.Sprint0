namespace Tyuiu.KukhtikovYA.Sprint0.Task5.V0.Lib;

public class DataService
{
    public static int Addition(int a, int b)
    {
        return a + b;
    }

    public static int Subtraction(int a, int b)
    {
        return a - b;
    }
    
    public static int Multiplication(int a, int b)
    {
        return a * b;
    }

    public static int Division(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine($"Переменная b = {b} на ноль делить нельзя");
            return -1;
        }
        
        return a / b;
    }
}