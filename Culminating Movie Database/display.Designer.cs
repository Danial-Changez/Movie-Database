namespace Culminating_Movie_Database
{
    partial class display
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
            this.title = new System.Windows.Forms.Label();
            this.sub = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.ratingSort = new System.Windows.Forms.Button();
            this.nameSort = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favCharDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(455, 26);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(160, 48);
            this.title.TabIndex = 3;
            this.title.Text = "Display";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sub
            // 
            this.sub.AutoSize = true;
            this.sub.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(296, 84);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(478, 29);
            this.sub.TabIndex = 8;
            this.sub.Text = "Here you may display and sort the database";
            this.sub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(-1, 513);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(172, 59);
            this.backBtn.TabIndex = 48;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ratingSort
            // 
            this.ratingSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingSort.Location = new System.Drawing.Point(12, 282);
            this.ratingSort.Name = "ratingSort";
            this.ratingSort.Size = new System.Drawing.Size(172, 128);
            this.ratingSort.TabIndex = 49;
            this.ratingSort.Text = "Sort By Rating";
            this.ratingSort.UseVisualStyleBackColor = true;
            this.ratingSort.Click += new System.EventHandler(this.ratingSort_Click);
            // 
            // nameSort
            // 
            this.nameSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSort.Location = new System.Drawing.Point(869, 282);
            this.nameSort.Name = "nameSort";
            this.nameSort.Size = new System.Drawing.Size(172, 128);
            this.nameSort.TabIndex = 50;
            this.nameSort.Text = "Sort By  Name";
            this.nameSort.UseVisualStyleBackColor = true;
            this.nameSort.Click += new System.EventHandler(this.nameSort_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.relDateDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.favCharDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.movieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(190, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(673, 456);
            this.dataGridView1.TabIndex = 51;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // relDateDataGridViewTextBoxColumn
            // 
            this.relDateDataGridViewTextBoxColumn.DataPropertyName = "relDate";
            this.relDateDataGridViewTextBoxColumn.HeaderText = "relDate";
            this.relDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.relDateDataGridViewTextBoxColumn.Name = "relDateDataGridViewTextBoxColumn";
            this.relDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "genre";
            this.genreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.Width = 125;
            // 
            // favCharDataGridViewTextBoxColumn
            // 
            this.favCharDataGridViewTextBoxColumn.DataPropertyName = "favChar";
            this.favCharDataGridViewTextBoxColumn.HeaderText = "favChar";
            this.favCharDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.favCharDataGridViewTextBoxColumn.Name = "favCharDataGridViewTextBoxColumn";
            this.favCharDataGridViewTextBoxColumn.Width = 125;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "rating";
            this.ratingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.Width = 125;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataSource = typeof(ClassLibrary.Movie);
            // 
            // display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 571);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nameSort);
            this.Controls.Add(this.ratingSort);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.title);
            this.Name = "display";
            this.Text = "Display";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.display_FormClosed);
            this.Load += new System.EventHandler(this.display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label sub;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button ratingSort;
        private System.Windows.Forms.Button nameSort;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn favCharDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource movieBindingSource;
    }
}