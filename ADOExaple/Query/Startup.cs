using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExaple.Query
{
    class Startup
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number of Cars : ");
            int TotalCar = Convert.ToInt32(Console.ReadLine());


            Car[] cars = new Car[TotalCar];//new Car()//

            for (int i = 0; i < TotalCar; i++)
            {
                Console.WriteLine("Enter the details of Car-{0}",(i+1));
                //int n = 10;
                Car car = new Car();
                car.SetData();
                //Console.Write("Model : ");
                //car.ModelNumber = Console.ReadLine();
                //Console.Write("Name : ");
                //car.Name = Console.ReadLine();
                //Console.Write("Car Type : ");
                //car.Type = Console.ReadLine();
                //Console.Write("No. Of Seat : ");
                //car.TotalSeat = Convert.ToInt32(Console.ReadLine());

                cars[i] = car;
               
            }

            Console.WriteLine("-------------Car Details--------------------");

            foreach (Car car in cars)
            {
                Console.WriteLine($"Model : {car.ModelNumber}  Name : {car.Name} " +
                    $" Type : {car.Type}  Seat : {car.TotalSeat}");
            }
        }
    }
}
