using System;

namespace Delegates5_CasoDeEstudioConMetodosOverloaded
{
    delegate int DelegateConDousParametrosReturnInt(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Caso de estudio con metodos overloaded.***");
            DelegateConDousParametrosReturnInt obDel = Suma;
            Console.WriteLine("\nChamando metodo Suma(...) usando un delegate");
            int total = obDel(10, 20);
            Console.WriteLine("Suma de 10 e 20 e: {0}", total);
            //Anque o metodo esta overloaded, lee a version correcta de sumar dous numeros enteiros
            Console.ReadKey();
        }

        public static int Suma(int x,int y)
        {
            return x + y;
        }

        public static int Suma(int x, int y, int z)
        {
            return x + y + z;
        }
    }
}
