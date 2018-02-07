using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Menu
{
    public static class CutomCommands
    {
        public static readonly RoutedUICommand Exit = new RoutedUICommand("Exit from App", "Exit", typeof(CutomCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.Q, ModifierKeys.Control)
            }
            );
    }
}
