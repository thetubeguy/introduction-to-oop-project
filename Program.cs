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

            Pigeon pippa = new Pigeon("Pippa", "Grey");
            pippa.Speak();
            pippa.Fly();
            pippa.EatPizza();
            pippa.Sleep();
            pippa.Spin();
            pippa.DoTheCaterpillar();
            pippa.Jump();
            Penguin pingu = new Penguin("Pingu", "Black & White");
            pingu.Speak();
            pingu.Fly();
            pingu.Spin();
            pingu.DoTheCaterpillar();
            pingu.Jump();
            Parrot polly = new Parrot("Polly", "Green & Yellow");
            polly.Speak();
            polly.Fly();

        }
    }
}
