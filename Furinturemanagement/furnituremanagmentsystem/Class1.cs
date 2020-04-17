using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace furnituremanagmentsystem
{
    static class global
    {
        private static int _globalLoggedUserId = 0;
        private static string _globalLoggedUserName = ""; 
        private static bool _globalLoggedCustomer = false;
        private static bool _globalLoggedAdmin = false;

        
        public static int GlobalLoggedUserId
        {
            get { return _globalLoggedUserId; }
            set { _globalLoggedUserId = value; }
        }
        public static string GlobalLoggedUserName
        {
            get { return _globalLoggedUserName; }
            set { _globalLoggedUserName = value; }
        }
        public static bool GlobalLoggedCustomer
        {
            get { return _globalLoggedCustomer; }
            set { _globalLoggedCustomer = value; }
        }
        public static bool GlobalLoggedAdmin
        {
            get { return _globalLoggedAdmin; }
            set { _globalLoggedAdmin = value; }
        }
        
    }
}
