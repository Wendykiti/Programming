using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlenderDecoratorStrategy
{
    class AddFrappe : IDoСoctails
    {
        public IDoСoctails Blender { get; set; }
        public AddFrappe(IDoСoctails blender)
        {
            Blender = blender;
        }
        public void DoСoctails()
        {
            Blender.DoСoctails();
            Console.WriteLine("Добавить лёд-фраппе");
        }
    }
}
