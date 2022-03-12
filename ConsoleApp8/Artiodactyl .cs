using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Artiodactyl : Animal
    {
        public Artiodactyl(string name, int drowth, double weight, string herbivorousomnivores) : base(name, drowth, weight)
        {
            HerbivorousOmnivores = herbivorousomnivores;
        }

        public Artiodactyl() { }

        public string HerbivorousOmnivores { get; set; }

        public override string ToString()
        {
            return $"Группа - Парнокопытное\n" +
                $"Имя животного - {Name}\n" +
                $"Рост - {Growth} см\n" +
                $"Вес - {Weight} кг\n" +
                $"Травоядные Всеядные животное - {HerbivorousOmnivores} \n";
        }
    }
}