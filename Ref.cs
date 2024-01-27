using System;
namespace VariableSwapper{
class Ref
{
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main(String[] args)
    {
        

        int x = 5;
        int y = 10;

        Console.WriteLine($"Before swapping: x = {x}, y = {y}");

        
        Swap(ref x, ref y);

        Console.WriteLine($"After swapping: x = {x}, y = {y}");
    }
}
}
