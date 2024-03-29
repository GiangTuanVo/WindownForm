using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindownForm
{
    public partial class frmPainting : Form
    {
        private Point Start, End;
        Bitmap bmOfGraphic;
        Graphics graphics;
        bool isDrawing = false;
        Point px, py;
        Pen pen = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int x, y, sX, sY, cX, cY;
        ColorDialog cd = new ColorDialog();
        Color SelectColor = Color.Red;

        public enum TOOL
        {
            SELECT,
            PEN,
            ERASER,
            FILLCOLOR,
            LINE,
            ELLIPSE,
            RECTANGLE,
            TRIANGLE
        }
        public TOOL curTool = TOOL.SELECT;

        public frmPainting()
        {
            InitializeComponent();
            graphics = Area.CreateGraphics();
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
            bmOfGraphic = new Bitmap(Area.Width, Area.Height);
            graphics = Graphics.FromImage(bmOfGraphic);
            graphics.Clear(Color.White);
            Area.Image = bmOfGraphic;
            pen.Width = 5;
        }
        //Selected funtion button
        private void btnFill_Click(object sender, EventArgs e)
        {
            curTool = TOOL.FILLCOLOR;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            curTool = TOOL.RECTANGLE;
        }

        private void Validate(Bitmap bm, Stack<Point> sp, int x, int y, Color Old_Color, Color New_Color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == Old_Color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, New_Color);
            }
        }
        private Point Set_Point(PictureBox area, Point location)
        {
            float px = 1f * area.Width / area.Width;
            float py = 1f * area.Height / area.Height;
            return new Point((int)(location.X * px), (int)(location.Y * py));
        }


        private void Area_MouseClick(object sender, MouseEventArgs e)
        {
            if (curTool == TOOL.FILLCOLOR)
            {
                Point point = Set_Point(Area, e.Location);
                Fill(bmOfGraphic, point.X, point.Y, SelectColor);
            }
        }

        private void Area_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isDrawing)
                {
                    if (curTool == TOOL.PEN)
                    {
                        px = e.Location;
                        graphics.DrawLine(pen, px, py);
                        py = px;
                    }
                    if (curTool == TOOL.ERASER)
                    {
                        px = e.Location;
                        graphics.DrawLine(erase, px, py);
                        py = px;
                    }
                }
                if (curTool == TOOL.TRIANGLE)
                {
                    End = e.Location;
                    label1.Text = $"{Math.Abs(Start.X - End.X)}";
                    this.Invalidate();
                }
            }

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;

            lblCurrentPos.Text = $"Position : X={e.Location.X}, Y={e.Location.Y}";
            Area.Refresh();
        }

        private void Area_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            Start = End = e.Location;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void Area_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;

            sX = x - cX;
            sY = y - cY;

            if (curTool == TOOL.ELLIPSE)
            {
                graphics.DrawEllipse(pen, cX, cY, sX, sY);
            }
            if (curTool == TOOL.RECTANGLE)
            {
                graphics.DrawRectangle(pen, cX, cY, sX, sY);
            }
            if (curTool == TOOL.LINE)
            {
                graphics.DrawLine(pen, cX, cY, x, y);
            }
            if (curTool == TOOL.TRIANGLE)
            {
                End = e.Location;
                this.Invalidate();
                Point point1 = Start;
                Point point2 = new Point(Math.Abs(Start.X + (Start.X - End.X)), End.Y);
                Point point3 = End;
                graphics.DrawPolygon(pen, new Point[] { point1, point2, point3 });
            }
        }

        private void Area_Paint(object sender, PaintEventArgs e)
        {
            Graphics newGraphics = e.Graphics;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (isDrawing)
            {
                if (curTool == TOOL.ELLIPSE)
                {
                    newGraphics.DrawEllipse(pen, cX, cY, sX, sY);

                }
                if (curTool == TOOL.RECTANGLE)
                {
                    newGraphics.DrawRectangle(pen, cX, cY, sX, sY);
                }
                if (curTool == TOOL.LINE)
                {
                    newGraphics.DrawLine(pen, cX, cY, x, y);
                }
                if (curTool == TOOL.TRIANGLE)
                {
                    Point point1 = Start;
                    Point point2 = new Point(Math.Abs(Start.X + (Start.X - End.X)), End.Y);
                    Point point3 = End;
                    newGraphics.DrawPolygon(pen, new Point[] { point1, point2, point3 });
                }
            }
        }


        //Fill color
        private void Fill(Bitmap bm, int x, int y, Color new_Color)
        {
            Color Old_Color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_Color);
            if (Old_Color == new_Color) { return; }

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    Validate(bm, pixel, pt.X - 1, pt.Y, Old_Color, new_Color);
                    Validate(bm, pixel, pt.X, pt.Y - 1, Old_Color, new_Color);
                    Validate(bm, pixel, pt.X + 1, pt.Y, Old_Color, new_Color);
                    Validate(bm, pixel, pt.X, pt.Y + 1, Old_Color, new_Color);
                }
            }
        }
    }
}
