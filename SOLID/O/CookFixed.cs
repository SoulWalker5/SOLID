using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O.Fixed
{
    class Cook
    {
        public string Name { get; set; }

        public Cook(string name)
        {
            this.Name = name;
        }

        public void MakeDinner(IMeal meal)
        {
            meal.Make();
        }
    }

    interface IMeal
    {
        void Make();
    }
    class RiceMeal : IMeal
    {
        public void Make()
        {
            Console.WriteLine("25 картошку");
            Console.WriteLine("Ведро доды");
            Console.WriteLine("Охапку дров");
            Console.WriteLine("Плов готово");
        }
    }
    class SaladMeal : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Нарезаем помидоры и огурцы");
            Console.WriteLine("Посыпаем зеленью, солью и специями");
            Console.WriteLine("Поливаем подсолнечным маслом");
            Console.WriteLine("Салат готов");
        }
    }
}
