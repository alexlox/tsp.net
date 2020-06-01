using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Data.Entity;

namespace MyPhotos
{
    /**
     * <summary>Media API to manage photos and videos in computer.</summary>
     */
    public class MyPhotosAPI
    {
        /**
         * <summary>
         * The structure of an image/video property.
         * <para>The name can be any string. The type can be 'string', 'int', 'float', 'double', 'datetime'.</para>
         * </summary>
         */
        public struct Property
        {
            public string Name;
            public string Type;
        }

        /**
         * <summary>Retrieves a list of media model objects.</summary>
         * <param name="filters">A list of filters for the selected media objects.</param>
         * <returns>A list of media model objects.</returns>
         */
        public List<Media> GetMedia(List<Filter> filters = null)
        {
            using (MyPhotosModelContainer context = new MyPhotosModelContainer())
            {
                return context.Media.Include(m => m.Characteristics.Select(c => c.CharValues)).ToList();
            }
        }

        /**
         * <summary>Gets image object usable in windows forms from a media object.</summary>
         * <param name="media">A media object from which the image is retieved.</param>
         * <exception cref="OutOfMemoryException">The format is invalid. Thrown by Image.FromFile method.</exception>
         * <exception cref="FileNotFoundException">File not found. Thrown by Image.FromFile method.</exception>
         * <exception cref="ArgumentException">Filename is an uri. Thrown by Image.FromFile method.</exception>
         */
        protected Image GetImageFromMedia(Media media)
        {
            if (media is null)
            {
                throw new ArgumentNullException(nameof(media));
            }

            Image image;

            if (media.Type == "video")
            {
                image = Image.FromFile(media.AbsPath);
                return image;
            }

            // Image from video implementation here.

            Stream stream = Stream.Null; // To avoid error until video implementation is done.
            image = Image.FromStream(stream);

            return image;
        }

        /**
         * <summary>Deletes a media object.</summary>
         * <param name="media"></param>
         */
        protected void DeleteMedia(Media media)
        {

        }

        /**
         * <summary>Adds a new characteristic.</summary>
         * <param name="characteristic">Characteristic to be added.</param>
         */
        protected void AddCharacteristic(Characteristic characteristic)
        {

        }

        /**
         * <summary>Inserts or updates a characteristic value of a media object.</summary>
         * <param name="media">Media object</param>
         * <param name="characteristic">Characteristic</param>
         * <param name="charValue">Characteristic value</param>
         */
        protected void ModifyCharacteristic(Media media, Characteristic characteristic, CharValue charValue)
        {

        }

        /**
         * <summary>Deletes a characteristic and all its values.</summary>
         * <param name="characteristic">Characteristic to be deleted.</param>
         */
        protected void DeleteCharacteristic(Characteristic characteristic)
        {

        }

        /**
         * <summary>Adds a media object.</summary>
         * <param name="media">Media object to be added.</param>
         */
        protected void AddMedia(Media media)
        {

        }

        /**
         * <summary>Gets list of photos and videos ids.</summary>
         * <param name="filters">A list of filters for the selected media objects.</param>
         * <returns>List of integers.</returns>
         */
        public List<int> GetPhotoVideoIds(List<Filter> filters = null)
        {
            List<int> ids = new List<int>();
            return ids;
        }

        /**
         * <summary>Gets image object for windows forms.</summary>
         * <param name="id">Id of the image/photo</param>
         * <exception cref="FileNotFoundException">File not found.</exception>
         * <exception cref="ArgumentException">There is something wrong with the image/video.</exception>
         * <returns>Image that can be used for windows forms. Null if not found.</returns>
         */
        public Image GetPhotoVideoImage(int id)
        {
            try
            {
                Media media = new Media();
                return this.GetImageFromMedia(media);
            } catch (OutOfMemoryException e)
            {
                throw new ArgumentException("Format is probably invalid.", e);
            }
        }

        /**
         * <summary>Deletes an image/video.</summary>
         * <param name="id">Id of the image/video.</param>
         * <returns>False if object with this id does not exist.</returns>
         */
        public bool DeletePhotoVideo(int id)
        {
            return true;
        }

        /**
         * <summary>Adds a new propery to the database.</summary>
         * <param name="propertyName">Propery name</param>
         * <param name="propertyType">Property type (ex. string, int, float, double, datetime)</param>
         * <returns>False if property is already existing.</returns>
         */
        public bool AddProperty(string propertyName, string propertyType)
        {
            return true;
        }

        /**
         * <summary>Adds or updates a propery of an image/video.</summary>
         * <param name="mediaId">Id of the image/video</param>
         * <param name="propertyName">Property name</param>
         * <param name="propertyValue">Property value</param>
         * <returns>False if the operation fails. True otherwise.</returns>
         */
        public bool ModifyProperty(int mediaId, string propertyName, string propertyValue)
        {
            return true;
        }

        /**
         * <summary>Deletes a property with all its values.</summary>
         * <param name="propertyName">Property name</param>
         * <returns>False if property does not exist.</returns>
         */
        public bool DeleteProperty(string propertyName)
        {
            return true;
        }

        /**
         * <summary>Adds a new image/video.</summary>
         * <param name="path">The full absolute path to the object.</param>
         * <param name="type">Can be "image" or "video".</param>
         * <exception cref="ArgumentException">When the type is invalid.</exception>
         * <exception cref="FileNotFoundException">When the file to the path is not found.</exception>
         * <returns>False if the object is already added.</returns>
         */
        public bool AddPhotoVideo(string path, string type)
        {
            if (type != "image" && type != "video")
            {
                throw new ArgumentException("Type can be only 'image' or 'video'");
            }
            return true;
        }

        /**
         * <summary>Exports the results.</summary>
         * <param name="ids">List objects' ids to export.</param>
         * <returns>False in case of failure.</returns>
         */
        public bool Export(List<int> ids)
        {
            return true;
        }

        /**
         * <summary>Sends an email with objects information.</summary>
         * <param name="ids">A list of objects ids</param>
         * <param name="toAddress">The address to send to</param>
         * <returns>False in case of failure.</returns>
         */
        public bool SendEmail(List<int> ids, string toAddress)
        {
            return true;
        }

        /**
         * <summary>Sends a print request with the image given as parameter.</summary>
         * <param name="id">The id of the image</param>
         * <returns>False in case of failure.</returns>
         */
        public bool PrintImage(int id)
        {
            return true;
        }

        /**
         * <summary>Gets a list of all available properties.</summary>
         * <returns>List of type Property</returns>
         */
        public List<Property> GetAllProperties()
        {
            List<Property> properties = new List<Property>();
            return properties;
        }
    }
}
