using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLibrary.Args;

namespace COMP3304_Assignment_2.Interfaces
{
    interface IDisplayViewController
    {
        void InitialiseDisplay(object pSource, InitialiseData pArgs);
    }
}
