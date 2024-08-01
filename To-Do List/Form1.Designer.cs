
namespace To_Do_List
{
    partial class ToDoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleLBL = new Label();
            NewBTN = new Button();
            TitleTB = new TextBox();
            DescriptLBL = new Label();
            DescriptTB = new TextBox();
            EditBTN = new Button();
            RemoveBTN = new Button();
            SaveBTN = new Button();
            ToDoListView = new DataGridView();
            PriorityLBL = new Label();
            CategoryLBL = new Label();
            TaskDue_dtp = new DateTimePicker();
            DueLBL = new Label();
            CompleteBTN = new Button();
            LoadBTN = new Button();
            Priority_cmb = new ComboBox();
            Category_cmb = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ToDoListView).BeginInit();
            SuspendLayout();
            // 
            // TitleLBL
            // 
            TitleLBL.AutoSize = true;
            TitleLBL.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TitleLBL.Location = new Point(12, 9);
            TitleLBL.Name = "TitleLBL";
            TitleLBL.Size = new Size(45, 18);
            TitleLBL.TabIndex = 0;
            TitleLBL.Text = "Title:";
            // 
            // NewBTN
            // 
            NewBTN.Font = new Font("Arial", 12F, FontStyle.Bold);
            NewBTN.Location = new Point(12, 135);
            NewBTN.Name = "NewBTN";
            NewBTN.Size = new Size(100, 31);
            NewBTN.TabIndex = 1;
            NewBTN.Text = "NEW";
            NewBTN.UseVisualStyleBackColor = true;
            NewBTN.Click += NewBTN_Click;
            // 
            // TitleTB
            // 
            TitleTB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleTB.Location = new Point(12, 30);
            TitleTB.Name = "TitleTB";
            TitleTB.Size = new Size(300, 26);
            TitleTB.TabIndex = 2;
            // 
            // DescriptLBL
            // 
            DescriptLBL.AutoSize = true;
            DescriptLBL.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DescriptLBL.Location = new Point(12, 59);
            DescriptLBL.Name = "DescriptLBL";
            DescriptLBL.Size = new Size(99, 18);
            DescriptLBL.TabIndex = 3;
            DescriptLBL.Text = "Description:";
            // 
            // DescriptTB
            // 
            DescriptTB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescriptTB.Location = new Point(12, 80);
            DescriptTB.Name = "DescriptTB";
            DescriptTB.Size = new Size(300, 26);
            DescriptTB.TabIndex = 4;
            // 
            // EditBTN
            // 
            EditBTN.Font = new Font("Arial", 12F, FontStyle.Bold);
            EditBTN.Location = new Point(118, 135);
            EditBTN.Name = "EditBTN";
            EditBTN.Size = new Size(100, 31);
            EditBTN.TabIndex = 5;
            EditBTN.Text = "EDIT";
            EditBTN.UseVisualStyleBackColor = true;
            EditBTN.Click += EditBTN_Click;
            // 
            // RemoveBTN
            // 
            RemoveBTN.Font = new Font("Arial", 12F, FontStyle.Bold);
            RemoveBTN.Location = new Point(224, 135);
            RemoveBTN.Name = "RemoveBTN";
            RemoveBTN.Size = new Size(100, 31);
            RemoveBTN.TabIndex = 6;
            RemoveBTN.Text = "REMOVE";
            RemoveBTN.UseVisualStyleBackColor = true;
            RemoveBTN.Click += DeleteBTN_Click;
            // 
            // SaveBTN
            // 
            SaveBTN.Font = new Font("Arial", 12F, FontStyle.Bold);
            SaveBTN.Location = new Point(486, 135);
            SaveBTN.Name = "SaveBTN";
            SaveBTN.Size = new Size(100, 31);
            SaveBTN.TabIndex = 7;
            SaveBTN.Text = "SAVE";
            SaveBTN.UseVisualStyleBackColor = true;
            SaveBTN.Click += SaveBTN_Click;
            // 
            // ToDoListView
            // 
            ToDoListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ToDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ToDoListView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            ToDoListView.BackgroundColor = Color.White;
            ToDoListView.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            ToDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ToDoListView.Location = new Point(12, 172);
            ToDoListView.Name = "ToDoListView";
            ToDoListView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ToDoListView.Size = new Size(680, 360);
            ToDoListView.TabIndex = 8;
            // 
            // PriorityLBL
            // 
            PriorityLBL.AutoSize = true;
            PriorityLBL.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PriorityLBL.Location = new Point(504, 61);
            PriorityLBL.Name = "PriorityLBL";
            PriorityLBL.Size = new Size(108, 18);
            PriorityLBL.TabIndex = 10;
            PriorityLBL.Text = "Task Priority:";
            // 
            // CategoryLBL
            // 
            CategoryLBL.AutoSize = true;
            CategoryLBL.Font = new Font("Arial", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CategoryLBL.Location = new Point(355, 61);
            CategoryLBL.Name = "CategoryLBL";
            CategoryLBL.Size = new Size(107, 16);
            CategoryLBL.TabIndex = 14;
            CategoryLBL.Text = "Task Category:";
            // 
            // TaskDue_dtp
            // 
            TaskDue_dtp.Location = new Point(355, 30);
            TaskDue_dtp.Name = "TaskDue_dtp";
            TaskDue_dtp.Size = new Size(200, 23);
            TaskDue_dtp.TabIndex = 17;
            // 
            // DueLBL
            // 
            DueLBL.AutoSize = true;
            DueLBL.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DueLBL.Location = new Point(355, 9);
            DueLBL.Name = "DueLBL";
            DueLBL.Size = new Size(83, 18);
            DueLBL.TabIndex = 18;
            DueLBL.Text = "Due Date:";
            // 
            // CompleteBTN
            // 
            CompleteBTN.Font = new Font("Arial", 12F, FontStyle.Bold);
            CompleteBTN.Location = new Point(330, 135);
            CompleteBTN.Name = "CompleteBTN";
            CompleteBTN.Size = new Size(100, 31);
            CompleteBTN.TabIndex = 19;
            CompleteBTN.Text = "DONE";
            CompleteBTN.UseVisualStyleBackColor = true;
            CompleteBTN.Click += CompleteBTN_Click;
            // 
            // LoadBTN
            // 
            LoadBTN.Font = new Font("Arial", 12F, FontStyle.Bold);
            LoadBTN.Location = new Point(592, 135);
            LoadBTN.Name = "LoadBTN";
            LoadBTN.Size = new Size(100, 31);
            LoadBTN.TabIndex = 20;
            LoadBTN.Text = "LOAD";
            LoadBTN.UseVisualStyleBackColor = true;
            LoadBTN.Click += LoadBTN_Click;
            // 
            // Priority_cmb
            // 
            Priority_cmb.FormattingEnabled = true;
            Priority_cmb.Items.AddRange(new object[] { "Low", "Medium", "High" });
            Priority_cmb.Location = new Point(504, 80);
            Priority_cmb.Name = "Priority_cmb";
            Priority_cmb.Size = new Size(121, 23);
            Priority_cmb.TabIndex = 21;
            // 
            // Category_cmb
            // 
            Category_cmb.FormattingEnabled = true;
            Category_cmb.Items.AddRange(new object[] { "Personal", "Business", "Home", "Shopping" });
            Category_cmb.Location = new Point(355, 80);
            Category_cmb.Name = "Category_cmb";
            Category_cmb.Size = new Size(121, 23);
            Category_cmb.TabIndex = 22;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 544);
            Controls.Add(Category_cmb);
            Controls.Add(Priority_cmb);
            Controls.Add(LoadBTN);
            Controls.Add(CompleteBTN);
            Controls.Add(DueLBL);
            Controls.Add(TaskDue_dtp);
            Controls.Add(CategoryLBL);
            Controls.Add(PriorityLBL);
            Controls.Add(ToDoListView);
            Controls.Add(SaveBTN);
            Controls.Add(RemoveBTN);
            Controls.Add(EditBTN);
            Controls.Add(DescriptTB);
            Controls.Add(DescriptLBL);
            Controls.Add(TitleTB);
            Controls.Add(NewBTN);
            Controls.Add(TitleLBL);
            Name = "ToDoList";
            Text = "To-Do List";
            Load += ToDoList_Load;
            ((System.ComponentModel.ISupportInitialize)ToDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLBL;
        private Button NewBTN;
        private TextBox TitleTB;
        private Label DescriptLBL;
        private TextBox DescriptTB;
        private Button EditBTN;
        private Button RemoveBTN;
        private Button SaveBTN;
        private DataGridView ToDoListView;
        private Label PriorityLBL;
        private Label CategoryLBL;
        private DateTimePicker TaskDue_dtp;
        private Label DueLBL;
        private Button CompleteBTN;
        private Button LoadBTN;
        private ComboBox Priority_cmb;
        private ComboBox Category_cmb;
    }
}
