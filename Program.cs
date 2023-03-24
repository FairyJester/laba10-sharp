
using System;
using System.Collections.Generic;

namespace laba10_sharp
{


    public class Car
    {
        public string CarName { set; get; }
    }

    public class Garege
    {
        public List<Car> garage = new List<Car>();
    }

    public class Washer
    {
        public delegate void WashCars(Car car);

        public WashCars washCars = new WashCars(wash);  

        public static void wash(Car car)
        {
            Console.WriteLine($" в автомойке ваш {car.CarName}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car Opel = new Car();
            Car Volvo = new Car();
            Car Nissan = new Car();

            Opel.CarName = "Opel Antara";
            Volvo.CarName = "Volvo s90";
            Nissan.CarName = "Nissan Juke";

            Garege garege = new Garege();
            garege.garage.Add(Opel);
            garege.garage.Add(Volvo);
            garege.garage.Add(Nissan);

            Washer washer = new Washer();

            foreach(var car in garege.garage)
            {
                washer.washCars(car);
            }
            Console.ReadLine();
        }
    }
}
