namespace Assignment2
{
    partial class Home
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gvHome = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bugDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignment2DataSet5 = new Assignment2.Assignment2DataSet5();
            this.assignment2DataSet4 = new Assignment2.Assignment2DataSet4();
            this.assignment2DataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugDataTableAdapter = new Assignment2.Assignment2DataSet5TableAdapters.BugDataTableAdapter();
            this.chrDefectStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieBugStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.gvHome2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrDefectStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieBugStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHome2)).BeginInit();
            this.SuspendLayout();
            // 
            // gvHome
            // 
            this.gvHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvHome.AutoGenerateColumns = false;
            this.gvHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priorityDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.gvHome.DataSource = this.bugDataBindingSource;
            this.gvHome.Location = new System.Drawing.Point(616, 43);
            this.gvHome.Name = "gvHome";
            this.gvHome.Size = new System.Drawing.Size(445, 139);
            this.gvHome.TabIndex = 0;
            this.gvHome.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvHome_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // bugDataBindingSource
            // 
            this.bugDataBindingSource.DataMember = "BugData";
            this.bugDataBindingSource.DataSource = this.assignment2DataSet5;
            // 
            // assignment2DataSet5
            // 
            this.assignment2DataSet5.DataSetName = "Assignment2DataSet5";
            this.assignment2DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assignment2DataSet4
            // 
            this.assignment2DataSet4.DataSetName = "Assignment2DataSet4";
            this.assignment2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assignment2DataSet4BindingSource
            // 
            this.assignment2DataSet4BindingSource.DataSource = this.assignment2DataSet4;
            this.assignment2DataSet4BindingSource.Position = 0;
            // 
            // bugDataTableAdapter
            // 
            this.bugDataTableAdapter.ClearBeforeFill = true;
            // 
            // chrDefectStatus
            // 
            this.chrDefectStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chrDefectStatus.BackColor = System.Drawing.Color.Transparent;
            this.chrDefectStatus.BorderlineColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.chrDefectStatus.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chrDefectStatus.Legends.Add(legend3);
            this.chrDefectStatus.Location = new System.Drawing.Point(289, 57);
            this.chrDefectStatus.Name = "chrDefectStatus";
            series3.BackSecondaryColor = System.Drawing.Color.Transparent;
            series3.ChartArea = "ChartArea1";
            series3.LabelBackColor = System.Drawing.Color.Transparent;
            series3.Legend = "Legend1";
            series3.Name = "Status";
            this.chrDefectStatus.Series.Add(series3);
            this.chrDefectStatus.Size = new System.Drawing.Size(280, 253);
            this.chrDefectStatus.TabIndex = 1;
            this.chrDefectStatus.Text = "Total of bugs which were submitted by you";
            title2.Name = "Total of bugs which were submitted by you";
            this.chrDefectStatus.Titles.Add(title2);
            this.chrDefectStatus.Visible = false;
            // 
            // pieBugStatus
            // 
            this.pieBugStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pieBugStatus.BackColor = System.Drawing.Color.Transparent;
            this.pieBugStatus.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.pieBugStatus.ChartAreas.Add(chartArea4);
            this.pieBugStatus.DataSource = this.bugDataBindingSource;
            legend4.Name = "Legend1";
            this.pieBugStatus.Legends.Add(legend4);
            this.pieBugStatus.Location = new System.Drawing.Point(12, 43);
            this.pieBugStatus.Name = "pieBugStatus";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Status";
            series4.XValueMember = "Status";
            series4.YValueMembers = "0";
            this.pieBugStatus.Series.Add(series4);
            this.pieBugStatus.Size = new System.Drawing.Size(281, 267);
            this.pieBugStatus.TabIndex = 2;
            this.pieBugStatus.Text = "Number of bugs which are in progress";
            this.pieBugStatus.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hello, look at charts to know your bugs status";
            // 
            // gvHome2
            // 
            this.gvHome2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvHome2.AutoGenerateColumns = false;
            this.gvHome2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHome2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1,
            this.priorityDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1});
            this.gvHome2.DataSource = this.bugDataBindingSource;
            this.gvHome2.Location = new System.Drawing.Point(616, 235);
            this.gvHome2.Name = "gvHome2";
            this.gvHome2.Size = new System.Drawing.Size(445, 181);
            this.gvHome2.TabIndex = 4;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            // 
            // priorityDataGridViewTextBoxColumn1
            // 
            this.priorityDataGridViewTextBoxColumn1.DataPropertyName = "Priority";
            this.priorityDataGridViewTextBoxColumn1.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn1.Name = "priorityDataGridViewTextBoxColumn1";
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bugs are waiting for you:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(575, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "List of bugs that you have reported so far:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "The number of bugs in different status";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1127, 425);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gvHome2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pieBugStatus);
            this.Controls.Add(this.chrDefectStatus);
            this.Controls.Add(this.gvHome);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrDefectStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieBugStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHome2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvHome;
        private System.Windows.Forms.BindingSource assignment2DataSet4BindingSource;
        private Assignment2DataSet4 assignment2DataSet4;
        private Assignment2DataSet5 assignment2DataSet5;
        private System.Windows.Forms.BindingSource bugDataBindingSource;
        private Assignment2DataSet5TableAdapters.BugDataTableAdapter bugDataTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrDefectStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieBugStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvHome2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}