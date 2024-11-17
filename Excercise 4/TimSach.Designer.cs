namespace excercise_2
{
    partial class TimSach
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
            this.Search_btn = new System.Windows.Forms.Button();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.Userinfor_grp = new System.Windows.Forms.GroupBox();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.AddBook_btn = new System.Windows.Forms.Button();
            this.Display_btn = new System.Windows.Forms.Button();
            this.dgvShelves = new System.Windows.Forms.DataGridView();
            this.ShelvesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookNumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.BookInShelf_btn = new System.Windows.Forms.Button();
            this.PublishedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Authors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.Userinfor_grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShelves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(1038, 18);
            this.Search_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(129, 42);
            this.Search_btn.TabIndex = 2;
            this.Search_btn.Text = "Tìm Kiếm";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Search_txt
            // 
            this.Search_txt.Location = new System.Drawing.Point(457, 18);
            this.Search_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(573, 22);
            this.Search_txt.TabIndex = 3;
            // 
            // Userinfor_grp
            // 
            this.Userinfor_grp.Controls.Add(this.Email_txt);
            this.Userinfor_grp.Controls.Add(this.Username_txt);
            this.Userinfor_grp.Location = new System.Drawing.Point(16, 4);
            this.Userinfor_grp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Userinfor_grp.Name = "Userinfor_grp";
            this.Userinfor_grp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Userinfor_grp.Size = new System.Drawing.Size(418, 140);
            this.Userinfor_grp.TabIndex = 4;
            this.Userinfor_grp.TabStop = false;
            this.Userinfor_grp.Text = "Thông Tin";
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(9, 57);
            this.Email_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.ReadOnly = true;
            this.Email_txt.Size = new System.Drawing.Size(185, 22);
            this.Email_txt.TabIndex = 1;
            // 
            // Username_txt
            // 
            this.Username_txt.Location = new System.Drawing.Point(9, 25);
            this.Username_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.ReadOnly = true;
            this.Username_txt.Size = new System.Drawing.Size(185, 22);
            this.Username_txt.TabIndex = 0;
            this.Username_txt.TextChanged += new System.EventHandler(this.Username_txt_TextChanged);
            // 
            // AddBook_btn
            // 
            this.AddBook_btn.Location = new System.Drawing.Point(134, 477);
            this.AddBook_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddBook_btn.Name = "AddBook_btn";
            this.AddBook_btn.Size = new System.Drawing.Size(156, 53);
            this.AddBook_btn.TabIndex = 5;
            this.AddBook_btn.Text = "Thêm Sách";
            this.AddBook_btn.UseVisualStyleBackColor = true;
            this.AddBook_btn.Click += new System.EventHandler(this.AddBook_btn_Click);
            // 
            // Display_btn
            // 
            this.Display_btn.Location = new System.Drawing.Point(1151, 149);
            this.Display_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Display_btn.Name = "Display_btn";
            this.Display_btn.Size = new System.Drawing.Size(156, 47);
            this.Display_btn.TabIndex = 6;
            this.Display_btn.Text = "Hiển Thị Kệ";
            this.Display_btn.UseVisualStyleBackColor = true;
            this.Display_btn.Click += new System.EventHandler(this.Display_btn_Click);
            // 
            // dgvShelves
            // 
            this.dgvShelves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShelves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShelvesName,
            this.Description,
            this.BookNumbers});
            this.dgvShelves.Location = new System.Drawing.Point(617, 203);
            this.dgvShelves.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvShelves.Name = "dgvShelves";
            this.dgvShelves.RowHeadersWidth = 51;
            this.dgvShelves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShelves.Size = new System.Drawing.Size(455, 206);
            this.dgvShelves.TabIndex = 7;
            this.dgvShelves.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvShelves_CellClick);
            // 
            // ShelvesName
            // 
            this.ShelvesName.HeaderText = "Tên Kệ Sách";
            this.ShelvesName.MinimumWidth = 6;
            this.ShelvesName.Name = "ShelvesName";
            this.ShelvesName.Width = 150;
            // 
            // Description
            // 
            this.Description.HeaderText = "Mô Tả";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 150;
            // 
            // BookNumbers
            // 
            this.BookNumbers.HeaderText = "Số Lượng Sách";
            this.BookNumbers.MinimumWidth = 6;
            this.BookNumbers.Name = "BookNumbers";
            this.BookNumbers.Width = 80;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(940, 477);
            this.Delete_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(156, 53);
            this.Delete_btn.TabIndex = 8;
            this.Delete_btn.Text = "Xóa Sách";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // BookInShelf_btn
            // 
            this.BookInShelf_btn.Location = new System.Drawing.Point(500, 477);
            this.BookInShelf_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookInShelf_btn.Name = "BookInShelf_btn";
            this.BookInShelf_btn.Size = new System.Drawing.Size(187, 53);
            this.BookInShelf_btn.TabIndex = 9;
            this.BookInShelf_btn.Text = "Hiện Thị Sách Trong Kệ";
            this.BookInShelf_btn.UseVisualStyleBackColor = true;
            this.BookInShelf_btn.Click += new System.EventHandler(this.BookInShelf_btn_Click);
            // 
            // PublishedDate
            // 
            this.PublishedDate.HeaderText = "Ngày phát hành";
            this.PublishedDate.MinimumWidth = 6;
            this.PublishedDate.Name = "PublishedDate";
            this.PublishedDate.Width = 190;
            // 
            // Authors
            // 
            this.Authors.HeaderText = "Tác giả";
            this.Authors.MinimumWidth = 6;
            this.Authors.Name = "Authors";
            this.Authors.Width = 150;
            // 
            // Title
            // 
            this.Title.HeaderText = "Tựa đề";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 165;
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Authors,
            this.PublishedDate});
            this.dgvBooks.Location = new System.Drawing.Point(25, 203);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(572, 206);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentClick);
            this.dgvBooks.SelectionChanged += new System.EventHandler(this.DgvBooks_SelectionChanged);
            // 
            // FindBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 623);
            this.Controls.Add(this.BookInShelf_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.dgvShelves);
            this.Controls.Add(this.Display_btn);
            this.Controls.Add(this.AddBook_btn);
            this.Controls.Add(this.Userinfor_grp);
            this.Controls.Add(this.Search_txt);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.dgvBooks);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FindBook";
            this.Text = "Tìm sách";
            this.Userinfor_grp.ResumeLayout(false);
            this.Userinfor_grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShelves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.GroupBox Userinfor_grp;
        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.Button AddBook_btn;
        private System.Windows.Forms.Button Display_btn;
        private System.Windows.Forms.DataGridView dgvShelves;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShelvesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookNumbers;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button BookInShelf_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Authors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridView dgvBooks;
    }
}