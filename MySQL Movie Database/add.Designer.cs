namespace MySQL_Movie_Database
{
    partial class add
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
            this.title = new System.Windows.Forms.Label();
            this.sub = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.relDateLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.favCharLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.favCharTextBox = new System.Windows.Forms.TextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(433, 33);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(96, 48);
            this.title.TabIndex = 2;
            this.title.Text = "Add";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sub
            // 
            this.sub.AutoSize = true;
            this.sub.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(246, 100);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(460, 29);
            this.sub.TabIndex = 7;
            this.sub.Text = "Here you may add movies to the database";
            this.sub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(201, 158);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(97, 32);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // relDateLabel
            // 
            this.relDateLabel.AutoSize = true;
            this.relDateLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.relDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relDateLabel.Location = new System.Drawing.Point(201, 219);
            this.relDateLabel.Name = "relDateLabel";
            this.relDateLabel.Size = new System.Drawing.Size(194, 32);
            this.relDateLabel.TabIndex = 9;
            this.relDateLabel.Text = "Release Date:";
            this.relDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(201, 287);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(101, 32);
            this.genreLabel.TabIndex = 10;
            this.genreLabel.Text = "Genre:";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // favCharLabel
            // 
            this.favCharLabel.AutoSize = true;
            this.favCharLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.favCharLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favCharLabel.Location = new System.Drawing.Point(201, 348);
            this.favCharLabel.Name = "favCharLabel";
            this.favCharLabel.Size = new System.Drawing.Size(272, 32);
            this.favCharLabel.TabIndex = 11;
            this.favCharLabel.Text = "Favourite Character:";
            this.favCharLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.Location = new System.Drawing.Point(201, 415);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(283, 32);
            this.rateLabel.TabIndex = 12;
            this.rateLabel.Text = "Your Rating (1 to 10):";
            this.rateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.nameTextBox.Location = new System.Drawing.Point(338, 153);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(416, 41);
            this.nameTextBox.TabIndex = 13;
            // 
            // genreTextBox
            // 
            this.genreTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.genreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.genreTextBox.Location = new System.Drawing.Point(338, 278);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(416, 41);
            this.genreTextBox.TabIndex = 14;
            // 
            // favCharTextBox
            // 
            this.favCharTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.favCharTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.favCharTextBox.Location = new System.Drawing.Point(498, 339);
            this.favCharTextBox.Name = "favCharTextBox";
            this.favCharTextBox.Size = new System.Drawing.Size(256, 41);
            this.favCharTextBox.TabIndex = 15;
            // 
            // rateTextBox
            // 
            this.rateTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rateTextBox.Location = new System.Drawing.Point(498, 410);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(256, 41);
            this.rateTextBox.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dateTimePicker1.Location = new System.Drawing.Point(462, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(3, 500);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(172, 59);
            this.backBtn.TabIndex = 47;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(758, 499);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(172, 59);
            this.addBtn.TabIndex = 48;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 561);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(this.favCharTextBox);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.favCharLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.relDateLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.title);
            this.Name = "add";
            this.Text = "Add";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.add_FormClosed_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label sub;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label relDateLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label favCharLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox favCharTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button addBtn;
    }
}