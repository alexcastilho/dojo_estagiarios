﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATMStags.Web.SerasaWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SerasaWebService.SerasaSoap")]
    public interface SerasaSoap {
        
        // CODEGEN: Generating message contract since element name CPF from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ValidarCPF", ReplyAction="*")]
        ATMStags.Web.SerasaWebService.ValidarCPFResponse ValidarCPF(ATMStags.Web.SerasaWebService.ValidarCPFRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ValidarCPF", ReplyAction="*")]
        System.Threading.Tasks.Task<ATMStags.Web.SerasaWebService.ValidarCPFResponse> ValidarCPFAsync(ATMStags.Web.SerasaWebService.ValidarCPFRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidarCPFRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidarCPF", Namespace="http://tempuri.org/", Order=0)]
        public ATMStags.Web.SerasaWebService.ValidarCPFRequestBody Body;
        
        public ValidarCPFRequest() {
        }
        
        public ValidarCPFRequest(ATMStags.Web.SerasaWebService.ValidarCPFRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ValidarCPFRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CPF;
        
        public ValidarCPFRequestBody() {
        }
        
        public ValidarCPFRequestBody(string CPF) {
            this.CPF = CPF;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidarCPFResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidarCPFResponse", Namespace="http://tempuri.org/", Order=0)]
        public ATMStags.Web.SerasaWebService.ValidarCPFResponseBody Body;
        
        public ValidarCPFResponse() {
        }
        
        public ValidarCPFResponse(ATMStags.Web.SerasaWebService.ValidarCPFResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ValidarCPFResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ValidarCPFResult;
        
        public ValidarCPFResponseBody() {
        }
        
        public ValidarCPFResponseBody(bool ValidarCPFResult) {
            this.ValidarCPFResult = ValidarCPFResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SerasaSoapChannel : ATMStags.Web.SerasaWebService.SerasaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SerasaSoapClient : System.ServiceModel.ClientBase<ATMStags.Web.SerasaWebService.SerasaSoap>, ATMStags.Web.SerasaWebService.SerasaSoap {
        
        public SerasaSoapClient() {
        }
        
        public SerasaSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SerasaSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SerasaSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SerasaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ATMStags.Web.SerasaWebService.ValidarCPFResponse ATMStags.Web.SerasaWebService.SerasaSoap.ValidarCPF(ATMStags.Web.SerasaWebService.ValidarCPFRequest request) {
            return base.Channel.ValidarCPF(request);
        }
        
        public bool ValidarCPF(string CPF) {
            ATMStags.Web.SerasaWebService.ValidarCPFRequest inValue = new ATMStags.Web.SerasaWebService.ValidarCPFRequest();
            inValue.Body = new ATMStags.Web.SerasaWebService.ValidarCPFRequestBody();
            inValue.Body.CPF = CPF;
            ATMStags.Web.SerasaWebService.ValidarCPFResponse retVal = ((ATMStags.Web.SerasaWebService.SerasaSoap)(this)).ValidarCPF(inValue);
            return retVal.Body.ValidarCPFResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ATMStags.Web.SerasaWebService.ValidarCPFResponse> ATMStags.Web.SerasaWebService.SerasaSoap.ValidarCPFAsync(ATMStags.Web.SerasaWebService.ValidarCPFRequest request) {
            return base.Channel.ValidarCPFAsync(request);
        }
        
        public System.Threading.Tasks.Task<ATMStags.Web.SerasaWebService.ValidarCPFResponse> ValidarCPFAsync(string CPF) {
            ATMStags.Web.SerasaWebService.ValidarCPFRequest inValue = new ATMStags.Web.SerasaWebService.ValidarCPFRequest();
            inValue.Body = new ATMStags.Web.SerasaWebService.ValidarCPFRequestBody();
            inValue.Body.CPF = CPF;
            return ((ATMStags.Web.SerasaWebService.SerasaSoap)(this)).ValidarCPFAsync(inValue);
        }
    }
}
