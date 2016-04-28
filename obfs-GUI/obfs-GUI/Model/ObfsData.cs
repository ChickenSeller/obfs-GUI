using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obfs_GUI.Model
{
    class ObfsData
    {

    }
    class OpenObfsParems
    {
        public string ExeFilePath;
        public ObfsStartParams StartParams;
        public string Status;
        public OpenObfsParems(string exeFilePath,ObfsStartParams startParams)
        {
            ExeFilePath = exeFilePath;
            StartParams = startParams;
            Status = "Idle";
        }
    }
    class ObfsStartParams
    {
        public string DestIP;
        public string DestPort;
        public string LocalIP;
        public string LocalPort;
        public string Password;
        public ObfsStartParams(string destIP,string destPort,string localIP,string localPort,string password)
        {
            DestIP = destIP;
            DestPort = destPort;
            LocalIP = localIP;
            LocalPort = localPort;
            Password = password;
        }
    }

    class TaskList
    {

    }
}
