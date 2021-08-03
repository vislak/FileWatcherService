using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
namespace FileWatcherService
{
    class FileWatcher
    {
        FileSystemWatcher objWatcher;
        public FileWatcher()
        {
            objWatcher = new FileSystemWatcher();
            objWatcher.Path =ConfigurationManager.AppSettings["FilePath"] ;
            objWatcher.Filter = "*.txt";
            objWatcher.NotifyFilter = NotifyFilters.DirectoryName | NotifyFilters.FileName
                | NotifyFilters.LastWrite | NotifyFilters.LastAccess;
            objWatcher.Created += ObjWatcher_Created;
            objWatcher.Renamed += ObjWatcher_Renamed;
            objWatcher.Deleted += ObjWatcher_Deleted;
            objWatcher.EnableRaisingEvents = true;
        }

        private void ObjWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Logger.Log(string.Format("file deleted {0}", e.FullPath));
        }

        private void ObjWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            Logger.Log(string.Format("file Renamed from {0} to {1}", e.OldFullPath, e.FullPath));
        }

        private void ObjWatcher_Created(object sender, FileSystemEventArgs e)
        {
            Logger.Log(string.Format("file created {0}",e.FullPath));

        }
    }
}
