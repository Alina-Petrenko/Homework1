using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Car : IComparable<Car>
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public int CompareTo(Car s)
        {
            if (s != null)
                return this.Speed.CompareTo(s.Speed);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }

    }
}

