using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzServiceLibrary
{
    class TopeDemasiadoGrande : Exception {
        public TopeDemasiadoGrande()
        {
            Logger.warning("El numero es demasiado grande", 4);
        }
    }
    class ValorNulo : Exception { 
        public ValorNulo()
           
        {
            Logger.error("ValorNulo", 5);
        }

      
    }
}

