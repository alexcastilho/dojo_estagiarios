﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace teste_webservice_consumidor.WebserviceTeste {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        private System.DateTime AnoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.DateTime Ano {
            get {
                return this.AnoField;
            }
            set {
                if ((this.AnoField.Equals(value) != true)) {
                    this.AnoField = value;
                    this.RaisePropertyChanged("Ano");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebserviceTeste.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        teste_webservice_consumidor.WebserviceTeste.HelloWorldResponse HelloWorld(teste_webservice_consumidor.WebserviceTeste.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<teste_webservice_consumidor.WebserviceTeste.HelloWorldResponse> HelloWorldAsync(teste_webservice_consumidor.WebserviceTeste.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name GetClienteResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCliente", ReplyAction="*")]
        teste_webservice_consumidor.WebserviceTeste.GetClienteResponse GetCliente(teste_webservice_consumidor.WebserviceTeste.GetClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<teste_webservice_consumidor.WebserviceTeste.GetClienteResponse> GetClienteAsync(teste_webservice_consumidor.WebserviceTeste.GetClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateCliente", ReplyAction="*")]
        void UpdateCliente(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateCliente", ReplyAction="*")]
        System.Threading.Tasks.Task UpdateClienteAsync(int id);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public teste_webservice_consumidor.WebserviceTeste.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(teste_webservice_consumidor.WebserviceTeste.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public teste_webservice_consumidor.WebserviceTeste.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(teste_webservice_consumidor.WebserviceTeste.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCliente", Namespace="http://tempuri.org/", Order=0)]
        public teste_webservice_consumidor.WebserviceTeste.GetClienteRequestBody Body;
        
        public GetClienteRequest() {
        }
        
        public GetClienteRequest(teste_webservice_consumidor.WebserviceTeste.GetClienteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetClienteRequestBody {
        
        public GetClienteRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetClienteResponse", Namespace="http://tempuri.org/", Order=0)]
        public teste_webservice_consumidor.WebserviceTeste.GetClienteResponseBody Body;
        
        public GetClienteResponse() {
        }
        
        public GetClienteResponse(teste_webservice_consumidor.WebserviceTeste.GetClienteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetClienteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public teste_webservice_consumidor.WebserviceTeste.Cliente[] GetClienteResult;
        
        public GetClienteResponseBody() {
        }
        
        public GetClienteResponseBody(teste_webservice_consumidor.WebserviceTeste.Cliente[] GetClienteResult) {
            this.GetClienteResult = GetClienteResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : teste_webservice_consumidor.WebserviceTeste.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<teste_webservice_consumidor.WebserviceTeste.WebServiceSoap>, teste_webservice_consumidor.WebserviceTeste.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        teste_webservice_consumidor.WebserviceTeste.HelloWorldResponse teste_webservice_consumidor.WebserviceTeste.WebServiceSoap.HelloWorld(teste_webservice_consumidor.WebserviceTeste.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            teste_webservice_consumidor.WebserviceTeste.HelloWorldRequest inValue = new teste_webservice_consumidor.WebserviceTeste.HelloWorldRequest();
            inValue.Body = new teste_webservice_consumidor.WebserviceTeste.HelloWorldRequestBody();
            teste_webservice_consumidor.WebserviceTeste.HelloWorldResponse retVal = ((teste_webservice_consumidor.WebserviceTeste.WebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<teste_webservice_consumidor.WebserviceTeste.HelloWorldResponse> teste_webservice_consumidor.WebserviceTeste.WebServiceSoap.HelloWorldAsync(teste_webservice_consumidor.WebserviceTeste.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<teste_webservice_consumidor.WebserviceTeste.HelloWorldResponse> HelloWorldAsync() {
            teste_webservice_consumidor.WebserviceTeste.HelloWorldRequest inValue = new teste_webservice_consumidor.WebserviceTeste.HelloWorldRequest();
            inValue.Body = new teste_webservice_consumidor.WebserviceTeste.HelloWorldRequestBody();
            return ((teste_webservice_consumidor.WebserviceTeste.WebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        teste_webservice_consumidor.WebserviceTeste.GetClienteResponse teste_webservice_consumidor.WebserviceTeste.WebServiceSoap.GetCliente(teste_webservice_consumidor.WebserviceTeste.GetClienteRequest request) {
            return base.Channel.GetCliente(request);
        }
        
        public teste_webservice_consumidor.WebserviceTeste.Cliente[] GetCliente() {
            teste_webservice_consumidor.WebserviceTeste.GetClienteRequest inValue = new teste_webservice_consumidor.WebserviceTeste.GetClienteRequest();
            inValue.Body = new teste_webservice_consumidor.WebserviceTeste.GetClienteRequestBody();
            teste_webservice_consumidor.WebserviceTeste.GetClienteResponse retVal = ((teste_webservice_consumidor.WebserviceTeste.WebServiceSoap)(this)).GetCliente(inValue);
            return retVal.Body.GetClienteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<teste_webservice_consumidor.WebserviceTeste.GetClienteResponse> teste_webservice_consumidor.WebserviceTeste.WebServiceSoap.GetClienteAsync(teste_webservice_consumidor.WebserviceTeste.GetClienteRequest request) {
            return base.Channel.GetClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<teste_webservice_consumidor.WebserviceTeste.GetClienteResponse> GetClienteAsync() {
            teste_webservice_consumidor.WebserviceTeste.GetClienteRequest inValue = new teste_webservice_consumidor.WebserviceTeste.GetClienteRequest();
            inValue.Body = new teste_webservice_consumidor.WebserviceTeste.GetClienteRequestBody();
            return ((teste_webservice_consumidor.WebserviceTeste.WebServiceSoap)(this)).GetClienteAsync(inValue);
        }
        
        public void UpdateCliente(int id) {
            base.Channel.UpdateCliente(id);
        }
        
        public System.Threading.Tasks.Task UpdateClienteAsync(int id) {
            return base.Channel.UpdateClienteAsync(id);
        }
    }
}
