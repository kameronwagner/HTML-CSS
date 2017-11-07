namespace ProjectTracker
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slReady = new System.Windows.Forms.ToolStripStatusLabel();
            this.projectDatabaseDataSet1 = new ProjectTracker.ProjectDatabaseDataSet();
            this.employeesTableAdapter1 = new ProjectTracker.ProjectDatabaseDataSetTableAdapters.EmployeesTableAdapter();
            this.projectsTableAdapter1 = new ProjectTracker.ProjectDatabaseDataSetTableAdapters.ProjectsTableAdapter();
            this.statusTableAdapter1 = new ProjectTracker.ProjectDatabaseDataSetTableAdapters.StatusTableAdapter();
            this.tableAdapterManager1 = new ProjectTracker.ProjectDatabaseDataSetTableAdapters.TableAdapterManager();
            this.tasksTableAdapter1 = new ProjectTracker.ProjectDatabaseDataSetTableAdapters.TasksTableAdapter();
            this.workTableAdapter1 = new ProjectTracker.ProjectDatabaseDataSetTableAdapters.WorkTableAdapter();
            this.hoursInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.projectsToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.tasksToolStripMenuItem,
            this.projectTasksToolStripMenuItem,
            this.projectEmployeesToolStripMenuItem,
            this.employeeTasksToolStripMenuItem,
            this.hoursInputToolStripMenuItem});
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.projectsToolStripMenuItem.Text = "E&dit";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.employeesToolStripMenuItem.Text = "&Projects";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItem2.Text = "&Employees";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.tasksToolStripMenuItem.Text = "&Tasks";
            this.tasksToolStripMenuItem.Click += new System.EventHandler(this.tasksToolStripMenuItem_Click);
            // 
            // projectTasksToolStripMenuItem
            // 
            this.projectTasksToolStripMenuItem.Name = "projectTasksToolStripMenuItem";
            this.projectTasksToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.projectTasksToolStripMenuItem.Text = "P&roject Tasks";
            this.projectTasksToolStripMenuItem.Click += new System.EventHandler(this.projectTasksToolStripMenuItem_Click);
            // 
            // projectEmployeesToolStripMenuItem
            // 
            this.projectEmployeesToolStripMenuItem.Name = "projectEmployeesToolStripMenuItem";
            this.projectEmployeesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.projectEmployeesToolStripMenuItem.Text = "Pr&oject Employees";
            this.projectEmployeesToolStripMenuItem.Click += new System.EventHandler(this.projectEmployeesToolStripMenuItem_Click);
            // 
            // employeeTasksToolStripMenuItem
            // 
            this.employeeTasksToolStripMenuItem.Name = "employeeTasksToolStripMenuItem";
            this.employeeTasksToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.employeeTasksToolStripMenuItem.Text = "Emplo&yee Tasks";
            this.employeeTasksToolStripMenuItem.Click += new System.EventHandler(this.employeeTasksToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "&Window";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.tileToolStripMenuItem.Text = "&Tile";
            this.tileToolStripMenuItem.Click += new System.EventHandler(this.tileToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.closeToolStripMenuItem.Text = "Cl&ose";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slReady});
            this.statusStrip1.Location = new System.Drawing.Point(0, 533);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(827, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slReady
            // 
            this.slReady.Name = "slReady";
            this.slReady.Size = new System.Drawing.Size(118, 17);
            this.slReady.Text = "toolStripStatusLabel1";
            // 
            // projectDatabaseDataSet1
            // 
            this.projectDatabaseDataSet1.DataSetName = "ProjectDatabaseDataSet";
            this.projectDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter1
            // 
            this.employeesTableAdapter1.ClearBeforeFill = true;
            // 
            // projectsTableAdapter1
            // 
            this.projectsTableAdapter1.ClearBeforeFill = true;
            // 
            // statusTableAdapter1
            // 
            this.statusTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.EmployeesTableAdapter = this.employeesTableAdapter1;
            this.tableAdapterManager1.ProjectsTableAdapter = this.projectsTableAdapter1;
            this.tableAdapterManager1.StatusTableAdapter = this.statusTableAdapter1;
            this.tableAdapterManager1.TasksTableAdapter = this.tasksTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = ProjectTracker.ProjectDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.WorkTableAdapter = this.workTableAdapter1;
            // 
            // tasksTableAdapter1
            // 
            this.tasksTableAdapter1.ClearBeforeFill = true;
            // 
            // workTableAdapter1
            // 
            this.workTableAdapter1.ClearBeforeFill = true;
            // 
            // hoursInputToolStripMenuItem
            // 
            this.hoursInputToolStripMenuItem.Name = "hoursInputToolStripMenuItem";
            this.hoursInputToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.hoursInputToolStripMenuItem.Text = "&Hours Input";
            this.hoursInputToolStripMenuItem.Click += new System.EventHandler(this.hoursInputToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 555);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slReady;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private ProjectDatabaseDataSet projectDatabaseDataSet1;
        private ProjectDatabaseDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter1;
        private ProjectDatabaseDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter1;
        private ProjectDatabaseDataSetTableAdapters.StatusTableAdapter statusTableAdapter1;
        private ProjectDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private ProjectDatabaseDataSetTableAdapters.TasksTableAdapter tasksTableAdapter1;
        private ProjectDatabaseDataSetTableAdapters.WorkTableAdapter workTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem projectEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoursInputToolStripMenuItem;
    }
}

