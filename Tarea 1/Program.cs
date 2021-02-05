using System;

namespace Tarea_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;
            int d = 11;
            int suma = 0;
            //aadb
            Console.Write(a + "/");
            Console.Write(a + "/");
            Console.Write(d + "/");
            Console.WriteLine(b + "/");
            suma = a + a + d + b;
            Console.WriteLine("la suma de estos numeros es: "+suma);
            //bda
            Console.Write(b + "/");
            Console.Write(d + "/");
            Console.WriteLine(a + "/");
            suma = b+  d + a;
            Console.WriteLine("la suma de estos numeros es: " +suma);
            //bdbd
            Console.Write(b+"/");
            Console.Write(d + "/");
            Console.Write(b + "/");
            Console.WriteLine(d + "/");
            suma = b + d + b + d;
            Console.WriteLine("la suma de estos numeros es: "  +suma);
        }
    }
}
