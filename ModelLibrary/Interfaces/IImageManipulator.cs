using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Interfaces
{
    public interface IImageManipulator 
    {

        Image LoadImage(String pPath);

        Image ResizeImage(Image pImg, Size pSize);

        Image FlipHImage(Image pImg);

        Image FlipVImage(Image pImg);
    }
}
