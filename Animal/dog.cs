using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
     class dog : Animal
    {
        public override string describe()
        {
            AnimalName = "dog";
            Animalcategory = "domestic / wild  ";
            Animalfavoritefood = "meat / bones";
            Animalplacetolive = "city or jungle  ";
            Animalmovment = "fast";
            return base.describe();
        }

    }
}
