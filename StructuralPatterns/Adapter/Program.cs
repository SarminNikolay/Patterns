using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();
            Auto auto = new Auto();
            driver.Travel(auto);
            Camel camel = new Camel();
            ITransport camelTransport = new CamelToTransportAdapter(camel);
            driver.Travel(camelTransport);

            Console.ReadKey();
        }
    }

    interface ITransport
    {
        void Drive();
    }

    class Auto : ITransport
    {
        public void Drive()
        {
            System.Console.WriteLine("Машина едет по дороге");
        }
    }

    class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }

    interface IAnimal
    {
        void Move();
    }

    class Camel : IAnimal
    {
        public void Move()
        {
            System.Console.WriteLine("Верблюд идет по пескам пустыни");
        }
    }

    class CamelToTransportAdapter : ITransport
    {
        Camel camel;

        public CamelToTransportAdapter(Camel c)
        {
            camel = c;
        }

        public void Drive()
        {
            camel.Move();
        }
    }
}
