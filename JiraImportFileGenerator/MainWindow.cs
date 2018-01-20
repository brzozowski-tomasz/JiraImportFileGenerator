using System;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JiraImportFileGenerator;

namespace CodeCleanUpResharperToJiraConverter
{
    public partial class Form1 : Form
    {
        #region Consts

        private const string FileDialogXmlFilter = "Xml files | *.xml";
        private const string IssueTable = "Issue";
        private const string IssueTypeTable = "IssueType";
        private const string CategoryColumn = "Category";
        private const string JiraCsvExtension = ".Jira.csv";
        private const string IdColumn = "Id";
 
        #endregion
        #region Private fields

        private string _filePath;
        private DataSet _dataSet;
        private InputType _inputType = InputType.Undefined;

        #endregion
        #region Consts

        public Form1()
        {
            InitializeComponent();
        }

        #endregion
        #region Event handlers

        private void btnLoadResharperIssues_Click(object sender, EventArgs e)
        {
            _inputType = InputType.Resharper;

            var dialog = new OpenFileDialog
            {
                Filter = FileDialogXmlFilter,
                Multiselect = false
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _filePath = dialog.FileName;

                _dataSet = new DataSet();
                _dataSet.ReadXml(_filePath);

                PopulateIssuesGrid();
                PopulateCategoryCombo();
                cmbxIssueCategory.Visible = true;
                cmbxIssueType.Visible = true;
                btnFilter.Visible = true;

                UpdateLabels();
            }
        }

        private void btnLoadVSCodeMeterics_Click(object sender, EventArgs e)
        {
            _inputType = InputType.VisualStudioCodeMetrics;

            var dialog = new OpenFileDialog
            {
                Filter = "Csv files | *.csv",
                Multiselect = false
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _filePath = dialog.FileName;

                _dataSet = new DataSet();
                var dataTable = GetDataTableFromCsv(_filePath, false);
                _dataSet.Tables.Add(dataTable);

                PopulateIssuesGrid();
                cmbxIssueCategory.Visible = false;
                cmbxIssueType.Visible = false;
                btnFilter.Visible = false;

                UpdateLabels();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbxIssueType.Text))
            {
                var table = issuesGridView.DataSource as DataTable;
                if (table != null)
                {
                    table.DefaultView.RowFilter = string.Empty;
                }
            }
            else
            {
                var whereClause = $"TypeId='{cmbxIssueType.Text}'";
                var table = issuesGridView.DataSource as DataTable;
                if (table != null)
                {
                    table.DefaultView.RowFilter = whereClause;
                }
            }

            UpdateLabels();
        }

        private void btnGenerateJira_Click(object sender, EventArgs e)
        {
            if (cmbxScmUrl.SelectedItem == null || string.IsNullOrWhiteSpace(cmbxScmUrl.SelectedItem.ToString()))
            {
                MessageBox.Show("Select Scm Url before generating Jira csv", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var outputStringBuilder = new StringBuilder();
            outputStringBuilder.Append(GetHeaderRow());

            foreach (DataGridViewRow issueRow in issuesGridView.SelectedRows)
            {
                outputStringBuilder.Append(GetIssueStringRowRepresentation(issueRow));
            }

            var outputFilePath = _filePath + JiraCsvExtension;
            File.WriteAllText(outputFilePath, outputStringBuilder.ToString());

            MessageBox.Show($"Jira import file created successfully: {outputFilePath}", "File created", MessageBoxButtons.OK);
        }

        private void cmbxIssueCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbxIssueCategory.Text))
            {
                var table = issuesGridView.DataSource as DataTable;
                if (table != null)
                {
                    table.DefaultView.RowFilter = string.Empty;
                }
            }
            else
            {
                var whereClause = $"Category='{cmbxIssueCategory.Text}'";

                cmbxIssueType.DataSource = _dataSet.Tables[IssueTypeTable].Select(whereClause).Select(item => item[IdColumn]).Distinct().ToList();
            }
        }

        #endregion
        #region Private methods

        private string GetIssueStringRowRepresentation(DataGridViewRow issueRow)
        {
            var issueStringBuilder = new StringBuilder();

            issueStringBuilder.Append("Code Cleanup, Redknee, Multiproduct, " + cmbxScmUrl.SelectedItem + ", master, ");

            if (_inputType == InputType.Resharper)
            {
                var jiraIssueType = MapResharperTypeIdToJiraIssueType(issueRow.Cells["TypeId"].Value.ToString());
                issueStringBuilder.Append(jiraIssueType + ',');
                issueStringBuilder.Append(issueRow.Cells["Message"].Value + " in " + issueRow.Cells["File"].Value + ',');
                issueStringBuilder.Append(issueRow.Cells["Message"].Value + " in " + issueRow.Cells["File"].Value + " Line: " +
                                          issueRow.Cells["Line"].Value + ',');
                issueStringBuilder.Append("\r\n");
            }

            else if (_inputType == InputType.VisualStudioCodeMetrics)
            {
                issueStringBuilder.Append("Long Methods" + ',');
                issueStringBuilder.Append("Long Methods in " + issueRow.Cells["Namespace"].Value + '.' + issueRow.Cells["Type"].Value + ".cs" + ',');
                issueStringBuilder.Append("Long Methods in " + issueRow.Cells["Namespace"].Value + '.' + issueRow.Cells["Type"].Value + '.' + issueRow.Cells["Member"].Value.ToString().Replace(',',' ') + 
                    " Visual studio line count: " + issueRow.Cells["LOC"].Value);
                issueStringBuilder.Append("\r\n");
            }

            return issueStringBuilder.ToString();
        }

        private string GetHeaderRow()
        {
            return "Project, CDC-Company, CDC-Software Product Name, CDC-scm_url, CSC-scm_branch, Type, Title, Description\r\n";
        }

        private void UpdateLabels()
        {
            lblNumberOfIssues.Text = $"Number of Issues: {issuesGridView.Rows.Count}";
            lblNumberOfIssuesSelected.Text = $"Number of Issues selected: {issuesGridView.SelectedRows.Count}";
        }

        private string MapResharperTypeIdToJiraIssueType(string resharperIssueType)
        {
            switch (resharperIssueType)
            {
                case "PossibleNullReferenceException":
                    return "Symbolic Execution - NPE";
                default:
                    return "Not known Jira Type";
            }
        }

        private void PopulateCategoryCombo()
        {
            if (_inputType == InputType.Resharper)
            {
                cmbxIssueCategory.DataSource = _dataSet.Tables[IssueTypeTable].Select().Select(item => item[CategoryColumn]).Distinct().ToList();
                return;
            }

            if (_inputType == InputType.VisualStudioCodeMetrics)
            {
                cmbxIssueCategory.DataSource = _dataSet.Tables[IssueTypeTable].Select().Select(item => item[CategoryColumn]).Distinct().ToList();
            }
        }

        private void PopulateIssuesGrid()
        {
            if (_inputType == InputType.VisualStudioCodeMetrics)
            {
                issuesGridView.DataSource = _dataSet.Tables[0];
                return;
            }

            if (_inputType == InputType.Resharper)
            {
                issuesGridView.DataSource = _dataSet.Tables[IssueTable];
            }
        }

        private void issuesGridView_SelectionChanged(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        #endregion Private methods

        

        static DataTable GetDataTableFromCsv(string path, bool isFirstRowHeader)
        {
            var header = isFirstRowHeader ? "Yes" : "No";
            var pathOnly = Path.GetDirectoryName(path);
            var fileName = Path.GetFileName(path);
            var sql = @"SELECT * FROM [" + fileName + "]";

            using (var connection = new OleDbConnection(
                @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathOnly +
                ";Extended Properties=\"Text;HDR=" + header + "\""))
            using (var command = new OleDbCommand(sql, connection))
            using (var adapter = new OleDbDataAdapter(command))
            {
                var dataTable = new DataTable {Locale = CultureInfo.CurrentCulture};
                adapter.Fill(dataTable);

                dataTable.Columns[0].ColumnName = "Scope";
                dataTable.Columns[1].ColumnName = "Project";
                dataTable.Columns[2].ColumnName = "Namespace";
                dataTable.Columns[3].ColumnName = "Type";
                dataTable.Columns[4].ColumnName = "Member";
                dataTable.Columns[5].ColumnName = "Maintain index";
                dataTable.Columns[6].ColumnName = "Complexity";
                dataTable.Columns[7].ColumnName = "Inheritance Depth";
                dataTable.Columns[8].ColumnName = "Class coupling";
                dataTable.Columns[9].ColumnName = "LOC";

                return dataTable;
            }
        }

        private void cmbxScmUrl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
