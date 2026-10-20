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
            panel1 = new Panel();
            label2 = new Label();
            button4 = new Button();
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
            panel3 = new Panel();
            label3 = new Label();
            button5 = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            button6 = new Button();
            panel6 = new Panel();
            panelMain.SuspendLayout();
            pnlRibbon.SuspendLayout();
            panel1.SuspendLayout();
            pnlClipboard.SuspendLayout();
            pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctrbox).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ButtonHighlight;
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
            pnlRibbon.Controls.Add(panel5);
            pnlRibbon.Controls.Add(panel3);
            pnlRibbon.Controls.Add(panel1);
            pnlRibbon.Controls.Add(pnlClipboard);
            pnlRibbon.Dock = DockStyle.Top;
            pnlRibbon.Location = new Point(0, 40);
            pnlRibbon.Name = "pnlRibbon";
            pnlRibbon.Padding = new Padding(5, 0, 5, 0);
            pnlRibbon.Size = new Size(865, 110);
            pnlRibbon.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(100, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(90, 100);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(0, 80);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 1;
            label2.Text = "Буфер обмена";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.free_icon_paste_4043782;
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(5, 3);
            button4.Name = "button4";
            button4.Size = new Size(78, 72);
            button4.TabIndex = 2;
            button4.Text = "Вставить";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = true;
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
            btnCopiboard.Text = "Вставить";
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
            label1.Text = "Буфер обмена";
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
            button2.Click += button2_Click;
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
            button1.Click += button1_Click;
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
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(196, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(90, 100);
            panel3.TabIndex = 4;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(0, 80);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 1;
            label3.Text = "Буфер обмена";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Properties.Resources.free_icon_paste_4043782;
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(5, 3);
            button5.Name = "button5";
            button5.Size = new Size(78, 72);
            button5.TabIndex = 2;
            button5.Text = "Вставить";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(89, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 100);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Controls.Add(button6);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(292, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(90, 100);
            panel5.TabIndex = 4;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(0, 80);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 1;
            label4.Text = "Буфер обмена";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = Properties.Resources.free_icon_paste_4043782;
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.Location = new Point(5, 3);
            button6.Name = "button6";
            button6.Size = new Size(78, 72);
            button6.TabIndex = 2;
            button6.Text = "Вставить";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = true;
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
            panelMain.ResumeLayout(false);
            pnlRibbon.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlClipboard.ResumeLayout(false);
            pnlTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctrbox).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
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
        private Button button4;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Panel panel5;
        private Label label4;
        private Button button6;
        private Panel panel6;
        private Panel panel3;
        private Label label3;
        private Button button5;
        private Panel panel4;
    }
}