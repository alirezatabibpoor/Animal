using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
     class cat:Animal 

    {
        public override string describe()

        {
            AnimalName = "cat";
            Animalcategory = "domestic ";
            Animalfavoritefood = "meat";
            Animalplacetolive = "city or jungle ";
            Animalmovment = "fast";
            return base.describe(); 
        }





    }
}
