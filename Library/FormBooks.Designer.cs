namespace Library
{
    partial class FormBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            flowLayoutPanelTop = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonLoan = new Button();
            labelName = new Label();
            buttonLogout = new Button();
            dataGridViewBooks = new DataGridView();
            panelTop.SuspendLayout();
            flowLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.AliceBlue;
            panelTop.Controls.Add(flowLayoutPanelTop);
            panelTop.Controls.Add(labelName);
            panelTop.Controls.Add(buttonLogout);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(964, 85);
            panelTop.TabIndex = 0;
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.Controls.Add(buttonAdd);
            flowLayoutPanelTop.Controls.Add(buttonEdit);
            flowLayoutPanelTop.Controls.Add(buttonDelete);
            flowLayoutPanelTop.Controls.Add(buttonLoan);
            flowLayoutPanelTop.Dock = DockStyle.Left;
            flowLayoutPanelTop.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Size = new Size(713, 85);
            flowLayoutPanelTop.TabIndex = 7;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(74, 111, 165);
            buttonAdd.Dock = DockStyle.Right;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Location = new Point(3, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(148, 71);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(74, 111, 165);
            buttonEdit.Dock = DockStyle.Right;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Location = new Point(157, 3);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(148, 71);
            buttonEdit.TabIndex = 7;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += ButtonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(74, 111, 165);
            buttonDelete.Dock = DockStyle.Right;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Location = new Point(311, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(148, 71);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // buttonLoan
            // 
            buttonLoan.BackColor = Color.FromArgb(74, 111, 165);
            buttonLoan.Dock = DockStyle.Right;
            buttonLoan.FlatStyle = FlatStyle.Flat;
            buttonLoan.Location = new Point(465, 3);
            buttonLoan.Name = "buttonLoan";
            buttonLoan.Size = new Size(148, 71);
            buttonLoan.TabIndex = 9;
            buttonLoan.Text = "Займ книг";
            buttonLoan.UseVisualStyleBackColor = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Dock = DockStyle.Right;
            labelName.Location = new Point(771, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(45, 19);
            labelName.TabIndex = 6;
            labelName.Text = "label1";
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.FromArgb(74, 111, 165);
            buttonLogout.Dock = DockStyle.Right;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Location = new Point(816, 0);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(148, 85);
            buttonLogout.TabIndex = 5;
            buttonLogout.Text = "Выйти";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += ButtonLogout_Click;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.AllowUserToAddRows = false;
            dataGridViewBooks.AllowUserToDeleteRows = false;
            dataGridViewBooks.AllowUserToResizeColumns = false;
            dataGridViewBooks.AllowUserToResizeRows = false;
            dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewBooks.BackgroundColor = Color.White;
            dataGridViewBooks.BorderStyle = BorderStyle.None;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.ColumnHeadersVisible = false;
            dataGridViewBooks.Dock = DockStyle.Fill;
            dataGridViewBooks.Location = new Point(10, 95);
            dataGridViewBooks.MultiSelect = false;
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.ReadOnly = true;
            dataGridViewBooks.RowHeadersVisible = false;
            dataGridViewBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooks.Size = new Size(964, 456);
            dataGridViewBooks.TabIndex = 1;
            // 
            // FormBooks
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 561);
            Controls.Add(dataGridViewBooks);
            Controls.Add(panelTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormBooks";
            Padding = new Padding(10);
            Text = "Книги";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            flowLayoutPanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button buttonLogout;
        private Label labelName;
        private DataGridView dataGridViewBooks;
        private FlowLayoutPanel flowLayoutPanelTop;
        private Button buttonAdd;
        private Button button2;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonLoan;
    }
}