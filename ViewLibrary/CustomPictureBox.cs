using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ViewLibrary
{
    // CUSTOM PICTURE BOX CLASS - PURPOSE: To give images a border
    // CODE REFERENCE: https://stackoverflow.com/questions/4446478/how-do-i-create-a-colored-border-on-a-picturebox-control
    // CODE REFERENCE NAME: Lankymart
    // CODE REFERENCE ACCESSED: 13/04/2020
    // AVAILABLE ONLINE
    public class CustomPictureBox : PictureBox
    {

        public CustomPictureBox()
        {

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            ControlPaint.DrawBorder(pe.Graphics, pe.ClipRectangle, Color.DarkGray, ButtonBorderStyle.Outset);
        }
    }
}
