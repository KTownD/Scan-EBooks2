namespace Scan_EBooks
{
    partial class frmEBooks
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
            this.txtPathForBooks = new System.Windows.Forms.TextBox();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxBooks = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBookCount = new System.Windows.Forms.Label();
            this.lblLineCount = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtPathForBooks
            // 
            this.txtPathForBooks.Location = new System.Drawing.Point(75, 12);
            this.txtPathForBooks.Name = "txtPathForBooks";
            this.txtPathForBooks.Size = new System.Drawing.Size(457, 26);
            this.txtPathForBooks.TabIndex = 0;
            this.txtPathForBooks.Text = "C:\\Dropbox\\Earn\\Teaching\\eBooks";
            // 
            // btnStartScan
            // 
            this.btnStartScan.Location = new System.Drawing.Point(554, 12);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(179, 34);
            this.btnStartScan.TabIndex = 1;
            this.btnStartScan.Text = "Scan Path for Books";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path:";
            // 
            // lbxBooks
            // 
            this.lbxBooks.FormattingEnabled = true;
            this.lbxBooks.ItemHeight = 20;
            this.lbxBooks.Location = new System.Drawing.Point(22, 61);
            this.lbxBooks.Name = "lbxBooks";
            this.lbxBooks.Size = new System.Drawing.Size(510, 344);
            this.lbxBooks.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Book Count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Line Count:";
            // 
            // lblBookCount
            // 
            this.lblBookCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBookCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBookCount.Location = new System.Drawing.Point(657, 60);
            this.lblBookCount.Name = "lblBookCount";
            this.lblBookCount.Size = new System.Drawing.Size(97, 21);
            this.lblBookCount.TabIndex = 4;
            // 
            // lblLineCount
            // 
            this.lblLineCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLineCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLineCount.Location = new System.Drawing.Point(657, 91);
            this.lblLineCount.Name = "lblLineCount";
            this.lblLineCount.Size = new System.Drawing.Size(97, 21);
            this.lblLineCount.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(657, 116);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // frmEBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLineCount);
            this.Controls.Add(this.lblBookCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartScan);
            this.Controls.Add(this.txtPathForBooks);
            this.Name = "frmEBooks";
            this.Text = "Scan EBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPathForBooks;
        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBookCount;
        private System.Windows.Forms.Label lblLineCount;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

