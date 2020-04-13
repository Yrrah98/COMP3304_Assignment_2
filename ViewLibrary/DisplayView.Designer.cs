namespace ViewLibrary
{
    partial class DisplayView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FlipHBtn = new System.Windows.Forms.Button();
            this.FlipVBtn = new System.Windows.Forms.Button();
            this.RotateCWBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(578, 432);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // FlipHBtn
            // 
            this.FlipHBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FlipHBtn.Location = new System.Drawing.Point(12, 462);
            this.FlipHBtn.Name = "FlipHBtn";
            this.FlipHBtn.Size = new System.Drawing.Size(98, 49);
            this.FlipHBtn.TabIndex = 1;
            this.FlipHBtn.Text = "Flip Horizontally";
            this.FlipHBtn.UseVisualStyleBackColor = true;
            this.FlipHBtn.Click += new System.EventHandler(this.FlipHBtn_Click);
            // 
            // FlipVBtn
            // 
            this.FlipVBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FlipVBtn.Location = new System.Drawing.Point(116, 462);
            this.FlipVBtn.Name = "FlipVBtn";
            this.FlipVBtn.Size = new System.Drawing.Size(98, 49);
            this.FlipVBtn.TabIndex = 2;
            this.FlipVBtn.Text = "Flip Vertically";
            this.FlipVBtn.UseVisualStyleBackColor = true;
            this.FlipVBtn.Click += new System.EventHandler(this.FlipVBtn_Click);
            // 
            // RotateCWBtn
            // 
            this.RotateCWBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RotateCWBtn.Location = new System.Drawing.Point(220, 462);
            this.RotateCWBtn.Name = "RotateCWBtn";
            this.RotateCWBtn.Size = new System.Drawing.Size(98, 49);
            this.RotateCWBtn.TabIndex = 3;
            this.RotateCWBtn.Text = "Rotate Clockwise";
            this.RotateCWBtn.UseVisualStyleBackColor = true;
            this.RotateCWBtn.Click += new System.EventHandler(this.RotateCWBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(324, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Rotate Anti-Clockwise";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveBtn.Location = new System.Drawing.Point(513, 462);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(77, 49);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DisplayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 523);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RotateCWBtn);
            this.Controls.Add(this.FlipVBtn);
            this.Controls.Add(this.FlipHBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DisplayView";
            this.Text = "DisplayView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FlipHBtn;
        private System.Windows.Forms.Button FlipVBtn;
        private System.Windows.Forms.Button RotateCWBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SaveBtn;
    }
}