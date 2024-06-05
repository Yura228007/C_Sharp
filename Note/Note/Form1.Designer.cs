namespace Note
{
    partial class Note_Main
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
            text_title = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            text_data = new TextBox();
            button_save = new Button();
            button_clear = new Button();
            show_result = new Label();
            SuspendLayout();
            // 
            // text_title
            // 
            text_title.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            text_title.Location = new Point(12, 16);
            text_title.MaxLength = 128;
            text_title.Name = "text_title";
            text_title.Size = new Size(306, 29);
            text_title.TabIndex = 0;
            text_title.Enter += text_title_Enter;
            text_title.Leave += text_title_Leave;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(186, 54);
            comboBox1.MaxLength = 32;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 24);
            comboBox1.TabIndex = 1;
            comboBox1.Enter += comboBox1_Enter;
            comboBox1.Leave += comboBox1_Leave;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F);
            dateTimePicker1.Location = new Point(12, 54);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(168, 25);
            dateTimePicker1.TabIndex = 2;
            // 
            // text_data
            // 
            text_data.AcceptsReturn = true;
            text_data.AcceptsTab = true;
            text_data.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            text_data.Location = new Point(12, 83);
            text_data.MaxLength = 1024;
            text_data.Multiline = true;
            text_data.Name = "text_data";
            text_data.ScrollBars = ScrollBars.Vertical;
            text_data.Size = new Size(306, 250);
            text_data.TabIndex = 3;
            text_data.Enter += text_data_Enter;
            text_data.Leave += text_data_Leave;
            // 
            // button_save
            // 
            button_save.Font = new Font("Segoe UI", 12F);
            button_save.Location = new Point(158, 339);
            button_save.Name = "button_save";
            button_save.Size = new Size(160, 42);
            button_save.TabIndex = 4;
            button_save.Text = "Сохранить";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_clear
            // 
            button_clear.Font = new Font("Segoe UI", 12F);
            button_clear.Location = new Point(12, 339);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(127, 42);
            button_clear.TabIndex = 5;
            button_clear.Text = "Очистить поля";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // show_result
            // 
            show_result.AutoSize = true;
            show_result.BackColor = Color.Coral;
            show_result.Font = new Font("Segoe UI", 26.24F);
            show_result.Location = new Point(12, 384);
            show_result.Name = "show_result";
            show_result.Size = new Size(302, 47);
            show_result.TabIndex = 6;
            show_result.Text = "Сделайте заметку";
            show_result.TextAlign = ContentAlignment.TopCenter;
            show_result.Click += show_result_Click;
            // 
            // Note_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 441);
            Controls.Add(show_result);
            Controls.Add(button_clear);
            Controls.Add(button_save);
            Controls.Add(text_data);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(text_title);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Note_Main";
            Text = "Заметки";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text_title;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox text_data;
        private Button button_save;
        private Button button_clear;
        private Label show_result;
    }
}
