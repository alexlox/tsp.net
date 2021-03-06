﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPhotos
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Filter", Namespace = "http://schemas.datacontract.org/2004/07/MyPhotos")]
    public partial class Filter : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "MyPhotosAPI.Property", Namespace = "http://schemas.datacontract.org/2004/07/MyPhotos")]
    public partial struct MyPhotosAPIProperty : System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string NameField;

        private string TypeField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
    }
}
namespace System.Drawing
{
    using System;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.SerializableAttribute()]
    public partial class Image : object, System.Runtime.Serialization.ISerializable
    {

        private System.Runtime.Serialization.SerializationInfo info;

        public Image(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            this.info = info;
        }

        public System.Runtime.Serialization.SerializationInfo SerializationInfo
        {
            get
            {
                return this.info;
            }
            set
            {
                this.info = value;
            }
        }

        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            if ((this.SerializationInfo == null))
            {
                return;
            }
            System.Runtime.Serialization.SerializationInfoEnumerator enumerator = this.SerializationInfo.GetEnumerator();
            for (
            ; enumerator.MoveNext();
            )
            {
                System.Runtime.Serialization.SerializationEntry entry = enumerator.Current;
                info.AddValue(entry.Name, entry.Value);
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IMyPhotos")]
public interface IMyPhotos
{

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMedia/GetPhotoVideoIds", ReplyAction = "http://tempuri.org/IMedia/GetPhotoVideoIdsResponse")]
    int[] GetPhotoVideoIds(MyPhotos.Filter[] filters);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMedia/GetPhotoVideoIds", ReplyAction = "http://tempuri.org/IMedia/GetPhotoVideoIdsResponse")]
    System.Threading.Tasks.Task<int[]> GetPhotoVideoIdsAsync(MyPhotos.Filter[] filters);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMedia/GetPhotoVideoImage", ReplyAction = "http://tempuri.org/IMedia/GetPhotoVideoImageResponse")]
    System.Drawing.Image GetPhotoVideoImage(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMedia/GetPhotoVideoImage", ReplyAction = "http://tempuri.org/IMedia/GetPhotoVideoImageResponse")]
    System.Threading.Tasks.Task<System.Drawing.Image> GetPhotoVideoImageAsync(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMedia/DeletePhotoVideo", ReplyAction = "http://tempuri.org/IMedia/DeletePhotoVideoResponse")]
    bool DeletePhotoVideo(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMedia/DeletePhotoVideo", ReplyAction = "http://tempuri.org/IMedia/DeletePhotoVideoResponse")]
    System.Threading.Tasks.Task<bool> DeletePhotoVideoAsync(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMedia/AddPhotoVideo", ReplyAction = "http://tempuri.org/IMedia/AddPhotoVideoResponse")]
    bool AddPhotoVideo(string path, string type);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMedia/AddPhotoVideo", ReplyAction = "http://tempuri.org/IMedia/AddPhotoVideoResponse")]
    System.Threading.Tasks.Task<bool> AddPhotoVideoAsync(string path, string type);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMedia/Export", ReplyAction = "http://tempuri.org/IMedia/ExportResponse")]
    bool Export(int[] ids);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMedia/Export", ReplyAction = "http://tempuri.org/IMedia/ExportResponse")]
    System.Threading.Tasks.Task<bool> ExportAsync(int[] ids);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMedia/SendEmail", ReplyAction = "http://tempuri.org/IMedia/SendEmailResponse")]
    bool SendEmail(int[] ids, string toAddress);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMedia/SendEmail", ReplyAction = "http://tempuri.org/IMedia/SendEmailResponse")]
    System.Threading.Tasks.Task<bool> SendEmailAsync(int[] ids, string toAddress);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMedia/PrintImage", ReplyAction = "http://tempuri.org/IMedia/PrintImageResponse")]
    bool PrintImage(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMedia/PrintImage", ReplyAction = "http://tempuri.org/IMedia/PrintImageResponse")]
    System.Threading.Tasks.Task<bool> PrintImageAsync(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMedia/GetAllProperties", ReplyAction = "http://tempuri.org/IMedia/GetAllPropertiesResponse")]
    MyPhotos.MyPhotosAPIProperty[] GetAllProperties();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMedia/GetAllProperties", ReplyAction = "http://tempuri.org/IMedia/GetAllPropertiesResponse")]
    System.Threading.Tasks.Task<MyPhotos.MyPhotosAPIProperty[]> GetAllPropertiesAsync();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICharacteristic/AddProperty", ReplyAction = "http://tempuri.org/ICharacteristic/AddPropertyResponse")]
    bool AddProperty(string propertyName, string propertyType);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICharacteristic/AddProperty", ReplyAction = "http://tempuri.org/ICharacteristic/AddPropertyResponse")]
    System.Threading.Tasks.Task<bool> AddPropertyAsync(string propertyName, string propertyType);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICharacteristic/ModifyProperty", ReplyAction = "http://tempuri.org/ICharacteristic/ModifyPropertyResponse")]
    bool ModifyProperty(int mediaId, string propertyName, string propertyValue);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICharacteristic/ModifyProperty", ReplyAction = "http://tempuri.org/ICharacteristic/ModifyPropertyResponse")]
    System.Threading.Tasks.Task<bool> ModifyPropertyAsync(int mediaId, string propertyName, string propertyValue);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICharacteristic/DeleteProperty", ReplyAction = "http://tempuri.org/ICharacteristic/DeletePropertyResponse")]
    bool DeleteProperty(string propertyName);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICharacteristic/DeleteProperty", ReplyAction = "http://tempuri.org/ICharacteristic/DeletePropertyResponse")]
    System.Threading.Tasks.Task<bool> DeletePropertyAsync(string propertyName);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IMyPhotosChannel : IMyPhotos, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class MyPhotosClient : System.ServiceModel.ClientBase<IMyPhotos>, IMyPhotos
{

    public MyPhotosClient()
    {
    }

    public MyPhotosClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
    {
    }

    public MyPhotosClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public MyPhotosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public MyPhotosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
    {
    }

    public int[] GetPhotoVideoIds(MyPhotos.Filter[] filters)
    {
        return base.Channel.GetPhotoVideoIds(filters);
    }

    public System.Threading.Tasks.Task<int[]> GetPhotoVideoIdsAsync(MyPhotos.Filter[] filters)
    {
        return base.Channel.GetPhotoVideoIdsAsync(filters);
    }

    public System.Drawing.Image GetPhotoVideoImage(int id)
    {
        return base.Channel.GetPhotoVideoImage(id);
    }

    public System.Threading.Tasks.Task<System.Drawing.Image> GetPhotoVideoImageAsync(int id)
    {
        return base.Channel.GetPhotoVideoImageAsync(id);
    }

    public bool DeletePhotoVideo(int id)
    {
        return base.Channel.DeletePhotoVideo(id);
    }

    public System.Threading.Tasks.Task<bool> DeletePhotoVideoAsync(int id)
    {
        return base.Channel.DeletePhotoVideoAsync(id);
    }

    public bool AddPhotoVideo(string path, string type)
    {
        return base.Channel.AddPhotoVideo(path, type);
    }

    public System.Threading.Tasks.Task<bool> AddPhotoVideoAsync(string path, string type)
    {
        return base.Channel.AddPhotoVideoAsync(path, type);
    }

    public bool Export(int[] ids)
    {
        return base.Channel.Export(ids);
    }

    public System.Threading.Tasks.Task<bool> ExportAsync(int[] ids)
    {
        return base.Channel.ExportAsync(ids);
    }

    public bool SendEmail(int[] ids, string toAddress)
    {
        return base.Channel.SendEmail(ids, toAddress);
    }

    public System.Threading.Tasks.Task<bool> SendEmailAsync(int[] ids, string toAddress)
    {
        return base.Channel.SendEmailAsync(ids, toAddress);
    }

    public bool PrintImage(int id)
    {
        return base.Channel.PrintImage(id);
    }

    public System.Threading.Tasks.Task<bool> PrintImageAsync(int id)
    {
        return base.Channel.PrintImageAsync(id);
    }

    public MyPhotos.MyPhotosAPIProperty[] GetAllProperties()
    {
        return base.Channel.GetAllProperties();
    }

    public System.Threading.Tasks.Task<MyPhotos.MyPhotosAPIProperty[]> GetAllPropertiesAsync()
    {
        return base.Channel.GetAllPropertiesAsync();
    }

    public bool AddProperty(string propertyName, string propertyType)
    {
        return base.Channel.AddProperty(propertyName, propertyType);
    }

    public System.Threading.Tasks.Task<bool> AddPropertyAsync(string propertyName, string propertyType)
    {
        return base.Channel.AddPropertyAsync(propertyName, propertyType);
    }

    public bool ModifyProperty(int mediaId, string propertyName, string propertyValue)
    {
        return base.Channel.ModifyProperty(mediaId, propertyName, propertyValue);
    }

    public System.Threading.Tasks.Task<bool> ModifyPropertyAsync(int mediaId, string propertyName, string propertyValue)
    {
        return base.Channel.ModifyPropertyAsync(mediaId, propertyName, propertyValue);
    }

    public bool DeleteProperty(string propertyName)
    {
        return base.Channel.DeleteProperty(propertyName);
    }

    public System.Threading.Tasks.Task<bool> DeletePropertyAsync(string propertyName)
    {
        return base.Channel.DeletePropertyAsync(propertyName);
    }
}
