using System;

namespace Delegates2
{
    class Program
    {
        delegate int DelegateConDousParametrosIntReturnInt(int x, int y);
        static void Main(string[] args)
        {
            Console.WriteLine("***Comparando o comportamento dun metodo estatico e un metodo de instancia cando se lle asigna un delegate de instancia.***");
            Console.WriteLine("Asignando un metodo estatico a un obxeto delegate.");
            //Asignando metodo estatico a objeto delegate.
            DelegateConDousParametrosIntReturnInt obDel = Suma;
            Console.WriteLine("Chamando a metodo Suma(..) de Program Class usando un delegate.");
            int total = obDel(10, 20);
            Console.WriteLine("A suma de 10 e 20 e: {0}", total);
            Console.WriteLine("obDel.Target={0}", obDel.Target);
            Console.WriteLine("obDel.Target==null? {0}", obDel.Target == null);//True
            Console.WriteLine("obDel.Method={0}", obDel.Method);

            ForaDoPrograma obFora = new ForaDoPrograma();

            Console.WriteLine("\nAsignando unha metodo de instancia a un obxeto delegate.");

            obDel = obFora.CalcularSuma;
            Console.WriteLine("Chamando a metodo CalcularSuma(..) da clase ForaDoPrograma usando un delegate.");
            total = obDel(50, 70);
            Console.WriteLine("Suma de 50 e 70 e {0}", total);
            Console.WriteLine("obDel.Target={0}", obDel.Target);
            //obDel.Target=DelegateEx1.ForaDoPrograma
            Console.WriteLine("obDel.Target==null? {0}", obDel.Target == null);//False
            Console.WriteLine("obDel.Method={0}", obDel.Method);
            Console.ReadKey();
        }

        public static int Suma(int x, int y)
        {
            return x + y;
        }
    }

    class ForaDoPrograma
    {
        public int CalcularSuma(int x, int y)
        {
            return x + y;
        }
    }
}
