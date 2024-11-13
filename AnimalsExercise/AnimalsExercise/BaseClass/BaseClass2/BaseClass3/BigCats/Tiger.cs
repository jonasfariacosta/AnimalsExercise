using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AnimalsExercise.BaseClass.BaseClass2.BaseClass3;
using AnimalsExercise.Interfaces;

namespace AnimalsExercise.BaseClass.BaseClass2.BaseClass3.BigCats
{
    internal class Tiger : PantheraBigCat, IHunt
    {
        public Tiger(float weight) : base(weight)
        {

        }
        public void Move()
        {
            Console.WriteLine("Tiger is moving");
        }

        public void Hunt()
        {
            Console.WriteLine(GetType().Name + " is hunting on land!");
        }


        /* public override void MakeSound()
         {
             Console.WriteLine("Tiger makes sound");
         }
        */
    }
}
