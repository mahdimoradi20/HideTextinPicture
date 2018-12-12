using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HideTextInPic
{
    public partial class Form1 : Form
    {
        private string filename;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Select a Picture!";
            if(of.ShowDialog() == DialogResult.OK){

                filename = of.FileName;
                Bitmap bmp = new Bitmap(filename);
                if (bmp.Width > 300)
                {
                    picAsli.Image = bmp;
                }
                else {
                    MessageBox.Show("We cannot Convert This image!\n\n it is too small\n\nSelect another!");
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(@"In the Name of God
1- Click On open for Open your Pic!
2- You Can Check it for hide Text By clicking On Check!
3- Enter Your Text in Text! We Hide it!
4- Click on Convert For Convert To Pic With Text!
5- Click Save!");
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            char[] ch = str.ToCharArray();
            Bitmap bmp = new Bitmap(picAsli.Image);
            int wid = 0;
            Color cl;
            for (int i = 0; i < ch.Length; i++)
            {
                cl = bmp.GetPixel(wid, 0);
                bmp.SetPixel(wid,0,Color.FromArgb((int)ch[i],cl.G,cl.B));
                wid += 3;
            }
            cl = bmp.GetPixel(wid, 0);
            bmp.SetPixel(wid, 0, Color.FromArgb((int)'*', cl.G, cl.B));
            picTabdil.Image = bmp;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Please Select a path for saving:";
            string str = filename.Substring(filename.LastIndexOf('.'));
            sf.Filter = "Pic"+ "|*" + str;
            if (sf.ShowDialog() == DialogResult.OK)
            {
                
                Bitmap img = new Bitmap(picTabdil.Image);
                img.Save(sf.FileName);
            }
           
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(picAsli.Image);
            Color cl;
            bool flag = false;
            for (int i = 0; i < bmp.Width; i++)
            {
                cl = bmp.GetPixel(i,0);
                if (cl.R == 42) {

                    flag = true;
                }
            }
            if (flag)

                MessageBox.Show("This picture try to hide a text in itself!");

            else

                MessageBox.Show("Don\'t worry! It is a Normal Image!!");

            char[] ch = new char[101];

            if (flag)
            {
                
                int j = 0;
                for(int i = 0 ; i < bmp.Width ; i+=3){

                    cl = bmp.GetPixel(i,0);
                    if(cl.R == 42)
                        break;
                    ch[j++] = (char)cl.R;
                }
            }
            if (flag)
            {

                String str = new String(ch);
                MessageBox.Show("Text is:\n\n" + str);
            }
        }
           
    }
}
