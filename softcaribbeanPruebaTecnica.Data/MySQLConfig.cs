using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softcaribbean.Data
{
    public class MySQLConfig
    {
        public MySQLConfig(string connetionString) => ConnectionString = connetionString;

        public string ConnectionString { get; set; }
    }
}
