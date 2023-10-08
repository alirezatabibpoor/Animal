using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
     class roster_hen : Animal
    {
        public override string describe()
        {
           AnimalName = "roster & hen ";
            Animalcategory = "domestic ";
            Animalfavoritefood = "seed";
            Animalplacetolive = "farm";
            Animalmovment = "slow";
            return base.describe();
        }
    }
}
