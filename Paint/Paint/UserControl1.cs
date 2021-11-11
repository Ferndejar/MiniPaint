using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Paint
{
    public delegate void OkEraserHandler(Object sender, EventArgs e);
    public delegate void OkEraseHandler(Object sender, EventArgs e);
    public delegate void OkColorHandler(Object sender, EventArgs e);


    public partial class UserControl1 : UserControl 
    {
        private ColorDialog kolor;

        public Bitmap OriginalImage { get; }
        private Graphics g = null;
        private Bitmap bitmapObj;
        private Pen pioro;

        public event OkEraserHandler EraserClick;
        public event OkEraseHandler EraseClick;
        public event OkColorHandler ColorClick;
        public event EventHandler<MouseEventArgs> PictureBoxMouseDownEvent;
        public event EventHandler<MouseEventArgs> PictureBoxMouseMoveEvent;
        public event EventHandler<MouseEventArgs> PictureBoxMouseUpvent;

        public UserControl1()
        {
            InitializeComponent();
            kolor = new ColorDialog();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            OriginalImage = new Bitmap(pictureBox1.Image);
            bitmapObj = new Bitmap(pictureBox1.Image);
            g = Graphics.FromImage(pictureBox1.Image);
            pioro = new Pen(Color.Red, float.Parse(cmb_PenSize.Text));
            pioro.StartCap = LineCap.Round;
            pioro.EndCap = LineCap.Round;
            g.Clear(Color.White);
        }
     

        private void GumkaButton_Click(object sender, EventArgs e)
        {
            if (EraserClick == null) return;
            EraserClick(sender, e);
        }

        private void wyczyscButton_Click(object sender, EventArgs e)
        {
            if (EraseClick == null) return;
            EraseClick(sender, e);
        }

        private void kolorButton_Click(object sender, EventArgs e)
        {
            if (ColorClick == null) return;
            ColorClick(sender, e);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            EventHandler<MouseEventArgs> handler = PictureBoxMouseDownEvent;
            if (handler != null)
            {
                handler(sender, e);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            EventHandler<MouseEventArgs> handler = PictureBoxMouseMoveEvent;
            if (handler != null)
            {
                handler(sender, e);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            EventHandler<MouseEventArgs> handler = PictureBoxMouseUpvent;
            if (handler != null)
            {
                handler(sender, e);
            }
        }
    }
}
