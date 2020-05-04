using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewLibrary.Args;
using ViewLibrary.Interfaces;

namespace ViewLibrary
{
    /// <summary>
    /// AUTHOR: Harry Jones 
    /// VERSION: 1 
    /// DESCRIPTION: The purpose of this class is to display images in a larger view window
    /// than the previous, allowing for buttons to be clicked and the image to be manipulated
    /// via the use of delegates and Commands
    /// </summary>
    public partial class DisplayView : Form, ISubscriber, IDisplayView
    {
        // DECLARE a StrategyDelegate called _flipH
        private StrategyDelegate _flipH;
        // DECLARE an ExecuteDelegate called _execute
        private ExecuteDelegate _execute;
        // DECLARE a SizeDelegate called _resize
        private SizeDelegate _resize;
        // DECLARE a StrategyDelegate called _flipV
        private StrategyDelegate _flipV;
        // DECLARE a StrategyDelegate called _rotateCW
        private StrategyDelegate _rotateCW;
        // DECLARE a StrategyDelegate called _rotateACW
        private StrategyDelegate _rotateACW;
        // DECLARE a StrategyDelegate called _save;
        private StrategyDelegate _save;
        // DECLARE a bool called added, instantiate as false
        private bool added = false;
        // DECLARE a Size variable called _minSize
        private Size _minSize;

        /// <summary>
        /// CONSTRUCTOR for DisplayView Class
        /// </summary>
        /// <param name="pFlipH"> StrategyDelegate passed in, flips horizontally</param>
        /// <param name="pExecute"></param>
        /// <param name="pResize"></param>
        /// <param name="pFlipV"> StrategyDelegate passed in, flips vertically </param>
        /// <param name="pRCW"> StrategyDelegate passed in, rotates clockwise </param>
        /// <param name="pRACW"> StrategyDelegate passed in, rotates anti clockwise </param>
        /// /// <param name="pRACW"> StrategyDelegate passed in, saves image </param>
        public DisplayView(StrategyDelegate pFlipH, ExecuteDelegate pExecute, SizeDelegate pResize, StrategyDelegate pFlipV,
            StrategyDelegate pRCW, StrategyDelegate pRACW, StrategyDelegate pSave)
        {
            InitializeComponent();

            // SET _flipH delegate to StrategyDelegate passed in (pFlipH)
            _flipH = pFlipH;
            // SET ExecuteDelegate to ExecuteDelegate passed in
            _execute = pExecute;
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
            // SET _minSize as a new Size, the width being the far most right button position (save button)
            // + its width and some extra width, same with height but y position and the save buttons height
            _minSize = new Size(SaveBtn.Location.X + SaveBtn.Width + 20, SaveBtn.Location.Y + SaveBtn.Height + 20);
            // SET the minimum size property of the DisplayView to _minSize variable
            this.MinimumSize = _minSize;
            // SET this windows visibility to true upon creation
            this.Visible = true;
        }


        #region IDisplayView

        public void Loaded()
        {
            // SET added to True
            added = true;
            // DECLARE a new Size, set it to the display views PictureBox size
            Size newSize = this.pictureBox1.Size;
            // DECLARE ICommand called resize and set to new ResizeCommand
            // passing in the resize delegate and the desired size
            ICommand resize = new ResizeCommand(_resize, newSize);
            // CALL to execute delegat passing in the icommand
            _execute(resize);
        }
        #endregion 

        #region ISubscriber
        /// <summary>
        /// METHOD: OnImageEvent, a method which is called when any changes occur to an image
        /// </summary>
        /// <param name="pSource"> calling object </param>
        /// <param name="pArgs"> event data</param>
        public void OnImageEvent(object pSource, EventArgs pArgs)
        {
            pictureBox1.Size = (pArgs as DisplayEventArgs).image.Size;

            // SET the picture box image to the image passed in through 
            // the event args cast as a DisplayEventArgs
            pictureBox1.Image = (pArgs as DisplayEventArgs).image;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// METHOD: FlipHBtn, makes necessary calls to flip the image horizontally
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlipHBtn_Click(object sender, EventArgs e)
        {
            // DECLARE ICommand called flipH and set as new ImageCommand
            // passing in the flip horizontal delegate
            ICommand flipH = new ImageCommand(_flipH);
            // CALL to ExecuteDelegate passing in the ICommand
            _execute(flipH);
        }

        private void FlipVBtn_Click(object sender, EventArgs e)
        {
            // DECLARE ICommand called flipV and set as new ImageCommand
            // passing in the flip vertical delegate
            ICommand flipV = new ImageCommand(_flipV);
            // CALL to ExecuteDelegate passing in the ICommand
            _execute(flipV);
        }

        private void RotateCWBtn_Click(object sender, EventArgs e)
        {
            // DECLARE ICommand called rCW and set as new ImageCommand
            // passing in the clockwise rotation delegate
            ICommand rCW = new ImageCommand(_rotateCW);
            // CALL to ExecuteDelegate passing in the ICommand
            _execute(rCW);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // DECLARE ICommand called rCW and set as new ImageCommand
            // passing in the clockwise rotation delegate
            ICommand save = new ImageCommand(_save);
            // CALL to ExecuteDelegate passing in the ICommand
            _execute(save);
        }
        #endregion

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            
        }

        private void DisplayView_Resize(object sender, EventArgs e)
        {
            // IF the added bool is true
            if (added && this.MinimumSize.Width >= _minSize.Width && this.MinimumSize.Width >= _minSize.Width)
            {
                // DECLARE a new Size variable and set it to the picture boxes
                // size
                Size newSize = this.pictureBox1.Size;
                // DECLARE a new ICommand and set it to a new ResizeCommand
                // passing in the resize delegate and the desired size
                ICommand resize = new ResizeCommand(_resize, newSize);
                // CALL to ExecuteDelegate passing in the ICommand
                _execute(resize);
            }
        }

        private void RotateACWBtn_Click(object sender, EventArgs e)
        {
            // DECLARE ICommand called rACW and set as new ImageCommand
            // passing in the anti-clockwise rotation delegate
            ICommand rACW = new ImageCommand(_rotateACW);
            // CALL to ExecuteDelegate passing in the ICommand
            _execute(rACW);
        }

        private void IncreaseBtn_Click(object sender, EventArgs e)
        {
            // DECLARE two ints one for width and one for height
            // SET the value of w and h to the width and height of the 
            // image + 10% of the images width or height
            int w = this.pictureBox1.Image.Width + this.pictureBox1.Image.Width / 10;
            int h = this.pictureBox1.Image.Height + this.pictureBox1.Image.Height / 10;
            // DECLARE a new Size, set it to the width and height
            Size nSize = new Size(w,h);
            // DECLARE a new ICommand and set it to a new ResizeCommand
            // passing in the resize delegate and the desired size
            ICommand rSize = new ResizeCommand(_resize, nSize);
            // CALL to ExecuteDelegate passing in the ICommand
            _execute(rSize);
        }

        private void DecreaseBtn_Click(object sender, EventArgs e)
        {
            // DECLARE two ints one for width and one for height
            // SET the value of w and h to the width and height of the 
            // image - 10% of the images width or height
            int w = this.pictureBox1.Image.Width - this.pictureBox1.Image.Width / 10;
            int h = this.pictureBox1.Image.Height - this.pictureBox1.Image.Height / 10;
            // DECLARE a new Size, set it to the width and height
            Size nSize = new Size(w, h);
            // DECLARE a new ICommand and set it to a new ResizeCommand
            // passing in the resize delegate and the desired size
            ICommand rSize = new ResizeCommand(_resize, nSize);
            // CALL to ExecuteDelegate passing in the ICommand
            _execute(rSize);
        }
    }
}
