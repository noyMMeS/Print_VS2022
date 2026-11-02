namespace Print_VS2022
{
    partial class frmPrint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            panelMain = new Panel();
            pnlRibbon = new Panel();
            pnlColor = new Panel();
            lblColor = new Label();
            btnclrBlack = new Button();
            panel7 = new Panel();
            pnlShapes = new Panel();
            lblShapes = new Label();
            btnCircle = new Button();
            panel6 = new Panel();
            pnlTools = new Panel();
            lblTools = new Label();
            btnEraser = new Button();
            btnBrush = new Button();
            panel4 = new Panel();
            pnlImage = new Panel();
            lblImage = new Label();
            btnImage = new Button();
            panel2 = new Panel();
            pnlClipboard = new Panel();
            btnCopiboard = new Button();
            label1 = new Label();
            pnlBorder = new Panel();
            pnlTopBar = new Panel();
            pnlIndicator = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pctrbox = new PictureBox();
            lblCords = new ToolStripStatusLabel();
            lblSize = new ToolStripStatusLabel();
            lblZoom = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            panelMain.SuspendLayout();
            pnlRibbon.SuspendLayout();
            pnlColor.SuspendLayout();
            pnlShapes.SuspendLayout();
            pnlTools.SuspendLayout();
            pnlImage.SuspendLayout();
            pnlClipboard.SuspendLayout();
            pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctrbox).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ButtonHighlight;
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblCords, lblSize, lblZoom });
            statusStrip1.Location = new Point(0, 603);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(865, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = SystemColors.AppWorkspace;
            panelMain.Controls.Add(pnlRibbon);
            panelMain.Controls.Add(pnlTopBar);
            panelMain.Controls.Add(pctrbox);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(865, 603);
            panelMain.TabIndex = 2;
            // 
            // pnlRibbon
            // 
            pnlRibbon.BackColor = Color.White;
            pnlRibbon.Controls.Add(pnlColor);
            pnlRibbon.Controls.Add(pnlShapes);
            pnlRibbon.Controls.Add(pnlTools);
            pnlRibbon.Controls.Add(pnlImage);
            pnlRibbon.Controls.Add(pnlClipboard);
            pnlRibbon.Dock = DockStyle.Top;
            pnlRibbon.Location = new Point(0, 40);
            pnlRibbon.Name = "pnlRibbon";
            pnlRibbon.Padding = new Padding(5, 0, 5, 0);
            pnlRibbon.Size = new Size(865, 110);
            pnlRibbon.TabIndex = 2;
            // 
            // pnlColor
            // 
            pnlColor.Controls.Add(lblColor);
            pnlColor.Controls.Add(btnclrBlack);
            pnlColor.Controls.Add(panel7);
            pnlColor.Location = new Point(495, 5);
            pnlColor.Name = "pnlColor";
            pnlColor.Size = new Size(133, 100);
            pnlColor.TabIndex = 5;
            // 
            // lblColor
            // 
            lblColor.Dock = DockStyle.Bottom;
            lblColor.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblColor.ForeColor = Color.Gray;
            lblColor.Location = new Point(0, 80);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(132, 20);
            lblColor.TabIndex = 1;
            lblColor.Text = "Color";
            lblColor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnclrBlack
            // 
            btnclrBlack.Cursor = Cursors.Hand;
            btnclrBlack.FlatAppearance.BorderSize = 0;
            btnclrBlack.FlatStyle = FlatStyle.Flat;
            btnclrBlack.Image = Properties.Resources.black_circle;
            btnclrBlack.ImageAlign = ContentAlignment.TopCenter;
            btnclrBlack.Location = new Point(32, 17);
            btnclrBlack.Name = "btnclrBlack";
            btnclrBlack.Size = new Size(73, 48);
            btnclrBlack.TabIndex = 2;
            btnclrBlack.TextAlign = ContentAlignment.BottomCenter;
            btnclrBlack.TextImageRelation = TextImageRelation.ImageAboveText;
            btnclrBlack.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightGray;
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(132, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1, 100);
            panel7.TabIndex = 0;
            // 
            // pnlShapes
            // 
            pnlShapes.Controls.Add(lblShapes);
            pnlShapes.Controls.Add(btnCircle);
            pnlShapes.Controls.Add(panel6);
            pnlShapes.Location = new Point(394, 5);
            pnlShapes.Name = "pnlShapes";
            pnlShapes.Size = new Size(90, 100);
            pnlShapes.TabIndex = 4;
            // 
            // lblShapes
            // 
            lblShapes.Dock = DockStyle.Bottom;
            lblShapes.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblShapes.ForeColor = Color.Gray;
            lblShapes.Location = new Point(0, 80);
            lblShapes.Name = "lblShapes";
            lblShapes.Size = new Size(89, 20);
            lblShapes.TabIndex = 1;
            lblShapes.Text = "Shapes";
            lblShapes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCircle
            // 
            btnCircle.Cursor = Cursors.Hand;
            btnCircle.FlatAppearance.BorderSize = 0;
            btnCircle.FlatStyle = FlatStyle.Flat;
            btnCircle.Image = Properties.Resources.dry_clean;
            btnCircle.ImageAlign = ContentAlignment.TopCenter;
            btnCircle.Location = new Point(5, 3);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(78, 72);
            btnCircle.TabIndex = 2;
            btnCircle.Text = "Circle";
            btnCircle.TextAlign = ContentAlignment.BottomCenter;
            btnCircle.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCircle.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(89, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 100);
            panel6.TabIndex = 0;
            // 
            // pnlTools
            // 
            pnlTools.Controls.Add(lblTools);
            pnlTools.Controls.Add(btnEraser);
            pnlTools.Controls.Add(btnBrush);
            pnlTools.Controls.Add(panel4);
            pnlTools.Location = new Point(196, 5);
            pnlTools.Name = "pnlTools";
            pnlTools.Size = new Size(192, 100);
            pnlTools.TabIndex = 4;
            // 
            // lblTools
            // 
            lblTools.Dock = DockStyle.Bottom;
            lblTools.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTools.ForeColor = Color.Gray;
            lblTools.Location = new Point(0, 80);
            lblTools.Name = "lblTools";
            lblTools.Size = new Size(191, 20);
            lblTools.TabIndex = 1;
            lblTools.Text = "Tools";
            lblTools.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEraser
            // 
            btnEraser.Cursor = Cursors.Hand;
            btnEraser.FlatAppearance.BorderSize = 0;
            btnEraser.FlatStyle = FlatStyle.Flat;
            btnEraser.Image = Properties.Resources.eraser;
            btnEraser.ImageAlign = ContentAlignment.TopCenter;
            btnEraser.Location = new Point(107, 3);
            btnEraser.Name = "btnEraser";
            btnEraser.Size = new Size(78, 72);
            btnEraser.TabIndex = 2;
            btnEraser.Text = "Eraser";
            btnEraser.TextAlign = ContentAlignment.BottomCenter;
            btnEraser.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEraser.UseVisualStyleBackColor = true;
            // 
            // btnBrush
            // 
            btnBrush.Cursor = Cursors.Hand;
            btnBrush.FlatAppearance.BorderSize = 0;
            btnBrush.FlatStyle = FlatStyle.Flat;
            btnBrush.Image = Properties.Resources.paintbrush;
            btnBrush.ImageAlign = ContentAlignment.TopCenter;
            btnBrush.Location = new Point(5, 3);
            btnBrush.Name = "btnBrush";
            btnBrush.Size = new Size(78, 72);
            btnBrush.TabIndex = 2;
            btnBrush.Text = "brush";
            btnBrush.TextAlign = ContentAlignment.BottomCenter;
            btnBrush.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBrush.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(191, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 100);
            panel4.TabIndex = 0;
            // 
            // pnlImage
            // 
            pnlImage.Controls.Add(lblImage);
            pnlImage.Controls.Add(btnImage);
            pnlImage.Controls.Add(panel2);
            pnlImage.Location = new Point(100, 5);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(90, 100);
            pnlImage.TabIndex = 3;
            // 
            // lblImage
            // 
            lblImage.Dock = DockStyle.Bottom;
            lblImage.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblImage.ForeColor = Color.Gray;
            lblImage.Location = new Point(0, 80);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(89, 20);
            lblImage.TabIndex = 1;
            lblImage.Text = "Image";
            lblImage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnImage
            // 
            btnImage.Cursor = Cursors.Hand;
            btnImage.FlatAppearance.BorderSize = 0;
            btnImage.FlatStyle = FlatStyle.Flat;
            btnImage.Image = Properties.Resources.image;
            btnImage.ImageAlign = ContentAlignment.TopCenter;
            btnImage.Location = new Point(5, 3);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(78, 72);
            btnImage.TabIndex = 2;
            btnImage.Text = "Select";
            btnImage.TextAlign = ContentAlignment.BottomCenter;
            btnImage.TextImageRelation = TextImageRelation.ImageAboveText;
            btnImage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(89, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 100);
            panel2.TabIndex = 0;
            // 
            // pnlClipboard
            // 
            pnlClipboard.Controls.Add(btnCopiboard);
            pnlClipboard.Controls.Add(label1);
            pnlClipboard.Controls.Add(pnlBorder);
            pnlClipboard.Location = new Point(5, 5);
            pnlClipboard.Name = "pnlClipboard";
            pnlClipboard.Size = new Size(90, 100);
            pnlClipboard.TabIndex = 0;
            // 
            // btnCopiboard
            // 
            btnCopiboard.Cursor = Cursors.Hand;
            btnCopiboard.FlatAppearance.BorderSize = 0;
            btnCopiboard.FlatStyle = FlatStyle.Flat;
            btnCopiboard.Image = Properties.Resources.free_icon_paste_4043782;
            btnCopiboard.ImageAlign = ContentAlignment.TopCenter;
            btnCopiboard.Location = new Point(5, 5);
            btnCopiboard.Name = "btnCopiboard";
            btnCopiboard.Size = new Size(78, 72);
            btnCopiboard.TabIndex = 2;
            btnCopiboard.Text = "Paste";
            btnCopiboard.TextAlign = ContentAlignment.BottomCenter;
            btnCopiboard.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCopiboard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(0, 80);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 1;
            label1.Text = "Clipboard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBorder
            // 
            pnlBorder.BackColor = Color.LightGray;
            pnlBorder.Dock = DockStyle.Right;
            pnlBorder.Location = new Point(89, 0);
            pnlBorder.Name = "pnlBorder";
            pnlBorder.Size = new Size(1, 100);
            pnlBorder.TabIndex = 0;
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Controls.Add(pnlIndicator);
            pnlTopBar.Controls.Add(button3);
            pnlTopBar.Controls.Add(button2);
            pnlTopBar.Controls.Add(button1);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(865, 40);
            pnlTopBar.TabIndex = 1;
            // 
            // pnlIndicator
            // 
            pnlIndicator.BackColor = SystemColors.ActiveCaption;
            pnlIndicator.Location = new Point(90, 37);
            pnlIndicator.Name = "pnlIndicator";
            pnlIndicator.Size = new Size(80, 3);
            pnlIndicator.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(170, 0);
            button3.Name = "button3";
            button3.Size = new Size(80, 37);
            button3.TabIndex = 2;
            button3.Text = "View";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(90, 0);
            button2.Name = "button2";
            button2.Size = new Size(80, 37);
            button2.TabIndex = 1;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(10, 0);
            button1.Name = "button1";
            button1.Size = new Size(80, 37);
            button1.TabIndex = 0;
            button1.Text = "File";
            button1.UseVisualStyleBackColor = false;
            // 
            // pctrbox
            // 
            pctrbox.Anchor = AnchorStyles.None;
            pctrbox.BackColor = SystemColors.ControlLightLight;
            pctrbox.BorderStyle = BorderStyle.FixedSingle;
            pctrbox.Location = new Point(5, 156);
            pctrbox.Name = "pctrbox";
            pctrbox.Size = new Size(623, 428);
            pctrbox.TabIndex = 0;
            pctrbox.TabStop = false;
            // 
            // lblCords
            // 
            lblCords.Name = "lblCords";
            lblCords.Size = new Size(48, 17);
            lblCords.Text = "X: 0 Y: 0";
            // 
            // lblSize
            // 
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(55, 17);
            lblSize.Text = "800 x 600";
            // 
            // lblZoom
            // 
            lblZoom.Name = "lblZoom";
            lblZoom.Size = new Size(747, 17);
            lblZoom.Spring = true;
            lblZoom.Text = "100%";
            // 
            // frmPrint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 625);
            Controls.Add(panelMain);
            Controls.Add(statusStrip1);
            Name = "frmPrint";
            Text = "Form1";
            Load += frmPrint_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panelMain.ResumeLayout(false);
            pnlRibbon.ResumeLayout(false);
            pnlColor.ResumeLayout(false);
            pnlShapes.ResumeLayout(false);
            pnlTools.ResumeLayout(false);
            pnlImage.ResumeLayout(false);
            pnlClipboard.ResumeLayout(false);
            pnlTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctrbox).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        // Объявления элементов
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pctrbox;
        private Panel pnlTopBar;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel pnlIndicator;
        private Panel pnlRibbon;
        private Panel pnlClipboard;
        private Panel pnlBorder;
        private Label label1;
        private Button btnCopiboard;
        private Button btnImage;
        private Panel pnlImage;
        private Label lblImage;
        private Panel panel2;
        private Panel pnlShapes;
        private Label lblShapes;
        private Button btnCircle;
        private Panel panel6;
        private Panel pnlTools;
        private Label lblTools;
        private Button btnBrush;
        private Panel panel4;
        private Panel pnlColor;
        private Label lblColor;
        private Button btnclrBlack;
        private Panel panel7;
        private Button btnEraser;
        private ToolStripStatusLabel lblCords;
        private ToolStripStatusLabel lblSize;
        private ToolStripStatusLabel lblZoom;
    }
}