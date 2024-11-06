namespace Culminating_Movie_Database
{
    partial class remove
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
            this.sub1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sub2 = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(373, 28);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(147, 40);
            this.title.TabIndex = 1;
            this.title.Text = "Remove";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sub1
            // 
            this.sub1.AutoSize = true;
            this.sub1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sub1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub1.Location = new System.Drawing.Point(185, 92);
            this.sub1.Name = "sub1";
            this.sub1.Size = new System.Drawing.Size(484, 26);
            this.sub1.TabIndex = 6;
            this.sub1.Text = "Here you may remove movies from the database";
            this.sub1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox2.Location = new System.Drawing.Point(246, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(354, 41);
            this.textBox2.TabIndex = 19;
            // 
            // sub2
            // 
            this.sub2.AutoSize = true;
            this.sub2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sub2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub2.Location = new System.Drawing.Point(241, 158);
            this.sub2.Name = "sub2";
            this.sub2.Size = new System.Drawing.Size(359, 26);
            this.sub2.TabIndex = 20;
            this.sub2.Text = "Enter the movie you wish to remove\r\n";
            this.sub2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeBtn
            // 
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(348, 278);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(172, 59);
            this.removeBtn.TabIndex = 45;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(-1, 476);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(172, 59);
            this.backBtn.TabIndex = 46;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 534);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.sub2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.sub1);
            this.Controls.Add(this.title);
            this.Name = "remove";
            this.Text = "Remove";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.remove_FormClosed_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label sub1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label sub2;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button backBtn;
    }
}