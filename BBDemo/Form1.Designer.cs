
namespace BBDemo
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
            btnStart = new System.Windows.Forms.Button();
            timMain = new System.Windows.Forms.Timer(components);
            Add = new System.Windows.Forms.Button();
            trackBar1 = new System.Windows.Forms.TrackBar();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new System.Drawing.Point(694, 55);
            btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(89, 31);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // timMain
            // 
            timMain.Interval = 1;
            timMain.Tick += timMain_Tick;
            // 
            // Add
            // 
            Add.Location = new System.Drawing.Point(694, 93);
            Add.Name = "Add";
            Add.Size = new System.Drawing.Size(89, 31);
            Add.TabIndex = 1;
            Add.Text = "Add Ball";
            Add.UseVisualStyleBackColor = true;
            Add.Click += button1_Click;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = System.Drawing.Color.White;
            trackBar1.Location = new System.Drawing.Point(675, 244);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new System.Drawing.Size(132, 56);
            trackBar1.TabIndex = 3;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(713, 221);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 20);
            label1.TabIndex = 4;
            label1.Text = "Radius";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(694, 149);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(89, 20);
            label2.TabIndex = 5;
            label2.Text = "Ball number";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(694, 172);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(30, 30);
            button1.TabIndex = 6;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(753, 172);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(30, 30);
            button2.TabIndex = 7;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(730, 177);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(17, 20);
            label3.TabIndex = 8;
            label3.Text = "0";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Location = new System.Drawing.Point(713, 308);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(61, 20);
            label4.TabIndex = 10;
            label4.Text = "Velocity";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(713, 331);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(30, 29);
            button3.TabIndex = 11;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(744, 331);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(30, 29);
            button4.TabIndex = 12;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(914, 600);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(Add);
            Controls.Add(btnStart);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Colliding Balls";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timMain;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

