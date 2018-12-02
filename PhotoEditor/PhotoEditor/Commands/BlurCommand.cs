using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoEditor.Editor;

namespace PhotoEditor.Commands
{
    public class BlurCommand:ICommand
    {
        private IPhotoEditor _editor;
        public BlurCommand(IPhotoEditor editor)
        {
            _editor = editor;
        }

        public void Execute()
        {
            _editor.Blur();
        }

        public void UnExecute()
        {
            Console.WriteLine("Unblur");
        }
    }
}
