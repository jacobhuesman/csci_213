namespace Project2
{
    partial class SearchByBattingAverageTable
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
            this.components = new System.ComponentModel.Container();
            this.baseballDataSet = new Project2.BaseballDataSet();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new Project2.BaseballDataSetTableAdapters.PlayersTableAdapter();
            this.tableAdapterManager = new Project2.BaseballDataSetTableAdapters.TableAdapterManager();
            this.playersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.maximumLabel = new System.Windows.Forms.Label();
            this.minimumLabel = new System.Windows.Forms.Label();
            this.maxNumeric = new System.Windows.Forms.NumericUpDown();
            this.minNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.baseballDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // baseballDataSet
            // 
            this.baseballDataSet.DataSetName = "BaseballDataSet";
            this.baseballDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.baseballDataSet;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PlayersTableAdapter = this.playersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project2.BaseballDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // playersDataGridView
            // 
            this.playersDataGridView.AllowUserToAddRows = false;
            this.playersDataGridView.AllowUserToDeleteRows = false;
            this.playersDataGridView.AutoGenerateColumns = false;
            this.playersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.playersDataGridView.DataSource = this.playersBindingSource;
            this.playersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.playersDataGridView.Name = "playersDataGridView";
            this.playersDataGridView.ReadOnly = true;
            this.playersDataGridView.Size = new System.Drawing.Size(444, 380);
            this.playersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PlayerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PlayerID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BattingAverage";
            this.dataGridViewTextBoxColumn4.HeaderText = "BattingAverage";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resetButton);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.maximumLabel);
            this.groupBox1.Controls.Add(this.minimumLabel);
            this.groupBox1.Controls.Add(this.maxNumeric);
            this.groupBox1.Controls.Add(this.minNumeric);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by batting average";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(363, 16);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(282, 16);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // maximumLabel
            // 
            this.maximumLabel.AutoSize = true;
            this.maximumLabel.Location = new System.Drawing.Point(142, 21);
            this.maximumLabel.Name = "maximumLabel";
            this.maximumLabel.Size = new System.Drawing.Size(27, 13);
            this.maximumLabel.TabIndex = 3;
            this.maximumLabel.Text = "Max";
            // 
            // minimumLabel
            // 
            this.minimumLabel.AutoSize = true;
            this.minimumLabel.Location = new System.Drawing.Point(6, 21);
            this.minimumLabel.Name = "minimumLabel";
            this.minimumLabel.Size = new System.Drawing.Size(24, 13);
            this.minimumLabel.TabIndex = 2;
            this.minimumLabel.Text = "Min";
            // 
            // maxNumeric
            // 
            this.maxNumeric.DecimalPlaces = 2;
            this.maxNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.maxNumeric.Location = new System.Drawing.Point(175, 19);
            this.maxNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxNumeric.Name = "maxNumeric";
            this.maxNumeric.Size = new System.Drawing.Size(100, 20);
            this.maxNumeric.TabIndex = 1;
            // 
            // minNumeric
            // 
            this.minNumeric.DecimalPlaces = 2;
            this.minNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.minNumeric.Location = new System.Drawing.Point(36, 19);
            this.minNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minNumeric.Name = "minNumeric";
            this.minNumeric.Size = new System.Drawing.Size(100, 20);
            this.minNumeric.TabIndex = 0;
            // 
            // SearchByBattingAverageTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 380);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.playersDataGridView);
            this.Name = "SearchByBattingAverageTable";
            this.Text = "Search By Batting Average Table";
            this.Load += new System.EventHandler(this.SearchByBattingAverageTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseballDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseballDataSet baseballDataSet;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private BaseballDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private BaseballDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView playersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label maximumLabel;
        private System.Windows.Forms.Label minimumLabel;
        private System.Windows.Forms.NumericUpDown maxNumeric;
        private System.Windows.Forms.NumericUpDown minNumeric;
    }
}

