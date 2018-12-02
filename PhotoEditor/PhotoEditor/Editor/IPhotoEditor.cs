using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor.Editor
{
    public interface IPhotoEditor
    {
        void Blur();
    
        void RotateRight90();
        void RotateLeft90();
        void Rotate180();
        void CinematicFilter();
        void Scale();

    }
}
