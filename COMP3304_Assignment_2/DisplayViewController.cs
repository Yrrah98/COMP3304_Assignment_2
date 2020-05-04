using COMP3304_Assignment_2.Interfaces;
using ModelLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLibrary;
using ViewLibrary.Args;
using ViewLibrary.Interfaces;

namespace COMP3304_Assignment_2
{
    /// <summary>
    /// AUTHOR: Harry Jones 
    /// VERSION: 1 
    /// DESCRIPTION: This is a controller class for the second GUI 
    /// which is made when an image is double clicked. This class instantiates and initialises the 
    /// DisplayView of an image
    /// </summary>
    class DisplayViewController : IDisplayViewController
    {
        // DECLARE an ExecuteDelegate variable, called _execute
        private ExecuteDelegate _execute;

        /// <summary>
        /// CONSTRUCTOR for DisplayViewController
        /// </summary>
        /// <param name="pExecute"> Execute delegate which will be passed into new displays </param>
        public DisplayViewController(ExecuteDelegate pExecute)
        {
            // SET ExecuteDelegate in this class, to the ExecuteDelegate passed into
            // the constructor
            _execute = pExecute;
        }

        /// <summary>
        /// METHOD: InitialiseDisplay, a method which is used to display a new display
        /// </summary>
        /// <param name="pSource"></param>
        /// <param name="pArgs"></param>
        public void InitialiseDisplay(object pSource, InitialiseData pArgs)
        {
            // INSTANTIATE a new IDisplay as DisplayView
            // passing in the InitialiseData EventArgs data as parameters
            IDisplayView newDisplay = new DisplayView(pArgs._flipH, _execute, pArgs._resize,
                pArgs._flipV, pArgs._rotateCW, pArgs._rotateACW, pArgs._save);
            // SUBSCRIBE the new display to the source object, cast as a IDisplayPublisher 
            (pSource as IImageCollection).SubscribeDisplay((newDisplay as ISubscriber).OnImageEvent, pArgs._key);
            // CALL to the new display Loaded method
            newDisplay.Loaded();
        }
    }
}
