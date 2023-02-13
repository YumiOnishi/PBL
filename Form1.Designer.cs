namespace PBL_new
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.path_name = new System.Windows.Forms.Label();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.button13 = new System.Windows.Forms.Button();
            this.file_name = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button14 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "File Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Previous";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "Rotate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 160);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 33);
            this.button5.TabIndex = 4;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 217);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 33);
            this.button6.TabIndex = 5;
            this.button6.Text = "Step1";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 257);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 33);
            this.button7.TabIndex = 6;
            this.button7.Text = "Step2";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(0, 297);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 33);
            this.button8.TabIndex = 7;
            this.button8.Text = "Step3";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(0, 353);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(111, 33);
            this.button9.TabIndex = 8;
            this.button9.Text = "Whiteout";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(0, 393);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(111, 33);
            this.button10.TabIndex = 9;
            this.button10.Text = "Preview";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // path_name
            // 
            this.path_name.AutoSize = true;
            this.path_name.Location = new System.Drawing.Point(176, 15);
            this.path_name.Name = "path_name";
            this.path_name.Size = new System.Drawing.Size(59, 25);
            this.path_name.TabIndex = 10;
            this.path_name.Text = "パス名";
            this.path_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // folderBrowserDialog2
            // 
            this.folderBrowserDialog2.HelpRequest += new System.EventHandler(this.folderBrowserDialog2_HelpRequest);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(176, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 420);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(670, 48);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(110, 40);
            this.button13.TabIndex = 12;
            this.button13.Text = "Delete";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // file_name
            // 
            this.file_name.AutoSize = true;
            this.file_name.Location = new System.Drawing.Point(176, 48);
            this.file_name.Name = "file_name";
            this.file_name.Size = new System.Drawing.Size(81, 25);
            this.file_name.TabIndex = 13;
            this.file_name.Text = "ファイル名";
            this.file_name.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(670, 127);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(110, 40);
            this.button14.TabIndex = 14;
            this.button14.Text = "Save";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(11, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 28);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.file_name);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.path_name);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private OpenFileDialog openFileDialog1;
        private ListView listView1;
        private ImageList imageList1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label path_name;
        private FolderBrowserDialog folderBrowserDialog2;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog2;
        private Button button13;
        private Label file_name;
        private SaveFileDialog saveFileDialog1;
        private Button button14;
        private Panel panel1;
    }
}