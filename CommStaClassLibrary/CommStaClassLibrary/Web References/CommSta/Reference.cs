﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace CommStaClassLibrary.CommSta {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IService", Namespace="http://tempuri.org/")]
    public partial class BasicHttpBinding_IService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback VKontakte_StaOperationCompleted;
        
        private System.Threading.SendOrPostCallback VKontakte_Sta_ForNewOperationCompleted;
        
        private System.Threading.SendOrPostCallback OK_StaOperationCompleted;
        
        private System.Threading.SendOrPostCallback OK_Sta_ForNewOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public BasicHttpBinding_IService() {
            this.Url = global::CommStaClassLibrary.Properties.Settings.Default.CommStaClassLibrary_CommStaService_CommStaService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event VKontakte_StaCompletedEventHandler VKontakte_StaCompleted;
        
        /// <remarks/>
        public event VKontakte_Sta_ForNewCompletedEventHandler VKontakte_Sta_ForNewCompleted;
        
        /// <remarks/>
        public event OK_StaCompletedEventHandler OK_StaCompleted;
        
        /// <remarks/>
        public event OK_Sta_ForNewCompletedEventHandler OK_Sta_ForNewCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService/VKontakte_Sta", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void VKontakte_Sta() {
            this.Invoke("VKontakte_Sta", new object[0]);
        }
        
        /// <remarks/>
        public void VKontakte_StaAsync() {
            this.VKontakte_StaAsync(null);
        }
        
        /// <remarks/>
        public void VKontakte_StaAsync(object userState) {
            if ((this.VKontakte_StaOperationCompleted == null)) {
                this.VKontakte_StaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVKontakte_StaOperationCompleted);
            }
            this.InvokeAsync("VKontakte_Sta", new object[0], this.VKontakte_StaOperationCompleted, userState);
        }
        
        private void OnVKontakte_StaOperationCompleted(object arg) {
            if ((this.VKontakte_StaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VKontakte_StaCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService/VKontakte_Sta_ForNew", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void VKontakte_Sta_ForNew() {
            this.Invoke("VKontakte_Sta_ForNew", new object[0]);
        }
        
        /// <remarks/>
        public void VKontakte_Sta_ForNewAsync() {
            this.VKontakte_Sta_ForNewAsync(null);
        }
        
        /// <remarks/>
        public void VKontakte_Sta_ForNewAsync(object userState) {
            if ((this.VKontakte_Sta_ForNewOperationCompleted == null)) {
                this.VKontakte_Sta_ForNewOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVKontakte_Sta_ForNewOperationCompleted);
            }
            this.InvokeAsync("VKontakte_Sta_ForNew", new object[0], this.VKontakte_Sta_ForNewOperationCompleted, userState);
        }
        
        private void OnVKontakte_Sta_ForNewOperationCompleted(object arg) {
            if ((this.VKontakte_Sta_ForNewCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VKontakte_Sta_ForNewCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService/OK_Sta", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void OK_Sta() {
            this.Invoke("OK_Sta", new object[0]);
        }
        
        /// <remarks/>
        public void OK_StaAsync() {
            this.OK_StaAsync(null);
        }
        
        /// <remarks/>
        public void OK_StaAsync(object userState) {
            if ((this.OK_StaOperationCompleted == null)) {
                this.OK_StaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnOK_StaOperationCompleted);
            }
            this.InvokeAsync("OK_Sta", new object[0], this.OK_StaOperationCompleted, userState);
        }
        
        private void OnOK_StaOperationCompleted(object arg) {
            if ((this.OK_StaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.OK_StaCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService/OK_Sta_ForNew", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void OK_Sta_ForNew() {
            this.Invoke("OK_Sta_ForNew", new object[0]);
        }
        
        /// <remarks/>
        public void OK_Sta_ForNewAsync() {
            this.OK_Sta_ForNewAsync(null);
        }
        
        /// <remarks/>
        public void OK_Sta_ForNewAsync(object userState) {
            if ((this.OK_Sta_ForNewOperationCompleted == null)) {
                this.OK_Sta_ForNewOperationCompleted = new System.Threading.SendOrPostCallback(this.OnOK_Sta_ForNewOperationCompleted);
            }
            this.InvokeAsync("OK_Sta_ForNew", new object[0], this.OK_Sta_ForNewOperationCompleted, userState);
        }
        
        private void OnOK_Sta_ForNewOperationCompleted(object arg) {
            if ((this.OK_Sta_ForNewCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.OK_Sta_ForNewCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    // CODEGEN: The optional WSDL extension element 'PolicyReference' from namespace 'http://schemas.xmlsoap.org/ws/2004/09/policy' was not handled.
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpsBinding_IService", Namespace="http://tempuri.org/")]
    public partial class BasicHttpsBinding_IService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback VKontakte_StaOperationCompleted;
        
        private System.Threading.SendOrPostCallback VKontakte_Sta_ForNewOperationCompleted;
        
        private System.Threading.SendOrPostCallback OK_StaOperationCompleted;
        
        private System.Threading.SendOrPostCallback OK_Sta_ForNewOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public BasicHttpsBinding_IService() {
            this.Url = "https://major-comm.com/CommStaService.svc";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event VKontakte_StaCompletedEventHandler VKontakte_StaCompleted;
        
        /// <remarks/>
        public event VKontakte_Sta_ForNewCompletedEventHandler VKontakte_Sta_ForNewCompleted;
        
        /// <remarks/>
        public event OK_StaCompletedEventHandler OK_StaCompleted;
        
        /// <remarks/>
        public event OK_Sta_ForNewCompletedEventHandler OK_Sta_ForNewCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService/VKontakte_Sta", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void VKontakte_Sta() {
            this.Invoke("VKontakte_Sta", new object[0]);
        }
        
        /// <remarks/>
        public void VKontakte_StaAsync() {
            this.VKontakte_StaAsync(null);
        }
        
        /// <remarks/>
        public void VKontakte_StaAsync(object userState) {
            if ((this.VKontakte_StaOperationCompleted == null)) {
                this.VKontakte_StaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVKontakte_StaOperationCompleted);
            }
            this.InvokeAsync("VKontakte_Sta", new object[0], this.VKontakte_StaOperationCompleted, userState);
        }
        
        private void OnVKontakte_StaOperationCompleted(object arg) {
            if ((this.VKontakte_StaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VKontakte_StaCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService/VKontakte_Sta_ForNew", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void VKontakte_Sta_ForNew() {
            this.Invoke("VKontakte_Sta_ForNew", new object[0]);
        }
        
        /// <remarks/>
        public void VKontakte_Sta_ForNewAsync() {
            this.VKontakte_Sta_ForNewAsync(null);
        }
        
        /// <remarks/>
        public void VKontakte_Sta_ForNewAsync(object userState) {
            if ((this.VKontakte_Sta_ForNewOperationCompleted == null)) {
                this.VKontakte_Sta_ForNewOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVKontakte_Sta_ForNewOperationCompleted);
            }
            this.InvokeAsync("VKontakte_Sta_ForNew", new object[0], this.VKontakte_Sta_ForNewOperationCompleted, userState);
        }
        
        private void OnVKontakte_Sta_ForNewOperationCompleted(object arg) {
            if ((this.VKontakte_Sta_ForNewCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VKontakte_Sta_ForNewCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService/OK_Sta", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void OK_Sta() {
            this.Invoke("OK_Sta", new object[0]);
        }
        
        /// <remarks/>
        public void OK_StaAsync() {
            this.OK_StaAsync(null);
        }
        
        /// <remarks/>
        public void OK_StaAsync(object userState) {
            if ((this.OK_StaOperationCompleted == null)) {
                this.OK_StaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnOK_StaOperationCompleted);
            }
            this.InvokeAsync("OK_Sta", new object[0], this.OK_StaOperationCompleted, userState);
        }
        
        private void OnOK_StaOperationCompleted(object arg) {
            if ((this.OK_StaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.OK_StaCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService/OK_Sta_ForNew", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void OK_Sta_ForNew() {
            this.Invoke("OK_Sta_ForNew", new object[0]);
        }
        
        /// <remarks/>
        public void OK_Sta_ForNewAsync() {
            this.OK_Sta_ForNewAsync(null);
        }
        
        /// <remarks/>
        public void OK_Sta_ForNewAsync(object userState) {
            if ((this.OK_Sta_ForNewOperationCompleted == null)) {
                this.OK_Sta_ForNewOperationCompleted = new System.Threading.SendOrPostCallback(this.OnOK_Sta_ForNewOperationCompleted);
            }
            this.InvokeAsync("OK_Sta_ForNew", new object[0], this.OK_Sta_ForNewOperationCompleted, userState);
        }
        
        private void OnOK_Sta_ForNewOperationCompleted(object arg) {
            if ((this.OK_Sta_ForNewCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.OK_Sta_ForNewCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void VKontakte_StaCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void VKontakte_Sta_ForNewCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void OK_StaCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void OK_Sta_ForNewCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591