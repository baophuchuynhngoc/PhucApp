namespace Phuc
{
    partial class f1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.Tentxt = new System.Windows.Forms.TextBox();
            this.Loptxt = new System.Windows.Forms.TextBox();
            this.Matxt = new System.Windows.Forms.TextBox();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.xID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMaSv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xID,
            this.xTenSV,
            this.xMaSv,
            this.xLop,
            this.xPhone});
            this.dataGridView1.Location = new System.Drawing.Point(11, 206);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(509, 193);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 229);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã Sinh Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 19);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(541, 67);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 37);
            this.button3.TabIndex = 11;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(544, 123);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 37);
            this.button4.TabIndex = 12;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(544, 307);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 38);
            this.button5.TabIndex = 16;
            this.button5.Text = "Update to Database ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Idtxt
            // 
            this.Idtxt.Location = new System.Drawing.Point(140, 6);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(298, 20);
            this.Idtxt.TabIndex = 17;
            // 
            // Tentxt
            // 
            this.Tentxt.Location = new System.Drawing.Point(140, 33);
            this.Tentxt.Name = "Tentxt";
            this.Tentxt.Size = new System.Drawing.Size(298, 20);
            this.Tentxt.TabIndex = 18;
            // 
            // Loptxt
            // 
            this.Loptxt.Location = new System.Drawing.Point(140, 60);
            this.Loptxt.Name = "Loptxt";
            this.Loptxt.Size = new System.Drawing.Size(298, 20);
            this.Loptxt.TabIndex = 19;
            // 
            // Matxt
            // 
            this.Matxt.Location = new System.Drawing.Point(140, 94);
            this.Matxt.Name = "Matxt";
            this.Matxt.Size = new System.Drawing.Size(298, 20);
            this.Matxt.TabIndex = 20;
            // 
            // Phonetxt
            // 
            this.Phonetxt.Location = new System.Drawing.Point(140, 127);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(298, 20);
            this.Phonetxt.TabIndex = 21;
            // 
            // xID
            // 
            this.xID.HeaderText = "ID";
            this.xID.MinimumWidth = 6;
            this.xID.Name = "xID";
            // 
            // xTenSV
            // 
            this.xTenSV.HeaderText = "Tên Sinh Viên";
            this.xTenSV.MinimumWidth = 6;
            this.xTenSV.Name = "xTenSV";
            // 
            // xMaSv
            // 
            this.xMaSv.HeaderText = "Mã Sinh Viên";
            this.xMaSv.MinimumWidth = 6;
            this.xMaSv.Name = "xMaSv";
            // 
            // xLop
            // 
            this.xLop.HeaderText = "Lớp";
            this.xLop.MinimumWidth = 6;
            this.xLop.Name = "xLop";
            // 
            // xPhone
            // 
            this.xPhone.HeaderText = "Phone";
            this.xPhone.MinimumWidth = 6;
            this.xPhone.Name = "xPhone";
            // 
            // f1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 410);
            this.Controls.Add(this.Phonetxt);
            this.Controls.Add(this.Matxt);
            this.Controls.Add(this.Loptxt);
            this.Controls.Add(this.Tentxt);
            this.Controls.Add(this.Idtxt);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "f1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox Idtxt;
        private System.Windows.Forms.TextBox Tentxt;
        private System.Windows.Forms.TextBox Loptxt;
        private System.Windows.Forms.TextBox Matxt;
        private System.Windows.Forms.TextBox Phonetxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn xID;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMaSv;
        private System.Windows.Forms.DataGridViewTextBoxColumn xLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPhone;
    }
}

