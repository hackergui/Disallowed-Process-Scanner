using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IllegalProcessScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Checker.Start();
        }

        private void Checker_Tick(object sender, EventArgs e)
        {
            Check("dnSpy"); // You can add another processes
        }

        private void Check(String procName)
        {
            Process[] processes = Process.GetProcessesByName(procName);
            foreach (Process name in processes)
            {
                if (name.ProcessName.Contains(procName))
                {
                    name.Kill();
                    Process.Start("https://www.youtube.com/channel/UCA9NKzZym6coY-XFyYTw9fQ");
                    Environment.Exit(0);
                }
            }
        }

    }
}
