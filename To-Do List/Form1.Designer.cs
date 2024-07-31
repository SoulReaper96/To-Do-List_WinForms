
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
            DeleteBTN = new Button();
            SaveBTN = new Button();
            ToDoListView = new DataGridView();
            Low_chk = new CheckBox();
            PriorityLBL = new Label();
            Medium_chk = new CheckBox();
            High_chk = new CheckBox();
            Shopping_chk = new CheckBox();
            Work_chk = new CheckBox();
            CategoryLBL = new Label();
            Personal_chk = new CheckBox();
            TaskDue_dtp = new DateTimePicker();
            DueLBL = new Label();
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
            NewBTN.Size = new Size(165, 31);
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
            EditBTN.Location = new Point(184, 135);
            EditBTN.Name = "EditBTN";
            EditBTN.Size = new Size(165, 31);
            EditBTN.TabIndex = 5;
            EditBTN.Text = "EDIT";
            EditBTN.UseVisualStyleBackColor = true;
            EditBTN.Click += EditBTN_Click;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Font = new Font("Arial", 12F, FontStyle.Bold);
            DeleteBTN.Location = new Point(355, 135);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(165, 31);
            DeleteBTN.TabIndex = 6;
            DeleteBTN.Text = "DELETE";
            DeleteBTN.UseVisualStyleBackColor = true;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // SaveBTN
            // 
            SaveBTN.Font = new Font("Arial", 12F, FontStyle.Bold);
            SaveBTN.Location = new Point(527, 135);
            SaveBTN.Name = "SaveBTN";
            SaveBTN.Size = new Size(165, 31);
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
            ToDoListView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            ToDoListView.Size = new Size(680, 360);
            ToDoListView.TabIndex = 8;
            // 
            // Low_chk
            // 
            Low_chk.AutoSize = true;
            Low_chk.Location = new Point(504, 82);
            Low_chk.Name = "Low_chk";
            Low_chk.Size = new Size(48, 19);
            Low_chk.TabIndex = 9;
            Low_chk.Text = "Low";
            Low_chk.UseVisualStyleBackColor = true;
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
            // Medium_chk
            // 
            Medium_chk.AutoSize = true;
            Medium_chk.Location = new Point(558, 82);
            Medium_chk.Name = "Medium_chk";
            Medium_chk.Size = new Size(71, 19);
            Medium_chk.TabIndex = 11;
            Medium_chk.Text = "Medium";
            Medium_chk.UseVisualStyleBackColor = true;
            // 
            // High_chk
            // 
            High_chk.AutoSize = true;
            High_chk.Location = new Point(504, 107);
            High_chk.Name = "High_chk";
            High_chk.Size = new Size(52, 19);
            High_chk.TabIndex = 12;
            High_chk.Text = "High";
            High_chk.UseVisualStyleBackColor = true;
            // 
            // Shopping_chk
            // 
            Shopping_chk.AutoSize = true;
            Shopping_chk.Location = new Point(355, 107);
            Shopping_chk.Name = "Shopping_chk";
            Shopping_chk.Size = new Size(77, 19);
            Shopping_chk.TabIndex = 16;
            Shopping_chk.Text = "Shopping";
            Shopping_chk.UseVisualStyleBackColor = true;
            // 
            // Work_chk
            // 
            Work_chk.AutoSize = true;
            Work_chk.Location = new Point(432, 82);
            Work_chk.Name = "Work_chk";
            Work_chk.Size = new Size(54, 19);
            Work_chk.TabIndex = 15;
            Work_chk.Text = "Work";
            Work_chk.UseVisualStyleBackColor = true;
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
            // Personal_chk
            // 
            Personal_chk.AutoSize = true;
            Personal_chk.Location = new Point(355, 82);
            Personal_chk.Name = "Personal_chk";
            Personal_chk.Size = new Size(71, 19);
            Personal_chk.TabIndex = 13;
            Personal_chk.Text = "Personal";
            Personal_chk.UseVisualStyleBackColor = true;
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
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 544);
            Controls.Add(DueLBL);
            Controls.Add(TaskDue_dtp);
            Controls.Add(Shopping_chk);
            Controls.Add(Work_chk);
            Controls.Add(CategoryLBL);
            Controls.Add(Personal_chk);
            Controls.Add(High_chk);
            Controls.Add(Medium_chk);
            Controls.Add(PriorityLBL);
            Controls.Add(Low_chk);
            Controls.Add(ToDoListView);
            Controls.Add(SaveBTN);
            Controls.Add(DeleteBTN);
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
        private Button DeleteBTN;
        private Button SaveBTN;
        private DataGridView ToDoListView;
        private CheckBox Low_chk;
        private Label PriorityLBL;
        private CheckBox Medium_chk;
        private CheckBox High_chk;
        private CheckBox Shopping_chk;
        private CheckBox Work_chk;
        private Label CategoryLBL;
        private CheckBox Personal_chk;
        private DateTimePicker TaskDue_dtp;
        private Label DueLBL;
    }
}
