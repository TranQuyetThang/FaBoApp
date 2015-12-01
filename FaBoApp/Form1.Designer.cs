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
            this.btnStartFanpage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFanpage = new System.Windows.Forms.TextBox();
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
            this.lblCountEmails2 = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.listViewPostEmails = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStartPost = new System.Windows.Forms.Button();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtAbout = new System.Windows.Forms.RichTextBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartFanpage
            // 
            this.btnStartFanpage.Location = new System.Drawing.Point(555, 8);
            this.btnStartFanpage.Name = "btnStartFanpage";
            this.btnStartFanpage.Size = new System.Drawing.Size(75, 23);
            this.btnStartFanpage.TabIndex = 1;
            this.btnStartFanpage.Text = "Start";
            this.btnStartFanpage.UseVisualStyleBackColor = true;
            this.btnStartFanpage.Click += new System.EventHandler(this.btnStartFanpage_Click);
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
            // txtFanpage
            // 
            this.txtFanpage.Location = new System.Drawing.Point(15, 10);
            this.txtFanpage.Name = "txtFanpage";
            this.txtFanpage.Size = new System.Drawing.Size(534, 20);
            this.txtFanpage.TabIndex = 0;
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
            this.listViewPosts.Location = new System.Drawing.Point(15, 40);
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
            this.listViewEmails.Location = new System.Drawing.Point(330, 40);
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
            this.lblCountPosts.Location = new System.Drawing.Point(15, 450);
            this.lblCountPosts.Name = "lblCountPosts";
            this.lblCountPosts.Size = new System.Drawing.Size(47, 13);
            this.lblCountPosts.TabIndex = 6;
            this.lblCountPosts.Text = "Count: --";
            // 
            // lblCountEmails
            // 
            this.lblCountEmails.AutoSize = true;
            this.lblCountEmails.Location = new System.Drawing.Point(330, 450);
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
            this.tabControl.Size = new System.Drawing.Size(657, 573);
            this.tabControl.TabIndex = 8;
            this.tabControl.TabIndexChanged += new System.EventHandler(this.tabControl_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.txtFanpage);
            this.tabPage1.Controls.Add(this.listViewEmails);
            this.tabPage1.Controls.Add(this.lblCountEmails);
            this.tabPage1.Controls.Add(this.listViewPosts);
            this.tabPage1.Controls.Add(this.btnStartFanpage);
            this.tabPage1.Controls.Add(this.lblCountPosts);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(649, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scan fanpage";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.lblCountEmails2);
            this.tabPage2.Controls.Add(this.webBrowser);
            this.tabPage2.Controls.Add(this.listViewPostEmails);
            this.tabPage2.Controls.Add(this.btnStartPost);
            this.tabPage2.Controls.Add(this.txtPost);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(649, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Scan post";
            // 
            // lblCountEmails2
            // 
            this.lblCountEmails2.AutoSize = true;
            this.lblCountEmails2.Location = new System.Drawing.Point(330, 450);
            this.lblCountEmails2.Name = "lblCountEmails2";
            this.lblCountEmails2.Size = new System.Drawing.Size(47, 13);
            this.lblCountEmails2.TabIndex = 8;
            this.lblCountEmails2.Text = "Count: --";
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(15, 40);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(300, 400);
            this.webBrowser.TabIndex = 3;
            // 
            // listViewPostEmails
            // 
            this.listViewPostEmails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listViewPostEmails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewPostEmails.Location = new System.Drawing.Point(330, 40);
            this.listViewPostEmails.Name = "listViewPostEmails";
            this.listViewPostEmails.Size = new System.Drawing.Size(300, 400);
            this.listViewPostEmails.TabIndex = 2;
            this.listViewPostEmails.UseCompatibleStateImageBehavior = false;
            this.listViewPostEmails.View = System.Windows.Forms.View.Details;
            this.listViewPostEmails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_KeyDown);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 270;
            // 
            // btnStartPost
            // 
            this.btnStartPost.Location = new System.Drawing.Point(533, 8);
            this.btnStartPost.Name = "btnStartPost";
            this.btnStartPost.Size = new System.Drawing.Size(97, 23);
            this.btnStartPost.TabIndex = 1;
            this.btnStartPost.Text = "Start";
            this.btnStartPost.UseVisualStyleBackColor = true;
            this.btnStartPost.Click += new System.EventHandler(this.btnStartPost_Click);
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(15, 10);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(512, 20);
            this.txtPost.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.txtAbout);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(649, 547);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            // 
            // txtAbout
            // 
            this.txtAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAbout.Enabled = false;
            this.txtAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbout.Location = new System.Drawing.Point(15, 10);
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.Size = new System.Drawing.Size(615, 450);
            this.txtAbout.TabIndex = 0;
            this.txtAbout.Text = "Name: Mobgame Tool\nVersion: 1.0.0\nAuthor: MobTeam\n\nMọi tâm tư tình cảm, đóng góp," +
    " báo lỗi xin liên hệ:\nthangtran@mobgame.vn \nduy@mobgame.vn\n\n";
            this.txtAbout.TextChanged += new System.EventHandler(this.txtAbout_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 496);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(660, 535);
            this.MinimumSize = new System.Drawing.Size(660, 535);
            this.Name = "Form1";
            this.Text = "Mobgame Tool";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartFanpage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFanpage;
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
		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label lblCountEmails2;
		private System.Windows.Forms.RichTextBox txtAbout;
    }
}

