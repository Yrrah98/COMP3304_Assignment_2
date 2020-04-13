using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLibrary.Args
{
    public class DisplayEventArgs : EventArgs
    {

        public Image image { get; set; }

        public DisplayEventArgs(Image pImg)
        {
            image = pImg;
        }
    }
}
