using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ViewLibrary.Interfaces;

namespace ViewLibrary
{
    // CUSTOM PICTURE BOX CLASS - PURPOSE: To give images a border
    // CODE REFERENCE: https://stackoverflow.com/questions/4446478/how-do-i-create-a-colored-border-on-a-picturebox-control
    // CODE REFERENCE NAME: Lankymart
    // CODE REFERENCE ACCESSED: 13/04/2020
    // AVAILABLE ONLINE
    public class CustomPictureBox : PictureBox, ICustomPictureBox
    {
        /// <summary>
        /// PROPERTY: imgKey, a property which grants access to a string
        /// </summary>
        public String imgKey { get; private set; }

        /// <summary>
        /// CONSTRUCTOR for CustomPictureBox class
        /// </summary>
        /// <param name="pUid"> the key of the IImageData the image belongs to </param>
        public CustomPictureBox(String pUid)
        {
            // SET the imgKey in this class to the image key passed in
            imgKey = pUid;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            ControlPaint.DrawBorder(pe.Graphics, pe.ClipRectangle, Color.DarkGray, ButtonBorderStyle.Outset);
        }
    }
}
