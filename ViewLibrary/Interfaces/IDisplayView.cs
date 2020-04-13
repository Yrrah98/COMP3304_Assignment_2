using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLibrary.Interfaces
{
    public interface IDisplayView
    {

        void OnDoubleClick(object pSource, EventArgs pArgs);
    }
}
