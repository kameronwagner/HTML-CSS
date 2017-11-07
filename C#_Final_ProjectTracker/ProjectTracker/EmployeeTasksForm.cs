/*Kameron Wagner
 * CIS 266  Final Project
 * Allows for Viewing projects and tasks
 * for a selected employee
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
    public partial class EmployeeTasksForm : Form
    {
        // boolean value for telling the list box if it can populate values
        private bool isLoaded = false;
        private ProjectDatabaseDataSet dsProjects;
        public EmployeeTasksForm(ProjectDatabaseDataSet data)
        {
            InitializeComponent();
            dsProjects = data;
            // private method so list box knows what to display
            BindListBox();
            isLoaded = true;
        }
        private void BindListBox()
        {
            isLoaded = false;
            lstName.DataSource = dsProjects.Employees;
            // what you want list box to show
            lstName.DisplayMember = "FullName";
            // what row defines the student
            lstName.ValueMember = "EmployeeID";
            isLoaded = true;

        }
        // select changed from employee to employee
        private void lstName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstProject.Items.Clear();
            txtHours.Clear();

            if (isLoaded)
            {
                if (lstName.SelectedIndex != -1)
                {
                    int employeeID = (int)lstName.SelectedValue;
                    ProjectDatabaseDataSet.EmployeesRow employeeRow = dsProjects.Employees.FindByEmployeeID(employeeID);
                    txtFullName.Text = employeeRow.FullName;
                    txtEmployeeID.Text = employeeRow[0].ToString();
                    txtTitle.Text = employeeRow.Title;

                    int empID = (int)employeeRow[0];
                    foreach (DataRow employeeTaskRow in dsProjects.Work.Rows)
                    {

                        if ((int)employeeTaskRow[1] == empID)
                        {
                            int taskID = (int)employeeTaskRow[2];
                            foreach (DataRow taskRow in dsProjects.Tasks.Rows)
                            {
                                if ((int)taskRow[0] == taskID)
                                {
                                    int projectID = (int)taskRow[6];
                                    foreach (DataRow projectRow in dsProjects.Projects.Rows)
                                    {

                                        if ((int)projectRow[0] == projectID)
                                        {

                                            ListViewItem item = new ListViewItem(projectRow[1].ToString());
                                            item.SubItems.Add(taskRow[1].ToString());
                                            item.SubItems.Add(employeeTaskRow[3].ToString());
                                            item.SubItems.Add(employeeTaskRow[4].ToString());

                                            lstProject.Items.Add(item);

                                            txtHours.Text = GetCount(empID).ToString();

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        //to get the count of hours worked on a project for an employee
        private decimal GetCount(int EmployeeID)
        {
            decimal counter = 0;
            foreach (DataRow employeeTaskRow in dsProjects.Work.Rows)
            {
                if ((int)employeeTaskRow[1] == EmployeeID)
                {
                    counter += decimal.Parse(employeeTaskRow[4].ToString());
                }
            }
            return decimal.Parse(counter.ToString());
        }
    }
}
