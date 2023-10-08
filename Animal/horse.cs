using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
     class horse : Animal
    {
        public override string describe()
        {
            AnimalName = "horse";
            Animalcategory = "domestic  ";
            Animalfavoritefood = "grass ";
            Animalplacetolive = "farm  ";
            Animalmovment = "fast";
            return base.describe();
        }
    }
}
