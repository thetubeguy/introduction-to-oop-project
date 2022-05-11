using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduction_to_oop_project
{
    public class Program 
    {
        static void Main(string[] args)
        {

            Bird myBird = new Bird("Tweety", "Yellow");
            myBird.Speak();
            myBird.Fly();

            Pigeon pippa = new Pigeon("Pippa", "Grey");
            pippa.Speak();
            pippa.Fly();
            pippa.EatPizza();
            pippa.Sleep();

        }
    }
}
