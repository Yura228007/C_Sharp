namespace Project100924
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
            button_add = new Button();
            listBox_lines = new ListBox();
            textBox_line = new TextBox();
            listBox_selectedLines = new ListBox();
            button_relocate = new Button();
            SuspendLayout();
            // 
            // button_add
            // 
            button_add.Font = new Font("Segoe UI", 14F);
            button_add.Location = new Point(284, 140);
            button_add.Name = "button_add";
            button_add.Size = new Size(112, 35);
            button_add.TabIndex = 0;
            button_add.Text = "добавить";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // listBox_lines
            // 
            listBox_lines.Font = new Font("Segoe UI", 14F);
            listBox_lines.FormattingEnabled = true;
            listBox_lines.ItemHeight = 25;
            listBox_lines.Location = new Point(92, 178);
            listBox_lines.Name = "listBox_lines";
            listBox_lines.SelectionMode = SelectionMode.MultiSimple;
            listBox_lines.Size = new Size(186, 104);
            listBox_lines.TabIndex = 1;
            // 
            // textBox_line
            // 
            textBox_line.Font = new Font("Segoe UI", 14F);
            textBox_line.Location = new Point(92, 140);
            textBox_line.Name = "textBox_line";
            textBox_line.Size = new Size(186, 32);
            textBox_line.TabIndex = 2;
            // 
            // listBox_selectedLines
            // 
            listBox_selectedLines.Font = new Font("Segoe UI", 14F);
            listBox_selectedLines.FormattingEnabled = true;
            listBox_selectedLines.ItemHeight = 25;
            listBox_selectedLines.Location = new Point(436, 179);
            listBox_selectedLines.Name = "listBox_selectedLines";
            listBox_selectedLines.SelectionMode = SelectionMode.MultiSimple;
            listBox_selectedLines.Size = new Size(186, 104);
            listBox_selectedLines.TabIndex = 1;
            // 
            // button_relocate
            // 
            button_relocate.Font = new Font("Segoe UI", 14F);
            button_relocate.Location = new Point(298, 209);
            button_relocate.Name = "button_relocate";
            button_relocate.Size = new Size(119, 38);
            button_relocate.TabIndex = 3;
            button_relocate.Text = "перенести";
            button_relocate.UseVisualStyleBackColor = true;
            button_relocate.Click += button_relocate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_relocate);
            Controls.Add(textBox_line);
            Controls.Add(listBox_selectedLines);
            Controls.Add(listBox_lines);
            Controls.Add(button_add);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_add;
        private ListBox listBox_lines;
        private TextBox textBox_line;
        private ListBox listBox_selectedLines;
        private Button button_relocate;
    }
}
