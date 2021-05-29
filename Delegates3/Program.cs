using System;

namespace Delegates3
{
    delegate void MultiDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Exemplo dun Delegate Multicast.***");
            // Pon como obxetivo un metodo estatico
            MultiDelegate multiDel = MetodoUn;
            //Pon como obxetivo outro metodo estatico
            multiDel += MetodoDous;
            //pon como obxetivo un metodo de instancia
            multiDel += new ForaDoPrograma().MetodoTres;
            multiDel();
            //Reducindo a cadena de delegates
            Console.WriteLine("\nReducindo a lonxitude da cadena de delegates descartando o MetodoDous");
            multiDel -= MetodoDous;
            //A seguinte invocacion chamará a MetodoUn e MetodoTres
            multiDel();
            Console.ReadKey();
        }

        public static void MetodoUn()
        {
            Console.WriteLine("Un metodo estatico da clase Program MetodoUn() executado");
        }

        public static void MetodoDous()
        {
            Console.WriteLine("Un metodo estatico da clase Program MetodoDous() executado");
        }
    }

    class ForaDoPrograma
    {
        public void MetodoTres()
        {
            Console.WriteLine("Unha metodo da instancia de clase ForaDoPrograma executase");
        }
    }
}
