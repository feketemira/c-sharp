using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGC
{
    internal class Atlag: Engszi
    {
        public Atlag() {
            Random rnd = new Random();
            this.jokedv = rnd.Next(1, 100);
           
        }  
    }
}
