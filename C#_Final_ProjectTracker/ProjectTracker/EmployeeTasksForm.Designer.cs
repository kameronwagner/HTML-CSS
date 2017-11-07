namespace ProjectTracker
{
    partial class EmployeeTasksForm
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
            System.Windows.Forms.Label employmentTypeLabel;
            System.Windows.Forms.Label employeeNumberLabel;
            System.Windows.Forms.Label fullNameLabel;
            this.projectDatabaseDataSet = new ProjectTracker.ProjectDatabaseDataSet();
            this.tableAdapterManager = new ProjectTracker.ProjectDatabaseDataSetTableAdapters.TableAdapterManager();
            this.employeesTableAdapter = new ProjectTracker.ProjectDatabaseDataSetTableAdapters.EmployeesTableAdapter();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Hours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TaskName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lstProject = new System.Windows.Forms.ListView();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lstName = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            employmentTypeLabel = new System.Windows.Forms.Label();
            employeeNumberLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employmentTypeLabel
            // 
            employmentTypeLabel.AutoSize = true;
            employmentTypeLabel.Location = new System.Drawing.Point(214, 68);
            employmentTypeLabel.Name = "employmentTypeLabel";
            employmentTypeLabel.Size = new System.Drawing.Size(79, 13);
            employmentTypeLabel.TabIndex = 17;
            employmentTypeLabel.Text = "Employee Title:";
            // 
            // employeeNumberLabel
            // 
            employeeNumberLabel.AutoSize = true;
            employeeNumberLabel.Location = new System.Drawing.Point(214, 42);
            employeeNumberLabel.Name = "employeeNumberLabel";
            employeeNumberLabel.Size = new System.Drawing.Size(70, 13);
            employeeNumberLabel.TabIndex = 19;
            employeeNumberLabel.Text = "Employee ID:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(214, 93);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(87, 13);
            fullNameLabel.TabIndex = 21;
            fullNameLabel.Text = "Employee Name:";
            // 
            // projectDatabaseDataSet
            // 
            this.projectDatabaseDataSet.DataSetName = "ProjectDatabaseDataSet";
            this.projectDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.ProjectsTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectTracker.ProjectDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.projectDatabaseDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Total Hours:";
            // 
            // Hours
            // 
            this.Hours.Text = "Hours";
            this.Hours.Width = 150;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 150;
            // 
            // TaskName
            // 
            this.TaskName.Text = "Task Name";
            this.TaskName.Width = 250;
            // 
            // ProjectName
            // 
            this.ProjectName.Text = "Project Name";
            this.ProjectName.Width = 250;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(620, 433);
            this.txtHours.Name = "txtHours";
            this.txtHours.ReadOnly = true;
            this.txtHours.Size = new System.Drawing.Size(133, 20);
            this.txtHours.TabIndex = 24;
            // 
            // lstProject
            // 
            this.lstProject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProjectName,
            this.TaskName,
            this.Date,
            this.Hours});
            this.lstProject.Location = new System.Drawing.Point(12, 175);
            this.lstProject.Name = "lstProject";
            this.lstProject.Size = new System.Drawing.Size(741, 253);
            this.lstProject.TabIndex = 23;
            this.lstProject.UseCompatibleStateImageBehavior = false;
            this.lstProject.View = System.Windows.Forms.View.Details;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(307, 39);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.ReadOnly = true;
            this.txtEmployeeID.Size = new System.Drawing.Size(43, 20);
            this.txtEmployeeID.TabIndex = 20;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(307, 89);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(136, 20);
            this.txtFullName.TabIndex = 22;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(307, 65);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(136, 20);
            this.txtTitle.TabIndex = 18;
            // 
            // lstName
            // 
            this.lstName.FormattingEnabled = true;
            this.lstName.Location = new System.Drawing.Point(12, 35);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(170, 134);
            this.lstName.TabIndex = 16;
            this.lstName.SelectedIndexChanged += new System.EventHandler(this.lstName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Employee Names:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Employee Info:";
            // 
            // EmployeeTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(768, 458);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.lstProject);
            this.Controls.Add(employmentTypeLabel);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(employeeNumberLabel);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.lstName);
            this.Name = "EmployeeTasksForm";
            this.Text = "Employee Task Form";
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectDatabaseDataSet projectDatabaseDataSet;
        private ProjectDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ProjectDatabaseDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Hours;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader TaskName;
        private System.Windows.Forms.ColumnHeader ProjectName;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.ListView lstProject;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ListBox lstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}