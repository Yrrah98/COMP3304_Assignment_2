using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLibrary.Args;
using ViewLibrary.Interfaces;

namespace ViewLibrary
{
    public delegate void StrategyDelegate();

    public delegate void ImageDelegate(Image pImg);

    public delegate void ExecuteDelegate(ICommand pCmd);

    public delegate void SizeDelegate(Size pSize);

    public delegate void DisplayViewDelegate(object pSource, InitialiseData data);
}
