using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
   abstract class Animal
    {
        
        public string AnimalName;
        public string Animalcategory;
        public string Animalfavoritefood;
        public string Animalplacetolive;
        public string Animalmovment;
        
       
        public virtual string describe()
        {

            return ( AnimalName + "//" + Animalcategory + "//" + Animalfavoritefood + "//" + Animalplacetolive + "//" + Animalmovment + "//");

        }
       
            


    }
}
