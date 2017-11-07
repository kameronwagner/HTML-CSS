namespace ProjectTracker
{
    partial class ProjectEmployeesForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label projectManagerLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.Employee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Task = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TaskDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lstProject = new System.Windows.Forms.ListBox();
            this.lstvEmployee = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.projectDatabaseDataSet = new ProjectTracker.ProjectDatabaseDataSet();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new ProjectTracker.ProjectDatabaseDataSetTableAdapters.ProjectsTableAdapter();
            this.tableAdapterManager = new ProjectTracker.ProjectDatabaseDataSetTableAdapters.TableAdapterManager();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new ProjectTracker.ProjectDatabaseDataSetTableAdapters.EmployeesTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            projectManagerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(215, 34);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(385, 64);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 25;
            descriptionLabel.Text = "Description:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(213, 64);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 27;
            statusLabel.Text = "Status:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(213, 92);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(58, 13);
            startDateLabel.TabIndex = 29;
            startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(213, 118);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(55, 13);
            endDateLabel.TabIndex = 30;
            endDateLabel.Text = "End Date:";
            // 
            // projectManagerLabel
            // 
            projectManagerLabel.AutoSize = true;
            projectManagerLabel.Location = new System.Drawing.Point(384, 34);
            projectManagerLabel.Name = "projectManagerLabel";
            projectManagerLabel.Size = new System.Drawing.Size(88, 13);
            projectManagerLabel.TabIndex = 31;
            projectManagerLabel.Text = "Project Manager:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Total Hours:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(259, 31);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(106, 20);
            this.txtName.TabIndex = 24;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(454, 61);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(196, 79);
            this.txtDescription.TabIndex = 26;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(259, 61);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(106, 20);
            this.txtStatus.TabIndex = 28;
            // 
            // txtManager
            // 
            this.txtManager.Location = new System.Drawing.Point(478, 31);
            this.txtManager.Name = "txtManager";
            this.txtManager.ReadOnly = true;
            this.txtManager.Size = new System.Drawing.Size(101, 20);
            this.txtManager.TabIndex = 32;
            // 
            // Employee
            // 
            this.Employee.Text = "Employee Name";
            this.Employee.Width = 250;
            // 
            // Task
            // 
            this.Task.Text = "TaskName";
            this.Task.Width = 200;
            // 
            // TaskDate
            // 
            this.TaskDate.Text = "TaskDate";
            this.TaskDate.Width = 200;
            // 
            // Hours
            // 
            this.Hours.Text = "Hours";
            this.Hours.Width = 150;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(656, 373);
            this.txtHours.Name = "txtHours";
            this.txtHours.ReadOnly = true;
            this.txtHours.Size = new System.Drawing.Size(96, 20);
            this.txtHours.TabIndex = 38;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(274, 115);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(92, 20);
            this.txtEndDate.TabIndex = 36;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(274, 89);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(92, 20);
            this.txtStartDate.TabIndex = 35;
            // 
            // lstProject
            // 
            this.lstProject.FormattingEnabled = true;
            this.lstProject.Location = new System.Drawing.Point(12, 31);
            this.lstProject.Name = "lstProject";
            this.lstProject.Size = new System.Drawing.Size(195, 121);
            this.lstProject.TabIndex = 34;
            this.lstProject.SelectedIndexChanged += new System.EventHandler(this.lstProject_SelectedIndexChanged);
            // 
            // lstvEmployee
            // 
            this.lstvEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Employee,
            this.Task,
            this.TaskDate,
            this.Hours});
            this.lstvEmployee.Location = new System.Drawing.Point(-1, 166);
            this.lstvEmployee.Name = "lstvEmployee";
            this.lstvEmployee.Size = new System.Drawing.Size(753, 201);
            this.lstvEmployee.TabIndex = 33;
            this.lstvEmployee.UseCompatibleStateImageBehavior = false;
            this.lstvEmployee.View = System.Windows.Forms.View.Details;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Project Names:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Project Info:";
            // 
            // projectDatabaseDataSet
            // 
            this.projectDatabaseDataSet.DataSetName = "ProjectDatabaseDataSet";
            this.projectDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.projectDatabaseDataSet;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProjectsTableAdapter = this.projectsTableAdapter;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TasksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectTracker.ProjectDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkTableAdapter = null;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.projectDatabaseDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // ProjectEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(772, 413);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtManager);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.lstProject);
            this.Controls.Add(this.lstvEmployee);
            this.Controls.Add(nameLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(statusLabel);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(endDateLabel);
            this.Controls.Add(projectManagerLabel);
            this.Name = "ProjectEmployeesForm";
            this.Text = "Project Employees Form";
            this.Load += new System.EventHandler(this.ProjectEmployeesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.ColumnHeader Employee;
        private System.Windows.Forms.ColumnHeader Task;
        private System.Windows.Forms.ColumnHeader TaskDate;
        private System.Windows.Forms.ColumnHeader Hours;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.ListBox lstProject;
        private System.Windows.Forms.ListView lstvEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private ProjectDatabaseDataSet projectDatabaseDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private ProjectDatabaseDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private ProjectDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private ProjectDatabaseDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
    }
}