using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoEditor.Commands;
using PhotoEditor.Memento;

namespace PhotoEditor
{
    public class Invoker
    {
        private ICommand _Command;

        Originator_State originator_undo = new Originator_State();
        CareTaker_State careTaker_undo = new CareTaker_State();

        Originator_State originator_redo = new Originator_State();
        CareTaker_State careTaker_redo = new CareTaker_State();

        public Invoker()
        {
          
        }

        public void SetCommand(ICommand command)
        {
            _Command = command;

            originator_undo.setState(_Command);
            careTaker_undo.push(originator_undo.saveStateToMemento());

        }

        public void Execute()
        {
            _Command.Execute();
        }

        public void UnExecute()
        {
            originator_undo.getStateFromMemento(careTaker_undo.pop());

            ICommand _Command = originator_undo.getState();

            _Command.UnExecute();

            originator_redo.setState(_Command);
            careTaker_redo.push(originator_redo.saveStateToMemento());

        }

        public void ReExecute()
        {
            originator_redo.getStateFromMemento(careTaker_redo.pop());
            ICommand _Command = originator_redo.getState();

            originator_undo.setState(_Command);
            careTaker_undo.push(originator_undo.saveStateToMemento());


            _Command.Execute();
        }

    }
}
