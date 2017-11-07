/*Kameron Wagner
 * CIS 266  Final Project
 * Allows for choosing a project
 * employee, task, date and input the hours
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
    public partial class HoursInputForm : Form
    {
        private ProjectDatabaseDataSet dsProject;
        public HoursInputForm(ProjectDatabaseDataSet data)
        {
            InitializeComponent();
            dsProject = data;
            FillTreeView();
        }
        //fill treeview with projects that are underway
        private void FillTreeView()
        {
            tvwProjects.Nodes.Clear();

            foreach (ProjectDatabaseDataSet.ProjectsRow projectRow
                in dsProject.Projects)
            {   // set to only allow edits to projects that are underway
                if (projectRow.StatusID == 2)
                {
                    TreeNode node = new TreeNode(projectRow.ProjectName);
                    node.Tag = projectRow.ProjectID;
                    tvwProjects.Nodes.Add(node);
                }
            }
        }
        public class TasksCombo
        {
            public string name { get; set; }
            public string id { get; set; }
            public override string ToString() { return this.name; }
        }
        //fill taskss that are underway to task combobox
        private void FillTasks(int projectid)
        {
            cboTask.Items.Clear();

            ProjectDatabaseDataSet.ProjectsRow projectRow =
                dsProject.Projects.FindByProjectID(projectid);
            DataRow[] taskRows =
                projectRow.GetChildRows("FK_Tasks_Projects");
            foreach (ProjectDatabaseDataSet.TasksRow taskRow in dsProject.Tasks)
            {
                if (taskRow.ProjectID == projectRow.ProjectID &&
                    taskRow.StatusID == 2)
                {
                    this.cboTask.DisplayMember = "TaskName";
                    this.cboTask.ValueMember = "TaskID";
                    this.cboTask.DataSource = dsProject.Tables["Tasks"];

                    cboTask.Items.Add(new TasksCombo
                    {
                        name = taskRow.TaskName,
                        id = taskRow.TaskID.ToString() });
                }
            }
        }
        //Select project to add task to task combobox
        private void tvwProjects_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            int id = (int)e.Node.Tag;
            FillTasks(id);
        }
        //load data for combobowes
        private void HoursInputForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.employeesTableAdapter1.Fill(this.projectDatabaseDataSet1.Employees);
                this.tasksTableAdapter1.Fill(this.projectDatabaseDataSet1.Tasks);
                // filled this way since my fill methods were not returning any values, not sure if it was a actually working right
                // or I just had no rows to return, I believe I just did it wrong, but it still breaks it
                this.cboEmployee.DisplayMember = "FullName";
                this.cboEmployee.ValueMember = "EmployeeID";
                this.cboEmployee.DataSource = dsProject.Tables["Employees"];
                //this.cboTask.DisplayMember = "TaskName";
                //this.cboTask.ValueMember = "TaskID";
                //this.cboTask.DataSource = dsProject.Tables["Tasks"];
            }
            catch (Exception ex)
            {
                // if it fails, updates status strip and throws exception
                MainForm myParent = (MainForm)MdiParent;
                myParent.SetReady(ex.Message);
            }
        }
        //Add hours to task
        private void NewEmployeeTaskRow(ProjectDatabaseDataSet.WorkRow row)
        {
            row.EmployeeID = (int)cboEmployee.SelectedValue;
            row.TaskID = Convert.ToInt32(cboTask.SelectedIndex);
            row.Date = DateTime.Parse(dtpDate.Text);
            row.Hours = Convert.ToInt32(txtHours.Text);
        }
        //Add data to a employeeTask row
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProjectDatabaseDataSet.WorkRow newRow =
            dsProject.Work.NewWorkRow();
            NewEmployeeTaskRow(newRow);
            dsProject.Work.Rows.Add(newRow);

            DialogResult result = MessageBox.Show((cboEmployee.Text.ToString()
                + ", Task: " + cboTask.Text.ToString() + ", Date: " + dtpDate.Text.ToString() +
                ", Hours " + txtHours.Text.ToString()), "Save entry?", MessageBoxButtons.YesNo);
        }
        //Close form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
