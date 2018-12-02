using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoEditor.Commands;

namespace PhotoEditor.Memento
{
    class Originator_State
    {
        private ICommand State;


        public void setState(ICommand State_)
        {
            this.State = State_;
        }

        public ICommand getState()
        {
            return State;
        }

        public Memento_State saveStateToMemento()
        {
            return new Memento_State(State);
        }

        public void getStateFromMemento(Memento_State memento)
        {
            State = memento.getState();
        }
    }
}
