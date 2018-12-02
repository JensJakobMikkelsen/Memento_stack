using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoEditor.Editor;

namespace PhotoEditor.Commands
{
    public class Rotate180Command: ICommand
    {
        private IPhotoEditor _editor;
        public Rotate180Command(IPhotoEditor editor)
        {
            _editor = editor;
        }
        public void Execute()
        {
            _editor.Rotate180();
        }

        public void ReExecute()
        {
            throw new NotImplementedException();
        }

        public void UnExecute()
        {
            _editor.Rotate180();
        }
    }
}
