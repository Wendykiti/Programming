using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlenderDecoratorStrategy
{
    class HomogeneousСocktail : IMethodOfWhipping //однородная текстура коктейла
    {
        public void MethodOfWhipping() 
        {
            Console.WriteLine("Коктейль однородной тексутры");
        }
    }
}
