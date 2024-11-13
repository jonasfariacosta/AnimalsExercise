using AnimalsExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsExercise.BaseClass.BaseClass2.BaseClass3.Birds
{
    internal class Goose : Bird , ISwim , IFly
    {
        public Goose(float weight) : base(weight)
        {

        }
        public void Move()
        {
            Console.WriteLine("Goose is moving!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Goose makes sound!");

        }
        public void Swim()
        {
            Console.WriteLine(GetType().Name + " is swimming!");
        }

        public void Fly()
        {
            Console.WriteLine(GetType().Name + " is flying!");
        }
    }
}
