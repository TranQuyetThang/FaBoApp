namespace FaBoApp
{
    partial class Form1
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
			this.btnStart = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.listViewPosts = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listViewEmails = new System.Windows.Forms.ListView();
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblCountPosts = new System.Windows.Forms.Label();
			this.lblCountEmails = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(292, 4);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tên fanpage";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(86, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(200, 20);
			this.textBox1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(107, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 13);
			this.label2.TabIndex = 3;
			// 
			// listViewPosts
			// 
			this.listViewPosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.listViewPosts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewPosts.Location = new System.Drawing.Point(15, 33);
			this.listViewPosts.Name = "listViewPosts";
			this.listViewPosts.Size = new System.Drawing.Size(300, 400);
			this.listViewPosts.TabIndex = 4;
			this.listViewPosts.UseCompatibleStateImageBehavior = false;
			this.listViewPosts.View = System.Windows.Forms.View.Details;
			this.listViewPosts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_KeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Width = 270;
			// 
			// listViewEmails
			// 
			this.listViewEmails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
			this.listViewEmails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewEmails.Location = new System.Drawing.Point(321, 33);
			this.listViewEmails.Name = "listViewEmails";
			this.listViewEmails.Size = new System.Drawing.Size(300, 400);
			this.listViewEmails.TabIndex = 5;
			this.listViewEmails.UseCompatibleStateImageBehavior = false;
			this.listViewEmails.View = System.Windows.Forms.View.Details;
			this.listViewEmails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_KeyDown);
			// 
			// columnHeader2
			// 
			this.columnHeader2.Width = 270;
			// 
			// lblCountPosts
			// 
			this.lblCountPosts.AutoSize = true;
			this.lblCountPosts.Location = new System.Drawing.Point(12, 436);
			this.lblCountPosts.Name = "lblCountPosts";
			this.lblCountPosts.Size = new System.Drawing.Size(47, 13);
			this.lblCountPosts.TabIndex = 6;
			this.lblCountPosts.Text = "Count: --";
			// 
			// lblCountEmails
			// 
			this.lblCountEmails.AutoSize = true;
			this.lblCountEmails.Location = new System.Drawing.Point(320, 436);
			this.lblCountEmails.Name = "lblCountEmails";
			this.lblCountEmails.Size = new System.Drawing.Size(47, 13);
			this.lblCountEmails.TabIndex = 7;
			this.lblCountEmails.Text = "Count: --";
			// 
			// Form1
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 461);
			this.Controls.Add(this.lblCountEmails);
			this.Controls.Add(this.lblCountPosts);
			this.Controls.Add(this.listViewEmails);
			this.Controls.Add(this.listViewPosts);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnStart);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(650, 500);
			this.MinimumSize = new System.Drawing.Size(650, 500);
			this.Name = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListView listViewPosts;
		private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listViewEmails;
		private System.Windows.Forms.Label lblCountPosts;
		private System.Windows.Forms.Label lblCountEmails;
		private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

