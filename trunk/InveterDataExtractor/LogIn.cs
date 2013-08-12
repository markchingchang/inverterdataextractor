using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InveterDataExtractor
{
    class LogIn
    {
        private bool _rememberMe = false;
        private FileStream fs;

        private const string FileName = "ExtractorLogin.np";

        private readonly string _filePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),FileName);
        public LogIn()
        {
            

        }

        public void Rememberme()
        {
            _rememberMe = true;
        }




    }
}
