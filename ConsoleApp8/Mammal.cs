using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Mammal : Animal
    {
        public Mammal(string name, int drowth, double weight, string warmblooded) : base(name, drowth, weight)
        {
            WarmBlooded = warmblooded;
        }

        public Mammal() { }

        public string WarmBlooded { get; set; }

        public override string ToString()
        {
            return $"Группа - Млекопитающее\n" +
                $"Имя животного - {Name}\n" +
                $"Рост - {Growth} см\n" +
                $"Вес - {Weight} кг\n" +
                $"Теплокровный - {WarmBlooded} \n";
        }
    }
}