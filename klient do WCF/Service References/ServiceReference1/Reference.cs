﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace klient_do_WCF.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataContractIService1WelcomeHistory", Namespace="http://schemas.datacontract.org/2004/07/Wcfsimplelibrary")]
    [System.SerializableAttribute()]
    public partial class DataContractIService1WelcomeHistory : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AgentActionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AgentAction {
            get {
                return this.AgentActionField;
            }
            set {
                if ((this.AgentActionField.Equals(value) != true)) {
                    this.AgentActionField = value;
                    this.RaisePropertyChanged("AgentAction");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataContractIService1SendOrder", Namespace="http://schemas.datacontract.org/2004/07/Wcfsimplelibrary")]
    [System.SerializableAttribute()]
    public partial class DataContractIService1SendOrder : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdressinfomationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailclientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool FinishorderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ItemnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OptionsendField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Adressinfomation {
            get {
                return this.AdressinfomationField;
            }
            set {
                if ((object.ReferenceEquals(this.AdressinfomationField, value) != true)) {
                    this.AdressinfomationField = value;
                    this.RaisePropertyChanged("Adressinfomation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Clientname {
            get {
                return this.ClientnameField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientnameField, value) != true)) {
                    this.ClientnameField = value;
                    this.RaisePropertyChanged("Clientname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Emailclient {
            get {
                return this.EmailclientField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailclientField, value) != true)) {
                    this.EmailclientField = value;
                    this.RaisePropertyChanged("Emailclient");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Finishorder {
            get {
                return this.FinishorderField;
            }
            set {
                if ((this.FinishorderField.Equals(value) != true)) {
                    this.FinishorderField = value;
                    this.RaisePropertyChanged("Finishorder");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Itemname {
            get {
                return this.ItemnameField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemnameField, value) != true)) {
                    this.ItemnameField = value;
                    this.RaisePropertyChanged("Itemname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Optionsend {
            get {
                return this.OptionsendField;
            }
            set {
                if ((object.ReferenceEquals(this.OptionsendField, value) != true)) {
                    this.OptionsendField = value;
                    this.RaisePropertyChanged("Optionsend");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WelcomeHistory", ReplyAction="http://tempuri.org/IService1/WelcomeHistoryResponse")]
        string WelcomeHistory(klient_do_WCF.ServiceReference1.DataContractIService1WelcomeHistory ALL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WelcomeHistory", ReplyAction="http://tempuri.org/IService1/WelcomeHistoryResponse")]
        System.Threading.Tasks.Task<string> WelcomeHistoryAsync(klient_do_WCF.ServiceReference1.DataContractIService1WelcomeHistory ALL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DateReturn", ReplyAction="http://tempuri.org/IService1/DateReturnResponse")]
        string DateReturn();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DateReturn", ReplyAction="http://tempuri.org/IService1/DateReturnResponse")]
        System.Threading.Tasks.Task<string> DateReturnAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SendOrder", ReplyAction="http://tempuri.org/IService1/SendOrderResponse")]
        string SendOrder(klient_do_WCF.ServiceReference1.DataContractIService1SendOrder data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SendOrder", ReplyAction="http://tempuri.org/IService1/SendOrderResponse")]
        System.Threading.Tasks.Task<string> SendOrderAsync(klient_do_WCF.ServiceReference1.DataContractIService1SendOrder data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReadText", ReplyAction="http://tempuri.org/IService1/ReadTextResponse")]
        string ReadText();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReadText", ReplyAction="http://tempuri.org/IService1/ReadTextResponse")]
        System.Threading.Tasks.Task<string> ReadTextAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : klient_do_WCF.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<klient_do_WCF.ServiceReference1.IService1>, klient_do_WCF.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string WelcomeHistory(klient_do_WCF.ServiceReference1.DataContractIService1WelcomeHistory ALL) {
            return base.Channel.WelcomeHistory(ALL);
        }
        
        public System.Threading.Tasks.Task<string> WelcomeHistoryAsync(klient_do_WCF.ServiceReference1.DataContractIService1WelcomeHistory ALL) {
            return base.Channel.WelcomeHistoryAsync(ALL);
        }
        
        public string DateReturn() {
            return base.Channel.DateReturn();
        }
        
        public System.Threading.Tasks.Task<string> DateReturnAsync() {
            return base.Channel.DateReturnAsync();
        }
        
        public string SendOrder(klient_do_WCF.ServiceReference1.DataContractIService1SendOrder data) {
            return base.Channel.SendOrder(data);
        }
        
        public System.Threading.Tasks.Task<string> SendOrderAsync(klient_do_WCF.ServiceReference1.DataContractIService1SendOrder data) {
            return base.Channel.SendOrderAsync(data);
        }
        
        public string ReadText() {
            return base.Channel.ReadText();
        }
        
        public System.Threading.Tasks.Task<string> ReadTextAsync() {
            return base.Channel.ReadTextAsync();
        }
    }
}