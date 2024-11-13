using AnimalsExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsExercise.BaseClass.BaseClass2.BaseClass3.Bats
{
    internal class Bat : Mammal , IHunt , IFly
    {
        public Bat (float weight) : base(weight)
        {

        }

        public void Move()
        {
            Console.WriteLine("Bat is moving!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bat makes sound!");

        }

        public void Hunt()
        {
            Console.WriteLine(GetType().Name + " is hunting on air!");
        }

        public void Fly()
        {
            Console.WriteLine(GetType().Name + " is flying!");
        }



    }
}
