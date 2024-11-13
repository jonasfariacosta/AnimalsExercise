using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsExercise.Interfaces
{
    [Obsolete("Use IFly, IHunt or ISwim.", true)]
    internal interface IMove
    {
        void Move();
    }
}
