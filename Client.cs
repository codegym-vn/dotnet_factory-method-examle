using System;

namespace DesignPattern_FactoryMethod
{
    class Client
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Console.WriteLine("Without Factory:");
            client.ViewToyota();
            client.ViewBMW();
            client.ViewAudi();
            Console.WriteLine("With Factory, please enter car type: ");
            CarFactory factory = new CarFactory();
            string carType = Console.ReadLine();
            factory.ViewCar(carType);
            Console.Read();
        }

        public void ViewToyota()
        {
            Toyota toyota = new Toyota();
            toyota.View();
        }

        public void ViewBMW()
        {
            BMW bMW = new BMW();
            bMW.View();
        }

        public void ViewAudi()
        {
            Audi audi =  new Audi();
            audi.View();
        }
    }

    interface ICar
    {
        public void View();
    }

    class Toyota : ICar
    {
        public void View()
        {
            Console.WriteLine("This is a Toyota car");
        }
    }

    class BMW : ICar
    {
        public void View()
        {
            Console.WriteLine("This is a BMW car");
        }
    }

    class Audi : ICar
    {
        public void View()
        {
            Console.WriteLine("This is an Audi car");
        }
    }

    class CarFactory
    {
        public void ViewCar(string CarType)
        {
            ICar car;
            switch (CarType)
            {
                case "Toyota": 
                    car = new Toyota();
                    car.View();
                    break;
                case "BMW":
                    car = new BMW();
                    car.View();
                    break;
                case "Audi":
                    car = new Audi();
                    car.View();
                    break;
                default:
                    Console.WriteLine("Car type not found");
                    break;
            }
        }
    }
}
