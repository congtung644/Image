namespace slideshowImage_LuuCongTung
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Playstop = new System.Windows.Forms.Button();
            this.images = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.images)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 3;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Playstop
            // 
            this.Playstop.Location = new System.Drawing.Point(424, 286);
            this.Playstop.Name = "Playstop";
            this.Playstop.Size = new System.Drawing.Size(75, 23);
            this.Playstop.TabIndex = 0;
            this.Playstop.Text = "Play";
            this.Playstop.UseVisualStyleBackColor = true;
            this.Playstop.Click += new System.EventHandler(this.Button1_Click);
            // 
            // images
            // 
            this.images.Location = new System.Drawing.Point(142, 35);
            this.images.Name = "images";
            this.images.Size = new System.Drawing.Size(447, 200);
            this.images.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.images.TabIndex = 2;
            this.images.TabStop = false;
            this.images.Click += new System.EventHandler(this.Image_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mở";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.images);
            this.Controls.Add(this.Playstop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.images)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Playstop;
        private System.Windows.Forms.PictureBox images;
        private System.Windows.Forms.Button button1;
    }
}

