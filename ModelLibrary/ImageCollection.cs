using ModelLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLibrary;
using ViewLibrary.Args;
using ViewLibrary.Interfaces;

namespace ModelLibrary
{
    /// <summary>
    /// AUTHOR: Harry Jones 
    /// VERSION: 1 
    /// DESCRIPTION: The purpose of this class is to store a collection of classes containing
    /// data about Images and to pass on relevant data from these classes
    /// </summary>
    public class ImageCollection : IImageCollection
    {
        // DECLARE a IDictionary<String, IImage> called _imgCollection
        private IDictionary<String, IImageData> _imgCollection;
        // DECLARE a DisplayViewDelgate called _newDisplay
        private DisplayViewDelegate _newDisplay;

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public ImageCollection(DisplayViewDelegate pDvD)
        {
            // SET the DisplayViewDelegate in this class
            // to the DisplayViewDelegate passed into the constructor
            _newDisplay = pDvD;
            // INITIALISE the Dictionary being used to contain the data 
            _imgCollection = new Dictionary<String, IImageData>();
        }

        #region IImageCollection
        /// <summary>
        /// METHOD: AddImage, a method to add an image to the collection
        /// </summary>
        public void AddImage(IImageData i, String pKey)
        {
            // ADD the IImageData to the collection with the key
            _imgCollection.Add(pKey, i);
        }
        /// <summary>
        /// METHOD: RetrieveImageData, retrieves an images data
        /// </summary>
        /// <param name="pKey"> the key of the image to find</param>
        public IImageData RetrieveImageData(String pKey)
        {
            // RETURN the IImageData found at the key passed in
            return _imgCollection[pKey];
        }
        /// <summary>
        /// METHOD: DoubleClick, a method which is used to handle the double click of
        /// a thumbnail
        /// </summary>
        /// <param name="pSource"></param>
        /// <param name="pArgs"></param>
        public void DoubleClick(object pSource, EventArgs pArgs)
        {
            // INSTANTIATE an IImageData as the return value of the dictionary at the 
            // key found in the source cast as an ICustomPictureBox
            IImageData i = RetrieveImageData((pSource as ICustomPictureBox).imgKey);
            // INSTANTIATE a new InitialiseData as a new InitialiseData
            // passing in the delegates found in the local IImageData variable
            InitialiseData args = new InitialiseData(i.FlipImageH, i.DisplaySize,
                        i.FlipImageV, i.RotateCW, 
                        i.RotateACW, i.SaveImage, (pSource as ICustomPictureBox).imgKey);

            // CALL _newDisplay delegate, passing in this and the agrs
            _newDisplay(this, args);
        }

        /// <summary>
        /// METHOD: SubscribeDisplay, a method which subscribes a display event handler method
        /// to a specific IImageData in the dictionary
        /// </summary>
        /// <param name="pArgs"></param>
        /// <param name="pKey"></param>
        public void SubscribeDisplay(EventHandler<EventArgs> pArgs, String pKey)
        {
            // CAST the IImageData found at the key passedin and Subscribe the 
            // the EventHandler passed into this method
            (_imgCollection[pKey] as IDisplayPublisher).SubscribeDisplay(pArgs);
        }
        #endregion



    }
}
