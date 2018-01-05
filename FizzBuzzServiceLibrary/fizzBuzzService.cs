using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzServiceLibrary
{
    class FizzBuzzService: IFizzBuzzServices
    {
        Random rand = new Random();
        public FizzBuzz[] GetAll() {


         
            int tope = rand.Next(0,200);


            FizzBuzz[] fizzBuzzeds= new FizzBuzz[tope];
            try
            {
                if (tope > 200) throw new TopeDemasiadoGrande();
                if (fizzBuzzeds == null) throw new ValorNulo();
                for (int i = 0; i < tope; i++)
                    fizzBuzzeds[i] = new FizzBuzz(i);
                return fizzBuzzeds;
            }catch(Exception ex) { 
            

            
                Logger.error("Ha habido el error "+ex.Message, 5);
            return null;
            }
        }
    }

}

