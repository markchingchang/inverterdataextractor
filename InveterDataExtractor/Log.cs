using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InveterDataExtractor
{
    public enum LogCtrl
    {
        Exists,
        Created,
        Error,
        Info,
        TX,
        RX,
        WriteError,
        OK,
        none,
    }
    
    public class Log
    {

        




        private readonly string _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private readonly string _appName;
        private string _fullPath;

        public Log()
        {
            
        }


        public Log(string appName)
        {
            _appName = appName;

            CreateLog(Path.Combine(_folderPath, _appName, "Log"));
        }

        public LogCtrl CreateLog(string path)
        {

            System.IO.Directory.CreateDirectory(path);
            
            _fullPath = path + "\\" + GetDate() + ".txt";

            if(File.Exists(_fullPath))
                return LogCtrl.Exists;

            File.Create(_fullPath);

            if (File.Exists(_fullPath))
                return LogCtrl.Created;


            return LogCtrl.Error;
        }

        public bool FileExists()
        {
            return File.Exists(_fullPath);
        }

        static public string GetDate()
        {
            return DateTime.Now.Date.ToString().Substring(0,10);
        }

        public LogCtrl WriteToLog(string logMsg, LogCtrl ctrl = LogCtrl.none)
        {
            if (FileExists())
            {
                FileStream fs = File.Open(_fullPath, FileMode.Append, FileAccess.Write, FileShare.Read);

                if (fs.CanWrite)
                {

                    logMsg = GetDate() + " " + getTime() + "\t[" + (ctrl == LogCtrl.none ? "" : ctrl.ToString())  + "]\t" + logMsg + "\r\n";
                    
                    byte[] info = new UTF8Encoding(true).GetBytes(logMsg);
                    fs.Write(info, 0, info.Length);
                    fs.Close();
                }


                return LogCtrl.OK;
            }

            return LogCtrl.WriteError;
        }


        private string getTime()
        {
            
            return DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + "." +
                   DateTime.Now.Millisecond.ToString();
        }


       

    }




}
