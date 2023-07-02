using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _8Task
{
    internal class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine(" just ate");
        }
    }
}
