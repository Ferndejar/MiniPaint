using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Paint : Form
    {
        ColorDialog color;
        Pen pen;
        Point point = new Point(0, 0);

        private float angle = 0.0f;
        private Bitmap OriginalImage = null;
        private int X0, Y0, X1, Y1;
        private bool SelectingArea = false;
        private Bitmap SelectedImage = null;
        private Graphics g = null;
        private Bitmap bitmapObj;
        private Rectangle SelectedRect;
        private bool MadeSelection = false;
        readonly Stack<Bitmap> UndoStack = new Stack<Bitmap>();
        readonly Stack<Bitmap> RedoStack = new Stack<Bitmap>();
        

        public Paint()
        {
            InitializeComponent();

            panel1.BackColor = Color.Aquamarine;
            color = new ColorDialog();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            OriginalImage = new Bitmap(pictureBox1.Image);
            bitmapObj = new Bitmap(pictureBox1.Image);
            g = Graphics.FromImage(pictureBox1.Image);
            pen = new Pen(Color.Red, float.Parse(gruboscPedzla_cmb.Text));
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            g.Clear(Color.White);
        }

        private void kolorButton_Click(object sender, EventArgs e)
        {
            color.ShowDialog();
            kolorPedzlaButton.BackColor = color.Color;
            pen.Color = color.Color;
        }

        private void wyczyscButton_Click(object sender, EventArgs e)
        {
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            pictureBox1.Refresh();
        }
        private void CopyToClipboard(Rectangle src_rect)
        {
            
            if(zaznacz_rb.Checked)
            {
                Bitmap bm = new Bitmap(src_rect.Width, src_rect.Height);

                
                using (Graphics gr = Graphics.FromImage(bm))
                {
                    Rectangle dest_rect = new Rectangle(0, 0, src_rect.Width, src_rect.Height);
                    gr.DrawImage(OriginalImage, dest_rect, src_rect, GraphicsUnit.Pixel);
                }

                
                Clipboard.SetImage(bm);
            }
        }
          

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
           
                if (e.Button == MouseButtons.Left)
                {
                    if (krzywa_rb.Checked)
                    {
                        g = Graphics.FromImage(pictureBox1.Image);
                        pen.DashStyle = DashStyle.Solid;
                        g.DrawLine(pen, point.X, point.Y, e.X, e.Y);
                        point = e.Location;
                    }
                    if(zaznacz_rb.Checked)
                    {

                    if (!SelectingArea) return;

                        X1 = e.X;
                        Y1 = e.Y;
                       
                        g.DrawImage(OriginalImage, 0, 0);
                    
                        pen.DashStyle = DashStyle.Dash;
                        Rectangle rect = MakeRectangle(X0,Y0,X1,Y1);
                        g.DrawRectangle(pen, rect);
                    }

                    pictureBox1.Refresh();
                }     
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Left)
            {
                point = e.Location;

                  if (zaznacz_rb.Checked)
                  {
                    SelectingArea = true;
                    X0 = e.X;
                    Y0 = e.Y;

                    SelectedImage = new Bitmap(pictureBox1.Image);
                    g = Graphics.FromImage(SelectedImage);
                    pictureBox1.Image = SelectedImage;
                  }
                UndoStack.Push((Bitmap)bitmapObj.Clone());
                RedoStack.Clear();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Left)
            {
                SolidBrush sB = new SolidBrush(pen.Color);
                if (krzywa_rb.Checked || linia_rb.Checked)
                {
                    g = Graphics.FromImage(pictureBox1.Image);
                    pen.DashStyle = DashStyle.Solid;
                    g.DrawLine(pen, point.X, point.Y, e.X, e.Y);
                    OriginalImage = new Bitmap(pictureBox1.Image);
                }
                else if (prostokat_rb.Checked)
                {
                    g = Graphics.FromImage(pictureBox1.Image);
                    if(wypelnienie_cb.Checked)
                    {
                        
                        g.FillRectangle(sB, Math.Min(point.X, e.X), Math.Min(point.Y, e.Y), Math.Abs(point.X - e.X), Math.Abs(point.Y - e.Y));
                    }
                    else
                    {
                        g.DrawRectangle(pen, Math.Min(point.X, e.X), Math.Min(point.Y, e.Y), Math.Abs(point.X - e.X), Math.Abs(point.Y - e.Y));
                    }
                    OriginalImage = new Bitmap(pictureBox1.Image);
                }
                else if (elipsa_rb.Checked)
                {
                    g = Graphics.FromImage(pictureBox1.Image);
                    if (wypelnienie_cb.Checked)
                    {
                        
                        g.FillEllipse(sB, Math.Min(point.X, e.X), Math.Min(point.Y, e.Y), Math.Abs(point.X - e.X), Math.Abs(point.Y - e.Y));
                    }
                    else
                    {
                        g.DrawEllipse(pen, Math.Min(point.X, e.X), Math.Min(point.Y, e.Y), Math.Abs(point.X - e.X), Math.Abs(point.Y - e.Y));
                    }
                    OriginalImage = new Bitmap(pictureBox1.Image);
                }
                else if(zaznacz_rb.Checked)
                {
                    if (!SelectingArea) return;
                    SelectingArea = false;
   
                    g = null;

                    SelectedRect = MakeRectangle(X0, Y0, X1, Y1);
                    MadeSelection = (
                        (SelectedRect.Width > 0) &&
                        (SelectedRect.Height > 0));

                    EnableMenuItems();
                }

            }
            pictureBox1.Refresh();
        }

        private Rectangle MakeRectangle(int x0, int y0, int x1, int y1)
        {
            return new Rectangle(
               Math.Min(x0, x1),
               Math.Min(y0, y1),
               Math.Abs(x0 - x1),
               Math.Abs(y0 - y1));
        }

        private void EnableMenuItems()
        {
                kopiujToolStripMenuItem.Enabled = MadeSelection;
                wytnijToolStripMenuItem.Enabled = MadeSelection;
                wklejToolStripMenuItem.Enabled = MadeSelection;          
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Png|*.png|JPG|*.jpg|Bitmap|*.bmp|Wszystkie formaty|*.png;*.jpg;*.bmp";
            if (save.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(save.FileName);
            }
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                g = Graphics.FromImage(pictureBox1.Image);
                pictureBox1.Refresh();
                OriginalImage = new Bitmap(pictureBox1.Image);
            }
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl1 myUserControl = new UserControl1();
            myUserControl.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage("Nowy");
            myTabPage.Controls.Add(myUserControl);
            tabControl1.TabPages.Add(myTabPage);
            myUserControl.EraseClick += GumkaButton_Click;
            myUserControl.ColorClick += kolorButton_Click;
            myUserControl.EraserClick += wyczyscButton_Click;
            myUserControl.PictureBoxMouseDownEvent += pictureBox1_MouseDown;
            myUserControl.PictureBoxMouseMoveEvent += pictureBox1_MouseMove;
            myUserControl.PictureBoxMouseUpvent += pictureBox1_MouseUp;
        }

        private void wyjdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy napewno chcesz wyjść?", "Wyjdź", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cmb_PenSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen = new Pen(pen.Color, float.Parse(gruboscPedzla_cmb.Text));
        }

        private void GumkaButton_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
        }

        Image ZoomPicture(Image img, Size size)
        {
            Bitmap bmp = new Bitmap(img, Convert.ToInt32(img.Width * size.Width), Convert.ToInt32(img.Height * size.Height));
            g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OriginalImage = new Bitmap(pictureBox1.Image);

            powiekszBar.Minimum = 1;
            powiekszBar.Maximum = 5;
            powiekszBar.SmallChange = 1;
            powiekszBar.LargeChange = 1;
            powiekszBar.UseWaitCursor = false;

            this.DoubleBuffered = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (powiekszBar.Value != 0)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = ZoomPicture(OriginalImage, new Size(powiekszBar.Value, powiekszBar.Value));
            }
        }

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UndoStack.Count > 0)
            {
                RedoStack.Push((Bitmap)bitmapObj.Clone());

                bitmapObj = UndoStack.Pop();
                g = Graphics.FromImage(bitmapObj);
                pictureBox1.Image = bitmapObj;
                pictureBox1.Invalidate();
              
            }
            else
            {
                MessageBox.Show("Nie ma nic do cofnięcia");
            }
            pictureBox1.Refresh();
        }

        private void ponówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RedoStack.Count > 0)
            {
                UndoStack.Push((Bitmap)bitmapObj.Clone());

                bitmapObj = RedoStack.Pop();
                g = Graphics.FromImage(bitmapObj);
                pictureBox1.Image = bitmapObj;
                pictureBox1.Invalidate();

            }
            else
            {
                MessageBox.Show("Nie ma nic do ponowienia");
            }
            pictureBox1.Refresh();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oProgramiePaint a = new oProgramiePaint();
            a.Show();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            
            int numOfCells = pictureBox1.Width;
            int cellSize = 25;
            pen.Color = Color.Black;

            for (int y = 0; y < numOfCells; ++y)
            {
                g.DrawLine(pen, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
          
            }

            for (int x = 0; x < numOfCells; ++x)
            {
                g.DrawLine(pen, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
              
            }

            OriginalImage = new Bitmap(pictureBox1.Image);
            pictureBox1.Refresh();
        }

        private void RotateImage(PictureBox pb, Image img, float angle)
        {
            if (img == null || pb.Image == null)
                return;

            Image oldImage = pb.Image;
            pb.Image = RotatePicturebox.RotateImage(img, angle);
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        }

        private void obróćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            angle += 45.0f;
            RotateImage(pictureBox1, OriginalImage, angle);
        }

        private void drukujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyToClipboard(SelectedRect);
            System.Media.SystemSounds.Beep.Play();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            CopyToClipboard(SelectedRect);

            using (Graphics gr = Graphics.FromImage(OriginalImage))
            {
                using (SolidBrush br = new SolidBrush(Color.White))
                {
                    gr.FillRectangle(br, SelectedRect);
                }
            }

            SelectedImage = new Bitmap(OriginalImage);
            pictureBox1.Image = SelectedImage;

            EnableMenuItems();
            SelectedImage = null;
            g = null;
            MadeSelection = false;

            System.Media.SystemSounds.Beep.Play();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Clipboard.ContainsImage()) return;

            Image clipboard_image = Clipboard.GetImage();

            Rectangle src_rect = new Rectangle(
                0, 0,
                clipboard_image.Width,
                clipboard_image.Height);

            using (Graphics gr = Graphics.FromImage(OriginalImage))
            {
                gr.DrawImage(clipboard_image, SelectedRect,
                    src_rect, GraphicsUnit.Pixel);
            }

            pictureBox1.Image = OriginalImage;
            pictureBox1.Refresh();

            SelectedImage = null;
            g = null;
            MadeSelection = false;
        }
    
    }



}
