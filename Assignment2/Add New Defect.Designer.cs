namespace Assignment2
{
    partial class Add_New_Defect
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
            this.btnAddNew = new System.Windows.Forms.Button();
            this.cmbTestcase = new System.Windows.Forms.ComboBox();
            this.lblReporter = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblSubSystem = new System.Windows.Forms.Label();
            this.cmbTaxonomy = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbAssignee = new System.Windows.Forms.ComboBox();
            this.cmbPriorityAdd = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbSeverityAdd = new System.Windows.Forms.ComboBox();
            this.txtDefect = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtBuild = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEnvironment = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bugDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignment2DataSet = new Assignment2.Assignment2DataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignment2DataSet2 = new Assignment2.Assignment2DataSet2();
            this.bugDataTableAdapter = new Assignment2.Assignment2DataSetTableAdapters.BugDataTableAdapter();
            this.assignment2DataSet1 = new Assignment2.Assignment2DataSet1();
            this.bugDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bugDataTableAdapter1 = new Assignment2.Assignment2DataSet1TableAdapters.BugDataTableAdapter();
            this.usersTableAdapter = new Assignment2.Assignment2DataSet2TableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bugDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugDataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(729, 532);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 40);
            this.btnAddNew.TabIndex = 52;
            this.btnAddNew.Text = "Add";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click_1);
            // 
            // cmbTestcase
            // 
            this.cmbTestcase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTestcase.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTestcase.FormattingEnabled = true;
            this.cmbTestcase.Location = new System.Drawing.Point(610, 280);
            this.cmbTestcase.Name = "cmbTestcase";
            this.cmbTestcase.Size = new System.Drawing.Size(284, 29);
            this.cmbTestcase.TabIndex = 51;
            // 
            // lblReporter
            // 
            this.lblReporter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReporter.AutoSize = true;
            this.lblReporter.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporter.Location = new System.Drawing.Point(606, 77);
            this.lblReporter.Name = "lblReporter";
            this.lblReporter.Size = new System.Drawing.Size(113, 21);
            this.lblReporter.TabIndex = 50;
            this.lblReporter.Text = "ReporterName";
            // 
            // lblProjectName
            // 
            this.lblProjectName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.Location = new System.Drawing.Point(326, 41);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(85, 21);
            this.lblProjectName.TabIndex = 49;
            this.lblProjectName.Text = "ProjectInfo";
            // 
            // lblSubSystem
            // 
            this.lblSubSystem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubSystem.AutoSize = true;
            this.lblSubSystem.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubSystem.Location = new System.Drawing.Point(606, 40);
            this.lblSubSystem.Name = "lblSubSystem";
            this.lblSubSystem.Size = new System.Drawing.Size(115, 21);
            this.lblSubSystem.TabIndex = 48;
            this.lblSubSystem.Text = "SubSystemInfo";
            // 
            // cmbTaxonomy
            // 
            this.cmbTaxonomy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTaxonomy.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTaxonomy.FormattingEnabled = true;
            this.cmbTaxonomy.Items.AddRange(new object[] {
            "Design",
            "Functional",
            "Non-Functional",
            "Performance",
            "User Experience"});
            this.cmbTaxonomy.Location = new System.Drawing.Point(610, 167);
            this.cmbTaxonomy.Name = "cmbTaxonomy";
            this.cmbTaxonomy.Size = new System.Drawing.Size(121, 29);
            this.cmbTaxonomy.TabIndex = 47;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(513, 169);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(82, 21);
            this.label27.TabIndex = 45;
            this.label27.Text = "Taxonomy";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(520, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 21);
            this.label13.TabIndex = 46;
            this.label13.Text = "Test Case";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(232, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Project*";
            // 
            // cmbAssignee
            // 
            this.cmbAssignee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAssignee.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAssignee.FormattingEnabled = true;
            this.cmbAssignee.Location = new System.Drawing.Point(326, 169);
            this.cmbAssignee.Name = "cmbAssignee";
            this.cmbAssignee.Size = new System.Drawing.Size(154, 28);
            this.cmbAssignee.TabIndex = 24;
            this.cmbAssignee.Text = "Select Assignee";
            // 
            // cmbPriorityAdd
            // 
            this.cmbPriorityAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPriorityAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriorityAdd.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPriorityAdd.FormattingEnabled = true;
            this.cmbPriorityAdd.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbPriorityAdd.Location = new System.Drawing.Point(326, 207);
            this.cmbPriorityAdd.Name = "cmbPriorityAdd";
            this.cmbPriorityAdd.Size = new System.Drawing.Size(154, 28);
            this.cmbPriorityAdd.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(215, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "Defect ID*";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(326, 241);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(154, 28);
            this.cmbStatus.TabIndex = 39;
            // 
            // cmbSeverityAdd
            // 
            this.cmbSeverityAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSeverityAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeverityAdd.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeverityAdd.FormattingEnabled = true;
            this.cmbSeverityAdd.Items.AddRange(new object[] {
            "Critical",
            "High",
            "Medium",
            "Low"});
            this.cmbSeverityAdd.Location = new System.Drawing.Point(326, 274);
            this.cmbSeverityAdd.Name = "cmbSeverityAdd";
            this.cmbSeverityAdd.Size = new System.Drawing.Size(154, 28);
            this.cmbSeverityAdd.TabIndex = 40;
            // 
            // txtDefect
            // 
            this.txtDefect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDefect.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDefect.Enabled = false;
            this.txtDefect.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefect.Location = new System.Drawing.Point(326, 74);
            this.txtDefect.Name = "txtDefect";
            this.txtDefect.Size = new System.Drawing.Size(154, 27);
            this.txtDefect.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(819, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 44;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(326, 107);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(568, 52);
            this.txtDesc.TabIndex = 27;
            // 
            // txtBuild
            // 
            this.txtBuild.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuild.Enabled = false;
            this.txtBuild.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuild.Location = new System.Drawing.Point(610, 208);
            this.txtBuild.Name = "txtBuild";
            this.txtBuild.Size = new System.Drawing.Size(121, 27);
            this.txtBuild.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(158, 320);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(135, 20);
            this.label17.TabIndex = 35;
            this.label17.Text = "Step to reproduce*";
            // 
            // txtEnvironment
            // 
            this.txtEnvironment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEnvironment.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnvironment.Location = new System.Drawing.Point(610, 247);
            this.txtEnvironment.Name = "txtEnvironment";
            this.txtEnvironment.Size = new System.Drawing.Size(121, 27);
            this.txtEnvironment.TabIndex = 42;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(504, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 20);
            this.label18.TabIndex = 36;
            this.label18.Text = "Sub System*";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(503, 247);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 20);
            this.label19.TabIndex = 37;
            this.label19.Text = "Environment";
            // 
            // txtSteps
            // 
            this.txtSteps.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSteps.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSteps.Location = new System.Drawing.Point(333, 317);
            this.txtSteps.Multiline = true;
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.Size = new System.Drawing.Size(561, 202);
            this.txtSteps.TabIndex = 43;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(516, 212);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 20);
            this.label20.TabIndex = 34;
            this.label20.Text = "Build Info*";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(202, 114);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 20);
            this.label21.TabIndex = 30;
            this.label21.Text = "Description*";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(522, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 20);
            this.label22.TabIndex = 29;
            this.label22.Text = "Reporter*";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(238, 242);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 20);
            this.label23.TabIndex = 32;
            this.label23.Text = "Status*";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(226, 279);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 20);
            this.label24.TabIndex = 28;
            this.label24.Text = "Severity*";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(231, 207);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 20);
            this.label25.TabIndex = 33;
            this.label25.Text = "Priority*";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(219, 169);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(74, 20);
            this.label26.TabIndex = 31;
            this.label26.Text = "Assignee*";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "ADD NEW DEFECT";
            // 
            // bugDataBindingSource
            // 
            this.bugDataBindingSource.DataMember = "BugData";
            this.bugDataBindingSource.DataSource = this.assignment2DataSet;
            // 
            // assignment2DataSet
            // 
            this.assignment2DataSet.DataSetName = "Assignment2DataSet";
            this.assignment2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.assignment2DataSet2;
            // 
            // assignment2DataSet2
            // 
            this.assignment2DataSet2.DataSetName = "Assignment2DataSet2";
            this.assignment2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bugDataTableAdapter
            // 
            this.bugDataTableAdapter.ClearBeforeFill = true;
            // 
            // assignment2DataSet1
            // 
            this.assignment2DataSet1.DataSetName = "Assignment2DataSet1";
            this.assignment2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bugDataBindingSource1
            // 
            this.bugDataBindingSource1.DataMember = "BugData";
            this.bugDataBindingSource1.DataSource = this.assignment2DataSet1;
            // 
            // bugDataTableAdapter1
            // 
            this.bugDataTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // Add_New_Defect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(968, 584);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.cmbTestcase);
            this.Controls.Add(this.lblReporter);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.lblSubSystem);
            this.Controls.Add(this.cmbTaxonomy);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbAssignee);
            this.Controls.Add(this.cmbPriorityAdd);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbSeverityAdd);
            this.Controls.Add(this.txtDefect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtBuild);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtEnvironment);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtSteps);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Name = "Add_New_Defect";
            this.Text = "Add_New_Defect";
            this.Load += new System.EventHandler(this.Add_New_Defect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bugDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugDataBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Assignment2DataSet assignment2DataSet;
        private System.Windows.Forms.BindingSource bugDataBindingSource;
        private Assignment2DataSetTableAdapters.BugDataTableAdapter bugDataTableAdapter;
        private Assignment2DataSet1 assignment2DataSet1;
        private System.Windows.Forms.BindingSource bugDataBindingSource1;
        private Assignment2DataSet1TableAdapters.BugDataTableAdapter bugDataTableAdapter1;
        private Assignment2DataSet2 assignment2DataSet2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Assignment2DataSet2TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.ComboBox cmbTestcase;
        private System.Windows.Forms.Label lblReporter;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblSubSystem;
        private System.Windows.Forms.ComboBox cmbTaxonomy;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.ComboBox cmbAssignee;
        private System.Windows.Forms.ComboBox cmbPriorityAdd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbSeverityAdd;
        private System.Windows.Forms.TextBox txtDefect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtBuild;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEnvironment;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSteps;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label1;
    }
}