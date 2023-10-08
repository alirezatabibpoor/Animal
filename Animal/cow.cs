using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class cow : Animal
    {
        public override string describe()
        {
            AnimalName = "cow";
            Animalcategory = "domestic ";
            Animalfavoritefood = "grass ";
            Animalplacetolive = "farm  "; 
            Animalmovment = "slow";
            return base.describe();
        }
    }
}
