using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Interfaces
{
    public interface IDisplayPublisher
    {

        void SubscribeDisplay(EventHandler<EventArgs> e);

        void UnsubscribeDisplay(EventHandler<EventArgs> e);
    }
}
