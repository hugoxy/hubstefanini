using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hub_stefanini_1
{
    public partial class TelaZero : UserControl
    {
        public TelaZero()
        {
            InitializeComponent();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            	textBox1.Text = DateTime.Now.ToLongTimeString();

        }

        private void pcFace_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/StefaniniIT/");
        }

        private void pcLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/company/stefanini/");
        }

        private void pcYou_Click(object sender, EventArgs e)
        {
        
            
        }

        private void pcTwt_Click(object sender, EventArgs e)
        {
       
            System.Diagnostics.Process.Start("https://twitter.com/StefaniniGlobal");
        }

        private void labelCopy_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/hugoxy");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oi, meu nome é Shophie e eu sou Assistente Virtual Inteligente da Stefanini", "Sophie - Assistente Virtual Inteligente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
