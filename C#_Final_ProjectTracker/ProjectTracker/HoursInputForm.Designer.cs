namespace ProjectTracker
{
    partial class HoursInputForm
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
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.cboTask = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tvwProjects = new System.Windows.Forms.TreeView();
            this.projectDatabaseDataSet1 = new ProjectTracker.ProjectDatabaseDataSet();
            this.tableAdapterManager1 = new ProjectTracker.ProjectDatabaseDataSetTableAdapters.TableAdapterManager();
            this.employeesTableAdapter1 = new ProjectTracker.ProjectDatabaseDataSetTableAdapters.EmployeesTableAdapter();
            this.projectsTableAdapter1 = new ProjectTracker.ProjectDatabaseDataSetTableAdapters.ProjectsTableAdapter();
            this.tasksTableAdapter1 = new ProjectTracker.ProjectDatabaseDataSetTableAdapters.TasksTableAdapter();
            this.workTableAdapter1 = new ProjectTracker.ProjectDatabaseDataSetTableAdapters.WorkTableAdapter();
            this.projectDatabaseDataSet2 = new ProjectTracker.ProjectDatabaseDataSet();
            this.ProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TasksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Name:";
            // 
            // cboEmployee
            // 
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(279, 25);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(121, 21);
            this.cboEmployee.TabIndex = 2;
            // 
            // cboTask
            // 
            this.cboTask.FormattingEnabled = true;
            this.cboTask.Location = new System.Drawing.Point(279, 50);
            this.cboTask.Name = "cboTask";
            this.cboTask.Size = new System.Drawing.Size(121, 21);
            this.cboTask.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Task Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(279, 75);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(96, 20);
            this.dtpDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hours:";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(279, 99);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(48, 20);
            this.txtHours.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(213, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(300, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tvwProjects
            // 
            this.tvwProjects.Location = new System.Drawing.Point(12, 28);
            this.tvwProjects.Name = "tvwProjects";
            this.tvwProjects.Size = new System.Drawing.Size(174, 204);
            this.tvwProjects.TabIndex = 11;
            this.tvwProjects.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwProjects_NodeMouseClick);
            // 
            // projectDatabaseDataSet1
            // 
            this.projectDatabaseDataSet1.DataSetName = "ProjectDatabaseDataSet";
            this.projectDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.EmployeesTableAdapter = this.employeesTableAdapter1;
            this.tableAdapterManager1.ProjectsTableAdapter = this.projectsTableAdapter1;
            this.tableAdapterManager1.StatusTableAdapter = null;
            this.tableAdapterManager1.TasksTableAdapter = this.tasksTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = ProjectTracker.ProjectDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.WorkTableAdapter = this.workTableAdapter1;
            // 
            // employeesTableAdapter1
            // 
            this.employeesTableAdapter1.ClearBeforeFill = true;
            // 
            // projectsTableAdapter1
            // 
            this.projectsTableAdapter1.ClearBeforeFill = true;
            // 
            // tasksTableAdapter1
            // 
            this.tasksTableAdapter1.ClearBeforeFill = true;
            // 
            // workTableAdapter1
            // 
            this.workTableAdapter1.ClearBeforeFill = true;
            // 
            // projectDatabaseDataSet2
            // 
            this.projectDatabaseDataSet2.DataSetName = "ProjectDatabaseDataSet";
            this.projectDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProjectsBindingSource
            // 
            this.ProjectsBindingSource.DataMember = "Projects";
            this.ProjectsBindingSource.DataSource = this.projectDatabaseDataSet1;
            // 
            // EmployeesBindingSource
            // 
            this.EmployeesBindingSource.DataMember = "Employees";
            this.EmployeesBindingSource.DataSource = this.projectDatabaseDataSet1;
            // 
            // TasksBindingSource
            // 
            this.TasksBindingSource.DataMember = "Tasks";
            this.TasksBindingSource.DataSource = this.projectDatabaseDataSet1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Project Names:";
            // 
            // HoursInputForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(410, 249);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tvwProjects);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboEmployee);
            this.Controls.Add(this.label1);
            this.Name = "HoursInputForm";
            this.Text = "Hours Input Form";
            this.Load += new System.EventHandler(this.HoursInputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TasksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.ComboBox cboTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TreeView tvwProjects;
        private ProjectDatabaseDataSet projectDatabaseDataSet1;
        private ProjectDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private ProjectDatabaseDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter1;
        private ProjectDatabaseDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter1;
        private ProjectDatabaseDataSetTableAdapters.TasksTableAdapter tasksTableAdapter1;
        private ProjectDatabaseDataSetTableAdapters.WorkTableAdapter workTableAdapter1;
        private ProjectDatabaseDataSet projectDatabaseDataSet2;
        private System.Windows.Forms.BindingSource ProjectsBindingSource;
        private System.Windows.Forms.BindingSource EmployeesBindingSource;
        private System.Windows.Forms.BindingSource TasksBindingSource;
        private System.Windows.Forms.Label label5;
    }
}