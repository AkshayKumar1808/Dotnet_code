using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise
{
    internal class Tiger : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("in tiger eat");
        }
        public void Hunting()
        {
            Console.WriteLine("tiger has to hunting");
        }
    }
}
