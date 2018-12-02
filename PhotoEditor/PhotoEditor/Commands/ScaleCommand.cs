using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoEditor.Editor;

namespace PhotoEditor.Commands
{
    public class ScaleCommand:ICommand
    {
        private IPhotoEditor _editor;
        public ScaleCommand(IPhotoEditor editor)
        {
            _editor = editor;
        }

        public void Execute()
        {
            _editor.Scale();
        }

        public void ReExecute()
        {
            throw new NotImplementedException();
        }

        public void UnExecute()
        {
            Console.WriteLine("Reverting back to previous scale");
        }
    }
}