namespace LIBRARY_PROJECT
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            label1 = new Label();
            btnBook = new FontAwesome.Sharp.IconButton();
            btnComputer = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(159, 141);
            label1.Name = "label1";
            label1.Size = new Size(269, 23);
            label1.TabIndex = 0;
            label1.Text = "G A R D E N  L I B R A R Y";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBook
            // 
            btnBook.Font = new Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBook.ForeColor = Color.Black;
            btnBook.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            btnBook.IconColor = SystemColors.ActiveCaptionText;
            btnBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBook.IconSize = 40;
            btnBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnBook.Location = new Point(198, 200);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(186, 52);
            btnBook.TabIndex = 1;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // btnComputer
            // 
            btnComputer.Font = new Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComputer.IconChar = FontAwesome.Sharp.IconChar.DesktopAlt;
            btnComputer.IconColor = Color.Black;
            btnComputer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnComputer.IconSize = 40;
            btnComputer.ImageAlign = ContentAlignment.MiddleLeft;
            btnComputer.Location = new Point(198, 258);
            btnComputer.Name = "btnComputer";
            btnComputer.Size = new Size(186, 49);
            btnComputer.TabIndex = 2;
            btnComputer.Text = "Computer";
            btnComputer.UseVisualStyleBackColor = true;
            btnComputer.Click += btnComputer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Handwriting", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(249, 164);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 3;
            label2.Text = "Register";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gardenpngg;
            pictureBox1.Location = new Point(209, -21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(588, 347);
            Controls.Add(label2);
            Controls.Add(btnComputer);
            Controls.Add(btnBook);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            Text = "M E N U ";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FontAwesome.Sharp.IconButton btnBook;
        private FontAwesome.Sharp.IconButton btnComputer;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
