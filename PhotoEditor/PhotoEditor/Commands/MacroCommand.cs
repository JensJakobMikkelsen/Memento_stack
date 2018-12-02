using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor.Commands
{
   public class MacroCommand: ICommand
    {
        private List<ICommand> _cmds;
        public MacroCommand(List<ICommand> commands)
        {
            _cmds = commands;
        }

        public void Add(ICommand command)
        {
            _cmds.Add(command);
        }

        public void Remove(ICommand command)
        {
            _cmds.Remove(command);
        }

        public void Execute()
        {
            foreach (var command in _cmds)
            {
                command.Execute();
            }
        }

        public void UnExecute()
        {
            foreach (var command in _cmds)
            {
                command.UnExecute();
            }
        }

        public void ReExecute()
        {
            throw new NotImplementedException();
        }
    }
}
