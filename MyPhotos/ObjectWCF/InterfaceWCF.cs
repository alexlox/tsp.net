using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MyPhotos;

namespace ObjectWCF
{
    [ServiceContract]
    interface IMedia
    {
        [OperationContract]
        List<int> GetPhotoVideoIds(List<Filter> filters = null);
        [OperationContract]
        Image GetPhotoVideoImage(int id);
        [OperationContract]
        bool DeletePhotoVideo(int id);
        [OperationContract]
        bool AddPhotoVideo(string path, string type);
        [OperationContract]
        bool Export(List<int> ids);
        [OperationContract]
        bool SendEmail(List<int> ids, string toAddress);
        [OperationContract]
        bool PrintImage(int id);
        [OperationContract]
        List<MyPhotosAPI.Property> GetAllProperties();
    }

    [ServiceContract]
    interface ICharacteristic
    {
        [OperationContract]
        bool AddProperty(string propertyName, string propertyType);
        [OperationContract]
        bool ModifyProperty(int mediaId, string propertyName, string propertyValue);
        [OperationContract]
        bool DeleteProperty(string propertyName);
    }

    [ServiceContract]
    interface ICharValue
    {
    }

    [ServiceContract]
    interface IMyPhotos: IMedia, ICharacteristic, ICharValue
    {

    }
}
