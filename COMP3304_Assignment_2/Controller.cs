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
using ViewLibrary.Interfaces;

namespace COMP3304_Assignment_2
{
    class Controller : IController
    {
        // DECLARE a Form called _collectionView 
        private Form _collectionView;
        // DECLARE a IDictionary<String, Form> called _displays
        private IDictionary<String, Form> _displays;
        // DECLARE an IImageManipulator called _imgManipulator
        private IImageManipulator _imgManipulator;
        // DECLARE a new OpenFileDialog called fileDialog
        private OpenFileDialog _fileDialog;
        // DECLARE a new ImageCollection called _imgCollection
        private IImageCollection _imgCollection;


        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public Controller()
        {

        }


        #region Private Methods
        private void Execute(ICommand pCmd)
        {
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
            // _displays
            _displays = new Dictionary<String, Form>();
            // _imgManipulator as new ImageManipulator
            _imgManipulator = new ImageManipulator();
            // _imgCollection as new ImageCollection
            _imgCollection = new ImageCollection();
            // INSTANTIATE _fileDialog
            _fileDialog = new OpenFileDialog();
            // SET multiselection on the file dialog to true
            _fileDialog.Multiselect = true;
            _fileDialog.ShowHelp = true;

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
                    // INSTANTIATE and INITIALISE a new PictureBox
                    PictureBox pb = new CustomPictureBox();
                    // INSTANTIATE a new IDisplayImage 
                    IDisplayView displayImage = new DisplayView(i.FlipImage, Execute, i.DisplaySize);
                    // SUBSCRIBE the OnImageEvent method in DisplayImage to the picture box
                    pb.DoubleClick += (displayImage as IDisplayView).OnDoubleClick;

                    (i as IDisplayPublisher).SubscribeDisplay((displayImage as ISubscriber).OnImageEvent);

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
