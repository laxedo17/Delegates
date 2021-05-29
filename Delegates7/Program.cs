using System;

namespace Delegates7
{
    class Vehiculo
    {
        public void MostrarVehiculo(Vehiculo meuV)
        {
            Console.WriteLine("Chamamos a Vehiculo.MostrarVehiculo");
            Console.WriteLine("meuV.GetHashCode() e: {0}", meuV.GetHashCode());
        }
    }

    class Bus : Vehiculo
    {
        public void MostrarBus(Bus meuBus)
        {
            Console.WriteLine("Chamamos a Bus.MostrarBus");
            Console.WriteLine("meuBus.GetHashCode() e {0}", meuBus.GetHashCode());
        }
    }
    class Program
    {
        public delegate void TomandoDelegateDeParametroDeTipoDerivado(Bus v);
        static void Main(string[] args)
        {
            Vehiculo vehiculo1 = new Vehiculo();//ok
            Bus bus1 = new Bus();//ok
            Console.WriteLine("***Explorando Contravarianza con delegates de C#***");
            //Casos xerales
            TomandoDelegateDeParametroDeTipoDerivado del1 = bus1.MostrarBus;
            del1(bus1);

            //Caso especial
            //Contravarianza:
            /*Observa que o delegate espera un metodo que acepta un parametro de tipo obxeto Bus(derivado) pero inda asi apunta ao metodo que acepta un parametro de obxeto tipo Vehiculo(base) */
            TomandoDelegateDeParametroDeTipoDerivado del2 = vehiculo1.MostrarVehiculo;
            del2(bus1);
            //Nota adicional: non podes pasar un obxeto vehiculo aqui
            //del2(vehiculo1);//error
            Console.ReadKey();
        }
    }
}
