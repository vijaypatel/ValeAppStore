using System;
using System.Collections.Generic;

namespace ValeAppStore
{
    public class UserInfo
    {
        public string UserName
        {
            get;
            set;
        }

        public string Location
        {
            get;
            set;
        }

        public IList<string> Roles
        {
            get;
            set;
        }
    }
}

