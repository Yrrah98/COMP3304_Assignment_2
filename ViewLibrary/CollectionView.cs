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
    /// DESCRIPTION: This class is the top-level GUI view 
    /// The purpose of this class is to add new images and display
    /// their thumbnails here
    /// </summary>
    public partial class CollectionView : Form, ISubscriber
    {
        // DECLARE a delegate called _addImg
        private StrategyDelegate _addImg;

        /// <summary>
        /// CONSTURCTOR for CollectionView
        /// </summary>
        /// <param name="pAddImage"> a StrategyDelegate passed in </param>
        public CollectionView(StrategyDelegate pAddImage)
        {
            // SET CollectionView StrategyDelegate to the StrategyDelegate passed in
            _addImg = pAddImage;

            InitializeComponent();
        }
        /// <summary>
        /// METHOD: LoadBtnClick, call StrategyDelegate to perform
        /// image adding functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            // CALL to StrategyDelegat, _addImge
            _addImg();
        }

        #region ISubscriber
        /// <summary>
        /// METHOD: OnImageEvent, called when a new image has been added
        /// and a thumbnail needs displaying
        /// </summary>
        /// <param name="pSource"></param>
        /// <param name="pArgs"></param>
        public void OnImageEvent(object pSource, EventArgs pArgs)
        {
            // ADD pictureBox found in EventArgs when cast as a ThumbEventArgs
            // to the flowLaypitPanel controls
            flowLayoutPanel1.Controls.Add((pArgs as ThumbEventArgs).pictureBox);
        }
        #endregion
    }
}
