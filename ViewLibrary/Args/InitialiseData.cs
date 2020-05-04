using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLibrary.Args
{
    /// <summary>
    /// AUTHOR: Harry Jones 
    /// VERSION: 1 
    /// DESCRIPTION: The purpose of this class is to provide the relevant data
    /// from an IImageData class in order to make a DisplayView for that IImageData
    /// </summary>
    public class InitialiseData
    {

        // DECLARE a StrategyDelegate called _flipH
        public StrategyDelegate _flipH;
        // DECLARE a SizeDelegate called _resize
        public SizeDelegate _resize;
        // DECLARE a StrategyDelegate called _flipV
        public StrategyDelegate _flipV;
        // DECLARE a StrategyDelegate called _rotateCW
        public StrategyDelegate _rotateCW;
        // DECLARE a StrategyDelegate called _rotateACW
        public StrategyDelegate _rotateACW;
        // DECLARE a StrategyDelegate called _save;
        public StrategyDelegate _save;
        // DECLARE a String to store a string relating to an IImageData
        public String _key;

        
        /// <summary>
        /// CONSTRUCTOR for InitialiseEventArgs
        /// </summary>
        /// <param name="pFlipH"></param>
        /// <param name="pExecute"></param>
        /// <param name="pResize"></param>
        /// <param name="pFlipV"></param>
        /// <param name="pRCW"></param>
        /// <param name="pRACW"></param>
        /// <param name="pSave"></param>
        public InitialiseData(StrategyDelegate pFlipH, SizeDelegate pResize, StrategyDelegate pFlipV,
            StrategyDelegate pRCW, StrategyDelegate pRACW, 
            StrategyDelegate pSave, String pKey)
        {
            // SET _flipH delegate to StrategyDelegate passed in (pFlipH)
            _flipH = pFlipH;
            // SET ResizeDelegate to ResizeDelegate passed in
            _resize = pResize;
            // SET _flipV delegate to StrategyDelegate passed in (pFlipV)
            _flipV = pFlipV;
            // SET _rotateCW delegate to StrategyDelegate passed in (pRCW)
            _rotateCW = pRCW;
            // SET _rotateACW delegate to StrategyDelegate passed in (pRACW)
            _rotateACW = pRACW;
            // SET _save StrategyDelegat to StrategyDelegate passed in (pSave)
            _save = pSave;
            // SET the String to the String passed in
            _key = pKey;

        }
    }
}
