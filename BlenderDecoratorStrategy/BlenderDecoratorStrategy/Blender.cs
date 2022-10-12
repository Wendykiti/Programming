using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlenderDecoratorStrategy
{
    public class Blender : IDoСoctails
    {

        public string Name { get; set; }
        public IMethodOfWhipping MethodOfWhipping { get; set; }
        public Blender(string name, IMethodOfWhipping methodOfWhipping)
        {
            Name = name;

        }

        public void DoСoctails()
        {
            MethodOfWhipping = MethodOfWhipping;
            Console.WriteLine("Какой текстуры коктейл?");

        }
    }

}
