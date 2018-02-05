using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataExtractionTool.Core;
using DataExtractionTool.Core.Pipelines.ProcessQueries;

namespace DataExtractionTool.UI
{
    public partial class Form1 : Form
    {
        private IEnumerable<WebPage> webPages;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void selectMetadata_Click(object sender, EventArgs e)
        {
            var result = metadataFileSelector.ShowDialog();
            if (result == DialogResult.OK)
            {
                metadataFile.Text = metadataFileSelector.FileName;
            }
        }

        private void loadData_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(metadataFile.Text))
            {
                var args = new QueryArgs {MetaDataFile = metadataFile.Text};

                var pipeline = new ProcessQueriesPipeline();
                pipeline.Run(args);
                if (args.Errors.Any())
                {
                    MessageBox.Show(string.Join(Environment.NewLine, args.Errors.ToArray()), "Error",
                        MessageBoxButtons.OK);
                    return;
                }
                webPages = args.WebPages;

                query.Enabled = true;
                executeQueries.Enabled = true;
            }
        }

        private void executeQuery_Click(object sender, EventArgs e)
        {
            var queries = queriesDataGridView.Rows.Cast<DataGridViewRow>().Select(r => new
            {
                Query = r.Cells["queryColumn"].Value as string,
                ColumnName = r.Cells["columnNameColumn"].Value as string
            }).Where(q => !string.IsNullOrWhiteSpace(q.ColumnName) && !string.IsNullOrWhiteSpace(q.Query)).ToList();

            var results = webPages.Select(d => new
            {
                d.Url,
                Columns = queries.Select(q => new
                {
                    q.ColumnName,
                    Value = d.HtmlDocument.QuerySelector(q.Query)?.TextContent?.Trim()
                }).ToDictionary(c => c.ColumnName, c => c.Value)
            });
            var dt = new DataTable();
            foreach (var q in queries)
            {
                dt.Columns.Add(new DataColumn(q.ColumnName, typeof(string)));
            }

            dt.Columns.Add(new DataColumn("URL", typeof(string)));
            foreach (var resultItem in results)
            {
                var row = dt.NewRow();
                foreach (var q in queries)
                {
                    row[q.ColumnName] = resultItem.Columns[q.ColumnName];
                }

                row["URL"] = resultItem.Url;
                dt.Rows.Add(row);
            }

            resultDataGridView.DataSource = dt;
        }
    }
}
