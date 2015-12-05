namespace WindowsFormsApplication1
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnURL = new System.Windows.Forms.Button();
            this.lstvURL = new System.Windows.Forms.ListView();
            this.colPub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAuthors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPublisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPubYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCitations = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtOutFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaperSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(149, 27);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(163, 20);
            this.txtURL.TabIndex = 6;
            this.txtURL.Text = "http://www.google.com";
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // btnURL
            // 
            this.btnURL.Location = new System.Drawing.Point(12, 27);
            this.btnURL.Name = "btnURL";
            this.btnURL.Size = new System.Drawing.Size(121, 23);
            this.btnURL.TabIndex = 5;
            this.btnURL.Text = "Execute";
            this.btnURL.UseVisualStyleBackColor = true;
            this.btnURL.Click += new System.EventHandler(this.btnURL_Click);
            // 
            // lstvURL
            // 
            this.lstvURL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPub,
            this.colAuthors,
            this.colPublisher,
            this.colPubYear,
            this.colCitations});
            this.lstvURL.Location = new System.Drawing.Point(12, 150);
            this.lstvURL.Name = "lstvURL";
            this.lstvURL.Size = new System.Drawing.Size(734, 186);
            this.lstvURL.TabIndex = 7;
            this.lstvURL.UseCompatibleStateImageBehavior = false;
            this.lstvURL.View = System.Windows.Forms.View.Details;
            // 
            // colPub
            // 
            this.colPub.Text = "Publication Title";
            this.colPub.Width = 109;
            // 
            // colAuthors
            // 
            this.colAuthors.Text = "Authors";
            this.colAuthors.Width = 202;
            // 
            // colPublisher
            // 
            this.colPublisher.Text = "Publisher";
            this.colPublisher.Width = 111;
            // 
            // colPubYear
            // 
            this.colPubYear.Text = "Publication Year";
            this.colPubYear.Width = 88;
            // 
            // colCitations
            // 
            this.colCitations.Text = "Citations";
            this.colCitations.Width = 214;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(350, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(143, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // txtOutFile
            // 
            this.txtOutFile.Location = new System.Drawing.Point(512, 27);
            this.txtOutFile.Name = "txtOutFile";
            this.txtOutFile.Size = new System.Drawing.Size(143, 20);
            this.txtOutFile.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Searched For Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Output File Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPaperSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 65);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for paper citations";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Execute Paper Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Paper title";
            // 
            // txtPaperSearch
            // 
            this.txtPaperSearch.Location = new System.Drawing.Point(29, 39);
            this.txtPaperSearch.Name = "txtPaperSearch";
            this.txtPaperSearch.Size = new System.Drawing.Size(459, 20);
            this.txtPaperSearch.TabIndex = 11;
            this.txtPaperSearch.Text = "Model Checking Aspect-Oriented Design Specification";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 348);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutFile);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstvURL);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnURL;
        private System.Windows.Forms.ListView lstvURL;
        private System.Windows.Forms.ColumnHeader colPub;
        private System.Windows.Forms.ColumnHeader colAuthors;
        private System.Windows.Forms.ColumnHeader colPublisher;
        private System.Windows.Forms.ColumnHeader colPubYear;
        private System.Windows.Forms.ColumnHeader colCitations;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtOutFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPaperSearch;
    }
}

