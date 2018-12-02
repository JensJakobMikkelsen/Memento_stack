using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoEditor.Editor;
using PhotoEditor.Memento;

namespace PhotoEditor.Commands
{
    public class CinematicFilterCommand: ICommand
    {
        private IPhotoEditor _editor;
        public CinematicFilterCommand(IPhotoEditor editor)
        {
            _editor = editor;
        }

        public void Execute()
        {
            _editor.CinematicFilter();
        }

        public void UnExecute()
        {
            Console.WriteLine("Unblur");
        }
    }
}
