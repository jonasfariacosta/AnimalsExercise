using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalsExercise.BaseClass.BaseClass2.BaseClass3;
using AnimalsExercise.Interfaces;

namespace AnimalsExercise.BaseClass.BaseClass2.BaseClass3.Birds
{
    internal class Penguin : Bird, IHunt , ISwim
    {
        public Penguin(float weight) : base(weight)
        {

        }
        public void Move()
        {
            Console.WriteLine("Penguin is moving!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Penguin makes sound!");

        }
        public void Hunt()
        {
            Console.WriteLine(GetType().Name + " is hunting on water!");
        }

        public void Swim()
        {
            Console.WriteLine("Penguin is swimming!");
        }
    }
}
