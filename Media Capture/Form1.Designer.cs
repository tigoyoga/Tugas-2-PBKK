namespace Media_Capture
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
            comboBox1 = new ComboBox();
            startbtn = new Button();
            capturebtn = new Button();
            savebtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            exitbtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // startbtn
            // 
            startbtn.Location = new Point(202, 12);
            startbtn.Name = "startbtn";
            startbtn.Size = new Size(94, 29);
            startbtn.TabIndex = 1;
            startbtn.Text = "Start";
            startbtn.UseVisualStyleBackColor = true;
            startbtn.Click += button1_Click;
            // 
            // capturebtn
            // 
            capturebtn.Location = new Point(311, 12);
            capturebtn.Name = "capturebtn";
            capturebtn.Size = new Size(94, 29);
            capturebtn.TabIndex = 2;
            capturebtn.Text = "Capture";
            capturebtn.UseVisualStyleBackColor = true;
            capturebtn.Click += button2_Click;
            // 
            // savebtn
            // 
            savebtn.Location = new Point(420, 12);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(94, 29);
            savebtn.TabIndex = 3;
            savebtn.Text = "Save Image";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += button3_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 62);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(776, 376);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(382, 370);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(391, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(382, 370);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // exitbtn
            // 
            exitbtn.Location = new Point(691, 12);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(94, 29);
            exitbtn.TabIndex = 5;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitbtn);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(savebtn);
            Controls.Add(capturebtn);
            Controls.Add(startbtn);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "WebcamApp";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Button startbtn;
        private Button capturebtn;
        private Button savebtn;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button exitbtn;
    }
}