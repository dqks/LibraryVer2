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
            labelName = new Label();
            buttonLogout = new Button();
            dataGridViewBooks = new DataGridView();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.AliceBlue;
            panelTop.Controls.Add(labelName);
            panelTop.Controls.Add(buttonLogout);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(964, 71);
            panelTop.TabIndex = 0;
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
            buttonLogout.Size = new Size(148, 71);
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
            dataGridViewBooks.Location = new Point(10, 81);
            dataGridViewBooks.MultiSelect = false;
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.ReadOnly = true;
            dataGridViewBooks.RowHeadersVisible = false;
            dataGridViewBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooks.Size = new Size(964, 470);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button buttonLogout;
        private Label labelName;
        private DataGridView dataGridViewBooks;
    }
}