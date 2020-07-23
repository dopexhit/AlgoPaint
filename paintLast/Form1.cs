using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Drawing.Drawing2D;

namespace paintLast
{
    public partial class Form1 : Form
    {
        public Point x = new Point();
        public Point y = new Point();
        public Pen p = new Pen(Color.Black,3);
        public Graphics g;
        int PW;
        bool Hided;
        bool notespanel_showing = false;
        bool flowpanel1 = false;
       // public Stack<PictureBox> pic = new Stack<PictureBox>();
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            PW = Spanal.Width;
            Hided = false;
            
    }

        public void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            y = e.Location;
        }

        public void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                x = e.Location;
                g.DrawLine(p, x, y);
                y = x;
            }

        }

        private void colorbut_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog()==DialogResult.OK)
            {
                p.Color = cd.Color;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            p.Color = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void notesbut_Click(object sender, EventArgs e)
        {
            //timer1.Start();

            Spanal.Visible = true;
            algoBox.Visible = true;
            if (upldbut.Visible == false)
            {
                upldbut.Visible = true;
            }
            else
            {
                upldbut.Visible = false;
            }

            if (notesControl.Visible==false)
            {
                notesControl.Visible = true;
            }
            else
            {
                notesControl.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Hided)
            {
               
                Spanal.Width = Spanal.Width + 20;
                if(Spanal.Width>=PW)
                {
                    timer1.Stop();
                    Hided = false;
                    //this.Refresh();
                }
            }
            else
            {
                Spanal.Width = Spanal.Width - 20;
                if (Spanal.Width <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                    //this.Refresh();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult d = fontDialog1.ShowDialog();
            if(d== DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(upldbut.Visible==false)
            {
                upldbut.Visible = true;
            }
            else
            {
                upldbut.Visible = false;
            }
            //notesControl.Visible = true;
            Spanal.Visible = true;
            algoBox.Visible = true;

            if (notesControl.Visible == false)
            {
                notesControl.Visible = true;
            }
            else
            {
                notesControl.Visible = false;
            }

           /* if (flowLayoutPanel2.Visible == false)
            {
                flowLayoutPanel2.Visible = true;
            }
            else
                flowLayoutPanel2.Visible = false;*/
        }


        private void Spanal_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(Application.ExecutablePath);
            string filename = Path.Combine(dir, @"insertion-sort-pseudocode-n.jpg");
            algoBox.BackgroundImage = Image.FromFile(filename);
        }

        private void mergeBox_Click(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(Application.ExecutablePath);
            string filename = Path.Combine(dir, @"mergesort.jpg");
            algoBox.BackgroundImage = Image.FromFile(filename);
        }

        private void quickBox_Click(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(Application.ExecutablePath);
            string filename = Path.Combine(dir, @"quicksort.png");
            algoBox.BackgroundImage = Image.FromFile(filename);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(Application.ExecutablePath);
            string filename = Path.Combine(dir, @"bucket-sort.jpg");
            algoBox.BackgroundImage = Image.FromFile(filename);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(Application.ExecutablePath);
            string filename = Path.Combine(dir, @"counting-sort.jpg");
            algoBox.BackgroundImage = Image.FromFile(filename);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(Application.ExecutablePath);
            string filename = Path.Combine(dir, @"insertion-sort-pseudocode-n.jpg");
            algoBox.BackgroundImage = Image.FromFile(filename);
            algoBox.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
   (System.Environment.SpecialFolder.Personal) + @"\binaryS.png");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(Application.ExecutablePath);
            string filename = Path.Combine(dir, @"kadaneS.png");
            algoBox.BackgroundImage = Image.FromFile(filename);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if(dialog.ShowDialog()==DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    algoBox.ImageLocation = imageLocation;
                    
                }

            }
            catch(Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void algoBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            DialogResult d = fontDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            p.Width = trackBar1.Value;
        }

       
    }
}
