using System;

namespace Delegates6_CovarianzaConDelegatesNonGeneric
{
    class Program
    {
        public delegate Vehiculo DelegateMostrarTipoDeVehiculo();
        static void Main(string[] args)
        {
            Vehiculo vehiculo1 = new Vehiculo();
            Bus bus1 = new Bus();
            Console.WriteLine("***Covarianza en delegates(C# 2.0 en adiante)***");
            DelegateMostrarTipoDeVehiculo del1 = vehiculo1.MostrarVehiculo;
            del1();
            //Observa que esta esperando un Vehiculo(ex. un tipo base) pero recibiu un Bus(subtipo)
            //Inda asi isto permitese a traves da Covarianza
            DelegateMostrarTipoDeVehiculo del2 = bus1.MostrarVehiculo;
            del2(); //o programa funciona ben, porque anque o tipo de return do delegate e un Vehiculo, o seu obxeto del2 recibiu un obxeto "Bus" derivado
            Console.ReadKey();
        }
    }
        
    class Vehiculo
        {
            public Vehiculo MostrarVehiculo()
            {
                Vehiculo meuVehiculo = new Vehiculo();
                Console.WriteLine("Creado novo Vehiculo");
                return meuVehiculo;
            }
        }

    class Bus : Vehiculo
        {
            public Bus MostrarBus()
            {
                Bus meuBus = new Bus();
                Console.WriteLine("Creado un Bus");
                return meuBus;
            }
        }
}
