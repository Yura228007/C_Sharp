namespace Project_050924
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
            label1 = new Label();
            textBox_fio = new TextBox();
            textBox_old = new TextBox();
            label2 = new Label();
            textBox_work = new TextBox();
            label3 = new Label();
            textBox_numberTelephone = new TextBox();
            label4 = new Label();
            textBox_homeNumber = new TextBox();
            checkBox_homeNumber = new CheckBox();
            radioButton_man = new RadioButton();
            radioButton_women = new RadioButton();
            label5 = new Label();
            button_save = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 86);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "ФИО";
            // 
            // textBox_fio
            // 
            textBox_fio.Location = new Point(225, 83);
            textBox_fio.Name = "textBox_fio";
            textBox_fio.Size = new Size(100, 23);
            textBox_fio.TabIndex = 1;
            // 
            // textBox_old
            // 
            textBox_old.Location = new Point(225, 112);
            textBox_old.Name = "textBox_old";
            textBox_old.Size = new Size(100, 23);
            textBox_old.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 115);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Возраст";
            // 
            // textBox_work
            // 
            textBox_work.Location = new Point(225, 141);
            textBox_work.Name = "textBox_work";
            textBox_work.Size = new Size(100, 23);
            textBox_work.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 144);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 4;
            label3.Text = "Место работы";
            // 
            // textBox_numberTelephone
            // 
            textBox_numberTelephone.Location = new Point(225, 170);
            textBox_numberTelephone.Name = "textBox_numberTelephone";
            textBox_numberTelephone.Size = new Size(100, 23);
            textBox_numberTelephone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 173);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 6;
            label4.Text = "Номер телефона";
            // 
            // textBox_homeNumber
            // 
            textBox_homeNumber.Location = new Point(225, 199);
            textBox_homeNumber.Name = "textBox_homeNumber";
            textBox_homeNumber.ReadOnly = true;
            textBox_homeNumber.Size = new Size(100, 23);
            textBox_homeNumber.TabIndex = 9;
            // 
            // checkBox_homeNumber
            // 
            checkBox_homeNumber.AutoSize = true;
            checkBox_homeNumber.Location = new Point(81, 201);
            checkBox_homeNumber.Name = "checkBox_homeNumber";
            checkBox_homeNumber.Size = new Size(138, 19);
            checkBox_homeNumber.TabIndex = 10;
            checkBox_homeNumber.Text = "Домашний телефон";
            checkBox_homeNumber.UseVisualStyleBackColor = true;
            checkBox_homeNumber.CheckedChanged += checkBox_homeNumber_CheckedChanged;
            // 
            // radioButton_man
            // 
            radioButton_man.AutoSize = true;
            radioButton_man.Location = new Point(167, 228);
            radioButton_man.Name = "radioButton_man";
            radioButton_man.Size = new Size(77, 19);
            radioButton_man.TabIndex = 11;
            radioButton_man.TabStop = true;
            radioButton_man.Text = "Мужской";
            radioButton_man.UseVisualStyleBackColor = true;
            radioButton_man.CheckedChanged += radioButton_man_CheckedChanged;
            // 
            // radioButton_women
            // 
            radioButton_women.AutoSize = true;
            radioButton_women.Location = new Point(250, 228);
            radioButton_women.Name = "radioButton_women";
            radioButton_women.Size = new Size(75, 19);
            radioButton_women.TabIndex = 12;
            radioButton_women.TabStop = true;
            radioButton_women.Text = "Женский";
            radioButton_women.UseVisualStyleBackColor = true;
            radioButton_women.CheckedChanged += radioButton_women_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 230);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 13;
            label5.Text = "Пол";
            // 
            // button_save
            // 
            button_save.Location = new Point(185, 253);
            button_save.Name = "button_save";
            button_save.Size = new Size(140, 39);
            button_save.TabIndex = 14;
            button_save.Text = "Сохранить";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_save);
            Controls.Add(label5);
            Controls.Add(radioButton_women);
            Controls.Add(radioButton_man);
            Controls.Add(checkBox_homeNumber);
            Controls.Add(textBox_homeNumber);
            Controls.Add(textBox_numberTelephone);
            Controls.Add(label4);
            Controls.Add(textBox_work);
            Controls.Add(label3);
            Controls.Add(textBox_old);
            Controls.Add(label2);
            Controls.Add(textBox_fio);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_fio;
        private TextBox textBox_old;
        private Label label2;
        private TextBox textBox_work;
        private Label label3;
        private TextBox textBox_numberTelephone;
        private Label label4;
        private TextBox textBox_homeNumber;
        private CheckBox checkBox_homeNumber;
        private RadioButton radioButton_man;
        private RadioButton radioButton_women;
        private Label label5;
        private Button button_save;
    }
}
