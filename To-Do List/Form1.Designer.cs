
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
            NewBTN.Location = new Point(12, 115);
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
            TitleTB.Size = new Size(680, 26);
            TitleTB.TabIndex = 2;
            // 
            // DescriptLBL
            // 
            DescriptLBL.AutoSize = true;
            DescriptLBL.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DescriptLBL.Location = new Point(12, 62);
            DescriptLBL.Name = "DescriptLBL";
            DescriptLBL.Size = new Size(99, 18);
            DescriptLBL.TabIndex = 3;
            DescriptLBL.Text = "Description:";
            // 
            // DescriptTB
            // 
            DescriptTB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescriptTB.Location = new Point(12, 83);
            DescriptTB.Name = "DescriptTB";
            DescriptTB.Size = new Size(680, 26);
            DescriptTB.TabIndex = 4;
            // 
            // EditBTN
            // 
            EditBTN.Font = new Font("Arial", 12F, FontStyle.Bold);
            EditBTN.Location = new Point(184, 115);
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
            DeleteBTN.Location = new Point(355, 115);
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
            SaveBTN.Location = new Point(527, 115);
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
            ToDoListView.Location = new Point(12, 161);
            ToDoListView.Name = "ToDoListView";
            ToDoListView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            ToDoListView.Size = new Size(680, 364);
            ToDoListView.TabIndex = 8;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 537);
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
    }
}
