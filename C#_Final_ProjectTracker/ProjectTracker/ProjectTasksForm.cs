/*Kameron Wagner
 * CIS 266  Final Project
 * Project Tasks form in Project Tracker 
 * You can also navigate through entries
 * Show tasks that are a part of selected project
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
    public partial class ProjectTasksForm : Form
    {
        public ProjectTasksForm()
        {
            InitializeComponent();
        }
        // shows which form is parent
        private MainForm MyParent
        {
            get { return (MainForm)MdiParent; }
        }
        // populates data from parent
        private ProjectDatabaseDataSet ParentData
        {
            get { return MyParent.ProjectData; }
        }
        // When save button is clicked, if it is valid and adpater can update the entry
        // Status label is updated
        private void projectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.projectsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.projectDatabaseDataSet);
            }
            catch (Exception ex)
            {
                // if it fails to save, updates status strip and throws exception
                MainForm myParent = (MainForm)MdiParent;
                myParent.SetReady(ex.Message);
            }
        }
        // When employees form loads, uses adapter to fill table for employees.
        // updates status label
        private void ProjectTasksForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'projectDatabaseDataSet.Tasks' table. You can move, or remove it, as needed.
                this.tasksTableAdapter.Fill(this.projectDatabaseDataSet.Tasks);
                // TODO: This line of code loads data into the 'projectDatabaseDataSet.Projects' table. You can move, or remove it, as needed.
                this.projectsTableAdapter.Fill(this.projectDatabaseDataSet.Projects);
            }
            catch (Exception ex)
            {
                // if error reading will populate error messsage
                MainForm myParent = (MainForm)MdiParent;
                myParent.SetReady(ex.Message);
            }
        }
    }
}
