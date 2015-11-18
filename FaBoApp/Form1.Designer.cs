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
            this.listViewEmail = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(292, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
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
            this.textBox1.TabIndex = 2;
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
            this.listViewPosts.Size = new System.Drawing.Size(280, 412);
            this.listViewPosts.TabIndex = 4;
            this.listViewPosts.UseCompatibleStateImageBehavior = false;
            this.listViewPosts.View = System.Windows.Forms.View.Details;
            this.listViewPosts.Resize += new System.EventHandler(this.listViewPosts_Resize);
            // 
            // listViewEmail
            // 
            this.listViewEmail.Location = new System.Drawing.Point(311, 33);
            this.listViewEmail.Name = "listViewEmail";
            this.listViewEmail.Size = new System.Drawing.Size(292, 412);
            this.listViewEmail.TabIndex = 5;
            this.listViewEmail.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 457);
            this.Controls.Add(this.listViewEmail);
            this.Controls.Add(this.listViewPosts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
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
        private System.Windows.Forms.ListView listViewEmail;
    }
}

