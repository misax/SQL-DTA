﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI
{
    public static class Helper
    {
        public static string ConnectString(string val)
        {
            return ConfigurationManager.ConnectionStrings[val].ConnectionString;
        }
    }
}
