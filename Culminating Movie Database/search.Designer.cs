namespace Culminating_Movie_Database
{
    partial class search
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
            this.sub1 = new System.Windows.Forms.Label();
            this.sub2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sub3 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(373, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(129, 40);
            this.title.TabIndex = 1;
            this.title.Text = "Search";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sub1
            // 
            this.sub1.AutoSize = true;
            this.sub1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sub1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub1.Location = new System.Drawing.Point(97, 79);
            this.sub1.Name = "sub1";
            this.sub1.Size = new System.Drawing.Size(559, 26);
            this.sub1.TabIndex = 6;
            this.sub1.Text = "Here you may search for specific movies in the database";
            this.sub1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sub2
            // 
            this.sub2.AutoSize = true;
            this.sub2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sub2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub2.Location = new System.Drawing.Point(97, 130);
            this.sub2.Name = "sub2";
            this.sub2.Size = new System.Drawing.Size(387, 26);
            this.sub2.TabIndex = 7;
            this.sub2.Text = "Enter the Movie Name below to search";
            this.sub2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox2.Location = new System.Drawing.Point(101, 181);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(379, 45);
            this.textBox2.TabIndex = 33;
            // 
            // sub3
            // 
            this.sub3.AutoSize = true;
            this.sub3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sub3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub3.Location = new System.Drawing.Point(240, 412);
            this.sub3.Name = "sub3";
            this.sub3.Size = new System.Drawing.Size(385, 26);
            this.sub3.TabIndex = 37;
            this.sub3.Text = "Would you like to edit this information?";
            this.sub3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(501, 181);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(155, 46);
            this.searchBtn.TabIndex = 44;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // yesBtn
            // 
            this.yesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesBtn.Location = new System.Drawing.Point(245, 465);
            this.yesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(173, 49);
            this.yesBtn.TabIndex = 45;
            this.yesBtn.Text = "Yes";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noBtn.Location = new System.Drawing.Point(445, 465);
            this.noBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(180, 49);
            this.noBtn.TabIndex = 46;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(-1, 566);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(173, 49);
            this.backBtn.TabIndex = 47;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataSource = typeof(ClassLibrary.Movie);
            // 
            // movieBindingSource1
            // 
            this.movieBindingSource1.DataSource = typeof(ClassLibrary.Movie);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox1.Location = new System.Drawing.Point(94, 245);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(687, 125);
            this.textBox1.TabIndex = 48;
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 614);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.sub3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.sub2);
            this.Controls.Add(this.sub1);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "search";
            this.Text = "Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.search_FormClosed_1);
            this.Load += new System.EventHandler(this.search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label sub1;
        private System.Windows.Forms.Label sub2;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label sub3;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.BindingSource movieBindingSource1;
        private System.Windows.Forms.TextBox textBox1;
    }
}