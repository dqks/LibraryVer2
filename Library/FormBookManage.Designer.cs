namespace Library
{
    partial class FormBookManage
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
            flowLayoutPanelButtons = new FlowLayoutPanel();
            buttonSave = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            textBoxIsbn = new TextBox();
            textBoxName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxPublicYear = new TextBox();
            label5 = new Label();
            textBoxPageAmount = new TextBox();
            label6 = new Label();
            textBoxAvailableExamples = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBoxExamplesAmount = new TextBox();
            label9 = new Label();
            label10 = new Label();
            comboBoxAuthor = new ComboBox();
            comboBoxGenre = new ComboBox();
            comboBoxPublisher = new ComboBox();
            richTextBoxAnnotation = new RichTextBox();
            flowLayoutPanelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelButtons
            // 
            flowLayoutPanelButtons.Controls.Add(buttonSave);
            flowLayoutPanelButtons.Controls.Add(buttonCancel);
            flowLayoutPanelButtons.Dock = DockStyle.Bottom;
            flowLayoutPanelButtons.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelButtons.Location = new Point(0, 661);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Padding = new Padding(10);
            flowLayoutPanelButtons.Size = new Size(584, 100);
            flowLayoutPanelButtons.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(74, 111, 165);
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Dock = DockStyle.Right;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Location = new Point(13, 13);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(148, 71);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(74, 111, 165);
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Dock = DockStyle.Right;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Location = new Point(167, 13);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(148, 71);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 21);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 1;
            label1.Text = "ISBN";
            // 
            // textBoxIsbn
            // 
            textBoxIsbn.Location = new Point(272, 18);
            textBoxIsbn.Name = "textBoxIsbn";
            textBoxIsbn.Size = new Size(286, 26);
            textBoxIsbn.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(272, 73);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(286, 26);
            textBoxName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 76);
            label2.Name = "label2";
            label2.Size = new Size(117, 19);
            label2.TabIndex = 3;
            label2.Text = "Название книги";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 186);
            label3.Name = "label3";
            label3.Size = new Size(47, 19);
            label3.TabIndex = 5;
            label3.Text = "Жанр";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 241);
            label4.Name = "label4";
            label4.Size = new Size(100, 19);
            label4.TabIndex = 7;
            label4.Text = "Издательство";
            // 
            // textBoxPublicYear
            // 
            textBoxPublicYear.Location = new Point(272, 293);
            textBoxPublicYear.Name = "textBoxPublicYear";
            textBoxPublicYear.Size = new Size(286, 26);
            textBoxPublicYear.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 296);
            label5.Name = "label5";
            label5.Size = new Size(92, 19);
            label5.TabIndex = 9;
            label5.Text = "Год издания";
            // 
            // textBoxPageAmount
            // 
            textBoxPageAmount.Location = new Point(272, 348);
            textBoxPageAmount.Name = "textBoxPageAmount";
            textBoxPageAmount.Size = new Size(286, 26);
            textBoxPageAmount.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 351);
            label6.Name = "label6";
            label6.Size = new Size(69, 19);
            label6.TabIndex = 11;
            label6.Text = "Страниц";
            // 
            // textBoxAvailableExamples
            // 
            textBoxAvailableExamples.Location = new Point(272, 458);
            textBoxAvailableExamples.Name = "textBoxAvailableExamples";
            textBoxAvailableExamples.Size = new Size(286, 26);
            textBoxAvailableExamples.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 461);
            label7.Name = "label7";
            label7.Size = new Size(164, 19);
            label7.TabIndex = 13;
            label7.Text = "Доступно экземпляров";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 131);
            label8.Name = "label8";
            label8.Size = new Size(51, 19);
            label8.TabIndex = 15;
            label8.Text = "Автор";
            // 
            // textBoxExamplesAmount
            // 
            textBoxExamplesAmount.Location = new Point(272, 403);
            textBoxExamplesAmount.Name = "textBoxExamplesAmount";
            textBoxExamplesAmount.Size = new Size(286, 26);
            textBoxExamplesAmount.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 406);
            label9.Name = "label9";
            label9.Size = new Size(136, 19);
            label9.TabIndex = 17;
            label9.Text = "Всего экземпляров";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 546);
            label10.Name = "label10";
            label10.Size = new Size(85, 19);
            label10.TabIndex = 19;
            label10.Text = "Аннотация";
            // 
            // comboBoxAuthor
            // 
            comboBoxAuthor.FormattingEnabled = true;
            comboBoxAuthor.Location = new Point(272, 128);
            comboBoxAuthor.Name = "comboBoxAuthor";
            comboBoxAuthor.Size = new Size(286, 27);
            comboBoxAuthor.TabIndex = 21;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(272, 178);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(286, 27);
            comboBoxGenre.TabIndex = 22;
            // 
            // comboBoxPublisher
            // 
            comboBoxPublisher.FormattingEnabled = true;
            comboBoxPublisher.Location = new Point(272, 233);
            comboBoxPublisher.Name = "comboBoxPublisher";
            comboBoxPublisher.Size = new Size(286, 27);
            comboBoxPublisher.TabIndex = 23;
            // 
            // richTextBoxAnnotation
            // 
            richTextBoxAnnotation.Location = new Point(272, 513);
            richTextBoxAnnotation.Name = "richTextBoxAnnotation";
            richTextBoxAnnotation.Size = new Size(286, 96);
            richTextBoxAnnotation.TabIndex = 24;
            richTextBoxAnnotation.Text = "";
            // 
            // FormBookManage
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 761);
            Controls.Add(richTextBoxAnnotation);
            Controls.Add(comboBoxPublisher);
            Controls.Add(comboBoxGenre);
            Controls.Add(comboBoxAuthor);
            Controls.Add(label10);
            Controls.Add(textBoxExamplesAmount);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBoxAvailableExamples);
            Controls.Add(label7);
            Controls.Add(textBoxPageAmount);
            Controls.Add(label6);
            Controls.Add(textBoxPublicYear);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(textBoxIsbn);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanelButtons);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormBookManage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление книги";
            flowLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelButtons;
        private Button buttonSave;
        private Button buttonCancel;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        public TextBox textBoxName;
        public TextBox textBoxPublicYear;
        public TextBox textBoxIsbn;
        public TextBox textBoxPageAmount;
        public TextBox textBoxAvailableExamples;
        public TextBox textBoxExamplesAmount;
        public ComboBox comboBoxAuthor;
        public ComboBox comboBoxGenre;
        public ComboBox comboBoxPublisher;
        public RichTextBox richTextBoxAnnotation;
    }
}