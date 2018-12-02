using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoEditor.Commands;

namespace PhotoEditor.Memento
{
    class Memento_State
    {

        private ICommand State;


        public Memento_State(ICommand State_)
        {
            this.State = State_;
        }

        public ICommand getState()
        {
            return State;
        }
    }
}
