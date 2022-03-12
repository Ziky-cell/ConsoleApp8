using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Animal
    {
        public Animal(string name, int growth, double weight)
        {
            Name = name;
            Growth = growth;
            Weight = weight;
        }

        public Animal() { }

        public string Name { get; set; }
        public int Growth { get; set; }
        public double Weight { get; set; }

        public override string ToString()
        {
            return $"Группа - Животные\n" +
                $"Имя животного - {Name}\n" +
                $"Рост - {Growth} см\n" +
                $"Вес - {Weight} кг\n";
        }
    }
}
