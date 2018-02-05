namespace DataExtractionTool.UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.metadataFile = new System.Windows.Forms.TextBox();
            this.metadataFileSelector = new System.Windows.Forms.OpenFileDialog();
            this.loadData = new System.Windows.Forms.Button();
            this.selectMetadata = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.query = new System.Windows.Forms.TextBox();
            this.executeQueries = new System.Windows.Forms.Button();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.queriesDataGridView = new System.Windows.Forms.DataGridView();
            this.queryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queriesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metadata File";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // metadataFile
            // 
            this.metadataFile.Location = new System.Drawing.Point(99, 23);
            this.metadataFile.Margin = new System.Windows.Forms.Padding(2);
            this.metadataFile.Name = "metadataFile";
            this.metadataFile.Size = new System.Drawing.Size(164, 20);
            this.metadataFile.TabIndex = 1;
            // 
            // loadData
            // 
            this.loadData.Location = new System.Drawing.Point(27, 63);
            this.loadData.Margin = new System.Windows.Forms.Padding(2);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(132, 33);
            this.loadData.TabIndex = 2;
            this.loadData.Text = "Load Data";
            this.loadData.UseVisualStyleBackColor = true;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // selectMetadata
            // 
            this.selectMetadata.Location = new System.Drawing.Point(264, 25);
            this.selectMetadata.Margin = new System.Windows.Forms.Padding(2);
            this.selectMetadata.Name = "selectMetadata";
            this.selectMetadata.Size = new System.Drawing.Size(34, 19);
            this.selectMetadata.TabIndex = 3;
            this.selectMetadata.Text = "...";
            this.selectMetadata.UseVisualStyleBackColor = true;
            this.selectMetadata.Click += new System.EventHandler(this.selectMetadata_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Query";
            // 
            // query
            // 
            this.query.Enabled = false;
            this.query.Location = new System.Drawing.Point(99, 139);
            this.query.Margin = new System.Windows.Forms.Padding(2);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(292, 20);
            this.query.TabIndex = 5;
            // 
            // executeQueries
            // 
            this.executeQueries.Enabled = false;
            this.executeQueries.Location = new System.Drawing.Point(395, 132);
            this.executeQueries.Margin = new System.Windows.Forms.Padding(2);
            this.executeQueries.Name = "executeQueries";
            this.executeQueries.Size = new System.Drawing.Size(148, 33);
            this.executeQueries.TabIndex = 6;
            this.executeQueries.Text = "Run Query";
            this.executeQueries.UseVisualStyleBackColor = true;
            this.executeQueries.Click += new System.EventHandler(this.executeQuery_Click);
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Location = new System.Drawing.Point(12, 304);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.Size = new System.Drawing.Size(657, 281);
            this.resultDataGridView.TabIndex = 7;
            // 
            // queriesDataGridView
            // 
            this.queriesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.queryColumn,
            this.columnNameColumn});
            this.queriesDataGridView.Location = new System.Drawing.Point(12, 164);
            this.queriesDataGridView.Name = "queriesDataGridView";
            this.queriesDataGridView.Size = new System.Drawing.Size(657, 117);
            this.queriesDataGridView.TabIndex = 8;
            // 
            // queryColumn
            // 
            this.queryColumn.HeaderText = "Query";
            this.queryColumn.Name = "queryColumn";
            // 
            // columnNameColumn
            // 
            this.columnNameColumn.HeaderText = "Column Name";
            this.columnNameColumn.Name = "columnNameColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 597);
            this.Controls.Add(this.queriesDataGridView);
            this.Controls.Add(this.resultDataGridView);
            this.Controls.Add(this.executeQueries);
            this.Controls.Add(this.query);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectMetadata);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.metadataFile);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queriesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox metadataFile;
        private System.Windows.Forms.OpenFileDialog metadataFileSelector;
        private System.Windows.Forms.Button loadData;
        private System.Windows.Forms.Button selectMetadata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox query;
        private System.Windows.Forms.Button executeQueries;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.DataGridView queriesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn queryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNameColumn;
    }
}

