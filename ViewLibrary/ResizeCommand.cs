using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLibrary.Interfaces;

namespace ViewLibrary
{
    public class ResizeCommand : ICommand
    {

        private SizeDelegate _action;

        private Size _size;

        public ResizeCommand(SizeDelegate pAction, Size pSize)
        {
            _action = pAction;
        }

        public void Execute()
        {
            _action(_size);
        }
    }
}
