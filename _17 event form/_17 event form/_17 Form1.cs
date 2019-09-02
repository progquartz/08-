using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(CopyFile );
            t.Start();
        }

        private void CopyFile()
        {
            FileManager fm = new FileManager();

            fm.InProgress += Fm_InProgress;
            fm.InProgress += Fm_InProgress2;
            fm.Copy("src.mp4", "dest.mp4");
        }

        private void Fm_InProgress2(object sender, double e) // 이벤트 핸들러 추가
        {
            Debug.WriteLine("Progress {0}", e);
        }
        private void Fm_InProgress(object sender, double e) // 이벤트 핸들러 추가
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler<double>(Fm_InProgress), sender, e);
            }
            else
            {
                this.progressBar1.Value = (int)e;
                this.lblpct.Text = string.Format("{0} %", (int)e);
            }
           
        }
    }
}
