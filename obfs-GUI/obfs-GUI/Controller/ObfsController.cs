using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using obfs_GUI.Model;
using System.Diagnostics;

namespace obfs_GUI.Controller
{
    class ObfsController
    {
        private OpenObfsParems openObfsParams;
        private System.Diagnostics.ProcessStartInfo newObfsInfo;
        System.Diagnostics.Process listFiles;

        public ObfsController(OpenObfsParems openObfsParamsData)
        {
            openObfsParams = openObfsParamsData;
            string Params = "scramblesuit --dest " + openObfsParams.StartParams.DestIP + ":" + openObfsParams.StartParams.DestPort + " --password " + openObfsParams.StartParams.Password + "  client " + openObfsParams.StartParams.LocalIP + ":" + openObfsParams.StartParams.LocalPort;
            newObfsInfo = new System.Diagnostics.ProcessStartInfo(openObfsParams.ExeFilePath, Params);

        }
        public void OpenObfs()
        {
            //newObfsInfo = new System.Diagnostics.ProcessStartInfo(openObfsParams.ExeFilePath, Params);
            newObfsInfo.RedirectStandardOutput = true;
            newObfsInfo.CreateNoWindow = true;
            newObfsInfo.UseShellExecute = false;
            
            listFiles = System.Diagnostics.Process.Start(newObfsInfo);
            System.IO.StreamReader myOutput = listFiles.StandardOutput;
            System.Console.WriteLine(myOutput.ReadToEnd());
        }
        public void StopObfs()
        {
            listFiles.Kill();
        }
    }
}
