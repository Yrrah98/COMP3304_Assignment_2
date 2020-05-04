using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLibrary.Interfaces;

namespace ViewLibrary
{
    /// <summary>
    /// AUTHOR: Harry Jones 
    /// VERSION: 1 
    /// DESCRIPTION: This class encapsulates delegate calls as an object
    /// this allows the command to be called from a relevant class.
    /// </summary>
    public class ImageCommand : ICommand
    {
        // DECLARE StrategyDelegate called _action
        private StrategyDelegate _action;
        /// <summary>
        /// CONSTRUCTOR for ImageCommand
        /// </summary>
        /// <param name="pAction"> a strategy delegate passed in </param>
        public ImageCommand(StrategyDelegate pAction)
        {
            // SET ImageCommand StrategyDelegat to StrategyDelegate passed in as parameter
            _action = pAction;
        }
        /// <summary>
        /// METHOD: Execute, a method which calls the delegate
        /// </summary>
        public void Execute()
        {
            // CALL to delegate
            _action();
        }
    }
}
