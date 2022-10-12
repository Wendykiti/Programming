using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlenderDecoratorStrategy
{
    sealed public class Barman
    {
        private static Barman barman = null;
        public static string Name { get; set; }
        public static IDoСoctails Blender { get; private set; }
        private Barman(string name, IDoСoctails blender)
        {
            Name = name;
            Blender = blender;
        }
        public static Barman GetBarman(string name, IDoСoctails blender) 
        {
            if (barman==null)
            {
                barman = new Barman(name, blender);
            }
            return barman;
        }
    }
}
