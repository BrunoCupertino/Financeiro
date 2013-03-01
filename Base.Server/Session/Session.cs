using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Base.Server.Model;

namespace Base.Server.Session
{
    public class Session
    {
        public static User CurrentUser { get; private set; }
        public static bool IsLogged 
        {
            get { return CurrentUser == null; }
        }

        public static void LogOn(User user)
        {
            CurrentUser = user;
        }

        public static void LogOff()
        {
            CurrentUser = null;
        }
    }
}
