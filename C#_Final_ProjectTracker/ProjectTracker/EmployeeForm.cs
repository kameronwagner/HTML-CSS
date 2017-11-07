/*Kameron Wagner
 * CIS 266  Final Project
 * Employees form in Project Tracker 
 * You have a tool strip to delete, add or save entries
 * From there you can also navigate through entries
 * Updates status label based on saving, deleteing or finding an error
 * Will let you know which row in your table has an issue.
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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
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
        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.employeesBindingSource.EndEdit();
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
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.projectDatabaseDataSet = null; // destroy object
                // make moviesdataset a reference variable
                projectDatabaseDataSet = ParentData;

                // reset the binding source
                employeesBindingSource.DataSource = projectDatabaseDataSet;
                employeesBindingSource.DataMember = projectDatabaseDataSet.Employees.TableName;
            }
            catch (Exception ex)
            {
                // if error reading will populate error messsage
                MainForm myParent = (MainForm)MdiParent;
                myParent.SetReady(ex.Message);
            }
        }
        // When a data error occurs, provides an error message on which row has an issue
        private void employeesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int row = e.RowIndex + 1;
            string errorMessage = "A data error occured.\n" +
                "Row: " + row + "\n" +
                "Error: " + e.Exception.Message;
            MessageBox.Show(errorMessage, "Data Error");
        }
    }
}
