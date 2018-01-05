using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
namespace FizzBuzzServiceLibrary
{
    [DataContract(Namespace = "")]
    public class FizzBuzz
    {
        [DataMember]
        string Response;
        [DataMember]
        DateTime registro;
        public FizzBuzz( int i) {
            setResponse(i);        }

        public string getResponse()
        {
            return Response;
        }
       
        public void setResponse(int i) {
            if (i % 3 == 0 && i % 5 == 0) { Response = "FizzBuzz"; }
            else if (i % 3 == 0)
            { Response = "Fizz"; }
            else if (i % 5 == 0)
            {
                Response = "Buzz";
            }
            else Response = i.ToString();
            registro = DateTime.Now;
        }



    }
}
