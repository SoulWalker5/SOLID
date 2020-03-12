using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O
{
    class Cook
    {
        public string Name { get; set; }
        public Cook(string name)
        {
            this.Name = name;
        }

        public void MakeDinner()
        {
            Console.WriteLine("25 картошку");
            Console.WriteLine("Ведро доды");
            Console.WriteLine("Охапку дров");
            Console.WriteLine("Плов готово");
        }
    }
}
