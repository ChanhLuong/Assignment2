namespace Assignment2.Application
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.bugDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignment2DataSet = new Assignment2.Assignment2DataSet();
            this.ID = new System.Windows.Forms.Label();
            this.txtDefectID = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtBuildInfo = new System.Windows.Forms.TextBox();
            this.txtEnv = new System.Windows.Forms.TextBox();
            this.txtReproduce = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbSeverity = new System.Windows.Forms.ComboBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignment2DataSet2 = new Assignment2.Assignment2DataSet2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCommentEmpty = new System.Windows.Forms.Label();
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
            this.label16 = new System.Windows.Forms.Label();
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
            this.txtTestCase = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSubAddPg = new System.Windows.Forms.ComboBox();
            this.cmbAssigneeAddPg = new System.Windows.Forms.ComboBox();
            this.cmbSttus = new System.Windows.Forms.ComboBox();
            this.txtReporter = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bugDataTableAdapter = new Assignment2.Assignment2DataSetTableAdapters.BugDataTableAdapter();
            this.assignment2DataSet1 = new Assignment2.Assignment2DataSet1();
            this.bugDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bugDataTableAdapter1 = new Assignment2.Assignment2DataSet1TableAdapters.BugDataTableAdapter();
            this.usersTableAdapter = new Assignment2.Assignment2DataSet2TableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bugDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugDataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, -231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project*";
            // 
            // cmbProject
            // 
            this.cmbProject.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(158, -236);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(185, 28);
            this.cmbProject.TabIndex = 1;
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
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Enabled = false;
            this.ID.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(19, -193);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(72, 20);
            this.ID.TabIndex = 2;
            this.ID.Text = "Defect ID";
            // 
            // txtDefectID
            // 
            this.txtDefectID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDefectID.Enabled = false;
            this.txtDefectID.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefectID.Location = new System.Drawing.Point(158, -198);
            this.txtDefectID.Name = "txtDefectID";
            this.txtDefectID.Size = new System.Drawing.Size(154, 27);
            this.txtDefectID.TabIndex = 2;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(19, -196);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(91, 20);
            this.Description.TabIndex = 4;
            this.Description.Text = "Description*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Severity*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, -102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Assignee*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, -70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Priority*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, -35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Status*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Build Info*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Environment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Sub System*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Step to reproduce*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(158, -206);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(431, 52);
            this.txtDescription.TabIndex = 3;
            // 
            // txtBuildInfo
            // 
            this.txtBuildInfo.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuildInfo.Location = new System.Drawing.Point(158, 38);
            this.txtBuildInfo.Name = "txtBuildInfo";
            this.txtBuildInfo.Size = new System.Drawing.Size(154, 27);
            this.txtBuildInfo.TabIndex = 8;
            // 
            // txtEnv
            // 
            this.txtEnv.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnv.Location = new System.Drawing.Point(158, 77);
            this.txtEnv.Name = "txtEnv";
            this.txtEnv.Size = new System.Drawing.Size(154, 27);
            this.txtEnv.TabIndex = 9;
            // 
            // txtReproduce
            // 
            this.txtReproduce.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReproduce.Location = new System.Drawing.Point(158, 145);
            this.txtReproduce.Multiline = true;
            this.txtReproduce.Name = "txtReproduce";
            this.txtReproduce.Size = new System.Drawing.Size(414, 202);
            this.txtReproduce.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(0, -277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(438, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 40);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbSeverity
            // 
            this.cmbSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeverity.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeverity.FormattingEnabled = true;
            this.cmbSeverity.Items.AddRange(new object[] {
            "Critical",
            "High",
            "Medium",
            "Low"});
            this.cmbSeverity.Location = new System.Drawing.Point(158, 35);
            this.cmbSeverity.Name = "cmbSeverity";
            this.cmbSeverity.Size = new System.Drawing.Size(154, 28);
            this.cmbSeverity.TabIndex = 7;
            // 
            // cmbPriority
            // 
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbPriority.Location = new System.Drawing.Point(158, -32);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(154, 28);
            this.cmbPriority.TabIndex = 6;
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
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(20, 20);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtTestCase);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cmbSubAddPg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbAssigneeAddPg);
            this.panel1.Controls.Add(this.cmbProject);
            this.panel1.Controls.Add(this.cmbPriority);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.cmbSttus);
            this.panel1.Controls.Add(this.cmbSeverity);
            this.panel1.Controls.Add(this.txtDefectID);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtReporter);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtBuildInfo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtEnv);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtReproduce);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Description);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 653);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.panel2.AutoScrollMinSize = new System.Drawing.Size(20, 20);
            this.panel2.Controls.Add(this.lblCommentEmpty);
            this.panel2.Controls.Add(this.btnAddNew);
            this.panel2.Controls.Add(this.cmbTestcase);
            this.panel2.Controls.Add(this.lblReporter);
            this.panel2.Controls.Add(this.lblProjectName);
            this.panel2.Controls.Add(this.lblSubSystem);
            this.panel2.Controls.Add(this.cmbTaxonomy);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.cmbAssignee);
            this.panel2.Controls.Add(this.cmbPriorityAdd);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.cmbStatus);
            this.panel2.Controls.Add(this.cmbSeverityAdd);
            this.panel2.Controls.Add(this.txtDefect);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtDesc);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtBuild);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txtEnvironment);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txtSteps);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 653);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblCommentEmpty
            // 
            this.lblCommentEmpty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCommentEmpty.AutoSize = true;
            this.lblCommentEmpty.Location = new System.Drawing.Point(385, 558);
            this.lblCommentEmpty.Name = "lblCommentEmpty";
            this.lblCommentEmpty.Size = new System.Drawing.Size(0, 13);
            this.lblCommentEmpty.TabIndex = 23;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(414, 587);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 40);
            this.btnAddNew.TabIndex = 22;
            this.btnAddNew.Text = "Add";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // cmbTestcase
            // 
            this.cmbTestcase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTestcase.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTestcase.FormattingEnabled = true;
            this.cmbTestcase.Location = new System.Drawing.Point(177, 558);
            this.cmbTestcase.Name = "cmbTestcase";
            this.cmbTestcase.Size = new System.Drawing.Size(154, 29);
            this.cmbTestcase.TabIndex = 21;
            // 
            // lblReporter
            // 
            this.lblReporter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReporter.AutoSize = true;
            this.lblReporter.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporter.Location = new System.Drawing.Point(177, 159);
            this.lblReporter.Name = "lblReporter";
            this.lblReporter.Size = new System.Drawing.Size(113, 21);
            this.lblReporter.TabIndex = 20;
            this.lblReporter.Text = "ReporterName";
            // 
            // lblProjectName
            // 
            this.lblProjectName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.Location = new System.Drawing.Point(177, 31);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(85, 21);
            this.lblProjectName.TabIndex = 19;
            this.lblProjectName.Text = "ProjectInfo";
            // 
            // lblSubSystem
            // 
            this.lblSubSystem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubSystem.AutoSize = true;
            this.lblSubSystem.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubSystem.Location = new System.Drawing.Point(457, 301);
            this.lblSubSystem.Name = "lblSubSystem";
            this.lblSubSystem.Size = new System.Drawing.Size(115, 21);
            this.lblSubSystem.TabIndex = 18;
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
            this.cmbTaxonomy.Location = new System.Drawing.Point(457, 157);
            this.cmbTaxonomy.Name = "cmbTaxonomy";
            this.cmbTaxonomy.Size = new System.Drawing.Size(154, 29);
            this.cmbTaxonomy.TabIndex = 17;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(360, 159);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(82, 21);
            this.label27.TabIndex = 15;
            this.label27.Text = "Taxonomy";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(66, 559);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 21);
            this.label13.TabIndex = 15;
            this.label13.Text = "Test Case";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(96, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Project*";
            // 
            // cmbAssignee
            // 
            this.cmbAssignee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAssignee.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAssignee.FormattingEnabled = true;
            this.cmbAssignee.Location = new System.Drawing.Point(177, 186);
            this.cmbAssignee.Name = "cmbAssignee";
            this.cmbAssignee.Size = new System.Drawing.Size(154, 28);
            this.cmbAssignee.TabIndex = 1;
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
            this.cmbPriorityAdd.Location = new System.Drawing.Point(177, 224);
            this.cmbPriorityAdd.Name = "cmbPriorityAdd";
            this.cmbPriorityAdd.Size = new System.Drawing.Size(154, 28);
            this.cmbPriorityAdd.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(85, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Defect ID*";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(177, 258);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(154, 28);
            this.cmbStatus.TabIndex = 7;
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
            this.cmbSeverityAdd.Location = new System.Drawing.Point(177, 291);
            this.cmbSeverityAdd.Name = "cmbSeverityAdd";
            this.cmbSeverityAdd.Size = new System.Drawing.Size(154, 28);
            this.cmbSeverityAdd.TabIndex = 7;
            // 
            // txtDefect
            // 
            this.txtDefect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDefect.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDefect.Enabled = false;
            this.txtDefect.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefect.Location = new System.Drawing.Point(177, 60);
            this.txtDefect.Name = "txtDefect";
            this.txtDefect.Size = new System.Drawing.Size(154, 27);
            this.txtDefect.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(516, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(177, 97);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(431, 52);
            this.txtDesc.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(35, 384);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 20);
            this.label16.TabIndex = 5;
            // 
            // txtBuild
            // 
            this.txtBuild.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuild.Enabled = false;
            this.txtBuild.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuild.Location = new System.Drawing.Point(457, 227);
            this.txtBuild.Name = "txtBuild";
            this.txtBuild.Size = new System.Drawing.Size(154, 27);
            this.txtBuild.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(22, 343);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(135, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "Step to reproduce*";
            // 
            // txtEnvironment
            // 
            this.txtEnvironment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEnvironment.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnvironment.Location = new System.Drawing.Point(457, 266);
            this.txtEnvironment.Name = "txtEnvironment";
            this.txtEnvironment.Size = new System.Drawing.Size(154, 27);
            this.txtEnvironment.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(351, 301);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 20);
            this.label18.TabIndex = 5;
            this.label18.Text = "Sub System*";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(350, 266);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 20);
            this.label19.TabIndex = 5;
            this.label19.Text = "Environment";
            // 
            // txtSteps
            // 
            this.txtSteps.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSteps.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSteps.Location = new System.Drawing.Point(177, 340);
            this.txtSteps.Multiline = true;
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.Size = new System.Drawing.Size(431, 202);
            this.txtSteps.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(363, 231);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 20);
            this.label20.TabIndex = 5;
            this.label20.Text = "Build Info*";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(66, 104);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 20);
            this.label21.TabIndex = 4;
            this.label21.Text = "Description*";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(84, 156);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 20);
            this.label22.TabIndex = 4;
            this.label22.Text = "Reporter*";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(102, 259);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 20);
            this.label23.TabIndex = 5;
            this.label23.Text = "Status*";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(90, 296);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 20);
            this.label24.TabIndex = 4;
            this.label24.Text = "Severity*";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(95, 224);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 20);
            this.label25.TabIndex = 5;
            this.label25.Text = "Priority*";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(83, 186);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(74, 20);
            this.label26.TabIndex = 4;
            this.label26.Text = "Assignee*";
            // 
            // txtTestCase
            // 
            this.txtTestCase.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestCase.Location = new System.Drawing.Point(158, 445);
            this.txtTestCase.Name = "txtTestCase";
            this.txtTestCase.Size = new System.Drawing.Size(154, 27);
            this.txtTestCase.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 447);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 21);
            this.label12.TabIndex = 15;
            this.label12.Text = "Test Case";
            // 
            // cmbSubAddPg
            // 
            this.cmbSubAddPg.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubAddPg.FormattingEnabled = true;
            this.cmbSubAddPg.Location = new System.Drawing.Point(158, 152);
            this.cmbSubAddPg.Name = "cmbSubAddPg";
            this.cmbSubAddPg.Size = new System.Drawing.Size(200, 29);
            this.cmbSubAddPg.TabIndex = 14;
            this.cmbSubAddPg.Text = "Please Select Sub System";
            // 
            // cmbAssigneeAddPg
            // 
            this.cmbAssigneeAddPg.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAssigneeAddPg.FormattingEnabled = true;
            this.cmbAssigneeAddPg.Location = new System.Drawing.Point(158, -70);
            this.cmbAssigneeAddPg.Name = "cmbAssigneeAddPg";
            this.cmbAssigneeAddPg.Size = new System.Drawing.Size(185, 28);
            this.cmbAssigneeAddPg.TabIndex = 1;
            this.cmbAssigneeAddPg.Text = "Please Select Assignee";
            // 
            // cmbSttus
            // 
            this.cmbSttus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSttus.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSttus.FormattingEnabled = true;
            this.cmbSttus.Items.AddRange(new object[] {
            "Open",
            "In Progress",
            "Fix",
            "Close"});
            this.cmbSttus.Location = new System.Drawing.Point(158, 2);
            this.cmbSttus.Name = "cmbSttus";
            this.cmbSttus.Size = new System.Drawing.Size(154, 28);
            this.cmbSttus.TabIndex = 7;
            // 
            // txtReporter
            // 
            this.txtReporter.Enabled = false;
            this.txtReporter.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReporter.Location = new System.Drawing.Point(158, -144);
            this.txtReporter.Name = "txtReporter";
            this.txtReporter.Size = new System.Drawing.Size(154, 27);
            this.txtReporter.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, -138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Reporter*";
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
            this.ClientSize = new System.Drawing.Size(646, 653);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Add_New_Defect";
            this.Text = "Add_New_Defect";
            this.Load += new System.EventHandler(this.Add_New_Defect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bugDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugDataBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtDefectID;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtBuildInfo;
        private System.Windows.Forms.TextBox txtEnv;
        private System.Windows.Forms.TextBox txtReproduce;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbSeverity;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Panel panel1;
        private Assignment2DataSet assignment2DataSet;
        private System.Windows.Forms.BindingSource bugDataBindingSource;
        private Assignment2DataSetTableAdapters.BugDataTableAdapter bugDataTableAdapter;
        private Assignment2DataSet1 assignment2DataSet1;
        private System.Windows.Forms.BindingSource bugDataBindingSource1;
        private Assignment2DataSet1TableAdapters.BugDataTableAdapter bugDataTableAdapter1;
        private Assignment2DataSet2 assignment2DataSet2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Assignment2DataSet2TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ComboBox cmbSubAddPg;
        private System.Windows.Forms.ComboBox cmbAssigneeAddPg;
        private System.Windows.Forms.ComboBox cmbSttus;
        public System.Windows.Forms.TextBox txtReporter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTestCase;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbTaxonomy;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbPriorityAdd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbSeverityAdd;
        private System.Windows.Forms.TextBox txtDefect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label16;
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
        private System.Windows.Forms.Label lblSubSystem;
        private System.Windows.Forms.ComboBox cmbTestcase;
        private System.Windows.Forms.Label lblReporter;
        private System.Windows.Forms.Label lblProjectName;
        public System.Windows.Forms.ComboBox cmbAssignee;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblCommentEmpty;
    }
}