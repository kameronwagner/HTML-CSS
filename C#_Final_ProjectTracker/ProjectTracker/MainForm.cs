/*Kameron Wagner
 * CIS 266  Final Project
 * Main form in Project Tracker 
 * You can a menu tool strip to with File and Edit
 * From there you can exit the application, or save
 * Open form for projects,employes,tasks, employee tasks,
 * project employees and hours input
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTracker
{
    public partial class MainForm : Form
    {
        private ProjectDatabaseDataSet Project;

        public ProjectDatabaseDataSet ProjectData
        {
            get { return Project; }
        }
        public MainForm()
        {
            InitializeComponent();
        }
        // Property for setting text of status label
        public void SetReady(string message)
        {// allows me to call the status bar in form, to show messages
            slReady.Text = message;
        }

        private void ShowForm(Form showThis)
        {
            // sets this form as the parent to child forms
            showThis.MdiParent = this;
            // shows which form is opening in the status label
            slReady.Text = "Opening Form " + showThis.Text;
            showThis.Show();
        }
        // fills all table data using the adapter
        private void GetData()
        {
            // make table adapters
            ProjectDatabaseDataSetTableAdapters.EmployeesTableAdapter taEmployees =
                new ProjectDatabaseDataSetTableAdapters.EmployeesTableAdapter();
            ProjectDatabaseDataSetTableAdapters.StatusTableAdapter taStatus =
                new ProjectDatabaseDataSetTableAdapters.StatusTableAdapter();
            ProjectDatabaseDataSetTableAdapters.ProjectsTableAdapter taProjects =
                new ProjectDatabaseDataSetTableAdapters.ProjectsTableAdapter();
            ProjectDatabaseDataSetTableAdapters.TasksTableAdapter taTasks =
                new ProjectDatabaseDataSetTableAdapters.TasksTableAdapter();
            ProjectDatabaseDataSetTableAdapters.WorkTableAdapter taWork =
                new ProjectDatabaseDataSetTableAdapters.WorkTableAdapter();
            try
            {
                taEmployees.Fill(Project.Employees);
                taStatus.Fill(Project.Status);
                taProjects.Fill(Project.Projects);
                taTasks.Fill(Project.Tasks);
                taWork.Fill(Project.Work);
            }
            catch (Exception ex)
            {
                // shows message in status label
                SetReady(ex.Message);
            }
        }
        // method to update and write data
        public void SaveData()
        {
            // make table adapters
            ProjectDatabaseDataSetTableAdapters.EmployeesTableAdapter taEmployees =
                new ProjectDatabaseDataSetTableAdapters.EmployeesTableAdapter();
            ProjectDatabaseDataSetTableAdapters.StatusTableAdapter taStatus =
                new ProjectDatabaseDataSetTableAdapters.StatusTableAdapter();
            ProjectDatabaseDataSetTableAdapters.ProjectsTableAdapter taProjects =
                new ProjectDatabaseDataSetTableAdapters.ProjectsTableAdapter();
            ProjectDatabaseDataSetTableAdapters.TasksTableAdapter taTasks =
                new ProjectDatabaseDataSetTableAdapters.TasksTableAdapter();
            ProjectDatabaseDataSetTableAdapters.WorkTableAdapter taWork =
                new ProjectDatabaseDataSetTableAdapters.WorkTableAdapter();

            //make table adapter manager and connect to table adapters
            ProjectDatabaseDataSetTableAdapters.TableAdapterManager taManager =
                new ProjectDatabaseDataSetTableAdapters.TableAdapterManager();
            taManager.EmployeesTableAdapter = taEmployees;
            taManager.StatusTableAdapter = taStatus;
            taManager.ProjectsTableAdapter = taProjects;
            taManager.TasksTableAdapter = taTasks;
            taManager.WorkTableAdapter = taWork;
            try
            {
                taManager.UpdateAll(Project);
            }
            catch(Exception ex)
            {
                SetReady(ex.Message);
            }
        }
        // when projects is clicked, it creates a new projects form
        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new ProjectForm());
        }
        // when employees is clicked, it creates a new employees form
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ShowForm(new EmployeeForm());
        }
        // when tasks is clicked, it creates a new task form
        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new TaskForm());
        }
        // when project tasks is clicked, it creates a new project task form
        private void projectTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new ProjectTasksForm());
        }
        // When exit is clicked in menu strip, asks if you really want to close the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
        // On form load, sets a message for status label to display
        private void MainForm_Load(object sender, EventArgs e)
        {
            Project = new ProjectDatabaseDataSet();
            slReady.Text = "Ready";
            GetData();
        }
        // cascade view
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }
        //tile view
        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }
        //closes child form
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
                frm.Close();
            slReady.Text = "Ready";
        }
        // updates data
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        // calls save data method and save data to disk
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Project.HasChanges())
                SaveData();
        }
        // when project employees is clicked, it creates a new project employee form
        private void projectEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new ProjectEmployeesForm(Project));
        }
        // when employee tasks is clicked, it creates a new employee task form
        private void employeeTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new EmployeeTasksForm(Project));
        }
        // when hours input is clicked, it creates a new hours input form
        private void hoursInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new HoursInputForm(Project));
        }
    }
}
