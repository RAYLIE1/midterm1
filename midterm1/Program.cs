using System;
using System.Collections.Generic;
using System.Linq;

class Car
{
    public string Brand { get; set; }
    public int Price { get; set; }

    public Car(string brand, int price)
    {
        Brand = brand;
        Price = price;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();
        cars.Add(new Car("Toyota", 1250000));
        cars.Add(new Car("Geely", 1300000));
        cars.Add(new Car("Honda", 1150000));
        cars.Add(new Car("Ford", 1400000));
        cars.Add(new Car("Nissan", 1050000));
        cars.Add(new Car("BMW", 1800000));
        cars.Add(new Car("Mercedes-Benz", 2000000));
        cars.Add(new Car("Chevrolet", 950000));
        cars.Add(new Car("Hyundai", 1100000));
        cars.Add(new Car("Kia", 1200000));

        var expensiveCars = from car in cars
                            where car.Price >= 1000000
                            select car;

        foreach (var carGroup in expensiveCars.GroupBy(car => car.Brand))
        {
            Console.WriteLine($"Cars of brand {carGroup.Key}:");
            foreach (var car in carGroup)
            {
                if (car.Price > 1200000)
                {
                    Console.WriteLine($"{car.Brand} - This belongs to class A car.");
                }
                else
                {
                    Console.WriteLine($"{car.Brand} - This belongs to class B car.");
                }
            }
            Console.WriteLine();
        }
    }
}
