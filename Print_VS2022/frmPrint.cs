using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Print_VS2022
{
    public partial class frmPrint : Form
    {
        public Bitmap bmp;
        public Graphics g;
        public bool isDrawing = false;
        public bool isMoving = false;
        public Point startPoint;
        public Point lastPoint;
        public string currentTool = "Brush";
        public Color currentColor = Color.Black;
        public Rectangle selectionRect;
        public Bitmap selectedBmp = null;
        public bool isFillShape = false;
        public SolidBrush superBrush = new SolidBrush(Color.Black);
        public float zoom = 1.0f;

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
            pctrbox.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMove.Visible = false;
            pnlView.Visible = false;
            lblSize.Text = $"{bmp.Width} x {bmp.Height}";
        }

        public void pctrbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            Point pt = GetZoomPoint(e.Location);

            if (currentTool.Equals("Move", StringComparison.OrdinalIgnoreCase))
            {
                if (selectionRect.Contains(pt))
                {
                    isMoving = true;
                    lastPoint = pt;
                    return;
                }
                CommitSelection();
                currentTool = "Select";
            }

            isDrawing = true;
            startPoint = pt;
            lastPoint = pt;

            if (currentTool.Equals("Select", StringComparison.OrdinalIgnoreCase))
            {
                selectionRect = Rectangle.Empty;
                btnMove.Visible = false;
            }
            else if (currentTool.Equals("Fill", StringComparison.OrdinalIgnoreCase))
            {
                FloodFill(pt, currentColor);
                pctrbox.Invalidate();
                isDrawing = false;
            }
        }

        public void pctrbox_MouseMove(object sender, MouseEventArgs e)
        {
            Point pt = GetZoomPoint(e.Location);
            lblCords.Text = $"X: {pt.X} Y: {pt.Y}";

            if (isMoving)
            {
                selectionRect.X += pt.X - lastPoint.X;
                selectionRect.Y += pt.Y - lastPoint.Y;
                lastPoint = pt;
                pctrbox.Invalidate();
                return;
            }

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
                    g.DrawLine(pen, lastPoint, pt);
                }
                lastPoint = pt;
            }
            pctrbox.Invalidate();
        }

        public void pctrbox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                isMoving = false;
                pctrbox.Invalidate();
                return;
            }

            if (!isDrawing) return;
            isDrawing = false;

            Point pt = GetZoomPoint(e.Location);
            Rectangle rect = GetRect(startPoint, pt);

            if (currentTool.Equals("Select", StringComparison.OrdinalIgnoreCase))
            {
                selectionRect = rect;
                btnMove.Visible = rect.Width > 0 && rect.Height > 0;
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
            e.Graphics.ScaleTransform(zoom, zoom);

            using (Pen dashedPen = new Pen(Color.Gray, 1) { DashStyle = DashStyle.Dash })
            {
                if (selectedBmp != null)
                {
                    e.Graphics.DrawImage(selectedBmp, selectionRect.X, selectionRect.Y, selectedBmp.Width, selectedBmp.Height);
                    e.Graphics.DrawRectangle(dashedPen, selectionRect);
                    return;
                }

                if (!isDrawing)
                {
                    if (currentTool.Equals("Select", StringComparison.OrdinalIgnoreCase) && selectionRect.Width > 0 && selectionRect.Height > 0)
                    {
                        e.Graphics.DrawRectangle(dashedPen, selectionRect);
                    }
                    return;
                }

                Point currentPoint = GetZoomPoint(pctrbox.PointToClient(Cursor.Position));
                Rectangle rect = GetRect(startPoint, currentPoint);

                if (currentTool.Equals("Select", StringComparison.OrdinalIgnoreCase))
                {
                    e.Graphics.DrawRectangle(dashedPen, rect);
                }
                else
                {
                    using (Pen pen = new Pen(currentColor, 2))
                    {
                        DrawShape(e.Graphics, pen, rect, currentTool);
                    }
                }
            }
        }

        public void btnTools_Click(object sender, EventArgs e)
        {
            CommitSelection();
            if (sender is Button btn)
            {
                currentTool = btn.Tag != null ? btn.Tag.ToString() : btn.Text;
                selectionRect = Rectangle.Empty;
                pctrbox.Invalidate();
            }
        }

        public void btnImage_Click(object sender, EventArgs e)
        {
            CommitSelection();
            currentTool = "Select";
            selectionRect = Rectangle.Empty;
            pctrbox.Invalidate();
        }

        public void btnColors_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                currentColor = btn.BackColor != SystemColors.Control ? btn.BackColor : Color.Black;
            }
        }

        public void btnTab_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                pnlIndicator.Left = btn.Left;
                pnlIndicator.Width = btn.Width;

                pnlRibbon.Visible = btn == btnHome;
                pnlView.Visible = btn == btnView;
            }
        }

        public void btnRotate_Click(object sender, EventArgs e)
        {
            CommitSelection();
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            ApplyZoom(zoom);
            lblSize.Text = $"{bmp.Width} x {bmp.Height}";
            pctrbox.Invalidate();
        }

        public void btnCopy_Click(object sender, EventArgs e)
        {
            if (selectedBmp != null)
            {
                Clipboard.SetImage(selectedBmp);
                return;
            }

            Rectangle rect = selectionRect.Width > 0 && selectionRect.Height > 0
                ? Rectangle.Intersect(new Rectangle(0, 0, bmp.Width, bmp.Height), selectionRect)
                : new Rectangle(0, 0, bmp.Width, bmp.Height);

            if (rect.Width <= 0 || rect.Height <= 0) return;

            using (Bitmap copyBmp = bmp.Clone(rect, bmp.PixelFormat))
            {
                Clipboard.SetImage(copyBmp);
            }
        }

        public void btnPaste_Click(object sender, EventArgs e)
        {
            if (!Clipboard.ContainsImage()) return;

            CommitSelection();
            using (Image clipImg = Clipboard.GetImage())
            {
                if (clipImg == null) return;
                selectedBmp = new Bitmap(clipImg);
                selectionRect = new Rectangle(0, 0, selectedBmp.Width, selectedBmp.Height);
                currentTool = "Move";
                btnMove.Visible = true;
                pctrbox.Invalidate();
            }
        }

        public void DrawShape(Graphics gr, Pen pen, Rectangle rect, string tool)
        {
            int side = Math.Min(rect.Width, rect.Height);
            Rectangle squareRect = new Rectangle(rect.X, rect.Y, side, side);
            Point[] triangle =
            {
                new Point(rect.X + rect.Width / 2, rect.Y),
                new Point(rect.X, rect.Bottom),
                new Point(rect.Right, rect.Bottom)
            };

            switch (tool.ToLower())
            {
                case "rectangle":
                    if (isFillShape) gr.FillRectangle(superBrush, rect);
                    gr.DrawRectangle(pen, rect);
                    break;
                case "square":
                    if (isFillShape) gr.FillRectangle(superBrush, squareRect);
                    gr.DrawRectangle(pen, squareRect);
                    break;
                case "circle":
                    if (isFillShape) gr.FillEllipse(superBrush, rect);
                    gr.DrawEllipse(pen, rect);
                    break;
                case "triangle":
                    if (isFillShape) gr.FillPolygon(superBrush, triangle);
                    gr.DrawPolygon(pen, triangle);
                    break;
            }
        }

        public Rectangle GetRect(Point p1, Point p2) => new Rectangle(
            Math.Min(p1.X, p2.X),
            Math.Min(p1.Y, p2.Y),
            Math.Abs(p1.X - p2.X),
            Math.Abs(p1.Y - p2.Y)
        );

        public Point GetZoomPoint(Point p) => new Point((int)(p.X / zoom), (int)(p.Y / zoom));

        public void CommitSelection()
        {
            if (selectedBmp != null)
            {
                g.DrawImage(selectedBmp, selectionRect.X, selectionRect.Y, selectedBmp.Width, selectedBmp.Height);
                selectedBmp.Dispose();
                selectedBmp = null;
            }
            btnMove.Visible = false;
        }

        public void ApplyZoom(float newZoom)
        {
            zoom = Math.Clamp(newZoom, 0.5f, 3.0f);
            pctrbox.Size = new Size((int)(bmp.Width * zoom), (int)(bmp.Height * zoom));
            lblZoom.Text = $"{(int)(zoom * 100)}%";
        }

        public void FloodFill(Point start, Color fillColor)
        {
            if (start.X < 0 || start.X >= bmp.Width || start.Y < 0 || start.Y >= bmp.Height) return;

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
            if (isFillShape)
            {
                isFillShape = false;
                btnFillToggle.BackColor = Color.Transparent;
                return;
            }

            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = superBrush.Color;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    superBrush.Color = colorDialog.Color;
                    btnFillToggle.BackColor = colorDialog.Color;
                    isFillShape = true;
                }
            }
        }

        public void btnMove_Click(object sender, EventArgs e)
        {
            if (selectedBmp != null)
            {
                currentTool = "Move";
                return;
            }

            Rectangle rect = Rectangle.Intersect(new Rectangle(0, 0, bmp.Width, bmp.Height), selectionRect);
            if (rect.Width <= 0 || rect.Height <= 0) return;

            selectionRect = rect;
            selectedBmp = bmp.Clone(rect, bmp.PixelFormat);
            using (SolidBrush whiteBrush = new SolidBrush(Color.White))
            {
                g.FillRectangle(whiteBrush, rect);
            }

            currentTool = "Move";
            pctrbox.Invalidate();
        }

        public void btnClear_Click(object sender, EventArgs e)
        {
            if (selectedBmp != null)
            {
                selectedBmp.Dispose();
                selectedBmp = null;
            }
            btnMove.Visible = false;
            selectionRect = Rectangle.Empty;
            g.Clear(Color.White);
            pctrbox.Invalidate();
        }

        public void btnFile_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Open", null, OpenImage_Click);
            menu.Items.Add("Save", null, SaveImage_Click);
            menu.Show(btnFile, 0, btnFile.Height);
        }

        public void OpenImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Images|*.png;*.jpg;*.jpeg;*.bmp";
                if (ofd.ShowDialog() != DialogResult.OK) return;

                CommitSelection();
                using (Bitmap loaded = new Bitmap(ofd.FileName))
                {
                    bmp.Dispose();
                    g.Dispose();
                    bmp = new Bitmap(loaded);
                    g = Graphics.FromImage(bmp);
                    pctrbox.Image = bmp;
                    ApplyZoom(1.0f);
                    lblSize.Text = $"{bmp.Width} x {bmp.Height}";
                    pctrbox.Invalidate();
                }
            }
        }

        public void SaveImage_Click(object sender, EventArgs e)
        {
            CommitSelection();
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                bmp.Save(sfd.FileName);
            }
        }

        public void btnZoomIn_Click(object sender, EventArgs e)
        {
            ApplyZoom(zoom + 0.25f);
            pctrbox.Invalidate();
        }

        public void btnZoomOut_Click(object sender, EventArgs e)
        {
            ApplyZoom(zoom - 0.25f);
            pctrbox.Invalidate();
        }
    }
}