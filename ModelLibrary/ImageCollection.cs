using ModelLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class ImageCollection : IImageCollection
    {
        // DECLARE a IDictionary<String, IImage> called _imgCollection
        private IDictionary<String, IImageData> _imgCollection;

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public ImageCollection()
        {
            _imgCollection = new Dictionary<String, IImageData>();
        }

        /// <summary>
        /// METHOD: AddImage, a method to add an image to the collection
        /// </summary>
        public void AddImage(IImageData i, String pKey)
        {

            _imgCollection.Add(pKey, i);
        }
    }
}
