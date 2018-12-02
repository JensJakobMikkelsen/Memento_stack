using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoEditor.Commands;
using PhotoEditor.Editor;
using PhotoEditor.Memento;

namespace PhotoEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Application
            
            Invoker _Invoker = new Invoker();
            IPhotoEditor _Editor = new Editor.PhotoEditor();
            BlurCommand Blur = new BlurCommand(_Editor);
            CinematicFilterCommand Cinematic = new CinematicFilterCommand(_Editor);
            Rotate90Command Rotate90 = new Rotate90Command(_Editor);
            Rotate180Command Rotate180 = new Rotate180Command(_Editor);
            ScaleCommand Scale = new ScaleCommand(_Editor);

            //Macro Command

            List<ICommand> Scale_Cinematic = new List<ICommand>();
            Scale_Cinematic.Add(Scale);
            Scale_Cinematic.Add(Cinematic);

            MacroCommand Macro_Scale_Cinematic = new MacroCommand(Scale_Cinematic);
         
           

            Console.WriteLine("Menu:\nq: Blur\nw: Cinematic filter\ne: Scale image\nr: Rotate 90\nt: Rotate 180\ny: Macro command\nz: undo\nx: redo\nc: exit");

            bool run = true;
            while (run)
            {

                var keyInput = Console.ReadLine();

                switch (keyInput)
                {
                    case "q":
                        _Invoker.SetCommand(Blur);
               
                        _Invoker.Execute();
                      
                        break;

                    case "w":
                        _Invoker.SetCommand(Cinematic);
                    
                        _Invoker.Execute();
                        
                        break;
                    case "e":
                        _Invoker.SetCommand(Scale);
               
                       _Invoker.Execute();
                      
                        break;
                    case "r":
                        _Invoker.SetCommand(Rotate90);
             
                        _Invoker.Execute();
                        
                       
                        break;
                    case "t":
                        _Invoker.SetCommand(Rotate180);
              
                        _Invoker.Execute();
                     
                        break;
                    case "y":
                        //Macro.Execute();
                        _Invoker.SetCommand(Macro_Scale_Cinematic);
                        _Invoker.Execute();
                        break;
                    case "z":
                    
                        _Invoker.UnExecute();
                      
                        break;
                    case "x":
                        _Invoker.ReExecute();
                        break;
                    case "c":
                        run = false;
                        break;

                }
            }
        }
    }
}
