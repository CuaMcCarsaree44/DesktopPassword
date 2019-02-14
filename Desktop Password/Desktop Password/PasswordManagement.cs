using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desktop_Password
{
    public partial class PasswordManagement : Form
    { 
        public PasswordManagement()
        {
            InitializeComponent();
        }

        public void PasswordManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.opened();
        }
    }
}
