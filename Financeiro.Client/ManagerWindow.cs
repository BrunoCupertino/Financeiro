using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Financeiro.Client
{
    public class WindowManager
    {
        private static Stack<Window> Windows = new Stack<Window>();

        public static void OpenWindow(Window window)
        {
            if (Windows.Count != 0)
            {
                window.Owner = Windows.Peek();
            }

            Windows.Push(window);
        }

        public static void CloseWindows()
        {
            if (Windows.Count != 0)
            {
                Windows.Pop();
            }

            Windows.Peek().ShowActivated = true;
        }
    }

    public interface IManagedWindow<T>
        where T : class
    {
        ModelForTransfer<T> ModelForTransfer { get; set;}
        void OpenWindow(Type window);
        void CloseWindow();
    }
}
