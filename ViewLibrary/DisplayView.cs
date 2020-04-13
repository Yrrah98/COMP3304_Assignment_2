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
    public partial class DisplayView : Form, ISubscriber, IDisplayView
    {
        private StrategyDelegate _flipH;

        private ExecuteDelegate _execute;

        private SizeDelegate _resize;

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public DisplayView(StrategyDelegate pFlipH, ExecuteDelegate pExecute, SizeDelegate pResize)
        {
            _flipH = pFlipH;

            _execute = pExecute;

            _resize = pResize;

            

            InitializeComponent();
        }


        #region IDisplayView

        public void OnDoubleClick(object pSource, EventArgs pArgs)
        {
            Size newSize = this.pictureBox1.Size;

            ICommand resize = new ResizeCommand(_resize, newSize);
            _execute(resize);

            this.Visible = true;
        }
        #endregion 



        #region ISubscriber

        public void OnImageEvent(object pSource, EventArgs pArgs)
        {
            pictureBox1.Image = (pArgs as DisplayEventArgs).image;
        }
        #endregion


        #region Private Methods

        private void FlipHBtn_Click(object sender, EventArgs e)
        {
            ICommand flipH = new ImageCommand(_flipH);
            _execute(flipH);
        }

        private void FlipVBtn_Click(object sender, EventArgs e)
        {

        }

        private void RotateCWBtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            //if (pictureBox1.Image != null)
            //{
            //    Size newSize = this.pictureBox1.Size;

            //    ICommand resize = new ResizeCommand(_resize, newSize);
            //    _execute(resize);
            //}
        }
    }
}
