﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceFizzBuzz.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IFizzBuzzServices")]
    public interface IFizzBuzzServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFizzBuzzServices/GetAll", ReplyAction="http://tempuri.org/IFizzBuzzServices/GetAllResponse")]
        System.Collections.Generic.List<FizzBuzzServiceLibrary.FizzBuzz> GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFizzBuzzServices/GetAll", ReplyAction="http://tempuri.org/IFizzBuzzServices/GetAllResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<FizzBuzzServiceLibrary.FizzBuzz>> GetAllAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFizzBuzzServicesChannel : WcfServiceFizzBuzz.ServiceReference1.IFizzBuzzServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FizzBuzzServicesClient : System.ServiceModel.ClientBase<WcfServiceFizzBuzz.ServiceReference1.IFizzBuzzServices>, WcfServiceFizzBuzz.ServiceReference1.IFizzBuzzServices {
        
        public FizzBuzzServicesClient() {
        }
        
        public FizzBuzzServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FizzBuzzServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FizzBuzzServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FizzBuzzServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<FizzBuzzServiceLibrary.FizzBuzz> GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<FizzBuzzServiceLibrary.FizzBuzz>> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
    }
}
