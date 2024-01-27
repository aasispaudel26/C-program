using System;
class Array{
  static void Main(string[] args){
    char[] abc = new char[5];
    abc[0]='a';
    abc[1]='b';
    abc[2]='c';
    abc[3]='d';
    abc[4]='e';
    for (int i = 0;i<5;i++){
      Console.WriteLine("the value at index{0} is {1}",i,abc[i]);
    }

  }
}