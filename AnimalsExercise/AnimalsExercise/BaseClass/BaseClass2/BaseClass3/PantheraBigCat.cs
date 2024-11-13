using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AnimalsExercise.BaseClass.BaseClass2;

namespace AnimalsExercise.BaseClass.BaseClass2.BaseClass3
{
    internal abstract class PantheraBigCat : Mammal
    {
        public PantheraBigCat(float weight) : base(weight)
        {

        }
        public sealed override void MakeSound()
        {
            Console.WriteLine(GetType().Name + " roars!");
        }
    }
}
