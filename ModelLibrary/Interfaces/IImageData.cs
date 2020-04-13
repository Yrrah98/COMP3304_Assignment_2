using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelLibrary.Interfaces
{
    public interface IImageData
    {

        Image image { get; }

        void AddImage(PictureBox pPb,Image pImg);

        void ThumbImage();

        void FlipImage();

        void DisplaySize(Size pSize);
    }
}
