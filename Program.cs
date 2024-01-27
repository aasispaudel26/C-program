// See https://aka.ms/new-console-template for more information
using System;
class Program{
  static void Main(string[] args){
    int a=5, b=10;
    Console.WriteLine("before swap a="+a+" b="+b);
    a= a+b;
    b= a-b;
    a= a-b;
    Console.Write("After swap a="+a+"b="+b);
  }
}
