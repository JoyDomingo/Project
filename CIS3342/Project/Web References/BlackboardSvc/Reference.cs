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

namespace Project.BlackboardSvc {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BlackboardSoap", Namespace="http://tempuri.org/")]
    public partial class Blackboard : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback LoginOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddNewUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddNewStudentOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddNewProfessorOperationCompleted;
        
        private System.Threading.SendOrPostCallback StudentViewCourseOperationCompleted;
        
        private System.Threading.SendOrPostCallback ProfessorCoursesOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateCoursesOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateSectionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Blackboard() {
            this.Url = global::Project.Properties.Settings.Default.Project_BlackboardSvc_Blackboard;
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
        public event getNameCompletedEventHandler getNameCompleted;
        
        /// <remarks/>
        public event LoginCompletedEventHandler LoginCompleted;
        
        /// <remarks/>
        public event AddNewUserCompletedEventHandler AddNewUserCompleted;
        
        /// <remarks/>
        public event AddNewStudentCompletedEventHandler AddNewStudentCompleted;
        
        /// <remarks/>
        public event AddNewProfessorCompletedEventHandler AddNewProfessorCompleted;
        
        /// <remarks/>
        public event StudentViewCourseCompletedEventHandler StudentViewCourseCompleted;
        
        /// <remarks/>
        public event ProfessorCoursesCompletedEventHandler ProfessorCoursesCompleted;
        
        /// <remarks/>
        public event UpdateCoursesCompletedEventHandler UpdateCoursesCompleted;
        
        /// <remarks/>
        public event UpdateSectionCompletedEventHandler UpdateSectionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getName", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getName(int id) {
            object[] results = this.Invoke("getName", new object[] {
                        id});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getNameAsync(int id) {
            this.getNameAsync(id, null);
        }
        
        /// <remarks/>
        public void getNameAsync(int id, object userState) {
            if ((this.getNameOperationCompleted == null)) {
                this.getNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetNameOperationCompleted);
            }
            this.InvokeAsync("getName", new object[] {
                        id}, this.getNameOperationCompleted, userState);
        }
        
        private void OngetNameOperationCompleted(object arg) {
            if ((this.getNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getNameCompleted(this, new getNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Login", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Login(int userName, string password, string API) {
            object[] results = this.Invoke("Login", new object[] {
                        userName,
                        password,
                        API});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void LoginAsync(int userName, string password, string API) {
            this.LoginAsync(userName, password, API, null);
        }
        
        /// <remarks/>
        public void LoginAsync(int userName, string password, string API, object userState) {
            if ((this.LoginOperationCompleted == null)) {
                this.LoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginOperationCompleted);
            }
            this.InvokeAsync("Login", new object[] {
                        userName,
                        password,
                        API}, this.LoginOperationCompleted, userState);
        }
        
        private void OnLoginOperationCompleted(object arg) {
            if ((this.LoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginCompleted(this, new LoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddNewUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool AddNewUser(User newUser) {
            object[] results = this.Invoke("AddNewUser", new object[] {
                        newUser});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void AddNewUserAsync(User newUser) {
            this.AddNewUserAsync(newUser, null);
        }
        
        /// <remarks/>
        public void AddNewUserAsync(User newUser, object userState) {
            if ((this.AddNewUserOperationCompleted == null)) {
                this.AddNewUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddNewUserOperationCompleted);
            }
            this.InvokeAsync("AddNewUser", new object[] {
                        newUser}, this.AddNewUserOperationCompleted, userState);
        }
        
        private void OnAddNewUserOperationCompleted(object arg) {
            if ((this.AddNewUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddNewUserCompleted(this, new AddNewUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddNewStudent", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool AddNewStudent(Students newStudent) {
            object[] results = this.Invoke("AddNewStudent", new object[] {
                        newStudent});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void AddNewStudentAsync(Students newStudent) {
            this.AddNewStudentAsync(newStudent, null);
        }
        
        /// <remarks/>
        public void AddNewStudentAsync(Students newStudent, object userState) {
            if ((this.AddNewStudentOperationCompleted == null)) {
                this.AddNewStudentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddNewStudentOperationCompleted);
            }
            this.InvokeAsync("AddNewStudent", new object[] {
                        newStudent}, this.AddNewStudentOperationCompleted, userState);
        }
        
        private void OnAddNewStudentOperationCompleted(object arg) {
            if ((this.AddNewStudentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddNewStudentCompleted(this, new AddNewStudentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddNewProfessor", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool AddNewProfessor(Professor newProf) {
            object[] results = this.Invoke("AddNewProfessor", new object[] {
                        newProf});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void AddNewProfessorAsync(Professor newProf) {
            this.AddNewProfessorAsync(newProf, null);
        }
        
        /// <remarks/>
        public void AddNewProfessorAsync(Professor newProf, object userState) {
            if ((this.AddNewProfessorOperationCompleted == null)) {
                this.AddNewProfessorOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddNewProfessorOperationCompleted);
            }
            this.InvokeAsync("AddNewProfessor", new object[] {
                        newProf}, this.AddNewProfessorOperationCompleted, userState);
        }
        
        private void OnAddNewProfessorOperationCompleted(object arg) {
            if ((this.AddNewProfessorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddNewProfessorCompleted(this, new AddNewProfessorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/StudentViewCourse", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet StudentViewCourse(int id) {
            object[] results = this.Invoke("StudentViewCourse", new object[] {
                        id});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void StudentViewCourseAsync(int id) {
            this.StudentViewCourseAsync(id, null);
        }
        
        /// <remarks/>
        public void StudentViewCourseAsync(int id, object userState) {
            if ((this.StudentViewCourseOperationCompleted == null)) {
                this.StudentViewCourseOperationCompleted = new System.Threading.SendOrPostCallback(this.OnStudentViewCourseOperationCompleted);
            }
            this.InvokeAsync("StudentViewCourse", new object[] {
                        id}, this.StudentViewCourseOperationCompleted, userState);
        }
        
        private void OnStudentViewCourseOperationCompleted(object arg) {
            if ((this.StudentViewCourseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.StudentViewCourseCompleted(this, new StudentViewCourseCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ProfessorCourses", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet ProfessorCourses(int profId) {
            object[] results = this.Invoke("ProfessorCourses", new object[] {
                        profId});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void ProfessorCoursesAsync(int profId) {
            this.ProfessorCoursesAsync(profId, null);
        }
        
        /// <remarks/>
        public void ProfessorCoursesAsync(int profId, object userState) {
            if ((this.ProfessorCoursesOperationCompleted == null)) {
                this.ProfessorCoursesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnProfessorCoursesOperationCompleted);
            }
            this.InvokeAsync("ProfessorCourses", new object[] {
                        profId}, this.ProfessorCoursesOperationCompleted, userState);
        }
        
        private void OnProfessorCoursesOperationCompleted(object arg) {
            if ((this.ProfessorCoursesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ProfessorCoursesCompleted(this, new ProfessorCoursesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateCourses", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateCourses(int id, string name, string description, int credit) {
            this.Invoke("UpdateCourses", new object[] {
                        id,
                        name,
                        description,
                        credit});
        }
        
        /// <remarks/>
        public void UpdateCoursesAsync(int id, string name, string description, int credit) {
            this.UpdateCoursesAsync(id, name, description, credit, null);
        }
        
        /// <remarks/>
        public void UpdateCoursesAsync(int id, string name, string description, int credit, object userState) {
            if ((this.UpdateCoursesOperationCompleted == null)) {
                this.UpdateCoursesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateCoursesOperationCompleted);
            }
            this.InvokeAsync("UpdateCourses", new object[] {
                        id,
                        name,
                        description,
                        credit}, this.UpdateCoursesOperationCompleted, userState);
        }
        
        private void OnUpdateCoursesOperationCompleted(object arg) {
            if ((this.UpdateCoursesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateCoursesCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateSection", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateSection(int id, int number, string day, string hours) {
            this.Invoke("UpdateSection", new object[] {
                        id,
                        number,
                        day,
                        hours});
        }
        
        /// <remarks/>
        public void UpdateSectionAsync(int id, int number, string day, string hours) {
            this.UpdateSectionAsync(id, number, day, hours, null);
        }
        
        /// <remarks/>
        public void UpdateSectionAsync(int id, int number, string day, string hours, object userState) {
            if ((this.UpdateSectionOperationCompleted == null)) {
                this.UpdateSectionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateSectionOperationCompleted);
            }
            this.InvokeAsync("UpdateSection", new object[] {
                        id,
                        number,
                        day,
                        hours}, this.UpdateSectionOperationCompleted, userState);
        }
        
        private void OnUpdateSectionOperationCompleted(object arg) {
            if ((this.UpdateSectionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateSectionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class User {
        
        private int userIDField;
        
        private string userFirstNameField;
        
        private string userLastNameField;
        
        private string userEmailField;
        
        private string userpasswordField;
        
        private string userTypeField;
        
        /// <remarks/>
        public int userID {
            get {
                return this.userIDField;
            }
            set {
                this.userIDField = value;
            }
        }
        
        /// <remarks/>
        public string UserFirstName {
            get {
                return this.userFirstNameField;
            }
            set {
                this.userFirstNameField = value;
            }
        }
        
        /// <remarks/>
        public string userLastName {
            get {
                return this.userLastNameField;
            }
            set {
                this.userLastNameField = value;
            }
        }
        
        /// <remarks/>
        public string userEmail {
            get {
                return this.userEmailField;
            }
            set {
                this.userEmailField = value;
            }
        }
        
        /// <remarks/>
        public string Userpassword {
            get {
                return this.userpasswordField;
            }
            set {
                this.userpasswordField = value;
            }
        }
        
        /// <remarks/>
        public string userType {
            get {
                return this.userTypeField;
            }
            set {
                this.userTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Professor {
        
        private int profIdField;
        
        private string profDepartmentField;
        
        /// <remarks/>
        public int ProfId {
            get {
                return this.profIdField;
            }
            set {
                this.profIdField = value;
            }
        }
        
        /// <remarks/>
        public string ProfDepartment {
            get {
                return this.profDepartmentField;
            }
            set {
                this.profDepartmentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Students {
        
        private int studentIDField;
        
        private int studentGradYearField;
        
        /// <remarks/>
        public int StudentID {
            get {
                return this.studentIDField;
            }
            set {
                this.studentIDField = value;
            }
        }
        
        /// <remarks/>
        public int StudentGradYear {
            get {
                return this.studentGradYearField;
            }
            set {
                this.studentGradYearField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void getNameCompletedEventHandler(object sender, getNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void LoginCompletedEventHandler(object sender, LoginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void AddNewUserCompletedEventHandler(object sender, AddNewUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddNewUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddNewUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void AddNewStudentCompletedEventHandler(object sender, AddNewStudentCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddNewStudentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddNewStudentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void AddNewProfessorCompletedEventHandler(object sender, AddNewProfessorCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddNewProfessorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddNewProfessorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void StudentViewCourseCompletedEventHandler(object sender, StudentViewCourseCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class StudentViewCourseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal StudentViewCourseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void ProfessorCoursesCompletedEventHandler(object sender, ProfessorCoursesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ProfessorCoursesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ProfessorCoursesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void UpdateCoursesCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void UpdateSectionCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591