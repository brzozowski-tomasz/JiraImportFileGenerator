namespace CodeCleanUpResharperToJiraConverter
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
            this.btnLoadIssues = new System.Windows.Forms.Button();
            this.issuesGridView = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnGenerateJira = new System.Windows.Forms.Button();
            this.lblNumberOfIssues = new System.Windows.Forms.Label();
            this.lblNumberOfIssuesSelected = new System.Windows.Forms.Label();
            this.cmbxIssueType = new System.Windows.Forms.ComboBox();
            this.cmbxIssueCategory = new System.Windows.Forms.ComboBox();
            this.btnLoadCodeAnalysis = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.issuesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadIssues
            // 
            this.btnLoadIssues.Location = new System.Drawing.Point(29, 27);
            this.btnLoadIssues.Name = "btnLoadIssues";
            this.btnLoadIssues.Size = new System.Drawing.Size(165, 30);
            this.btnLoadIssues.TabIndex = 0;
            this.btnLoadIssues.Text = "Load R# Issues";
            this.btnLoadIssues.UseVisualStyleBackColor = true;
            this.btnLoadIssues.Click += new System.EventHandler(this.btnLoadIssues_Click);
            // 
            // issuesGridView
            // 
            this.issuesGridView.AllowUserToAddRows = false;
            this.issuesGridView.AllowUserToDeleteRows = false;
            this.issuesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.issuesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.issuesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issuesGridView.Location = new System.Drawing.Point(29, 108);
            this.issuesGridView.Name = "issuesGridView";
            this.issuesGridView.ReadOnly = true;
            this.issuesGridView.RowTemplate.Height = 24;
            this.issuesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.issuesGridView.Size = new System.Drawing.Size(1180, 525);
            this.issuesGridView.TabIndex = 1;
            this.issuesGridView.SelectionChanged += new System.EventHandler(this.issuesGridView_SelectionChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Location = new System.Drawing.Point(1134, 57);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnGenerateJira
            // 
            this.btnGenerateJira.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateJira.Location = new System.Drawing.Point(1043, 657);
            this.btnGenerateJira.Name = "btnGenerateJira";
            this.btnGenerateJira.Size = new System.Drawing.Size(166, 28);
            this.btnGenerateJira.TabIndex = 4;
            this.btnGenerateJira.Text = "Generate Jira Csv";
            this.btnGenerateJira.UseVisualStyleBackColor = true;
            this.btnGenerateJira.Click += new System.EventHandler(this.btnGenerateJira_Click);
            // 
            // lblNumberOfIssues
            // 
            this.lblNumberOfIssues.AutoSize = true;
            this.lblNumberOfIssues.Location = new System.Drawing.Point(26, 76);
            this.lblNumberOfIssues.Name = "lblNumberOfIssues";
            this.lblNumberOfIssues.Size = new System.Drawing.Size(122, 17);
            this.lblNumberOfIssues.TabIndex = 5;
            this.lblNumberOfIssues.Text = "Number of Issues:";
            // 
            // lblNumberOfIssuesSelected
            // 
            this.lblNumberOfIssuesSelected.AutoSize = true;
            this.lblNumberOfIssuesSelected.Location = new System.Drawing.Point(279, 76);
            this.lblNumberOfIssuesSelected.Name = "lblNumberOfIssuesSelected";
            this.lblNumberOfIssuesSelected.Size = new System.Drawing.Size(179, 17);
            this.lblNumberOfIssuesSelected.TabIndex = 6;
            this.lblNumberOfIssuesSelected.Text = "Number of Issues selected:";
            // 
            // cmbxIssueType
            // 
            this.cmbxIssueType.FormattingEnabled = true;
            this.cmbxIssueType.Location = new System.Drawing.Point(642, 57);
            this.cmbxIssueType.Name = "cmbxIssueType";
            this.cmbxIssueType.Size = new System.Drawing.Size(479, 24);
            this.cmbxIssueType.TabIndex = 7;
            // 
            // cmbxIssueCategory
            // 
            this.cmbxIssueCategory.FormattingEnabled = true;
            this.cmbxIssueCategory.Location = new System.Drawing.Point(642, 27);
            this.cmbxIssueCategory.Name = "cmbxIssueCategory";
            this.cmbxIssueCategory.Size = new System.Drawing.Size(479, 24);
            this.cmbxIssueCategory.TabIndex = 8;
            this.cmbxIssueCategory.SelectedIndexChanged += new System.EventHandler(this.cmbxIssueCategory_SelectedIndexChanged);
            // 
            // btnLoadCodeAnalysis
            // 
            this.btnLoadCodeAnalysis.Location = new System.Drawing.Point(221, 27);
            this.btnLoadCodeAnalysis.Name = "btnLoadCodeAnalysis";
            this.btnLoadCodeAnalysis.Size = new System.Drawing.Size(165, 30);
            this.btnLoadCodeAnalysis.TabIndex = 9;
            this.btnLoadCodeAnalysis.Text = "Load VS Analysis";
            this.btnLoadCodeAnalysis.UseVisualStyleBackColor = true;
            this.btnLoadCodeAnalysis.Click += new System.EventHandler(this.btnLoadCodeAnalysis_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(543, 657);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(479, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 707);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnLoadCodeAnalysis);
            this.Controls.Add(this.cmbxIssueCategory);
            this.Controls.Add(this.cmbxIssueType);
            this.Controls.Add(this.lblNumberOfIssuesSelected);
            this.Controls.Add(this.lblNumberOfIssues);
            this.Controls.Add(this.btnGenerateJira);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.issuesGridView);
            this.Controls.Add(this.btnLoadIssues);
            this.Name = "Form1";
            this.Text = "Resharper to Jira Converter";
            ((System.ComponentModel.ISupportInitialize)(this.issuesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadIssues;
        private System.Windows.Forms.DataGridView issuesGridView;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnGenerateJira;
        private System.Windows.Forms.Label lblNumberOfIssues;
        private System.Windows.Forms.Label lblNumberOfIssuesSelected;
        private System.Windows.Forms.ComboBox cmbxIssueType;
        private System.Windows.Forms.ComboBox cmbxIssueCategory;
        private System.Windows.Forms.Button btnLoadCodeAnalysis;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

