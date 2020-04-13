using ModelLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewLibrary.Args;

namespace ModelLibrary
{
    public class ImageData : IImageData, IPublisher, IImageManipulatorInject, IDisplayPublisher
    {
        /// <summary>
        /// PROPERTY which grants access to an image
        /// </summary>
        public Image image { get; private set; }

        public PictureBox pictureBox { get; private set; }

        private IImageManipulator _imgMan;

        // DECLARE EventHandler<EventArgs> called ThumbEvent
        private EventHandler<EventArgs> OnThumbEvent;

        private EventHandler<EventArgs> OnDisplayEvent;

        /// <summary>
        /// CONSTRUCTOR for ImageData
        /// </summary>
        public ImageData()
        {

        }

        #region IDisplayPublisher

        public void SubscribeDisplay(EventHandler<EventArgs> e)
        {
            OnDisplayEvent += e;
        }

        public void UnsubscribeDisplay(EventHandler<EventArgs> e)
        {
            OnDisplayEvent -= e;
        }
        #endregion

        #region IImageManipulatorInject
        /// <summary>
        /// METHOD: Inject, injects the ImageManipulator into the image data
        /// </summary>
        /// <param name="pImgMan"></param>
        public void Inject(IImageManipulator pImgMan)
        {
            _imgMan = pImgMan;
        }
        #endregion


        #region IPublisher

        /// <summary>
        /// METHOD: Subscribe, subscribes a listener to an event
        /// </summary>
        /// <param name="e"></param>
        public void Subscribe(EventHandler<EventArgs> e)
        {
            OnThumbEvent += e;
        }
        /// <summary>
        /// METHOD: Unsubscribe an event from a handler
        /// </summary>
        /// <param name="e"></param>
        public void Unsubscribe(EventHandler<EventArgs> e)
        {
            OnThumbEvent -= e;
        }
        #endregion

        #region IImageData
        /// <summary>
        /// METHOD: AddImage, a method which adds the image for this image data 
        /// </summary>
        /// <param name="pPb"></param>
        /// <param name="pImg"></param>
        public void AddImage(PictureBox pPb, Image pImg)
        {
            pictureBox = pPb;

            image = pImg;

            ThumbImage();
        }
        /// <summary>
        /// METHOD: A method which will be passed as a delegate, causes 
        /// an event to be published
        /// </summary>
        public void ThumbImage()
        {
            Size newSize = new Size(65, 65);

            image = _imgMan.ResizeImage(image, newSize);

            OnThumbnailEvent();
        }

        public void DisplaySize(Size pSize)
        {
            
            image = _imgMan.ResizeImage(image, pSize);

            OnDisplayImageEvent();
        }

        public void FlipImage()
        {
            image = _imgMan.FlipHImage(image);

            OnDisplayImageEvent();
        }
        #endregion

        #region PrivateMethods

        private void OnThumbnailEvent()
        {
            pictureBox.Image = image;

            pictureBox.Width = pictureBox.Image.Width;

            pictureBox.Height = pictureBox.Image.Height;

            ThumbEventArgs args = new ThumbEventArgs(pictureBox);

            OnThumbEvent(this, args);
        }

        private void OnDisplayImageEvent()
        {
            DisplayEventArgs args = new DisplayEventArgs(image);

            OnDisplayEvent(this, args);
        }
        #endregion
    }
}
