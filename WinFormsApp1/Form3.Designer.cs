namespace WinFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label3 = new Label();
            menuButton = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(442, 147);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(590, 41);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Filtrar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(273, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(282, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(533, 91);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(180, 157);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._27556_200;
            pictureBox3.Location = new Point(282, 283);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(197, 155);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(533, 283);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(180, 155);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
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
            sidebar.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(menuButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 77);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(83, 42);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 1;
            label3.Text = "Menu";
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(633, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(166, 23);
            dataGridView1.TabIndex = 10;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(sidebar);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Label label3;
        private PictureBox menuButton;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
    }
}