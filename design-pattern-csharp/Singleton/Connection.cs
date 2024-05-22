using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_csharp.Singleton
{
    public class Connection
    {
        private string _host;
        private string _username;
        private string _password;

        public Connection(string host, string username, string password)
        {
            _host = host;
            _username = username;
            _password = password;
        }
    }
}
