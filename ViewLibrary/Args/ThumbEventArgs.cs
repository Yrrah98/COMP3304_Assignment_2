using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewLibrary.Args
{
    /// <summary>
    /// AUTHOR: Harry Jones 
    /// VERSION: 1 
    /// DESCRIPTION: The purpose of this class is to provide the CollectionView
    /// with the thumbnail to be displayed in the GUI
    /// </summary>
    public class ThumbEventArgs : EventArgs
    {
        // DECLARE a PictureBox called pictureBox
        // public get and set
        public PictureBox pictureBox { get; set; }
        /// <summary>
        /// CONSTRUCTOR for ThumbEventArgs
        /// </summary>
        /// <param name="pPb"> PictureBox parameter passed in</param>
        public ThumbEventArgs(PictureBox pPb)
        {
            // SRT ThumbEventArgs PictureBox to the PictureBox passed in 
            pictureBox = pPb;
        }
    }
}
