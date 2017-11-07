/*Kameron Wagner
 * CIS 266  Final Project
 * Allows for Viewing employees and tasks
 * for a selected project
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
    public partial class ProjectEmployeesForm : Form
    {
        // boolean value for telling the list box if it can populate values
        bool isLoaded = false;
        private ProjectDatabaseDataSet dsProject;
        public ProjectEmployeesForm(ProjectDatabaseDataSet data)
        {
            InitializeComponent();
            dsProject = data;
            // private method so list box knows what to display
            BindListBox();
            isLoaded = true;
        }
        private void BindListBox()
        {
            isLoaded = false;
            lstProject.DataSource = dsProject.Projects;
            // what you want list box to show
            lstProject.DisplayMember = "ProjectName";
            // what row defines the student
            lstProject.ValueMember = "ProjectID";
            isLoaded = true;

        }
        // select changed from project to project
        private void lstProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstvEmployee.Items.Clear();      //clears listview so listview will not display info from previous selected projects
            txtHours.Clear();
            if (isLoaded)                   //makes sure isloaded is set to true
            {
                if (lstProject.SelectedIndex != -1) //if there is a selection
                {

                    int projectID = (int)lstProject.SelectedValue;

                    ProjectDatabaseDataSet.ProjectsRow projectRow = dsProject.Projects.FindByProjectID(projectID);
                    txtName.Text = projectRow.ProjectName;
                    txtDescription.Text = projectRow.Description;
                    txtStatus.Text = projectRow.StatusID.ToString();
                    txtStartDate.Text = projectRow.StartDate.ToString();
                    txtEndDate.Text = projectRow.EndDate.ToString();

                    int projectManager = (int)projectRow[1];

                    foreach (DataRow employees in dsProject.Employees.Rows)
                    {
                        if ((int)employees[0] == projectManager)
                        {
                            txtManager.Text = employees["FullName"].ToString();
                            //local variable for total hours worked on project
                            decimal projectHours = 0;  
                            foreach (DataRow tasks in dsProject.Tasks.Rows)
                            {
                                if ((int)tasks[2] == projectID)
                                {
                                    int taskID = (int)tasks[0];

                                    foreach (DataRow employeeTask in dsProject.Work.Rows)
                                    {
                                        if ((int)employeeTask[2] == taskID)
                                        {
                                            int employeeID = (int)employeeTask[1];
                                            //local variable for suming task hours for a project
                                            decimal taskHours = 0;  
                                            foreach (DataRow employee in dsProject.Employees.Rows)
                                            {

                                                if ((int)employee[0] == employeeID)
                                                {
                                                    //sums task hours
                                                    taskHours += decimal.Parse(employeeTask[4].ToString());
                                                    ListViewItem item = new ListViewItem(employee["FullName"].ToString());
                                                    item.SubItems.Add(tasks[1].ToString());
                                                    item.SubItems.Add(employeeTask[3].ToString());
                                                    item.SubItems.Add(employeeTask[4].ToString());
                                                    //adds to listview
                                                    lstvEmployee.Items.Add(item);
                                                    //to sum local variable for calculating project total hours
                                                    projectHours += taskHours;
                                                    //displays total hours
                                                    txtHours.Text = projectHours.ToString();


                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void ProjectEmployeesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDatabaseDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.projectDatabaseDataSet.Employees);
            try
            {
                // TODO: This line of code loads data into the 'projectDatabaseDataSet.Employees' table. You can move, or remove it, as needed.
                this.employeesTableAdapter.Fill(this.projectDatabaseDataSet.Employees);
                // TODO: This line of code loads data into the 'projectDatabaseDataSet.Projects' table. You can move, or remove it, as needed.
                this.projectsTableAdapter.Fill(this.projectDatabaseDataSet.Projects);
            }
            catch (Exception ex)
            {
                // if it fails to save, updates status strip and throws exception
                MainForm myParent = (MainForm)MdiParent;
                myParent.SetReady(ex.Message);
            }
        }
    }
}
