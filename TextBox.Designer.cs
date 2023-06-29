namespace Project2
{
    partial class TextBox
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnFocus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(245, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "عمر أحمد ممس";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(245, 24);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(63, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(245, 24);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Omer MEMES";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(63, 180);
            this.textBox4.MaxLength = 11;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(245, 24);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "PhoneNumber";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(63, 235);
            this.textBox5.MaxLength = 3000;
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(245, 121);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "WordWrapTrue";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(333, 41);
            this.textBox6.MaxLength = 3000;
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(245, 121);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "WordWrapFalse";
            this.textBox6.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Location = new System.Drawing.Point(333, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 155);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox7
            // 
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Location = new System.Drawing.Point(3, 20);
            this.textBox7.MaxLength = 3000;
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(318, 132);
            this.textBox7.TabIndex = 5;
            this.textBox7.Text = "Dock";
            // 
            // btnFocus
            // 
            this.btnFocus.Location = new System.Drawing.Point(417, 394);
            this.btnFocus.Name = "btnFocus";
            this.btnFocus.Size = new System.Drawing.Size(103, 27);
            this.btnFocus.TabIndex = 7;
            this.btnFocus.Text = "Focus";
            this.btnFocus.UseVisualStyleBackColor = true;
            this.btnFocus.Click += new System.EventHandler(this.btnFocus_Click);
            // 
            // TextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFocus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "TextBox";
            this.Text = "TextBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnFocus;
    }
}