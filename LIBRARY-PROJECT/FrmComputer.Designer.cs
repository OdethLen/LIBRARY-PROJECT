namespace LIBRARY_PROJECT
{
    partial class btnBack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnBack));
            groupBox1 = new GroupBox();
            lblprinttotal = new Label();
            txtNoprints = new TextBox();
            label4 = new Label();
            txtComputernum = new TextBox();
            btnNewcomputer = new FontAwesome.Sharp.IconButton();
            btnAddComputer = new FontAwesome.Sharp.IconButton();
            txtNamec = new TextBox();
            dtpcomputer = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvComputer = new DataGridView();
            btnBack2 = new FontAwesome.Sharp.IconButton();
            btnExporttxtc = new FontAwesome.Sharp.IconButton();
            btnExportWordc = new FontAwesome.Sharp.IconButton();
            btnReadtxt = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComputer).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblprinttotal);
            groupBox1.Controls.Add(txtNoprints);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtComputernum);
            groupBox1.Controls.Add(btnNewcomputer);
            groupBox1.Controls.Add(btnAddComputer);
            groupBox1.Controls.Add(txtNamec);
            groupBox1.Controls.Add(dtpcomputer);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(115, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 182);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Register";
            // 
            // lblprinttotal
            // 
            lblprinttotal.AutoSize = true;
            lblprinttotal.Font = new Font("Lucida Sans Typewriter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblprinttotal.Location = new Point(295, 139);
            lblprinttotal.Name = "lblprinttotal";
            lblprinttotal.Size = new Size(39, 15);
            lblprinttotal.TabIndex = 10;
            lblprinttotal.Text = "Cost";
            // 
            // txtNoprints
            // 
            txtNoprints.Font = new Font("Lucida Sans", 9.75F);
            txtNoprints.Location = new Point(167, 131);
            txtNoprints.Name = "txtNoprints";
            txtNoprints.Size = new Size(84, 23);
            txtNoprints.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 133);
            label4.Name = "label4";
            label4.Size = new Size(132, 17);
            label4.TabIndex = 8;
            label4.Text = "Number of prints";
            // 
            // txtComputernum
            // 
            txtComputernum.Font = new Font("Lucida Sans", 9.75F);
            txtComputernum.Location = new Point(167, 93);
            txtComputernum.Name = "txtComputernum";
            txtComputernum.Size = new Size(84, 23);
            txtComputernum.TabIndex = 7;
            // 
            // btnNewcomputer
            // 
            btnNewcomputer.Font = new Font("Lucida Handwriting", 9F);
            btnNewcomputer.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnNewcomputer.IconColor = Color.Black;
            btnNewcomputer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNewcomputer.IconSize = 32;
            btnNewcomputer.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewcomputer.Location = new Point(317, 77);
            btnNewcomputer.Name = "btnNewcomputer";
            btnNewcomputer.Size = new Size(106, 35);
            btnNewcomputer.TabIndex = 4;
            btnNewcomputer.Text = "NEW";
            btnNewcomputer.UseVisualStyleBackColor = true;
            btnNewcomputer.Click += btnNewcomputer_Click;
            // 
            // btnAddComputer
            // 
            btnAddComputer.Font = new Font("Lucida Handwriting", 9F);
            btnAddComputer.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnAddComputer.IconColor = Color.Black;
            btnAddComputer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddComputer.IconSize = 32;
            btnAddComputer.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddComputer.Location = new Point(317, 30);
            btnAddComputer.Name = "btnAddComputer";
            btnAddComputer.Size = new Size(106, 35);
            btnAddComputer.TabIndex = 3;
            btnAddComputer.Text = "ADD";
            btnAddComputer.UseVisualStyleBackColor = true;
            btnAddComputer.Click += btnAddComputer_Click;
            // 
            // txtNamec
            // 
            txtNamec.Font = new Font("Lucida Sans", 9.75F);
            txtNamec.Location = new Point(86, 30);
            txtNamec.Name = "txtNamec";
            txtNamec.Size = new Size(165, 23);
            txtNamec.TabIndex = 6;
            // 
            // dtpcomputer
            // 
            dtpcomputer.Font = new Font("Lucida Sans", 9.75F);
            dtpcomputer.Format = DateTimePickerFormat.Short;
            dtpcomputer.Location = new Point(86, 64);
            dtpcomputer.Name = "dtpcomputer";
            dtpcomputer.Size = new Size(165, 23);
            dtpcomputer.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 73);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 4;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 101);
            label2.Name = "label2";
            label2.Size = new Size(141, 17);
            label2.TabIndex = 3;
            label2.Text = "Computer number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // dgvComputer
            // 
            dgvComputer.BackgroundColor = Color.PowderBlue;
            dgvComputer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComputer.Location = new Point(59, 319);
            dgvComputer.Name = "dgvComputer";
            dgvComputer.Size = new Size(608, 193);
            dgvComputer.TabIndex = 2;
            // 
            // btnBack2
            // 
            btnBack2.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            btnBack2.IconColor = Color.CadetBlue;
            btnBack2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBack2.IconSize = 32;
            btnBack2.Location = new Point(12, 12);
            btnBack2.Name = "btnBack2";
            btnBack2.Size = new Size(57, 31);
            btnBack2.TabIndex = 3;
            btnBack2.UseVisualStyleBackColor = true;
            btnBack2.Click += btnBack2_Click;
            // 
            // btnExporttxtc
            // 
            btnExporttxtc.Font = new Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExporttxtc.IconChar = FontAwesome.Sharp.IconChar.None;
            btnExporttxtc.IconColor = Color.Black;
            btnExporttxtc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExporttxtc.Location = new Point(65, 259);
            btnExporttxtc.Name = "btnExporttxtc";
            btnExporttxtc.Size = new Size(113, 30);
            btnExporttxtc.TabIndex = 7;
            btnExporttxtc.Text = "EXPORT TXT";
            btnExporttxtc.UseVisualStyleBackColor = true;
            btnExporttxtc.Click += btnExporttxtc_Click;
            // 
            // btnExportWordc
            // 
            btnExportWordc.Font = new Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportWordc.IconChar = FontAwesome.Sharp.IconChar.None;
            btnExportWordc.IconColor = Color.Black;
            btnExportWordc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportWordc.Location = new Point(215, 259);
            btnExportWordc.Name = "btnExportWordc";
            btnExportWordc.Size = new Size(151, 30);
            btnExportWordc.TabIndex = 9;
            btnExportWordc.Text = "EXPORT WORD";
            btnExportWordc.UseVisualStyleBackColor = true;
            btnExportWordc.Click += btnExportWordc_Click;
            // 
            // btnReadtxt
            // 
            btnReadtxt.Font = new Font("Lucida Handwriting", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReadtxt.IconChar = FontAwesome.Sharp.IconChar.None;
            btnReadtxt.IconColor = Color.Black;
            btnReadtxt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReadtxt.Location = new Point(59, 535);
            btnReadtxt.Name = "btnReadtxt";
            btnReadtxt.Size = new Size(128, 32);
            btnReadtxt.TabIndex = 10;
            btnReadtxt.Text = "READ TXT";
            btnReadtxt.UseVisualStyleBackColor = true;
            btnReadtxt.Click += btnReadtxt_Click;
            // 
            // btnBack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(749, 659);
            Controls.Add(btnReadtxt);
            Controls.Add(btnExportWordc);
            Controls.Add(btnExporttxtc);
            Controls.Add(btnBack2);
            Controls.Add(dgvComputer);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "btnBack";
            Text = "C O M P U T E R   R E G I S T E R";
            Load += btnBack_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComputer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private DateTimePicker dtpcomputer;
        private TextBox txtNamec;
        private FontAwesome.Sharp.IconButton btnNewcomputer;
        private FontAwesome.Sharp.IconButton btnAddComputer;
        private TextBox txtComputernum;
        private DataGridView dgvComputer;
        private FontAwesome.Sharp.IconButton btnBack2;
        private Label label4;
        private TextBox txtNoprints;
        private Label lblprinttotal;
        private FontAwesome.Sharp.IconButton btnExporttxtc;
        private FontAwesome.Sharp.IconButton btnExportWordc;
        private FontAwesome.Sharp.IconButton btnReadtxt;
    }
}