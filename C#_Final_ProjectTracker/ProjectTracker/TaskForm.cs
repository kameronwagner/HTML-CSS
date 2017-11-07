/*Kameron Wagner
 * CIS 266  Final Project
 * Tasks form in Project Tracker 
 * You have a tool strip to delete, add or save entries
 * From there you can also navigate through entries
 * Updates status label based on saving, deleteing or finding an error
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
    public partial class TaskForm : Form
    {
        public TaskForm()
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
        private void tasksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tasksBindingSource.EndEdit();
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
        private void TaskForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'projectDatabaseDataSet.Status' table. You can move, or remove it, as needed.
                this.statusTableAdapter.Fill(this.projectDatabaseDataSet.Status);
                // TODO: This line of code loads data into the 'projectDatabaseDataSet.Tasks' table. You can move, or remove it, as needed.
                this.tasksTableAdapter.Fill(this.projectDatabaseDataSet.Tasks);
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
