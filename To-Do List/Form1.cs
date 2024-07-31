using System.Data;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        DataTable todoList = new();
        DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();

        bool isEditing = false;
        private void ToDoList_Load(object sender, EventArgs e)
        {
            checkBoxColumn.Name = "chk_column";
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Create columns
            ToDoListView.Columns.Add(checkBoxColumn);
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");
            // Point our datagridview to our datasource
            ToDoListView.DataSource = todoList;
        }

        private void NewBTN_Click(object sender, EventArgs e)
        {
            TitleTB.Text = "";
            DescriptTB.Text = "";
        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            isEditing = true;

            // Fill text fields with data from table
            TitleTB.Text = todoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            DescriptTB.Text = todoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();

        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[ToDoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Title"] = TitleTB.Text;
                todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Description"] = DescriptTB.Text;
            }
            else
            {
                todoList.Rows.Add(TitleTB.Text, DescriptTB.Text);
            }
            // Clear fields
            TitleTB.Text = "";
            DescriptTB.Text = "";
            isEditing = false;
        }
    }
}
