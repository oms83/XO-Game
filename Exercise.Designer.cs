namespace Project2
{
    partial class Exercise
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
            this.rbGril = new System.Windows.Forms.RadioButton();
            this.rbBoy = new System.Windows.Forms.RadioButton();
            this.rbBook = new System.Windows.Forms.RadioButton();
            this.rbPen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project2.Properties.Resources.pen;
            this.pictureBox1.Location = new System.Drawing.Point(96, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(759, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rbGril
            // 
            this.rbGril.AutoSize = true;
            this.rbGril.Location = new System.Drawing.Point(254, 479);
            this.rbGril.Name = "rbGril";
            this.rbGril.Size = new System.Drawing.Size(47, 21);
            this.rbGril.TabIndex = 1;
            this.rbGril.TabStop = true;
            this.rbGril.Tag = "Girl";
            this.rbGril.Text = "Girl";
            this.rbGril.UseVisualStyleBackColor = true;
            this.rbGril.CheckedChanged += new System.EventHandler(this.rbGril_CheckedChanged);
            // 
            // rbBoy
            // 
            this.rbBoy.AutoSize = true;
            this.rbBoy.Location = new System.Drawing.Point(355, 479);
            this.rbBoy.Name = "rbBoy";
            this.rbBoy.Size = new System.Drawing.Size(53, 21);
            this.rbBoy.TabIndex = 2;
            this.rbBoy.TabStop = true;
            this.rbBoy.Tag = "Boy";
            this.rbBoy.Text = "Boy";
            this.rbBoy.UseVisualStyleBackColor = true;
            this.rbBoy.CheckedChanged += new System.EventHandler(this.rbBoy_CheckedChanged);
            // 
            // rbBook
            // 
            this.rbBook.AutoSize = true;
            this.rbBook.Location = new System.Drawing.Point(462, 479);
            this.rbBook.Name = "rbBook";
            this.rbBook.Size = new System.Drawing.Size(60, 21);
            this.rbBook.TabIndex = 3;
            this.rbBook.TabStop = true;
            this.rbBook.Tag = "Book";
            this.rbBook.Text = "Book";
            this.rbBook.UseVisualStyleBackColor = true;
            this.rbBook.CheckedChanged += new System.EventHandler(this.rbBook_CheckedChanged);
            // 
            // rbPen
            // 
            this.rbPen.AutoSize = true;
            this.rbPen.Location = new System.Drawing.Point(576, 479);
            this.rbPen.Name = "rbPen";
            this.rbPen.Size = new System.Drawing.Size(52, 21);
            this.rbPen.TabIndex = 4;
            this.rbPen.TabStop = true;
            this.rbPen.Tag = "Pen";
            this.rbPen.Text = "Pen";
            this.rbPen.UseVisualStyleBackColor = true;
            this.rbPen.CheckedChanged += new System.EventHandler(this.rbPen_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 36F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(373, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 79);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Exercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbPen);
            this.Controls.Add(this.rbBook);
            this.Controls.Add(this.rbBoy);
            this.Controls.Add(this.rbGril);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Exercise";
            this.Text = "Exercise";
            this.Load += new System.EventHandler(this.Exercise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbGril;
        private System.Windows.Forms.RadioButton rbBoy;
        private System.Windows.Forms.RadioButton rbBook;
        private System.Windows.Forms.RadioButton rbPen;
        private System.Windows.Forms.Label label1;
    }
}