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
    [ServiceContract]
   
    public interface  IFizzBuzzServices   {
        [WebGet(UriTemplate = "/fizzBuzz")]
      [WebInvoke( Method="GET",UriTemplate="/fizzBuzz",
           RequestFormat=WebMessageFormat.Json,
            ResponseFormat=WebMessageFormat.Json,
          BodyStyle =WebMessageBodyStyle.Wrapped)]
        [OperationContract]
        FizzBuzz[]  GetAll();
    }
}
