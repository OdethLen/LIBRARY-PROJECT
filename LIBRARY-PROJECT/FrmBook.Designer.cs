namespace LIBRARY_PROJECT
{
    partial class FrmBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBook));
            groupBox1 = new GroupBox();
            dtpEnddate = new DateTimePicker();
            btnAddBook = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            btnNewbookr = new FontAwesome.Sharp.IconButton();
            dtpdate = new DateTimePicker();
            txtPublisher = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvBookregister = new DataGridView();
            btnOpentxtFile = new FontAwesome.Sharp.IconButton();
            btnBack = new FontAwesome.Sharp.IconButton();
            btnExporttxt = new FontAwesome.Sharp.IconButton();
            btnExportWord = new FontAwesome.Sharp.IconButton();
            btnExportexcel = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookregister).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dtpEnddate);
            groupBox1.Controls.Add(btnAddBook);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnNewbookr);
            groupBox1.Controls.Add(dtpdate);
            groupBox1.Controls.Add(txtPublisher);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(101, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 226);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Register";
            // 
            // dtpEnddate
            // 
            dtpEnddate.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEnddate.Format = DateTimePickerFormat.Short;
            dtpEnddate.Location = new Point(287, 168);
            dtpEnddate.Name = "dtpEnddate";
            dtpEnddate.Size = new Size(117, 23);
            dtpEnddate.TabIndex = 12;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBook.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAddBook.IconColor = Color.Black;
            btnAddBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddBook.Location = new Point(394, 44);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(104, 30);
            btnAddBook.TabIndex = 5;
            btnAddBook.Text = "ADD";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(207, 174);
            label6.Name = "label6";
            label6.Size = new Size(74, 17);
            label6.TabIndex = 11;
            label6.Text = "End date";
            // 
            // btnNewbookr
            // 
            btnNewbookr.Font = new Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewbookr.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNewbookr.IconColor = Color.Black;
            btnNewbookr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNewbookr.IconSize = 32;
            btnNewbookr.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewbookr.Location = new Point(394, 80);
            btnNewbookr.Name = "btnNewbookr";
            btnNewbookr.Size = new Size(106, 30);
            btnNewbookr.TabIndex = 2;
            btnNewbookr.Text = "NEW";
            btnNewbookr.UseVisualStyleBackColor = true;
            btnNewbookr.Click += btnNewbookr_Click;
            // 
            // dtpdate
            // 
            dtpdate.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpdate.Format = DateTimePickerFormat.Short;
            dtpdate.Location = new Point(65, 172);
            dtpdate.Name = "dtpdate";
            dtpdate.Size = new Size(115, 23);
            dtpdate.TabIndex = 10;
            // 
            // txtPublisher
            // 
            txtPublisher.Font = new Font("Lucida Sans", 9.75F);
            txtPublisher.Location = new Point(118, 133);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(231, 23);
            txtPublisher.TabIndex = 9;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Lucida Sans", 9.75F);
            txtAuthor.Location = new Point(118, 100);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(231, 23);
            txtAuthor.TabIndex = 8;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Lucida Sans", 9.75F);
            txtTitle.Location = new Point(118, 66);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(231, 23);
            txtTitle.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Font = new Font("Lucida Sans", 9.75F);
            txtName.Location = new Point(86, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(171, 23);
            txtName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 177);
            label5.Name = "label5";
            label5.Size = new Size(43, 17);
            label5.TabIndex = 5;
            label5.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 135);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 4;
            label4.Text = "Publisher";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 103);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 3;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 69);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 2;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 33);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // dgvBookregister
            // 
            dgvBookregister.BackgroundColor = Color.Pink;
            dgvBookregister.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookregister.Location = new Point(64, 357);
            dgvBookregister.Name = "dgvBookregister";
            dgvBookregister.Size = new Size(613, 193);
            dgvBookregister.TabIndex = 1;
            // 
            // btnOpentxtFile
            // 
            btnOpentxtFile.Font = new Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpentxtFile.IconChar = FontAwesome.Sharp.IconChar.None;
            btnOpentxtFile.IconColor = Color.Black;
            btnOpentxtFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOpentxtFile.Location = new Point(64, 568);
            btnOpentxtFile.Name = "btnOpentxtFile";
            btnOpentxtFile.Size = new Size(122, 30);
            btnOpentxtFile.TabIndex = 2;
            btnOpentxtFile.Text = "READ TXT";
            btnOpentxtFile.UseVisualStyleBackColor = true;
            btnOpentxtFile.Click += btnOpentxtFile_Click;
            // 
            // btnBack
            // 
            btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            btnBack.IconColor = Color.RosyBrown;
            btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBack.IconSize = 32;
            btnBack.Location = new Point(12, 21);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(57, 31);
            btnBack.TabIndex = 4;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnExporttxt
            // 
            btnExporttxt.Font = new Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExporttxt.IconChar = FontAwesome.Sharp.IconChar.None;
            btnExporttxt.IconColor = Color.Black;
            btnExporttxt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExporttxt.Location = new Point(64, 303);
            btnExporttxt.Name = "btnExporttxt";
            btnExporttxt.Size = new Size(113, 30);
            btnExporttxt.TabIndex = 6;
            btnExporttxt.Text = "EXPORT TXT";
            btnExporttxt.UseVisualStyleBackColor = true;
            btnExporttxt.Click += btnExporttxt_Click;
            // 
            // btnExportWord
            // 
            btnExportWord.Font = new Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportWord.IconChar = FontAwesome.Sharp.IconChar.None;
            btnExportWord.IconColor = Color.Black;
            btnExportWord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportWord.Location = new Point(201, 303);
            btnExportWord.Name = "btnExportWord";
            btnExportWord.Size = new Size(121, 30);
            btnExportWord.TabIndex = 7;
            btnExportWord.Text = "EXPORT WORD";
            btnExportWord.UseVisualStyleBackColor = true;
            btnExportWord.Click += btnExportWord_Click;
            // 
            // btnExportexcel
            // 
            btnExportexcel.Font = new Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportexcel.IconChar = FontAwesome.Sharp.IconChar.None;
            btnExportexcel.IconColor = Color.Black;
            btnExportexcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportexcel.Location = new Point(351, 303);
            btnExportexcel.Name = "btnExportexcel";
            btnExportexcel.Size = new Size(126, 30);
            btnExportexcel.TabIndex = 8;
            btnExportexcel.Text = "EXPORT EXCEL";
            btnExportexcel.UseVisualStyleBackColor = true;
            btnExportexcel.Click += btnExportexcel_Click;
            // 
            // FrmBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(749, 659);
            Controls.Add(btnExportexcel);
            Controls.Add(btnExportWord);
            Controls.Add(btnExporttxt);
            Controls.Add(btnBack);
            Controls.Add(btnOpentxtFile);
            Controls.Add(dgvBookregister);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmBook";
            Text = "B O O K  R E G I S T E R";
            Load += FrmBook_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookregister).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpdate;
        private TextBox txtPublisher;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private TextBox txtName;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnNewbookr;
        private DateTimePicker dtpEnddate;
        private Label label6;
        private DataGridView dgvBookregister;
        private FontAwesome.Sharp.IconButton btnOpentxtFile;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnAddBook;
        private FontAwesome.Sharp.IconButton btnExporttxt;
        private FontAwesome.Sharp.IconButton btnExportWord;
        private FontAwesome.Sharp.IconButton btnExportexcel;
    }
}