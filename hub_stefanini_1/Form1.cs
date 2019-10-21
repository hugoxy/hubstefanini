using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;



namespace hub_stefanini_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            telaUm1.Visible = false;
            webBrowser1.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnSair.Top;
            SidePanel.Height = btnSair.Height;
            Thread.Sleep(100);
            System.Environment.Exit(0);
        }

        private void btnHoras_Click(object sender, EventArgs e)
        {

            SidePanel.Height = btnHoras.Height;
            SidePanel.Top = btnHoras.Top;
            telaZero1.Visible = false;
            telaUm1.Visible = true;
            webBrowser1.Visible = false;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            telaZero1.Visible = true;
            telaUm1.Visible = false;
            webBrowser1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPonto.Height;
            SidePanel.Top = btnPonto.Top;
            telaUm1.Visible = false;
            telaZero1.Visible = false;
            webBrowser1.Visible = true;
            webBrowser1.BringToFront();
            webBrowser1.Navigate("http://portalhoras.stefanini.com/");
            btnScreen.BringToFront();

            while ((webBrowser1.ReadyState != WebBrowserReadyState.Complete))
            {
                Application.DoEvents();
                Thread.Sleep(100);
            }

            //webBrowser1.Document.GetElementById("txtUserName").InnerText = "seu usuario";
            // webBrowser1.Document.GetElementById("txtPassword").InnerText = "sua senha";
            // webBrowser1.Document.GetElementById("Submit").InvokeMember("click");
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://stefanini.com/");
        }

        //Veriaveis para Screen Shot:
        ImageFormat img; Bitmap bt; Graphics screenShot;

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnScreen.Height;
            SidePanel.Top = btnScreen.Top;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //this.Hide();
                // This gives time to the Form to hide before it takes the screenshot. 500 miliseconds are enough.
                //Thread.Sleep(500);


                // Set the image to the size of the screen.
                bt = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
                // Creates the graphic object for the image (bt).    
                screenShot = Graphics.FromImage(bt);
                // Takes the screenshot.
                screenShot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
                img = ImageFormat.Jpeg;

                // Saves the image.
                bt.Save(saveFileDialog1.FileName, img);
                // After the screenshot is taken the Form reappears.
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
        }







    }


}





