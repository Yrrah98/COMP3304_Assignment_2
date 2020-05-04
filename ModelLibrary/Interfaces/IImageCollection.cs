using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Interfaces
{
    public interface IImageCollection
    {
        IImageData RetrieveImageData(String pKey);

        void AddImage(IImageData i, String pKey);

        void DoubleClick(object pSource, EventArgs pArgs);

        void SubscribeDisplay(EventHandler<EventArgs> pArgs, String pKey);
    }
}
