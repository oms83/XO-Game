namespace Project2
{
    partial class GameXO
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
            this.label7 = new System.Windows.Forms.Label();
            this.CurrentPlayer = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblWinnerInGame = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn16 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn256 = new System.Windows.Forms.Button();
            this.btn128 = new System.Windows.Forms.Button();
            this.btn64 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project2.Properties.Resources.OMSS;
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code SemiBold", 20F);
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(133, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 45);
            this.label7.TabIndex = 19;
            this.label7.Text = "Trun";
            // 
            // CurrentPlayer
            // 
            this.CurrentPlayer.AutoSize = true;
            this.CurrentPlayer.Font = new System.Drawing.Font("Cascadia Code SemiBold", 20F);
            this.CurrentPlayer.ForeColor = System.Drawing.Color.White;
            this.CurrentPlayer.Location = new System.Drawing.Point(93, 406);
            this.CurrentPlayer.Name = "CurrentPlayer";
            this.CurrentPlayer.Size = new System.Drawing.Size(180, 45);
            this.CurrentPlayer.TabIndex = 20;
            this.CurrentPlayer.Text = "Player 1";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Cascadia Code SemiBold", 20F);
            this.lblWinner.ForeColor = System.Drawing.Color.Yellow;
            this.lblWinner.Location = new System.Drawing.Point(113, 468);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(140, 45);
            this.lblWinner.TabIndex = 21;
            this.lblWinner.Text = "Winner";
            // 
            // lblWinnerInGame
            // 
            this.lblWinnerInGame.AutoSize = true;
            this.lblWinnerInGame.Font = new System.Drawing.Font("Cascadia Code SemiBold", 20F);
            this.lblWinnerInGame.ForeColor = System.Drawing.Color.Lime;
            this.lblWinnerInGame.Location = new System.Drawing.Point(63, 530);
            this.lblWinnerInGame.Name = "lblWinnerInGame";
            this.lblWinnerInGame.Size = new System.Drawing.Size(240, 45);
            this.lblWinnerInGame.TabIndex = 22;
            this.lblWinnerInGame.Text = "In Progress";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 20F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(36, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 59);
            this.button1.TabIndex = 23;
            this.button1.Text = "Restar Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F);
            this.label14.ForeColor = System.Drawing.Color.OrangeRed;
            this.label14.Location = new System.Drawing.Point(133, 223);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 22);
            this.label14.TabIndex = 24;
            this.label14.Text = "Ömer MEMES";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cascadia Code SemiBold", 30F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(623, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(492, 66);
            this.label15.TabIndex = 25;
            this.label15.Text = "Tic Tac Toe Game";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn1.Location = new System.Drawing.Point(539, 165);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(143, 169);
            this.btn1.TabIndex = 26;
            this.btn1.Text = "?";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn2.Location = new System.Drawing.Point(794, 165);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(143, 169);
            this.btn2.TabIndex = 27;
            this.btn2.Text = "?";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Black;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Cascadia Code SemiBold", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn4.Location = new System.Drawing.Point(1049, 165);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(143, 169);
            this.btn4.TabIndex = 28;
            this.btn4.Text = "?";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn32
            // 
            this.btn32.BackColor = System.Drawing.Color.Black;
            this.btn32.FlatAppearance.BorderSize = 0;
            this.btn32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn32.Font = new System.Drawing.Font("Cascadia Code SemiBold", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn32.Location = new System.Drawing.Point(1049, 381);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(143, 169);
            this.btn32.TabIndex = 31;
            this.btn32.Text = "?";
            this.btn32.UseVisualStyleBackColor = false;
            this.btn32.Click += new System.EventHandler(this.btn32_Click);
            // 
            // btn16
            // 
            this.btn16.BackColor = System.Drawing.Color.Black;
            this.btn16.FlatAppearance.BorderSize = 0;
            this.btn16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn16.Font = new System.Drawing.Font("Cascadia Code SemiBold", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn16.Location = new System.Drawing.Point(794, 381);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(143, 169);
            this.btn16.TabIndex = 30;
            this.btn16.Text = "?";
            this.btn16.UseVisualStyleBackColor = false;
            this.btn16.Click += new System.EventHandler(this.btn16_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Black;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Cascadia Code SemiBold", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn8.Location = new System.Drawing.Point(539, 381);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(143, 169);
            this.btn8.TabIndex = 29;
            this.btn8.Text = "?";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn256
            // 
            this.btn256.BackColor = System.Drawing.Color.Black;
            this.btn256.FlatAppearance.BorderSize = 0;
            this.btn256.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn256.Font = new System.Drawing.Font("Cascadia Code SemiBold", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn256.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn256.Location = new System.Drawing.Point(1049, 590);
            this.btn256.Name = "btn256";
            this.btn256.Size = new System.Drawing.Size(143, 169);
            this.btn256.TabIndex = 34;
            this.btn256.Text = "?";
            this.btn256.UseVisualStyleBackColor = false;
            this.btn256.Click += new System.EventHandler(this.btn256_Click);
            // 
            // btn128
            // 
            this.btn128.BackColor = System.Drawing.Color.Black;
            this.btn128.FlatAppearance.BorderSize = 0;
            this.btn128.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn128.Font = new System.Drawing.Font("Cascadia Code SemiBold", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn128.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn128.Location = new System.Drawing.Point(794, 590);
            this.btn128.Name = "btn128";
            this.btn128.Size = new System.Drawing.Size(143, 169);
            this.btn128.TabIndex = 33;
            this.btn128.Text = "?";
            this.btn128.UseVisualStyleBackColor = false;
            this.btn128.Click += new System.EventHandler(this.btn128_Click);
            // 
            // btn64
            // 
            this.btn64.BackColor = System.Drawing.Color.Black;
            this.btn64.FlatAppearance.BorderSize = 0;
            this.btn64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn64.Font = new System.Drawing.Font("Cascadia Code SemiBold", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn64.Location = new System.Drawing.Point(539, 590);
            this.btn64.Name = "btn64";
            this.btn64.Size = new System.Drawing.Size(143, 169);
            this.btn64.TabIndex = 32;
            this.btn64.Text = "?";
            this.btn64.UseVisualStyleBackColor = false;
            this.btn64.Click += new System.EventHandler(this.btn64_Click);
            // 
            // GameXO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1350, 794);
            this.Controls.Add(this.btn256);
            this.Controls.Add(this.btn128);
            this.Controls.Add(this.btn64);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn16);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWinnerInGame);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.CurrentPlayer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GameXO";
            this.Text = "GameXO";
            this.Load += new System.EventHandler(this.GameXO_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameXO_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CurrentPlayer;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblWinnerInGame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn16;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn256;
        private System.Windows.Forms.Button btn128;
        private System.Windows.Forms.Button btn64;
    }
}