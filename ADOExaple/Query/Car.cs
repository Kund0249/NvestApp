using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExaple.Query
{
    class Car
    {
        public string ModelNumber;
        public string Name;
        public string Type;
        public int TotalSeat;

        public void SetData()
        {
            Console.Write("Model : ");
            ModelNumber = Console.ReadLine();
            Console.Write("Name : ");
            Name = Console.ReadLine();
            Console.Write("Car Type : ");
            Type = Console.ReadLine();
            Console.Write("No. Of Seat : ");
            TotalSeat = Convert.ToInt32(Console.ReadLine());
        }
    }
}
