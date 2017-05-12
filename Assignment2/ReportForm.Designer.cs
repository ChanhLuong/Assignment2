namespace Assignment2
{
    partial class ReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.btnBugRating = new System.Windows.Forms.Button();
            this.btnBugProject = new System.Windows.Forms.Button();
            this.btnBugInd = new System.Windows.Forms.Button();
            this.btnBugStatus = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GetBugNumberStatusPeriod_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetBugNumberAssignee_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetBugRating_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetBugByProject_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GetBugNumberStatusPeriod_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetBugNumberAssignee_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetBugRating_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetBugByProject_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // cmbFrom
            // 
            this.cmbFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbFrom.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(162, 84);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(205, 29);
            this.cmbFrom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // cmbTo
            // 
            this.cmbTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(416, 84);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(214, 29);
            this.cmbTo.TabIndex = 3;
            // 
            // btnBugRating
            // 
            this.btnBugRating.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBugRating.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBugRating.Location = new System.Drawing.Point(22, 155);
            this.btnBugRating.Name = "btnBugRating";
            this.btnBugRating.Size = new System.Drawing.Size(146, 30);
            this.btnBugRating.TabIndex = 7;
            this.btnBugRating.Text = "Bug Rating Report";
            this.btnBugRating.UseVisualStyleBackColor = true;
            this.btnBugRating.Click += new System.EventHandler(this.btnBugRating_Click);
            // 
            // btnBugProject
            // 
            this.btnBugProject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBugProject.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBugProject.Location = new System.Drawing.Point(191, 155);
            this.btnBugProject.Name = "btnBugProject";
            this.btnBugProject.Size = new System.Drawing.Size(180, 30);
            this.btnBugProject.TabIndex = 7;
            this.btnBugProject.Text = "Bug Per Project Report";
            this.btnBugProject.UseVisualStyleBackColor = true;
            this.btnBugProject.Click += new System.EventHandler(this.btnBugProject_Click_1);
            // 
            // btnBugInd
            // 
            this.btnBugInd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBugInd.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBugInd.Location = new System.Drawing.Point(407, 155);
            this.btnBugInd.Name = "btnBugInd";
            this.btnBugInd.Size = new System.Drawing.Size(264, 30);
            this.btnBugInd.TabIndex = 7;
            this.btnBugInd.Text = "Assigned Bug Per Member Report";
            this.btnBugInd.UseVisualStyleBackColor = true;
            this.btnBugInd.Click += new System.EventHandler(this.btnBugInd_Click);
            // 
            // btnBugStatus
            // 
            this.btnBugStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBugStatus.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBugStatus.Location = new System.Drawing.Point(700, 155);
            this.btnBugStatus.Name = "btnBugStatus";
            this.btnBugStatus.Size = new System.Drawing.Size(190, 30);
            this.btnBugStatus.TabIndex = 7;
            this.btnBugStatus.Text = "Report per Bug Status";
            this.btnBugStatus.UseVisualStyleBackColor = true;
            this.btnBugStatus.Click += new System.EventHandler(this.btnBugStatus_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(276, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(475, 39);
            this.label8.TabIndex = 8;
            this.label8.Text = "BUG TRACKING REPORTS";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GetBugByProject_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Assignment2.BugByProject.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(55, 217);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(934, 383);
            this.reportViewer1.TabIndex = 11;
            this.reportViewer1.Visible = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "New",
            "Assigned",
            "Fixed",
            "Rejected",
            "Reopened",
            "Verified",
            "Closed"});
            this.cmbStatus.Location = new System.Drawing.Point(734, 87);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(135, 29);
            this.cmbStatus.TabIndex = 12;
            this.cmbStatus.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(675, 87);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 21);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status";
            this.lblStatus.Visible = false;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.GetBugRating_ResultBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Assignment2.BugRating.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(55, 246);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(934, 354);
            this.reportViewer2.TabIndex = 14;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.GetBugNumberAssignee_ResultBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Assignment2.BugPerAssignee.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(55, 274);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(934, 326);
            this.reportViewer3.TabIndex = 15;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.GetBugNumberStatusPeriod_ResultBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Assignment2.BugPerStatus.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(55, 297);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(934, 303);
            this.reportViewer4.TabIndex = 16;
            // 
            // GetBugNumberStatusPeriod_ResultBindingSource
            // 
            this.GetBugNumberStatusPeriod_ResultBindingSource.DataSource = typeof(Assignment2.GetBugNumberStatusPeriod_Result);
            // 
            // GetBugNumberAssignee_ResultBindingSource
            // 
            this.GetBugNumberAssignee_ResultBindingSource.DataSource = typeof(Assignment2.GetBugNumberAssignee_Result);
            // 
            // GetBugRating_ResultBindingSource
            // 
            this.GetBugRating_ResultBindingSource.DataSource = typeof(Assignment2.GetBugRating_Result);
            // 
            // GetBugByProject_ResultBindingSource
            // 
            this.GetBugByProject_ResultBindingSource.DataSource = typeof(Assignment2.GetBugByProject_Result);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1106, 612);
            this.Controls.Add(this.reportViewer4);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBugStatus);
            this.Controls.Add(this.btnBugInd);
            this.Controls.Add(this.btnBugProject);
            this.Controls.Add(this.btnBugRating);
            this.Controls.Add(this.cmbTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFrom);
            this.Controls.Add(this.label1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetBugNumberStatusPeriod_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetBugNumberAssignee_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetBugRating_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetBugByProject_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.Button btnBugRating;
        private System.Windows.Forms.Button btnBugProject;
        private System.Windows.Forms.Button btnBugInd;
        private System.Windows.Forms.Button btnBugStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource GetBugByProject_ResultBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource GetBugRating_ResultBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource GetBugNumberAssignee_ResultBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource GetBugNumberStatusPeriod_ResultBindingSource;
    }
}