using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLibrary.Interfaces
{
    public interface ISubscriber
    {

        void OnImageEvent(object pSource, EventArgs pArgs);
    }
}
