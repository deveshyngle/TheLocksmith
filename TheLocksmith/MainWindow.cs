using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheLocksmith
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            AnsBox.Text = TheLocksmith.Program.Encrypt(DataBox.Text, KeyBox.Text);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(AnsBox.Text);
        }
    }
}
