using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor.Commands
{
    public class NoCommand: ICommand
    {
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void ReExecute()
        {
            throw new NotImplementedException();
        }

        public void UnExecute()
        {
            throw new NotImplementedException();
        }
    }
}
