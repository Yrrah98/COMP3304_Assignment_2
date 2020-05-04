using ModelLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewLibrary;
using ViewLibrary.Args;
using ViewLibrary.Interfaces;

namespace ModelLibrary
{
    /// <summary>
    /// AUTHOR: Harry Jones 
    /// VERSION: 1 
    /// DESCRIPTION: This class is where a lot of the systems functionality comes from
    /// the purpose of this class is to store the image and it possesses methods 
    /// which call for the image to be manipulated. The relevant subscriber is then notified of
    /// the changes to the image through events. 
    /// </summary>
    public class ImageData : IImageData, IPublisher, 
        IImageManipulatorInject, IDisplayPublisher
    {
        /// <summary>
        /// PROPERTY which grants access to an image
        /// </summary>
        public Image image { get; private set; }
        // DECLARE an Image property, private. called currImg, stores the current state of the image
        private Image currImg { get; set; }
        // DECLARE a PictureBox property, public get private set called pictureBox
        public PictureBox pictureBox { get; private set; }
        // DECLARE an IImageManipulator called _imgMan
        private IImageManipulator _imgMan;
        // DECLARE EventHandler<EventArgs> called ThumbEvent
        private EventHandler<EventArgs> OnThumbEvent;
        // DECLARE EventHandler<EventArgs> called OnDisplayEvent
        private EventHandler<EventArgs> OnDisplayEvent;

        #region ImageManipulation Variables - individual image data
        // DECLARE a bool called flippedH, stores whether the 
        // img has been flipped horizontally
        private bool flippedH = false;
        // DECLARE a bool called flippedV, same as flippedH 
        // but vertical orientation
        private bool flippedV = false;
        // DECLARE a float called _rotate
        // stores the angle to rotate the image by
        private float _rotate = 45f;

        private Size currentPbSize;
        #endregion

        /// <summary>
        /// CONSTRUCTOR for ImageData
        /// </summary>
        public ImageData()
        {
        }

        #region IDisplayPublisher

        public void SubscribeDisplay(EventHandler<EventArgs> e)
        {
            // ADD event handler to the OnDisplayEvent
            OnDisplayEvent += e;
        }

        public void UnsubscribeDisplay(EventHandler<EventArgs> e)
        {
            // REMOVE the event handler from the OnDisplayEvent
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
            // SET imageManipulator in this class
            // to the image manipulator passed in
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
        /// METHOD: SaveImage, saves the current image to a specified file path
        /// </summary>
        public void SaveImage()
        {
            // DECLARE a new SaveFileDialog as a new SaveFileDialog
            SaveFileDialog saveFile = new SaveFileDialog();
            // SET the save file filter to the image formats you would like to
            // save the image as
            saveFile.Filter = "Images|*.png;*.bmp;*.jpg";
            // DECLARE a new ImageFormat and instantiate it to
            // ImageFormat.Bmp
            ImageFormat format = ImageFormat.Bmp;
            // IF the saveFile dialog is open
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                // THEN 
                // CALL to currImg.Save method, passing in the file name typed in
                // and the desired format as a parameter
                currImg.Save(saveFile.FileName, format);
            }
            // DISPOSE of the SaveFIleDialog
            saveFile.Dispose();
            
        }
        /// <summary>
        /// METHOD: AddImage, a method which adds the image for this image data 
        /// </summary>
        /// <param name="pPb"></param>
        /// <param name="pImg"></param>
        public void AddImage(PictureBox pPb, Image pImg)
        {
            // SET pictureBox to picture box parameter passed in
            pictureBox = pPb;
            // SET image parameter to image passed in
            image = pImg;
            // SET currImage to the image 
            currImg = image;
            // CALL to ThumbImage method
            ThumbImage();
        }
        /// <summary>
        /// METHOD: A method which will be passed as a delegate, causes 
        /// an event to be published
        /// </summary>
        public void ThumbImage()
        {
            // DECLARE the thumbnail size desired
            Size newSize = new Size(65, 65);
            // DECLARE a new Image and set its value
            // to the return value of the image manipulators ResizeImage method
            // passing in the image and the size
            Image img = _imgMan.ResizeImage(image, newSize);
            // CALL to OnThumbnailEvent method, passing in the local image 
            OnThumbnailEvent(img);
        }
        /// <summary>
        /// METHOD: DisplaySize a method which is used to change the display size of an image
        /// </summary>
        /// <param name="pSize"></param>
        public void DisplaySize(Size pSize)
        {
            // SET currImg value to return value of image manipulator ResizeImage
            // pass in image and size passed in as parameter
            image = _imgMan.ResizeImage(currImg, pSize);
            // CALL to OnDisplayEvent method passing in currImg
            OnDisplayImageEvent(image);
        }
        /// <summary>
        /// METHOD: RotateCW, a method which calls the necessary methods to rotate 
        /// the image Clockwise
        /// </summary>
        public void RotateCW()
        {
            // SET currImg value to return value of image manipulator RotateImageCW
            // pass in image and rotation passed in as parameter
            currImg = _imgMan.RotateImage(image, _rotate);
            // CALL to CircularRotate so the value of the rotation doesn't get
            // continually large
            CircularRotate();
            // CALL to OnDisplayImageEvent method passing in the currImg
            OnDisplayImageEvent(currImg);
        }
        /// <summary>
        /// METHOD: RotateACW, a method which calls necessary methods 
        /// to rotate the image Anti-Clockwise
        /// </summary>
        public void RotateACW()
        {
            // SET currImg value to return value of image manipulator RotateImageCW
            // pass in image and rotation passed in as parameter
            currImg = _imgMan.RotateImage(image, -_rotate);
            // CALL to CircularRotate so the value of the rotation doesn't get
            // continually smaller
            CircularRotate();
            // CALL to OnDisplayImageEvent passing in currImg
            OnDisplayImageEvent(currImg);
        }
        /// <summary>
        /// METHOD: FlipImageV, a method which makes the necessary method calls 
        /// to flip an image vertically
        /// </summary>
        public void FlipImageV()
        {
            // SET currImg to returned value of image manipulator FlipVImage method
            // passing in the image and flippedV variable
            currImg = _imgMan.FlipVImage(image, flippedV);
            // INVERT the value of the flippedV bool
            // so next time this is called it flips back
            flippedV = !flippedV;
            // CALL to OnDisplayImageEvent, passing in current image
            OnDisplayImageEvent(currImg);
        }
        /// <summary>
        /// METHOD: FlipImageh, a method which makes the necessary calls to 
        /// flip an image horizontally
        /// </summary>
        public void FlipImageH()
        {
            // SET currImg to returned value of image manipulator FlipHImage method
            // passing in the image and flippedH variable
            currImg = _imgMan.FlipHImage(image, flippedH);
            // INVERT the value of the flippedH bool
            // so next time this method is called it flips back
            flippedH = !flippedH;
            // CALL to OnDisplayImageEvent, passing in currImg as parameter
            OnDisplayImageEvent(currImg);
        }
        #endregion

        #region PrivateMethods
        /// <summary>
        /// METHOD: OnThumbnailEvent, makes a new ThumbEventArgs and calls event handler
        /// </summary>
        /// <param name="pImg">the image which is going to be display</param>
        private void OnThumbnailEvent(Image pImg)
        {
            // SET pictureBox image to the image passed in
            pictureBox.Image = pImg;
            // SET the pictureBox width and height to the 
            // images width and height respectively
            pictureBox.Width = pictureBox.Image.Width;
            // ^^
            pictureBox.Height = pictureBox.Image.Height;
            // DECLARE and instantiate a new ThumbEventArgs, passing in the 
            // PictureBox as a parameter
            ThumbEventArgs args = new ThumbEventArgs(pictureBox);
            // CALL to OnThumbEvent handler, passing this and the local args in
            OnThumbEvent(this, args);
        }
        /// <summary>
        /// METHOD: OnDisplayImageEvent, a method which sends an image out to the display view
        /// creates a new DisplayEventArgs
        /// </summary>
        /// <param name="pImg"></param>
        private void OnDisplayImageEvent(Image pImg)
        {
            // DECLARE and instantiate a new DisplayEventArgs
            // passing in the image which was passed into the method as a parameter
            // to the constructor
            DisplayEventArgs args = new DisplayEventArgs(pImg);
            // CALL to OnDisplayEvent event handler
            OnDisplayEvent(this, args);
        }
        /// <summary>
        /// METHOD: CircularRotate, a method which manages the value of the 
        /// rotate variable, stops it getting to large
        /// </summary>
        private void CircularRotate()
        {
            if (_rotate < 360)
                _rotate += 45;
            else
                _rotate = 45f;
        }
        #endregion
    }
}
