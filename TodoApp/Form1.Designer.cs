namespace TodoApp
{
    partial class Form1
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
            DescriptionBox = new TextBox();
            AddButton = new Button();
            StartDateBox = new DateTimePicker();
            Header = new Label();
            SearchTodo = new Button();
            SearchBox = new TextBox();
            Title = new Label();
            TitleBox = new TextBox();
            Description = new Label();
            StartDate = new Label();
            EndDate = new Label();
            EndDateBox = new DateTimePicker();
            LoadAllTodo = new Button();
            DeleteTodo = new Button();
            EditTodo = new Button();
            TodoView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TodoView).BeginInit();
            SuspendLayout();
            // 
            // DescriptionBox
            // 
            DescriptionBox.AllowDrop = true;
            DescriptionBox.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionBox.Location = new Point(12, 249);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(1452, 62);
            DescriptionBox.TabIndex = 0;
            DescriptionBox.TextChanged += DescriptionBox_TextChanged;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(12, 359);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(140, 59);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add/Update";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click_1;
            // 
            // StartDateBox
            // 
            StartDateBox.AllowDrop = true;
            StartDateBox.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            StartDateBox.Location = new Point(1157, 137);
            StartDateBox.Name = "StartDateBox";
            StartDateBox.Size = new Size(307, 33);
            StartDateBox.TabIndex = 16;
            // 
            // Header
            // 
            Header.AllowDrop = true;
            Header.BackColor = Color.Khaki;
            Header.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(1477, 71);
            Header.TabIndex = 3;
            Header.Text = "TODO_LIST!";
            Header.TextAlign = ContentAlignment.BottomRight;
            // 
            // SearchTodo
            // 
            SearchTodo.AllowDrop = true;
            SearchTodo.AutoSize = true;
            SearchTodo.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTodo.Location = new Point(12, 21);
            SearchTodo.Name = "SearchTodo";
            SearchTodo.Size = new Size(140, 35);
            SearchTodo.TabIndex = 4;
            SearchTodo.Text = "Search";
            SearchTodo.UseVisualStyleBackColor = true;
            SearchTodo.Click += SearchTodo_Click_1;
            // 
            // SearchBox
            // 
            SearchBox.AllowDrop = true;
            SearchBox.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            SearchBox.Location = new Point(139, 21);
            SearchBox.Multiline = true;
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(247, 35);
            SearchBox.TabIndex = 5;
            SearchBox.Text = "enter task name";
            SearchBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Title
            // 
            Title.AllowDrop = true;
            Title.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.Black;
            Title.Location = new Point(12, 93);
            Title.Name = "Title";
            Title.Size = new Size(103, 50);
            Title.TabIndex = 6;
            Title.Text = "Title:";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TitleBox
            // 
            TitleBox.AllowDrop = true;
            TitleBox.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TitleBox.Location = new Point(12, 143);
            TitleBox.Multiline = true;
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(374, 50);
            TitleBox.TabIndex = 7;
            // 
            // Description
            // 
            Description.AllowDrop = true;
            Description.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Description.Location = new Point(12, 196);
            Description.Name = "Description";
            Description.Size = new Size(193, 50);
            Description.TabIndex = 8;
            Description.Text = "Description:";
            Description.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartDate
            // 
            StartDate.AllowDrop = true;
            StartDate.BackColor = SystemColors.MenuHighlight;
            StartDate.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            StartDate.Location = new Point(1056, 137);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(105, 33);
            StartDate.TabIndex = 9;
            StartDate.Text = "Start Date";
            StartDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EndDate
            // 
            EndDate.AllowDrop = true;
            EndDate.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EndDate.Location = new Point(1066, 181);
            EndDate.Name = "EndDate";
            EndDate.Size = new Size(95, 33);
            EndDate.TabIndex = 17;
            EndDate.Text = "End Date";
            EndDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EndDateBox
            // 
            EndDateBox.CalendarFont = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EndDateBox.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EndDateBox.Location = new Point(1157, 181);
            EndDateBox.Name = "EndDateBox";
            EndDateBox.Size = new Size(307, 33);
            EndDateBox.TabIndex = 16;
            // 
            // LoadAllTodo
            // 
            LoadAllTodo.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LoadAllTodo.Location = new Point(183, 359);
            LoadAllTodo.Name = "LoadAllTodo";
            LoadAllTodo.Size = new Size(150, 59);
            LoadAllTodo.TabIndex = 18;
            LoadAllTodo.Text = "Load All Todo";
            LoadAllTodo.UseVisualStyleBackColor = true;
            LoadAllTodo.Click += LoadAllTodo_Click_1;
            // 
            // DeleteTodo
            // 
            DeleteTodo.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteTodo.Location = new Point(379, 359);
            DeleteTodo.Name = "DeleteTodo";
            DeleteTodo.Size = new Size(161, 59);
            DeleteTodo.TabIndex = 19;
            DeleteTodo.Text = "Delete Selected";
            DeleteTodo.UseVisualStyleBackColor = true;
            DeleteTodo.Click += DeleteTodo_Click_1;
            // 
            // EditTodo
            // 
            EditTodo.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EditTodo.Location = new Point(595, 359);
            EditTodo.Name = "EditTodo";
            EditTodo.Size = new Size(141, 59);
            EditTodo.TabIndex = 20;
            EditTodo.Text = "Edit Selected";
            EditTodo.UseVisualStyleBackColor = true;
            EditTodo.Click += EditTodo_Click_1;
            // 
            // TodoView
            // 
            TodoView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TodoView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TodoView.Location = new Point(12, 424);
            TodoView.Name = "TodoView";
            TodoView.RowHeadersWidth = 62;
            TodoView.RowTemplate.Height = 33;
            TodoView.Size = new Size(1452, 614);
            TodoView.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1476, 1050);
            Controls.Add(TodoView);
            Controls.Add(EditTodo);
            Controls.Add(DeleteTodo);
            Controls.Add(LoadAllTodo);
            Controls.Add(EndDateBox);
            Controls.Add(EndDate);
            Controls.Add(StartDate);
            Controls.Add(Description);
            Controls.Add(TitleBox);
            Controls.Add(Title);
            Controls.Add(SearchBox);
            Controls.Add(SearchTodo);
            Controls.Add(Header);
            Controls.Add(StartDateBox);
            Controls.Add(AddButton);
            Controls.Add(DescriptionBox);
            Name = "Form1";
            Text = "Todo App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)TodoView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DescriptionBox;
        private Button AddButton;
        private DateTimePicker StartDateBox;
        private Label Header;
        private Button SearchTodo;
        private TextBox SearchBox;
        private Label Title;
        private TextBox TitleBox;
        private Label Description;
        private Label StartDate;
        private Label EndDate;
        private DateTimePicker EndDateBox;
        private Button LoadAllTodo;
        private Button DeleteTodo;
        private Button EditTodo;
        private DataGridView TodoView;
    }
}