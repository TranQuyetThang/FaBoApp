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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.btnStartPost = new System.Windows.Forms.Button();
            this.listViewPostEmails = new System.Windows.Forms.ListView();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(256, 6);
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
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 20);
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
            this.listViewPosts.Location = new System.Drawing.Point(6, 32);
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
            this.listViewEmails.Location = new System.Drawing.Point(354, 32);
            this.listViewEmails.Name = "listViewEmails";
            this.listViewEmails.Size = new System.Drawing.Size(301, 400);
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
            this.lblCountPosts.Location = new System.Drawing.Point(3, 435);
            this.lblCountPosts.Name = "lblCountPosts";
            this.lblCountPosts.Size = new System.Drawing.Size(47, 13);
            this.lblCountPosts.TabIndex = 6;
            this.lblCountPosts.Text = "Count: --";
            // 
            // lblCountEmails
            // 
            this.lblCountEmails.AutoSize = true;
            this.lblCountEmails.Location = new System.Drawing.Point(351, 435);
            this.lblCountEmails.Name = "lblCountEmails";
            this.lblCountEmails.Size = new System.Drawing.Size(47, 13);
            this.lblCountEmails.TabIndex = 7;
            this.lblCountEmails.Text = "Count: --";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(-5, -2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(696, 485);
            this.tabControl.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.listViewEmails);
            this.tabPage1.Controls.Add(this.lblCountEmails);
            this.tabPage1.Controls.Add(this.listViewPosts);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Controls.Add(this.lblCountPosts);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(688, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fanpage";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.listViewPostEmails);
            this.tabPage2.Controls.Add(this.btnStartPost);
            this.tabPage2.Controls.Add(this.txtPost);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(688, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Post";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(688, 459);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Setting";
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(56, 40);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(216, 20);
            this.txtPost.TabIndex = 0;
            // 
            // btnStartPost
            // 
            this.btnStartPost.Location = new System.Drawing.Point(111, 84);
            this.btnStartPost.Name = "btnStartPost";
            this.btnStartPost.Size = new System.Drawing.Size(97, 23);
            this.btnStartPost.TabIndex = 1;
            this.btnStartPost.Text = "Start";
            this.btnStartPost.UseVisualStyleBackColor = true;
            this.btnStartPost.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listViewPostEmails
            // 
            this.listViewPostEmails.Location = new System.Drawing.Point(355, 15);
            this.listViewPostEmails.Name = "listViewPostEmails";
            this.listViewPostEmails.Size = new System.Drawing.Size(280, 427);
            this.listViewPostEmails.TabIndex = 2;
            this.listViewPostEmails.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 474);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(701, 513);
            this.MinimumSize = new System.Drawing.Size(701, 513);
            this.Name = "Form1";
            this.Text = "Mobgame Tool";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnStartPost;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.ListView listViewPostEmails;
    }
}

