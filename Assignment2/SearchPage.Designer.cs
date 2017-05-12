namespace Assignment2
{
    partial class SearchPage
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
            this.gridViewDefectList = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reporterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assigneeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subsystemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.envDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bugDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.assignment2DataSet4 = new Assignment2.Assignment2DataSet4();
            this.bugDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignment2DataSet3 = new Assignment2.Assignment2DataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDefectID = new System.Windows.Forms.TextBox();
            this.cmbPrjSrcPg = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtEnv = new System.Windows.Forms.TextBox();
            this.txtBuildInfo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbSubSrchPg = new System.Windows.Forms.ComboBox();
            this.cmbAssigneeSrcPg = new System.Windows.Forms.ComboBox();
            this.bugDataTableAdapter = new Assignment2.Assignment2DataSet3TableAdapters.BugDataTableAdapter();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.cmbReporter = new System.Windows.Forms.ComboBox();
            this.bugDataTableAdapter1 = new Assignment2.Assignment2DataSet4TableAdapters.BugDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDefectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewDefectList
            // 
            this.gridViewDefectList.AutoGenerateColumns = false;
            this.gridViewDefectList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewDefectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDefectList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priorityDataGridViewTextBoxColumn,
            this.stepsDataGridViewTextBoxColumn,
            this.projectDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.reporterDataGridViewTextBoxColumn,
            this.buildNoDataGridViewTextBoxColumn,
            this.assigneeDataGridViewTextBoxColumn,
            this.subsystemDataGridViewTextBoxColumn,
            this.envDataGridViewTextBoxColumn});
            this.gridViewDefectList.DataSource = this.bugDataBindingSource1;
            this.gridViewDefectList.Location = new System.Drawing.Point(481, 49);
            this.gridViewDefectList.Name = "gridViewDefectList";
            this.gridViewDefectList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewDefectList.Size = new System.Drawing.Size(627, 433);
            this.gridViewDefectList.TabIndex = 0;
            this.gridViewDefectList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewDefectList_CellContentClick);
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
            // stepsDataGridViewTextBoxColumn
            // 
            this.stepsDataGridViewTextBoxColumn.DataPropertyName = "Steps";
            this.stepsDataGridViewTextBoxColumn.HeaderText = "Steps";
            this.stepsDataGridViewTextBoxColumn.Name = "stepsDataGridViewTextBoxColumn";
            // 
            // projectDataGridViewTextBoxColumn
            // 
            this.projectDataGridViewTextBoxColumn.DataPropertyName = "Project";
            this.projectDataGridViewTextBoxColumn.HeaderText = "Project";
            this.projectDataGridViewTextBoxColumn.Name = "projectDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // reporterDataGridViewTextBoxColumn
            // 
            this.reporterDataGridViewTextBoxColumn.DataPropertyName = "Reporter";
            this.reporterDataGridViewTextBoxColumn.HeaderText = "Reporter";
            this.reporterDataGridViewTextBoxColumn.Name = "reporterDataGridViewTextBoxColumn";
            // 
            // buildNoDataGridViewTextBoxColumn
            // 
            this.buildNoDataGridViewTextBoxColumn.DataPropertyName = "BuildNo";
            this.buildNoDataGridViewTextBoxColumn.HeaderText = "BuildNo";
            this.buildNoDataGridViewTextBoxColumn.Name = "buildNoDataGridViewTextBoxColumn";
            // 
            // assigneeDataGridViewTextBoxColumn
            // 
            this.assigneeDataGridViewTextBoxColumn.DataPropertyName = "Assignee";
            this.assigneeDataGridViewTextBoxColumn.HeaderText = "Assignee";
            this.assigneeDataGridViewTextBoxColumn.Name = "assigneeDataGridViewTextBoxColumn";
            // 
            // subsystemDataGridViewTextBoxColumn
            // 
            this.subsystemDataGridViewTextBoxColumn.DataPropertyName = "Subsystem";
            this.subsystemDataGridViewTextBoxColumn.HeaderText = "Subsystem";
            this.subsystemDataGridViewTextBoxColumn.Name = "subsystemDataGridViewTextBoxColumn";
            // 
            // envDataGridViewTextBoxColumn
            // 
            this.envDataGridViewTextBoxColumn.DataPropertyName = "Env";
            this.envDataGridViewTextBoxColumn.HeaderText = "Env";
            this.envDataGridViewTextBoxColumn.Name = "envDataGridViewTextBoxColumn";
            // 
            // bugDataBindingSource1
            // 
            this.bugDataBindingSource1.DataMember = "BugData";
            this.bugDataBindingSource1.DataSource = this.assignment2DataSet4;
            // 
            // assignment2DataSet4
            // 
            this.assignment2DataSet4.DataSetName = "Assignment2DataSet4";
            this.assignment2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bugDataBindingSource
            // 
            this.bugDataBindingSource.DataMember = "BugData";
            this.bugDataBindingSource.DataSource = this.assignment2DataSet3;
            // 
            // assignment2DataSet3
            // 
            this.assignment2DataSet3.DataSetName = "Assignment2DataSet3";
            this.assignment2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Defect ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Assignee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Environment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Build Info";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Sub System";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Priority";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 396);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Reporter";
            // 
            // txtDefectID
            // 
            this.txtDefectID.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefectID.Location = new System.Drawing.Point(159, 92);
            this.txtDefectID.MaximumSize = new System.Drawing.Size(180, 180);
            this.txtDefectID.Name = "txtDefectID";
            this.txtDefectID.Size = new System.Drawing.Size(146, 29);
            this.txtDefectID.TabIndex = 2;
            // 
            // cmbPrjSrcPg
            // 
            this.cmbPrjSrcPg.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrjSrcPg.FormattingEnabled = true;
            this.cmbPrjSrcPg.Location = new System.Drawing.Point(159, 61);
            this.cmbPrjSrcPg.MaximumSize = new System.Drawing.Size(180, 0);
            this.cmbPrjSrcPg.Name = "cmbPrjSrcPg";
            this.cmbPrjSrcPg.Size = new System.Drawing.Size(171, 29);
            this.cmbPrjSrcPg.TabIndex = 1;

            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(159, 123);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(275, 77);
            this.txtDescription.TabIndex = 3;
            // 
            // txtEnv
            // 
            this.txtEnv.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnv.Location = new System.Drawing.Point(159, 236);
            this.txtEnv.MaximumSize = new System.Drawing.Size(180, 180);
            this.txtEnv.Name = "txtEnv";
            this.txtEnv.Size = new System.Drawing.Size(146, 29);
            this.txtEnv.TabIndex = 5;

            // 
            // txtBuildInfo
            // 
            this.txtBuildInfo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuildInfo.Location = new System.Drawing.Point(159, 301);
            this.txtBuildInfo.MaximumSize = new System.Drawing.Size(180, 180);
            this.txtBuildInfo.Name = "txtBuildInfo";
            this.txtBuildInfo.Size = new System.Drawing.Size(146, 29);
            this.txtBuildInfo.TabIndex = 7;

            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(359, 445);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 37);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Se&arch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(255, 445);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 37);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "or Step";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(690, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 25);
            this.label13.TabIndex = 14;
            this.label13.Text = "LIST OF DEFECTS";
            // 
            // cmbSubSrchPg
            // 
            this.cmbSubSrchPg.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubSrchPg.FormattingEnabled = true;
            this.cmbSubSrchPg.Location = new System.Drawing.Point(159, 333);
            this.cmbSubSrchPg.Name = "cmbSubSrchPg";
            this.cmbSubSrchPg.Size = new System.Drawing.Size(202, 29);
            this.cmbSubSrchPg.TabIndex = 15;

            // 
            // cmbAssigneeSrcPg
            // 
            this.cmbAssigneeSrcPg.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAssigneeSrcPg.FormattingEnabled = true;
            this.cmbAssigneeSrcPg.Location = new System.Drawing.Point(159, 204);
            this.cmbAssigneeSrcPg.MaximumSize = new System.Drawing.Size(180, 0);
            this.cmbAssigneeSrcPg.Name = "cmbAssigneeSrcPg";
            this.cmbAssigneeSrcPg.Size = new System.Drawing.Size(179, 29);
            this.cmbAssigneeSrcPg.TabIndex = 1;

            // 
            // bugDataTableAdapter
            // 
            this.bugDataTableAdapter.ClearBeforeFill = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Open",
            "In Progress",
            "Fix",
            "Close"});
            this.cmbStatus.Location = new System.Drawing.Point(159, 268);
            this.cmbStatus.MaximumSize = new System.Drawing.Size(180, 0);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(162, 29);
            this.cmbStatus.TabIndex = 1;

            // 
            // cmbPriority
            // 
            this.cmbPriority.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbPriority.Location = new System.Drawing.Point(159, 365);
            this.cmbPriority.MaximumSize = new System.Drawing.Size(180, 0);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(179, 29);
            this.cmbPriority.TabIndex = 1;

            // 
            // cmbReporter
            // 
            this.cmbReporter.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReporter.FormattingEnabled = true;
            this.cmbReporter.Location = new System.Drawing.Point(159, 400);
            this.cmbReporter.MaximumSize = new System.Drawing.Size(180, 0);
            this.cmbReporter.Name = "cmbReporter";
            this.cmbReporter.Size = new System.Drawing.Size(179, 29);
            this.cmbReporter.TabIndex = 1;

            // 
            // bugDataTableAdapter1
            // 
            this.bugDataTableAdapter1.ClearBeforeFill = true;
            // 
            // SearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1128, 502);
            this.Controls.Add(this.cmbSubSrchPg);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbReporter);
            this.Controls.Add(this.cmbAssigneeSrcPg);
            this.Controls.Add(this.cmbPrjSrcPg);
            this.Controls.Add(this.txtBuildInfo);
            this.Controls.Add(this.txtEnv);
            this.Controls.Add(this.txtDefectID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridViewDefectList);
            this.Name = "SearchPage";
            this.Text = "SearchPage";
            this.Load += new System.EventHandler(this.SearchPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDefectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDefectID;
        private System.Windows.Forms.ComboBox cmbPrjSrcPg;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtEnv;
        private System.Windows.Forms.TextBox txtBuildInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbSubSrchPg;
        private Assignment2DataSet3 assignment2DataSet3;
        private System.Windows.Forms.BindingSource bugDataBindingSource;
        private Assignment2DataSet3TableAdapters.BugDataTableAdapter bugDataTableAdapter;
        private System.Windows.Forms.ComboBox cmbAssigneeSrcPg;
        public System.Windows.Forms.DataGridView gridViewDefectList;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.ComboBox cmbReporter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reporterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assigneeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subsystemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn envDataGridViewTextBoxColumn;
        private Assignment2DataSet4 assignment2DataSet4;
        private System.Windows.Forms.BindingSource bugDataBindingSource1;
        private Assignment2DataSet4TableAdapters.BugDataTableAdapter bugDataTableAdapter1;
    }
}