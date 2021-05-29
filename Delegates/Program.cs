using System;

namespace Delegates //Aos delegates defineselles como type safe function pointers, porque permiten conhecer se unha funcion e compatible cos parametros pasados tanto en compile time como runtime
{
    class Program
    {
        delegate int DelegateConDousParametrosIntReturnInt(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine("***Unha simple demo dun delegate.***"); 
            Console.WriteLine("\n Chamando a metodo Suma(..) sen usar un delegate:");
            Console.WriteLine("A suma de 10 e 20 = {0}", Suma(10, 20));

            //Creando unha instancia dun delegate
            //DelegateConDousParametrosIntReturnInt obDel = new DelegateConDousParametrosIntReturnInt(Suma);
            //ou simplemente escrito como sigue
            DelegateConDousParametrosIntReturnInt obDel = Suma;
            Console.WriteLine("\nChamando metodo Suma(..) usando un delegate.");
            int total = obDel(10, 20);
            Console.WriteLine("A suma de 10 e 20 = {0}", total);
            /* Forma alternativa de calcuar a suma de dous numeros. */          
            //obDel(25,75) e a abreviatura de obDel.Invoke(25,75)          
            Console.WriteLine("\nUsando o metodo Invoke() nunha instancia dun delegate, calculando a suma de 25 e 75.");
            total = obDel(25, 75);
            Console.WriteLine("A suma de 25 e 75 e = {0}", total);

            Console.ReadKey();
        }

        public static int Suma(int a,int b)
        {
            return a + b;
        }
    }
}
