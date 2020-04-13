using ImageProcessor;
using ModelLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class ImageManipulator : IImageManipulator
    {

        public ImageManipulator()
        {

        }

        /// <summary>
        /// METHOD: FlipHImage, a method which flips an image horizontally
        /// </summary>
        /// <param name="pImg"></param>
        /// <returns></returns>
        public Image FlipHImage(Image pImg)
        {
            using (MemoryStream outStream = new MemoryStream())
            {
                using (ImageFactory imgFctry = new ImageFactory())
                {
                    imgFctry.Load(pImg).Flip(false, false);
                }
                Image img = Bitmap.FromStream(outStream);

                return img;
            }
        }

        /// <summary>
        /// METHOD: FlipVImage, a method which flips an image vertically 
        /// </summary>
        /// <param name="pImg"></param>
        /// <returns></returns>
        public Image FlipVImage(Image pImg)
        {
            using (MemoryStream outStream = new MemoryStream())
            {
                using (ImageFactory imgFctry = new ImageFactory())
                {
                    imgFctry.Load(pImg).Flip(true, false);
                }
                Image img = Bitmap.FromStream(outStream);

                return img;
            }
        }

        /// <summary>
        /// METHOD: LoadImage, a method which loads an image 
        /// </summary>
        /// <param name="pPath"></param>
        /// <returns></returns>
        public Image LoadImage(String pPath)
        {
            using (MemoryStream outStream = new MemoryStream())
            {
                using (ImageFactory imgFctry = new ImageFactory())
                {
                    imgFctry.Load(pPath).Save(outStream);
                }
                Image img = Bitmap.FromStream(outStream);

                return img;
            }
        }

        /// <summary>
        /// METHOD: ResizeImage, a method which resizes an image
        /// </summary>
        /// <param name="pImg"></param>
        /// <param name="pSize"></param>
        /// <returns></returns>
        public Image ResizeImage(Image pImg, Size pSize)
        {
            using (MemoryStream outStream = new MemoryStream())
            {
                using (ImageFactory imgFctry = new ImageFactory())
                {
                    imgFctry.Load(pImg).Resize(pSize).Save(outStream);
                }
                Image img = Bitmap.FromStream(outStream);

                return img;
            }
        }
    }
}
