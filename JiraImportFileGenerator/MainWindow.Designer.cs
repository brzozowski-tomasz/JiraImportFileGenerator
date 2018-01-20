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
            this.btnLoadResharperIssues = new System.Windows.Forms.Button();
            this.issuesGridView = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnGenerateJira = new System.Windows.Forms.Button();
            this.lblNumberOfIssues = new System.Windows.Forms.Label();
            this.lblNumberOfIssuesSelected = new System.Windows.Forms.Label();
            this.cmbxIssueType = new System.Windows.Forms.ComboBox();
            this.cmbxIssueCategory = new System.Windows.Forms.ComboBox();
            this.btnLoadVSCodeMetrics = new System.Windows.Forms.Button();
            this.cmbxScmUrl = new System.Windows.Forms.ComboBox();
            this.lblScmUrl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.issuesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadResharperIssues
            // 
            this.btnLoadResharperIssues.Location = new System.Drawing.Point(29, 27);
            this.btnLoadResharperIssues.Name = "btnLoadResharperIssues";
            this.btnLoadResharperIssues.Size = new System.Drawing.Size(165, 30);
            this.btnLoadResharperIssues.TabIndex = 0;
            this.btnLoadResharperIssues.Text = "Load R# Issues";
            this.btnLoadResharperIssues.UseVisualStyleBackColor = true;
            this.btnLoadResharperIssues.Click += new System.EventHandler(this.btnLoadResharperIssues_Click);
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
            // btnLoadVSCodeMetrics
            // 
            this.btnLoadVSCodeMetrics.Location = new System.Drawing.Point(221, 27);
            this.btnLoadVSCodeMetrics.Name = "btnLoadVSCodeMetrics";
            this.btnLoadVSCodeMetrics.Size = new System.Drawing.Size(165, 30);
            this.btnLoadVSCodeMetrics.TabIndex = 9;
            this.btnLoadVSCodeMetrics.Text = "Load VS Code Metrics";
            this.btnLoadVSCodeMetrics.UseVisualStyleBackColor = true;
            this.btnLoadVSCodeMetrics.Click += new System.EventHandler(this.btnLoadVSCodeMeterics_Click);
            // 
            // cmbxScmUrl
            // 
            this.cmbxScmUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxScmUrl.FormattingEnabled = true;
            this.cmbxScmUrl.Items.AddRange(new object[] {
            "https://github.com/DFRedKnee/turnkey-converged-billing-activation-portal.git",
            "https://github.com/DFRedKnee/turnkey-converged-billing-web-self-care.git"});
            this.cmbxScmUrl.Location = new System.Drawing.Point(400, 657);
            this.cmbxScmUrl.Name = "cmbxScmUrl";
            this.cmbxScmUrl.Size = new System.Drawing.Size(622, 24);
            this.cmbxScmUrl.TabIndex = 10;
            this.cmbxScmUrl.SelectedIndexChanged += new System.EventHandler(this.cmbxScmUrl_SelectedIndexChanged);
            // 
            // lblScmUrl
            // 
            this.lblScmUrl.AutoSize = true;
            this.lblScmUrl.Location = new System.Drawing.Point(329, 660);
            this.lblScmUrl.Name = "lblScmUrl";
            this.lblScmUrl.Size = new System.Drawing.Size(57, 17);
            this.lblScmUrl.TabIndex = 11;
            this.lblScmUrl.Text = "ScmUrl:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 707);
            this.Controls.Add(this.lblScmUrl);
            this.Controls.Add(this.cmbxScmUrl);
            this.Controls.Add(this.btnLoadVSCodeMetrics);
            this.Controls.Add(this.cmbxIssueCategory);
            this.Controls.Add(this.cmbxIssueType);
            this.Controls.Add(this.lblNumberOfIssuesSelected);
            this.Controls.Add(this.lblNumberOfIssues);
            this.Controls.Add(this.btnGenerateJira);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.issuesGridView);
            this.Controls.Add(this.btnLoadResharperIssues);
            this.Name = "Form1";
            this.Text = "Resharper to Jira Converter";
            ((System.ComponentModel.ISupportInitialize)(this.issuesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadResharperIssues;
        private System.Windows.Forms.DataGridView issuesGridView;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnGenerateJira;
        private System.Windows.Forms.Label lblNumberOfIssues;
        private System.Windows.Forms.Label lblNumberOfIssuesSelected;
        private System.Windows.Forms.ComboBox cmbxIssueType;
        private System.Windows.Forms.ComboBox cmbxIssueCategory;
        private System.Windows.Forms.Button btnLoadVSCodeMetrics;
        private System.Windows.Forms.ComboBox cmbxScmUrl;
        private System.Windows.Forms.Label lblScmUrl;
    }
}

