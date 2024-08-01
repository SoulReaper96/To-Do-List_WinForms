using System.Data;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class ToDoList : Form
    {
        private DataTable tasksTable = new();
        //DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();

        public ToDoList()
        {
            InitializeComponent();
            Priority_cmb.SelectedIndex = 0;
            Category_cmb.SelectedIndex = 0;
        }

        private void InitializeTasksTable()
        {
            tasksTable = new DataTable();
            tasksTable.TableName = "MyDataTable"; // Set the TableName property

            // Add columns and rows to the DataTable as needed
            tasksTable.Columns.Add("ID", typeof(int));
            tasksTable.Columns.Add("Description", typeof(string));
            tasksTable.Columns.Add("DueDate", typeof(DateTime));
            tasksTable.Columns.Add("IsComplete", typeof(bool));
            tasksTable.Columns.Add("Priority", typeof(string));
            tasksTable.Columns.Add("Category", typeof(string));

            // Now you can serialize the DataTable
            using (var writer = new StringWriter())
            {
                tasksTable.WriteXml(writer, XmlWriteMode.WriteSchema);
                string xml = writer.ToString();
                Console.WriteLine(xml);
            }
        }

        //bool isEditing = false;
        private void ToDoList_Load(object sender, EventArgs e)
        {
            InitializeTasksTable();
            // Point our datagridview to our datasource
            ToDoListView.DataSource = tasksTable;
        }

        private void NewBTN_Click(object sender, EventArgs e)
        {
            DataRow newRow = tasksTable.NewRow();
            newRow["ID"] = tasksTable.Rows.Count > 0 ? (int)tasksTable.Compute("MAX(ID)", string.Empty) + 1 : 1;
            newRow["Description"] = DescriptTB.Text;
            newRow["DueDate"] = TaskDue_dtp.Value;
            newRow["IsComplete"] = false;
            newRow["Priority"] = Priority_cmb.SelectedItem.ToString();
            newRow["Category"] = Category_cmb.SelectedItem.ToString();
            tasksTable.Rows.Add(newRow);
        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            if (ToDoListView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ToDoListView.SelectedRows[0];
                selectedRow.Cells["Description"].Value = DescriptTB.Text;
                selectedRow.Cells["DueDate"].Value = TaskDue_dtp.Value;
                selectedRow.Cells["Priority"].Value = Priority_cmb.SelectedItem.ToString();
                selectedRow.Cells["Category"].Value = Category_cmb.SelectedItem.ToString();
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (ToDoListView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ToDoListView.SelectedRows[0];
                ToDoListView.Rows.Remove(selectedRow);
            }
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                tasksTable.WriteXml("tasks.xml");
                MessageBox.Show("Tasks saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving tasks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompleteBTN_Click(object sender, EventArgs e)
        {
            if (ToDoListView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ToDoListView.SelectedRows[0];
                selectedRow.Cells["IsComplete"].Value = true;
            }
        }

        private void LoadBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.IO.File.Exists("tasks.xml"))
                {
                    tasksTable.ReadXml("tasks.xml");
                    MessageBox.Show("Tasks loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No saved tasks found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading tasks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
