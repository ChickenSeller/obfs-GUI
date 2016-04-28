using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using obfs_GUI.Controller;
using obfs_GUI.Model;
using System.Threading;

namespace obfs_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ObfsController c1;
        private void Form1_Load(object sender, EventArgs e)
        {
            ObfsStartParams startParams = new ObfsStartParams("106.187.44.14", "58081", "127.0.0.1", "65521", "GSGHJGHVFDCFXSSFCADAFSGDNGMJGHGF");
            OpenObfsParems openParams = new OpenObfsParems("obfsproxy.exe", startParams);
            c1 = new ObfsController(openParams);
            Thread t1 = new Thread(new ThreadStart(c1.OpenObfs));
            t1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1.StopObfs();
        }
    }
}
