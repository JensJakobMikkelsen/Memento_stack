using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor.Memento
{
    class CareTaker_State
    {
        private Stack<Memento_State> mementoStack = new Stack<Memento_State>();

        public void push(Memento_State state)
        {
            mementoStack.Push(state);
        }

        public Memento_State pop()
        {
            return mementoStack.Pop();
        }
    }
}
