using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Interfaces
{
    public interface IImageCollection
    {

        void AddImage(IImageData i, String pKey);
    }
}
