using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLibrary.Args
{
    /// <summary>
    /// AUTHOR: Harry Jones 
    /// VERSION: 1 
    /// DESCRIPTION: This class is the event arguments which is given to 
    /// a DisplayView class, allowing the image to be changed at run time
    /// </summary>
    public class DisplayEventArgs : EventArgs
    {
        // DECLARE a property of type Image called image
        public Image image { get; set; }

        /// <summary>
        /// CONSTRUCTOR for DisplayEventArgs
        /// </summary>
        /// <param name="pImg"> Image parameter passed in </param>
        public DisplayEventArgs(Image pImg)
        {
            // SET image property to the Image parameter passed in
            image = pImg;
        }
    }
}
