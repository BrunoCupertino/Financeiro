using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Reflection;

namespace Financeiro.Client
{
    public class Client
    {
        private static Stack<Window> Windows = new Stack<Window>();

        public static void AddWindow(Window window)
        {
            if (Windows.Count != 0)
            {
                window.Owner = Windows.Peek();
            }

            Windows.Push(window);
        }

        public static void RemoveWindows()
        {
            if (Windows.Count != 0)
            {
                Windows.Pop();
            }
            Windows.Peek().ShowActivated = true;
        }
    }

    public enum StateView
    {
        Edit, New
    }

    public class Helper
    {
        public static void CopyOfType<T>(object original, T newObject)
        {
            Type typeOriginal = original.GetType();
            Type typeNewObject = newObject.GetType();

            foreach (PropertyInfo prop in typeOriginal.GetProperties())
            {
                PropertyInfo propertyNew = typeNewObject.GetProperty(prop.Name);

                if (propertyNew != null)
                {
                    propertyNew.SetValue(newObject, prop.GetValue(original, null), null);
                }
            }
        }
    }

    public class ModelForTransfer<T>
        where T : class
    {
        public ModelForTransfer(T original, T modified)
        {
            this.Original = original;
            this.Modified = modified;
        }

        public T Original { get; set; }
        public T Modified { get; set; }
    }
}
