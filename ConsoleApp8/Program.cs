using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Лев", 250, 225);
            Mammal mammal = new Mammal("Жираф ", 610, 1200, "Да");
            Artiodactyl artiodactyl = new Artiodactyl("Гну", 140, 250, "Да");
            Bird bird = new Bird("Снегирь", 18, 0.035, "Да");


            Console.WriteLine(animal.ToString());
            Console.WriteLine(mammal.ToString());
            Console.WriteLine(artiodactyl.ToString());
            Console.WriteLine(bird.ToString());

            Console.ReadKey();
        }
    }
}
