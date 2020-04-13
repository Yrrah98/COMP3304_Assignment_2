using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Interfaces
{
    public interface IPublisher
    {

        void Subscribe(EventHandler<EventArgs> e);

        void Unsubscribe(EventHandler<EventArgs> e);
    }
}
