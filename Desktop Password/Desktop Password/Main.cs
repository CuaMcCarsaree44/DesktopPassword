using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desktop_Password
{
    public partial class Main : Form
    {
        protected internal string execute = "TBSq50715";
        PasswordManagement Holo = new PasswordManagement();
        private static Main Instance;


        public Main()
        {
            InitializeComponent();
        }

        public static Main getInstance()
        {
            if (Instance == null)
            {
                new Main();
            }
            return Instance;
        }

        private void cmdButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD.exe");
        }

        private void ShutdownButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            System.Diagnostics.Process Proc = new System.Diagnostics.Process();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown /s";
            Proc.StartInfo = startInfo;
            Proc.Start();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            PasswordTextbox.Text = "";
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text.Equals(execute))
            {
                Holo.Show();
                this.Enabled = false;
            }
        }

        public void Enabler() { this.Enabled = true; }

        public static void opened()
        {
            //Enabler();
        }

        private void Main_MouseLeave(object sender, EventArgs e)
        {
           

        }
    }
}
