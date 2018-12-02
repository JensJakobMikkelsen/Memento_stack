using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoEditor.Memento;
namespace PhotoEditor.Editor
{
    public class PhotoEditor: IPhotoEditor
    {

        public void Blur()
        {
            Console.WriteLine("Blur");
        }

        public void RotateRight90()
        {
            Console.WriteLine("Rotate right 90 ");
        }

        public void RotateLeft90()
        {
            Console.WriteLine("Rotate left 90 ");
        }

  
        public void Rotate180()
        {
            Console.WriteLine("Rotate 180 ");
        }

        public void CinematicFilter()
        {
            Console.WriteLine("Sweet Cinematic filter on");
        }

        public void Scale()
        {
            Console.WriteLine("Scaling image");
        }

        public void UnScale()
        {
            Console.WriteLine("unscaling image");
        }


        public void CinematicFilterOff()
        {
            Console.WriteLine("Sweet Cinematic filter off");
        }
    }
}
