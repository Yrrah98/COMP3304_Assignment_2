using ImageProcessor;
using ModelLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    /// <summary>
    /// AUTHOR: Harry Jones 
    /// VERSION: 1 
    /// DESCRIPTION: The purpose of this class is to manipulate images using the 
    /// ImageProcessor NuGet package. 
    /// </summary>
    public class ImageManipulator : IImageManipulator
    {
        /// <summary>
        /// CONSTRUCTOR for ImageManipulator
        /// </summary>
        public ImageManipulator()
        {

        }

        /// <summary>
        /// METHOD: FlipHImage, a method which flips an image horizontally
        /// </summary>
        /// <param name="pImg"></param>
        /// <returns></returns>
        public Image FlipHImage(Image pImg, bool flip)
        {
            // DECLARE and instantiate a new MemoryStream
            // give it a null assignment
            MemoryStream bmpOut = null;

            // IF the images raw format is a Bitmap
            if (ImageFormat.Bmp.Equals(pImg.RawFormat))
            {
                // THEN set bmpOut to a new Memory stream
                bmpOut = new MemoryStream();
                /*
                 * The reason for this is that if the image added is a bitmap
                 * then errors are caused within the using statement when 
                 * the stream is closed
                 */
            }
            // USING memory stream - new MemoryStream
            using (MemoryStream outStream = new MemoryStream())
            {
                // USING ImageFactory - new ImageFactory
                using (ImageFactory imgFctry = new ImageFactory())
                {
                    // IF flip is false
                    if (!flip)
                    {
                        // IF the local memory stream is not null
                        if (bmpOut != null)
                            // LOAD image paramer, FLIP with float parameter and
                            // SAVE to memory stream
                            imgFctry.Load(pImg).Flip(flip).Save(bmpOut);
                        else
                            // LOAD image paramer, FLIP with float parameter and
                            // SAVE to memory stream
                            imgFctry.Load(pImg).Flip(flip).Save(outStream);
                    }
                    // ELSE
                    else
                    {
                        // IF the local memory stream is not null
                        if (bmpOut != null)
                            // LOAD image paramer, FLIP with float parameter and
                            // SAVE to memory stream
                            imgFctry.Load(pImg).Save(bmpOut);
                        else
                            // LOAD image paramer, FLIP with float parameter and
                            // SAVE to memory stream
                            imgFctry.Load(pImg).Save(outStream);
                    }
                }
                // DECLARE a new Image
                Image img;
                // IF bitmap memory stream variable is not null
                if (bmpOut != null)
                    // SET image to Bitmap from bitmap memory stream
                    img = Bitmap.FromStream(bmpOut);
                else
                    // ELSE THEN SET image to Bitmap from Using statement MemoryStream
                    img = Bitmap.FromStream(outStream);
                // RETURN img
                return img;
            }
        }

        /// <summary>
        /// METHOD: FlipVImage, a method which flips an image vertically 
        /// </summary>
        /// <param name="pImg"></param>
        /// <returns></returns>
        public Image FlipVImage(Image pImg, bool flip)
        {
            // DECLARE and instantiate a new MemoryStream
            // give it a null assignment
            MemoryStream bmpOut = null;

            // IF the images raw format is a Bitmap
            if (ImageFormat.Bmp.Equals(pImg.RawFormat))
            {
                // THEN set bmpOut to a new Memory stream
                bmpOut = new MemoryStream();
                /*
                 * The reason for this is that if the image added is a bitmap
                 * then errors are caused within the using statement when 
                 * the stream is closed
                 */
            }
            // USING memory stream - new MemoryStream
            using (MemoryStream outStream = new MemoryStream())
            {
                // USING ImageFactory - new ImageFactory
                using (ImageFactory imgFctry = new ImageFactory())
                { 
                    // IF flip is false
                    if (!flip)
                    {
                        // IF the local memory stream is not null
                        if (bmpOut != null)
                            // LOAD image parameter, FLIP with float parameter and
                            // SAVE to memory stream
                            imgFctry.Load(pImg).Flip(true, flip).Save(bmpOut);
                        else
                            // LOAD image parameter, FLIP with float parameter and
                            // SAVE to memory stream
                            imgFctry.Load(pImg).Flip(true, flip).Save(outStream);
                    }
                    // ELSE
                    else
                    {
                        // IF the local memory stream is not null
                        if (bmpOut != null)
                            // LOAD image parameter, FLIP with float parameter and
                            // SAVE to memory stream
                            imgFctry.Load(pImg).Save(bmpOut);
                        else
                            // LOAD image parameter, FLIP with float parameter and
                            // SAVE to memory stream
                            imgFctry.Load(pImg).Save(outStream);
                    }
                }
                // DECLARE a new Image
                Image img;
                // IF bitmap memory stream variable is not null
                if (bmpOut != null)
                    // SET image to Bitmap from bitmap memory stream
                    img = Bitmap.FromStream(bmpOut);
                else
                    // ELSE THEN SET image to Bitmap from Using statement MemoryStream
                    img = Bitmap.FromStream(outStream);
                // RETURN img
                return img;
            }
        }

        public Image RotateImage(Image pImg, float pRtate)
        {
            // DECLARE and instantiate a new MemoryStream
            // give it a null assignment
            MemoryStream bmpOut = null;

            // IF the images raw format is a Bitmap
            if (ImageFormat.Bmp.Equals(pImg.RawFormat))
            {
                // THEN set bmpOut to a new Memory stream
                bmpOut = new MemoryStream();
                /*
                 * The reason for this is that if the image added is a bitmap
                 * then errors are caused within the using statement when 
                 * the stream is closed
                 */
            }
            // USING memory stream - new MemoryStream
            using (MemoryStream outStream = new MemoryStream())
            {
                // USING ImageFactory - new ImageFactory
                using (ImageFactory imgFctry = new ImageFactory())
                {
                    // IF the local memory stream is not null
                    if (bmpOut != null)
                        // THEN use that to save the stream
                        imgFctry.Load(pImg).Rotate(pRtate).Save(bmpOut);
                    else
                        // ELSE IF IT IS use the using statement stream
                        imgFctry.Load(pImg).Rotate(pRtate).Save(outStream);
                }
                // DECLARE a new Image
                Image img;
                // IF bitmap memory stream variable is not null
                if (bmpOut != null)
                    // SET image to Bitmap from bitmap memory stream
                    img = Bitmap.FromStream(bmpOut);
                else
                    // ELSE THEN SET image to Bitmap from Using statement MemoryStream
                    img = Bitmap.FromStream(outStream);
                // RETURN img
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
            // DECLARE and instantiate a new MemoryStream
            // give it a null assignment
            MemoryStream bmpOut = null;

            // IF the images raw format is a Bitmap
            if (System.IO.Path.GetExtension(pPath) == ".bmp")
            {
                // THEN set bmpOut to a new Memory stream
                bmpOut = new MemoryStream();
                /*
                 * The reason for this is that if the image added is a bitmap
                 * then errors are caused within the using statement when 
                 * the stream is closed
                 */
            }
            // USING memory stream - new MemoryStream
            using (MemoryStream outStream = new MemoryStream())
            {
                // USING ImageFactory - new ImageFactory
                using (ImageFactory imgFctry = new ImageFactory())
                {
                    // IF the local memory stream is not null
                    if (bmpOut != null)
                        // THEN use that to save the stream
                        imgFctry.Load(pPath).Save(bmpOut);
                    else
                        // ELSE IF IT IS use the using statement stream
                        imgFctry.Load(pPath).Save(outStream);
                }
                // DECLARE a new Image
                Image img;
                // IF bitmap memory stream variable is not null
                if (bmpOut != null)
                    // SET image to Bitmap from bitmap memory stream
                    img = Bitmap.FromStream(bmpOut);
                else
                    // ELSE THEN SET image to Bitmap from Using statement MemoryStream
                    img = Bitmap.FromStream(outStream);

                // RETURN img
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
            // DECLARE and instantiate a new MemoryStream
            // give it a null assignment
            MemoryStream bmpOut = null;

            // IF the images raw format is a Bitmap
            if (ImageFormat.Bmp.Equals(pImg.RawFormat))
            {
                // THEN set bmpOut to a new Memory stream
                bmpOut = new MemoryStream();
                /*
                 * The reason for this is that if the image added is a bitmap
                 * then errors are caused within the using statement when 
                 * the stream is closed
                 */
            }
            // USING memory stream - new MemoryStream
            using (MemoryStream outStream = new MemoryStream())
            {
                // USING ImageFactory - new ImageFactory
                using (ImageFactory imgFctry = new ImageFactory())
                {
                    // IF the local memory stream is not null
                    if (bmpOut != null)
                        // THEN use that to save the stream
                        imgFctry.Load(pImg).Resize(pSize).Save(bmpOut);
                    else
                        // ELSE IF IT IS use the using statement stream
                        imgFctry.Load(pImg).Resize(pSize).Save(outStream);
                }
                // DECLARE a new Image
                Image img;
                // IF bitmap memory stream variable is not null
                if (bmpOut != null)
                    // SET image to Bitmap from bitmap memory stream
                    img = Bitmap.FromStream(bmpOut);
                else
                    // ELSE THEN SET image to Bitmap from Using statement MemoryStream
                    img = Bitmap.FromStream(outStream);
                // RETURN img
                return img;
            }
        }
    }
}
