using System;

namespace Delegates4
{
    delegate int MultiDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Caso de estudio con un delegate multicast cando poñemos como obxetivo metodos non void.***");
            // Target MetodoUn
            MultiDelegate multiDel = MetodoUn;
            //Target MetodoDous
            multiDel += MetodoDous;
            //Target MetodoTres
            multiDel += MetodoTres;
            int valorFinal = multiDel();
            Console.WriteLine("O valor final e {0}", valorFinal);
            //En metodos non void o valor final e o que se toma como referencia, e o que devolvera o valor, os metodos anteriores intermedios perdense
            //Ademais, se un dos metodos intermedios dese unha excepcion, o metodo final non se executa porque se interrumpe o programa
            Console.ReadKey();
        }

        public static int MetodoUn()
        {
            Console.WriteLine("Un metodo estatico da clase Program-MetodoUn() executado");
            return 1;
        }

        public static int MetodoDous()
        {
            Console.WriteLine("Un metodo estatico da clase Program-MetodoDous() executado");
            return 2;
        }

        public static int MetodoTres()
        {
            Console.WriteLine("Un metodo estatico da clase Program-MetodoTres() executado");
            return 3;
        }
    }
}
