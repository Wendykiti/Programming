using System;

namespace BlenderDecoratorStrategy
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Какой текстуры коктейль?");
            IMethodOfWhipping method = new HomogeneousСocktail();
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    method = new HomogeneousСocktail();
                    break;
                case 2:
                    method = new PorridgСocktail();
                    break;
                default:
                    break; 

            }
            IDoСoctails blender = new Blender("Bork Blender", method);
            //blender = new AddAlcohol(blender);
            //blender = new AddAlcohol(blender);
            //blender = new AddFrappe(blender);
            //blender.DoСoctails();
            method.MethodOfWhipping();
            Console.ReadKey();
        }
    }
}
