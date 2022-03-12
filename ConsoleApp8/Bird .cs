using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Bird : Animal
    {
        public Bird(string name, int drowth, double weight, string fly) : base(name, drowth, weight)
        {
            Fly = fly;
        }

        public Bird() { }

        public string Fly { get; set; }

        public override string ToString()
        {
            return $"Группа - Птиц\n" +
                $"Имя животного - {Name}\n" +
                $"Рост - {Growth} см\n" +
               $"Вес - {Weight} кг\n" +
               $"Летает - {Fly} \n";
        }
    }
}