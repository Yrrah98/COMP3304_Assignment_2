using COMP3304_Assignment_2.Interfaces;
using ModelLibrary;
using ModelLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewLibrary;
using ViewLibrary.Args;
using ViewLibrary.Interfaces;

namespace COMP3304_Assignment_2
{
    /// <summary>
    /// AUTHOR: Harry Jones 
    /// VERSION: 1 
    /// DESCRIPTION: The purpose of this class is to connect up the Model and View libraries,
    /// and some functions delegated by the CollectionView. This class will house the different 
    /// classes and provide a means for them to communicate 
    /// </summary>
    class Controller : IController
    {
        // DECLARE a Form called _collectionView 
        private Form _collectionView;
        // DECLARE an IImageManipulator called _imgManipulator
        private IImageManipulator _imgManipulator;
        // DECLARE a new OpenFileDialog called fileDialog
        private OpenFileDialog _fileDialog;
        // DECLARE a new ImageCollection called _imgCollection
        private IImageCollection _imgCollection;
        // DECLARE an IDisplayViewController called _dvController
        private IDisplayViewController _dvController;

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public Controller()
        { 
        }

        #region Private Methods
        /// <summary>
        /// METHOD: Execute, a method which is used to execute a command object
        /// </summary>
        /// <param name="pCmd"> the command which needs to be executed </param>
        private void Execute(ICommand pCmd)
        {
            // CALL to the Execute method of the command
            pCmd.Execute();
        }
        #endregion

        #region IController
        /// <summary>
        /// METHOD: Initialise, a method which initialises the Controller
        /// </summary>
        public void Initialise()
        {
            // INSTANTIATE _collectionView 
            _collectionView = new CollectionView(AddImage);
            // _imgManipulator as new ImageManipulator
            _imgManipulator = new ImageManipulator();
            // INSTANTIATE _fileDialog
            _fileDialog = new OpenFileDialog();
            // INSTANTIATE _dvController as a new DisplayViewController
            _dvController = new DisplayViewController(Execute);
            // _imgCollection as new ImageCollection
            _imgCollection = new ImageCollection(_dvController.InitialiseDisplay);
            // SET multiselection on the file dialog to true
            _fileDialog.Multiselect = true;
            // RUN the the new collection view
            Application.Run(_collectionView);
        }

        /// <summary>
        /// METHOD: AddImage, the method which adds new images to the collection
        /// </summary>
        public void AddImage()
        {
            // IF the returned value of the fileDialog is cancel
            if (_fileDialog.ShowDialog() == DialogResult.Cancel)
            {
                // THEN
                // PRINT to console "Cancelled out"
                Console.WriteLine("Cancelled out");
            }
            // ELSE
            else
            {
                // DECLARE a new List of strings set as a new List of strings
                IList<String> fileNamePaths = new List<String>();
                // SET the value of the _fileNamePaths list to the strings selected 
                // by the user in the dialog window 
                fileNamePaths = _fileDialog.FileNames;
                // FOREACH through the list of strings generated
                foreach (String s in fileNamePaths)
                {
                    // INSTANTIATE instance variable, type String
                    // SET to a new guid as a string
                    String uid = Guid.NewGuid().ToString();
                    // INSTANTIATE instance variable, type IImage data
                    // SET to a new ImageData, passing in OpenDisplayView to constructor
                    IImageData i = new ImageData();
                    // CAST IImageData as a IImageManipulatorInject
                    (i as IImageManipulatorInject).Inject(_imgManipulator);
                    // INSTANTIATE and INITIALISE a new PictureBox, passing in the UID as a 
                    PictureBox pb = new CustomPictureBox(uid);
                    // SUBSCRIBE the OnImageEvent method in DisplayImage to the picture box
                    pb.DoubleClick += _imgCollection.DoubleClick;
                    // CAST image data as an IPublisher and call Subscribe _collectionView as ISubscriber
                    (i as IPublisher).Subscribe((_collectionView as ISubscriber).OnImageEvent);
                    // CALL to AddImage method on IImageData variable
                    // passing in picture box and image returned from LoadImage method of 
                    // the image manipulator
                    i.AddImage(pb, _imgManipulator.LoadImage(s));
                    // ADD IImageData to _imageCollection and passing in uid aswell
                    // ***** Created IImageData in this class as the image collection is 
                    // for storage purposes only *****
                    _imgCollection.AddImage(i, uid);
                }
            }
        }
        #endregion
    }
}
