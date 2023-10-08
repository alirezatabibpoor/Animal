using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class lion:Animal
    {
        public override string describe()
        {
            AnimalName = "lion";
            Animalcategory = "wild";
            Animalfavoritefood = "meat";
            Animalplacetolive = "jungle";
            Animalmovment = "fast ";
            return base.describe();
        }
    }
}
