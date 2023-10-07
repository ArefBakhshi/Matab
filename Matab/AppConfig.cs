using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matab
{
    public static class AppConfig
    {
        // public static string ConnectionString = "Data Source=.;Initial Catalog=Matab;Integrated Security=True;";
        public static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Matab.mdf;Integrated Security=True;";
    }
}
