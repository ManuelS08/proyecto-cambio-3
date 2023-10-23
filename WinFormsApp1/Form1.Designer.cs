namespace WinFormsApp1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            sidebartimer = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            menuButton = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.DarkSlateGray;
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(button2);
            sidebar.Controls.Add(button3);
            sidebar.Controls.Add(button4);
            sidebar.Controls.Add(button5);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(223, 499);
            sidebar.MinimumSize = new Size(92, 499);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(223, 499);
            sidebar.TabIndex = 0;
            sidebar.Paint += sidebar_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 58);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-9, -14);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 0);
            button1.Size = new Size(239, 69);
            button1.TabIndex = 1;
            button1.Text = "     Inicio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = Color.Transparent;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 150);
            button2.Name = "button2";
            button2.Padding = new Padding(30, 0, 0, 0);
            button2.Size = new Size(239, 61);
            button2.TabIndex = 2;
            button2.Text = "Shop";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 217);
            button3.Name = "button3";
            button3.Padding = new Padding(30, 0, 0, 0);
            button3.Size = new Size(239, 67);
            button3.TabIndex = 3;
            button3.Text = "Best deal";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 290);
            button4.Name = "button4";
            button4.Padding = new Padding(30, 0, 0, 0);
            button4.Size = new Size(239, 62);
            button4.TabIndex = 4;
            button4.Text = "Ajustes";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.ForeColor = Color.Transparent;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 358);
            button5.Name = "button5";
            button5.Padding = new Padding(30, 0, 0, 0);
            button5.Size = new Size(239, 65);
            button5.TabIndex = 5;
            button5.Text = "Nosotros";
            button5.UseVisualStyleBackColor = true;
            // 
            // sidebartimer
            // 
            sidebartimer.Tick += sidebarTimer_Tick;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(507, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(345, 237);
            panel3.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(341, 231);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSlateGray;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1098, 34);
            panel4.TabIndex = 2;
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = Properties.Resources.value__1_1;
            menuButton.Location = new Point(9, 37);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(52, 37);
            menuButton.SizeMode = PictureBoxSizeMode.CenterImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(83, 42);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 77);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cerrar1;
            pictureBox1.Location = new Point(1052, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.minimazar1;
            pictureBox3.Location = new Point(980, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.maxi;
            pictureBox4.Location = new Point(1016, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1094, 498);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(sidebar);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_2;
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Panel panel2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private System.Windows.Forms.Timer sidebartimer;
        private FlowLayoutPanel sidebar;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Panel panel1;
        private Label label1;
        private PictureBox menuButton;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}