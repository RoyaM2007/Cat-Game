namespace Cat_Game
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
            pic1 = new PictureBox();
            pic2 = new PictureBox();
            pic3 = new PictureBox();
            pic4 = new PictureBox();
            pic5 = new PictureBox();
            pic6 = new PictureBox();
            lblScore = new Label();
            btnNewGame = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic6).BeginInit();
            SuspendLayout();
            // 
            // pic1
            // 
            pic1.BorderStyle = BorderStyle.FixedSingle;
            pic1.Image = Properties.Resources.question;
            pic1.Location = new Point(110, 110);
            pic1.Name = "pic1";
            pic1.Size = new Size(140, 88);
            pic1.SizeMode = PictureBoxSizeMode.Zoom;
            pic1.TabIndex = 0;
            pic1.TabStop = false;
            // 
            // pic2
            // 
            pic2.BorderStyle = BorderStyle.FixedSingle;
            pic2.Image = Properties.Resources.question;
            pic2.Location = new Point(324, 110);
            pic2.Name = "pic2";
            pic2.Size = new Size(140, 88);
            pic2.SizeMode = PictureBoxSizeMode.Zoom;
            pic2.TabIndex = 1;
            pic2.TabStop = false;
            // 
            // pic3
            // 
            pic3.BorderStyle = BorderStyle.FixedSingle;
            pic3.Image = Properties.Resources.question;
            pic3.Location = new Point(536, 110);
            pic3.Name = "pic3";
            pic3.Size = new Size(140, 88);
            pic3.SizeMode = PictureBoxSizeMode.Zoom;
            pic3.TabIndex = 2;
            pic3.TabStop = false;
            // 
            // pic4
            // 
            pic4.BorderStyle = BorderStyle.FixedSingle;
            pic4.Image = Properties.Resources.question;
            pic4.Location = new Point(110, 251);
            pic4.Name = "pic4";
            pic4.Size = new Size(140, 88);
            pic4.SizeMode = PictureBoxSizeMode.Zoom;
            pic4.TabIndex = 3;
            pic4.TabStop = false;
            // 
            // pic5
            // 
            pic5.BorderStyle = BorderStyle.FixedSingle;
            pic5.Image = Properties.Resources.question;
            pic5.Location = new Point(324, 251);
            pic5.Name = "pic5";
            pic5.Size = new Size(140, 88);
            pic5.SizeMode = PictureBoxSizeMode.Zoom;
            pic5.TabIndex = 4;
            pic5.TabStop = false;
            // 
            // pic6
            // 
            pic6.BorderStyle = BorderStyle.FixedSingle;
            pic6.Image = Properties.Resources.question;
            pic6.Location = new Point(536, 251);
            pic6.Name = "pic6";
            pic6.Size = new Size(140, 88);
            pic6.SizeMode = PictureBoxSizeMode.Zoom;
            pic6.TabIndex = 5;
            pic6.TabStop = false;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(153, 410);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(44, 25);
            lblScore.TabIndex = 6;
            lblScore.Text = "Xal:";
            // 
            // btnNewGame
            // 
            btnNewGame.BackColor = Color.White;
            btnNewGame.FlatStyle = FlatStyle.Flat;
            btnNewGame.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewGame.ForeColor = Color.FromArgb(0, 64, 0);
            btnNewGame.Location = new Point(334, 402);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(118, 40);
            btnNewGame.TabIndex = 7;
            btnNewGame.Text = "Yeni oyun";
            btnNewGame.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Maroon;
            btnExit.Location = new Point(558, 403);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(118, 40);
            btnExit.TabIndex = 8;
            btnExit.Text = "Çıxış";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 542);
            Controls.Add(btnExit);
            Controls.Add(btnNewGame);
            Controls.Add(lblScore);
            Controls.Add(pic6);
            Controls.Add(pic5);
            Controls.Add(pic4);
            Controls.Add(pic3);
            Controls.Add(pic2);
            Controls.Add(pic1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic1;
        private PictureBox pic2;
        private PictureBox pic3;
        private PictureBox pic4;
        private PictureBox pic5;
        private PictureBox pic6;
        private Label lblScore;
        private Button btnNewGame;
        private Button btnExit;
    }
}
