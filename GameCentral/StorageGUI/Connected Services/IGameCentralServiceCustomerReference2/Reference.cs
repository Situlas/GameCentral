﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StorageGUI.IGameCentralServiceCustomerReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int CVRk__BackingFieldField;
        
        private string Cityk__BackingFieldField;
        
        private bool CustomerTypek__BackingFieldField;
        
        private string Emailk__BackingFieldField;
        
        private string FNamek__BackingFieldField;
        
        private int Idk__BackingFieldField;
        
        private string LNamek__BackingFieldField;
        
        private int Phonek__BackingFieldField;
        
        private int ZipCodek__BackingFieldField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<CVR>k__BackingField", IsRequired=true)]
        public int CVRk__BackingField {
            get {
                return this.CVRk__BackingFieldField;
            }
            set {
                if ((this.CVRk__BackingFieldField.Equals(value) != true)) {
                    this.CVRk__BackingFieldField = value;
                    this.RaisePropertyChanged("CVRk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<City>k__BackingField", IsRequired=true)]
        public string Cityk__BackingField {
            get {
                return this.Cityk__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Cityk__BackingFieldField, value) != true)) {
                    this.Cityk__BackingFieldField = value;
                    this.RaisePropertyChanged("Cityk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<CustomerType>k__BackingField", IsRequired=true)]
        public bool CustomerTypek__BackingField {
            get {
                return this.CustomerTypek__BackingFieldField;
            }
            set {
                if ((this.CustomerTypek__BackingFieldField.Equals(value) != true)) {
                    this.CustomerTypek__BackingFieldField = value;
                    this.RaisePropertyChanged("CustomerTypek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Email>k__BackingField", IsRequired=true)]
        public string Emailk__BackingField {
            get {
                return this.Emailk__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Emailk__BackingFieldField, value) != true)) {
                    this.Emailk__BackingFieldField = value;
                    this.RaisePropertyChanged("Emailk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<FName>k__BackingField", IsRequired=true)]
        public string FNamek__BackingField {
            get {
                return this.FNamek__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.FNamek__BackingFieldField, value) != true)) {
                    this.FNamek__BackingFieldField = value;
                    this.RaisePropertyChanged("FNamek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Id>k__BackingField", IsRequired=true)]
        public int Idk__BackingField {
            get {
                return this.Idk__BackingFieldField;
            }
            set {
                if ((this.Idk__BackingFieldField.Equals(value) != true)) {
                    this.Idk__BackingFieldField = value;
                    this.RaisePropertyChanged("Idk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<LName>k__BackingField", IsRequired=true)]
        public string LNamek__BackingField {
            get {
                return this.LNamek__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.LNamek__BackingFieldField, value) != true)) {
                    this.LNamek__BackingFieldField = value;
                    this.RaisePropertyChanged("LNamek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Phone>k__BackingField", IsRequired=true)]
        public int Phonek__BackingField {
            get {
                return this.Phonek__BackingFieldField;
            }
            set {
                if ((this.Phonek__BackingFieldField.Equals(value) != true)) {
                    this.Phonek__BackingFieldField = value;
                    this.RaisePropertyChanged("Phonek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<ZipCode>k__BackingField", IsRequired=true)]
        public int ZipCodek__BackingField {
            get {
                return this.ZipCodek__BackingFieldField;
            }
            set {
                if ((this.ZipCodek__BackingFieldField.Equals(value) != true)) {
                    this.ZipCodek__BackingFieldField = value;
                    this.RaisePropertyChanged("ZipCodek__BackingField");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IGameCentralServiceCustomerReference2.IGameCentralServiceCustomer")]
    public interface IGameCentralServiceCustomer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameCentralServiceCustomer/Create", ReplyAction="http://tempuri.org/IGameCentralServiceCustomer/CreateResponse")]
        void Create(StorageGUI.IGameCentralServiceCustomerReference2.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameCentralServiceCustomer/Create", ReplyAction="http://tempuri.org/IGameCentralServiceCustomer/CreateResponse")]
        System.Threading.Tasks.Task CreateAsync(StorageGUI.IGameCentralServiceCustomerReference2.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameCentralServiceCustomer/Delete", ReplyAction="http://tempuri.org/IGameCentralServiceCustomer/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameCentralServiceCustomer/Delete", ReplyAction="http://tempuri.org/IGameCentralServiceCustomer/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameCentralServiceCustomer/Get", ReplyAction="http://tempuri.org/IGameCentralServiceCustomer/GetResponse")]
        StorageGUI.IGameCentralServiceCustomerReference2.Customer Get(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameCentralServiceCustomer/Get", ReplyAction="http://tempuri.org/IGameCentralServiceCustomer/GetResponse")]
        System.Threading.Tasks.Task<StorageGUI.IGameCentralServiceCustomerReference2.Customer> GetAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameCentralServiceCustomer/GetAll", ReplyAction="http://tempuri.org/IGameCentralServiceCustomer/GetAllResponse")]
        StorageGUI.IGameCentralServiceCustomerReference2.Customer[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameCentralServiceCustomer/GetAll", ReplyAction="http://tempuri.org/IGameCentralServiceCustomer/GetAllResponse")]
        System.Threading.Tasks.Task<StorageGUI.IGameCentralServiceCustomerReference2.Customer[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameCentralServiceCustomer/Update", ReplyAction="http://tempuri.org/IGameCentralServiceCustomer/UpdateResponse")]
        void Update(StorageGUI.IGameCentralServiceCustomerReference2.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameCentralServiceCustomer/Update", ReplyAction="http://tempuri.org/IGameCentralServiceCustomer/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(StorageGUI.IGameCentralServiceCustomerReference2.Customer customer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGameCentralServiceCustomerChannel : StorageGUI.IGameCentralServiceCustomerReference2.IGameCentralServiceCustomer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GameCentralServiceCustomerClient : System.ServiceModel.ClientBase<StorageGUI.IGameCentralServiceCustomerReference2.IGameCentralServiceCustomer>, StorageGUI.IGameCentralServiceCustomerReference2.IGameCentralServiceCustomer {
        
        public GameCentralServiceCustomerClient() {
        }
        
        public GameCentralServiceCustomerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GameCentralServiceCustomerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameCentralServiceCustomerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameCentralServiceCustomerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Create(StorageGUI.IGameCentralServiceCustomerReference2.Customer customer) {
            base.Channel.Create(customer);
        }
        
        public System.Threading.Tasks.Task CreateAsync(StorageGUI.IGameCentralServiceCustomerReference2.Customer customer) {
            return base.Channel.CreateAsync(customer);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        public StorageGUI.IGameCentralServiceCustomerReference2.Customer Get(int id) {
            return base.Channel.Get(id);
        }
        
        public System.Threading.Tasks.Task<StorageGUI.IGameCentralServiceCustomerReference2.Customer> GetAsync(int id) {
            return base.Channel.GetAsync(id);
        }
        
        public StorageGUI.IGameCentralServiceCustomerReference2.Customer[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<StorageGUI.IGameCentralServiceCustomerReference2.Customer[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public void Update(StorageGUI.IGameCentralServiceCustomerReference2.Customer customer) {
            base.Channel.Update(customer);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(StorageGUI.IGameCentralServiceCustomerReference2.Customer customer) {
            return base.Channel.UpdateAsync(customer);
        }
    }
}
