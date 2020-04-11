using MyPhotos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWCF
{
    public class MyPhotos : IMyPhotos
    {
        private MyPhotosAPI myPhotosAPI = new MyPhotosAPI();
        public bool AddPhotoVideo(string path, string type)
        {
            return myPhotosAPI.AddPhotoVideo(path, type);
        }

        public bool AddProperty(string propertyName, string propertyType)
        {
            return myPhotosAPI.AddProperty(propertyName, propertyType);
        }

        public bool DeletePhotoVideo(int id)
        {
            return myPhotosAPI.DeletePhotoVideo(id);
        }

        public bool DeleteProperty(string propertyName)
        {
            return myPhotosAPI.DeleteProperty(propertyName);
        }

        public bool Export(List<int> ids)
        {
            return myPhotosAPI.Export(ids);
        }

        public List<MyPhotosAPI.Property> GetAllProperties()
        {
            return myPhotosAPI.GetAllProperties();
        }

        public List<int> GetPhotoVideoIds(List<Filter> filters = null)
        {
            return myPhotosAPI.GetPhotoVideoIds(filters);
        }

        public Image GetPhotoVideoImage(int id)
        {
            return myPhotosAPI.GetPhotoVideoImage(id);
        }

        public bool ModifyProperty(int mediaId, string propertyName, string propertyValue)
        {
            return myPhotosAPI.ModifyProperty(mediaId, propertyName, propertyValue);
        }

        public bool PrintImage(int id)
        {
            return myPhotosAPI.PrintImage(id);
        }

        public bool SendEmail(List<int> ids, string toAddress)
        {
            return myPhotosAPI.SendEmail(ids, toAddress);
        }
    }
}
