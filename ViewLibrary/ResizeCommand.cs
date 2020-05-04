using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLibrary.Interfaces;

namespace ViewLibrary
{
    /// <summary>
    /// AUTHOR: Harry Jones 
    /// VERSION: 1 
    /// DESCRIPTION: The purpose of this command is to provide the ability to 
    /// resize an image, it is a command which encapsulates a delegate call
    /// allowing the delegate to be called from a relevant class.
    /// </summary>
    public class ResizeCommand : ICommand
    {
        // DECLARE a SizeDelegate called _action
        private SizeDelegate _action;
        // DECLARE a Size variable called _size
        private Size _size;

        /// <summary>
        /// CONSTRUCTOR for ResizeCommand 
        /// </summary>
        /// <param name="pAction"> delegate passed in</param>
        /// <param name="pSize"> size data passed in</param>
        public ResizeCommand(SizeDelegate pAction, Size pSize)
        {
            // SET _action to SizeDelegate passed in
            _action = pAction;
            // SET _sie to Size variable passed in
            _size = pSize;
        }

        /// <summary>
        /// METHOD: Execute, a method which is called to execute a command
        /// </summary>
        public void Execute()
        {
            // CALL _action delegate passing in the Size parameter
            _action(_size);
        }
    }
}
