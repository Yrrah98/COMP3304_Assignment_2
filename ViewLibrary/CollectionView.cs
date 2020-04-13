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
    public partial class CollectionView : Form, ISubscriber
    {
        // DECLARE a delegate called _addImg
        private StrategyDelegate _addImg;

        public CollectionView(StrategyDelegate pAddImage)
        {

            _addImg = pAddImage;

            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            _addImg();
        }

        #region ISubscriber
        public void OnImageEvent(object pSource, EventArgs pArgs)
        {
            flowLayoutPanel1.Controls.Add((pArgs as ThumbEventArgs).pictureBox);
        }
        #endregion
    }
}
