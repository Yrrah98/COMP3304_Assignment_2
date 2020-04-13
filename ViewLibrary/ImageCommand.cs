using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLibrary.Interfaces;

namespace ViewLibrary
{
    public class ImageCommand : ICommand
    {
        private StrategyDelegate _action;

        public ImageCommand(StrategyDelegate pAction)
        {
            _action = pAction;
        }

        public void Execute()
        {
            _action();
        }
    }
}
