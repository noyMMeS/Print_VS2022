using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Print_VS2022
{
    public partial class frmPrint : Form
    {
        public Bitmap bmp;
        public Graphics g;
        public bool isDrawing = false;
        public Point startPoint;
        public Point lastPoint;
        public string currentTool = "Brush";
        public Color currentColor = Color.Black;
        public Rectangle selectionRect;
        public bool isFillShape = false;
        public SolidBrush superBrush = new SolidBrush(Color.Black);

        public frmPrint()
        {
            InitializeComponent();
        }

        public void frmPrint_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pctrbox.Width, pctrbox.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pctrbox.Image = bmp;
            lblSize.Text = $"{bmp.Width} x {bmp.Height}";
        }

        public void pctrbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            isDrawing = true;
            startPoint = e.Location;
            lastPoint = e.Location;

            if (currentTool.Equals("Fill", StringComparison.OrdinalIgnoreCase))
            {
                FloodFill(e.Location, currentColor);
                pctrbox.Invalidate();
                isDrawing = false;
            }
        }

        public void pctrbox_MouseMove(object sender, MouseEventArgs e)
        {
            lblCords.Text = $"X: {e.X} Y: {e.Y}";
            if (!isDrawing) return;

            bool isFreeDraw = currentTool.Equals("Pen", StringComparison.OrdinalIgnoreCase) ||
                              currentTool.Equals("Brush", StringComparison.OrdinalIgnoreCase) ||
                              currentTool.Equals("Eraser", StringComparison.OrdinalIgnoreCase);

            if (isFreeDraw)
            {
                Color penColor = currentTool.Equals("Eraser", StringComparison.OrdinalIgnoreCase) ? Color.White : currentColor;
                int penWidth = currentTool.Equals("Brush", StringComparison.OrdinalIgnoreCase) ? 5 : (currentTool.Equals("Eraser", StringComparison.OrdinalIgnoreCase) ? 15 : 1);

                using (Pen pen = new Pen(penColor, penWidth))
                {
                    pen.StartCap = pen.EndCap = LineCap.Round;
                    g.DrawLine(pen, lastPoint, e.Location);
                }
                lastPoint = e.Location;
            }
            pctrbox.Invalidate();
        }

        public void pctrbox_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;
            isDrawing = false;
            Rectangle rect = GetRect(startPoint, e.Location);

            if (currentTool.Equals("Select", StringComparison.OrdinalIgnoreCase))
            {
                selectionRect = rect;
            }
            else
            {
                using (Pen pen = new Pen(currentColor, 2))
                {
                    DrawShape(g, pen, rect, currentTool);
                }
            }
            pctrbox.Invalidate();
        }

        public void pctrbox_Paint(object sender, PaintEventArgs e)
        {
            if (!isDrawing) return;
            Point currentPoint = pctrbox.PointToClient(Cursor.Position);
            Rectangle rect = GetRect(startPoint, currentPoint);

            using (Pen pen = new Pen(currentColor, 2))
            using (Pen dashedPen = new Pen(Color.Gray, 1) { DashStyle = DashStyle.Dash })
            {
                if (currentTool.Equals("Select", StringComparison.OrdinalIgnoreCase))
                    e.Graphics.DrawRectangle(dashedPen, rect);
                else
                    DrawShape(e.Graphics, pen, rect, currentTool);
            }
        }

        public void btnTools_Click(object sender, EventArgs e) =>
            currentTool = sender is Button btn ? (btn.Tag != null ? btn.Tag.ToString() : btn.Text) : currentTool;

        public void btnColors_Click(object sender, EventArgs e) =>
            currentColor = sender is Button btn ? (btn.BackColor != SystemColors.Control ? btn.BackColor : Color.Black) : currentColor;

        public void btnTab_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                pnlIndicator.Left = btn.Left;
                pnlIndicator.Width = btn.Width;
            }
        }

        public void btnRotate_Click(object sender, EventArgs e)
        {
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pctrbox.Size = new Size(bmp.Width, bmp.Height);
            g.Dispose();
            g = Graphics.FromImage(bmp);
            lblSize.Text = $"{bmp.Width} x {bmp.Height}";
            pctrbox.Invalidate();
        }

        public void btnCopy_Click(object sender, EventArgs e)
        {
            Rectangle rect = Rectangle.Intersect(new Rectangle(0, 0, bmp.Width, bmp.Height), selectionRect);
            if (rect.Width <= 0 || rect.Height <= 0) return;

            using (Bitmap copyBmp = bmp.Clone(rect, bmp.PixelFormat))
            {
                Clipboard.SetImage(copyBmp);
            }
        }

        public void btnPaste_Click(object sender, EventArgs e)
        {
            if (!Clipboard.ContainsImage()) return;
            using (Image clipImg = Clipboard.GetImage())
            {
                if (clipImg == null) return;
                g.DrawImage(clipImg, 0, 0);
                pctrbox.Invalidate();
            }
        }

        public void DrawShape(Graphics gr, Pen pen, Rectangle rect, string tool)
        {
            int side = Math.Min(rect.Width, rect.Height);
            Point[] triangle = {
                new Point(rect.X + rect.Width / 2, rect.Y),
                new Point(rect.X, rect.Bottom),
                new Point(rect.Right, rect.Bottom)
            };

            switch (tool.ToLower())
            {
                case "rectangle": gr.DrawRectangle(pen, rect); if (isFillShape) gr.FillRectangle(superBrush, rect); break;
                case "square": gr.DrawRectangle(pen, new Rectangle(rect.X, rect.Y, side, side)); if (isFillShape) gr.FillRectangle(superBrush, rect); break;
                case "circle": gr.DrawEllipse(pen, rect); if (isFillShape) gr.FillRectangle(superBrush, rect); break;
                case "triangle": gr.DrawPolygon(pen, triangle); if (isFillShape) gr.FillRectangle(superBrush, rect); break;
            }
        }

        public Rectangle GetRect(Point p1, Point p2) => new Rectangle(
            Math.Min(p1.X, p2.X),
            Math.Min(p1.Y, p2.Y),
            Math.Abs(p1.X - p2.X),
            Math.Abs(p1.Y - p2.Y)
   );

        public void FloodFill(Point start, Color fillColor)
        {
            Color targetColor = bmp.GetPixel(start.X, start.Y);
            if (targetColor.ToArgb() == fillColor.ToArgb()) return;

            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(start);

            while (pixels.Count > 0)
            {
                Point pt = pixels.Pop();
                if (pt.X < 0 || pt.X >= bmp.Width || pt.Y < 0 || pt.Y >= bmp.Height) continue;

                if (bmp.GetPixel(pt.X, pt.Y).ToArgb() == targetColor.ToArgb())
                {
                    bmp.SetPixel(pt.X, pt.Y, fillColor);
                    pixels.Push(new Point(pt.X + 1, pt.Y));
                    pixels.Push(new Point(pt.X - 1, pt.Y));
                    pixels.Push(new Point(pt.X, pt.Y + 1));
                    pixels.Push(new Point(pt.X, pt.Y - 1));
                }
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {

        }

        private void btnpalette_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = currentColor;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    currentColor = colorDialog.Color;
                    btnpalette.BackColor = currentColor;
                }
            }

        }
        public void btnFillToggle_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = currentColor;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    superBrush.Color = currentColor;
                    isFillShape = true;
                }
            }
        }

    }
}
