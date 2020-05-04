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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.RotateACWBtn = new System.Windows.Forms.Button();
            this.IncreaseBtn = new System.Windows.Forms.Button();
            this.DecreaseBtn = new System.Windows.Forms.Button();
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
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // FlipHBtn
            // 
            this.FlipHBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FlipHBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlipHBtn.Location = new System.Drawing.Point(12, 462);
            this.FlipHBtn.Name = "FlipHBtn";
            this.FlipHBtn.Size = new System.Drawing.Size(82, 49);
            this.FlipHBtn.TabIndex = 1;
            this.FlipHBtn.Text = "Flip Horizontally";
            this.FlipHBtn.UseVisualStyleBackColor = true;
            this.FlipHBtn.Click += new System.EventHandler(this.FlipHBtn_Click);
            // 
            // FlipVBtn
            // 
            this.FlipVBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FlipVBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlipVBtn.Location = new System.Drawing.Point(100, 462);
            this.FlipVBtn.Name = "FlipVBtn";
            this.FlipVBtn.Size = new System.Drawing.Size(74, 49);
            this.FlipVBtn.TabIndex = 2;
            this.FlipVBtn.Text = "Flip Vertically";
            this.FlipVBtn.UseVisualStyleBackColor = true;
            this.FlipVBtn.Click += new System.EventHandler(this.FlipVBtn_Click);
            // 
            // RotateCWBtn
            // 
            this.RotateCWBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RotateCWBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotateCWBtn.Location = new System.Drawing.Point(180, 462);
            this.RotateCWBtn.Name = "RotateCWBtn";
            this.RotateCWBtn.Size = new System.Drawing.Size(73, 49);
            this.RotateCWBtn.TabIndex = 3;
            this.RotateCWBtn.Text = "Rotate Clockwise";
            this.RotateCWBtn.UseVisualStyleBackColor = true;
            this.RotateCWBtn.Click += new System.EventHandler(this.RotateCWBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(513, 462);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(77, 49);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // RotateACWBtn
            // 
            this.RotateACWBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RotateACWBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotateACWBtn.Location = new System.Drawing.Point(259, 462);
            this.RotateACWBtn.Name = "RotateACWBtn";
            this.RotateACWBtn.Size = new System.Drawing.Size(94, 49);
            this.RotateACWBtn.TabIndex = 6;
            this.RotateACWBtn.Text = "Rotate Anti-Clockwise";
            this.RotateACWBtn.UseVisualStyleBackColor = true;
            this.RotateACWBtn.Click += new System.EventHandler(this.RotateACWBtn_Click);
            // 
            // IncreaseBtn
            // 
            this.IncreaseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IncreaseBtn.Location = new System.Drawing.Point(359, 462);
            this.IncreaseBtn.Name = "IncreaseBtn";
            this.IncreaseBtn.Size = new System.Drawing.Size(115, 23);
            this.IncreaseBtn.TabIndex = 7;
            this.IncreaseBtn.Text = "Increase Size";
            this.IncreaseBtn.UseVisualStyleBackColor = true;
            this.IncreaseBtn.Click += new System.EventHandler(this.IncreaseBtn_Click);
            // 
            // DecreaseBtn
            // 
            this.DecreaseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DecreaseBtn.Location = new System.Drawing.Point(359, 488);
            this.DecreaseBtn.Name = "DecreaseBtn";
            this.DecreaseBtn.Size = new System.Drawing.Size(115, 23);
            this.DecreaseBtn.TabIndex = 8;
            this.DecreaseBtn.Text = "Decrease Size";
            this.DecreaseBtn.UseVisualStyleBackColor = true;
            this.DecreaseBtn.Click += new System.EventHandler(this.DecreaseBtn_Click);
            // 
            // DisplayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 523);
            this.Controls.Add(this.DecreaseBtn);
            this.Controls.Add(this.IncreaseBtn);
            this.Controls.Add(this.RotateACWBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.RotateCWBtn);
            this.Controls.Add(this.FlipVBtn);
            this.Controls.Add(this.FlipHBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DisplayView";
            this.Text = "DisplayView";
            this.Resize += new System.EventHandler(this.DisplayView_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FlipHBtn;
        private System.Windows.Forms.Button FlipVBtn;
        private System.Windows.Forms.Button RotateCWBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button RotateACWBtn;
        private System.Windows.Forms.Button IncreaseBtn;
        private System.Windows.Forms.Button DecreaseBtn;
    }
}