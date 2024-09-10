namespace LoginPassword
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
            button_login1 = new Button();
            button_reg1 = new Button();
            textBox_password1 = new TextBox();
            button_save = new Button();
            label5 = new Label();
            radioButton_women = new RadioButton();
            radioButton_man = new RadioButton();
            checkBox_homeNumber = new CheckBox();
            textBox_homeNumber = new TextBox();
            textBox_numberTelephone = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox_fio = new TextBox();
            label1 = new Label();
            numericUpDown_old = new NumericUpDown();
            textBox_login2 = new TextBox();
            textBox_password2 = new TextBox();
            label_login = new Label();
            label_password = new Label();
            button_login2 = new Button();
            button_back = new Button();
            comboBox_login1 = new ComboBox();
            comboBox_work = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_old).BeginInit();
            SuspendLayout();
            // 
            // button_login1
            // 
            button_login1.Font = new Font("Segoe UI", 14F);
            button_login1.Location = new Point(127, 196);
            button_login1.Name = "button_login1";
            button_login1.Size = new Size(139, 34);
            button_login1.TabIndex = 0;
            button_login1.Text = "войти";
            button_login1.UseVisualStyleBackColor = true;
            button_login1.Click += button_login1_Click;
            // 
            // button_reg1
            // 
            button_reg1.Font = new Font("Segoe UI", 14F);
            button_reg1.Location = new Point(272, 196);
            button_reg1.Name = "button_reg1";
            button_reg1.Size = new Size(139, 34);
            button_reg1.TabIndex = 1;
            button_reg1.Text = "регистрация";
            button_reg1.UseVisualStyleBackColor = true;
            button_reg1.Click += button_reg1_Click;
            // 
            // textBox_password1
            // 
            textBox_password1.Font = new Font("Segoe UI", 14F);
            textBox_password1.Location = new Point(127, 274);
            textBox_password1.Name = "textBox_password1";
            textBox_password1.PasswordChar = '*';
            textBox_password1.Size = new Size(284, 32);
            textBox_password1.TabIndex = 2;
            textBox_password1.Visible = false;
            // 
            // button_save
            // 
            button_save.Font = new Font("Segoe UI", 14F);
            button_save.Location = new Point(638, 368);
            button_save.Name = "button_save";
            button_save.Size = new Size(229, 44);
            button_save.TabIndex = 28;
            button_save.Text = "Сохранить";
            button_save.UseVisualStyleBackColor = true;
            button_save.Visible = false;
            button_save.Click += button_save_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(580, 335);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 27;
            label5.Text = "Пол";
            label5.Visible = false;
            // 
            // radioButton_women
            // 
            radioButton_women.AutoSize = true;
            radioButton_women.Font = new Font("Segoe UI", 14F);
            radioButton_women.Location = new Point(760, 333);
            radioButton_women.Name = "radioButton_women";
            radioButton_women.Size = new Size(107, 29);
            radioButton_women.TabIndex = 26;
            radioButton_women.TabStop = true;
            radioButton_women.Text = "Женский";
            radioButton_women.UseVisualStyleBackColor = true;
            radioButton_women.Visible = false;
            // 
            // radioButton_man
            // 
            radioButton_man.AutoSize = true;
            radioButton_man.Font = new Font("Segoe UI", 14F);
            radioButton_man.Location = new Point(644, 333);
            radioButton_man.Name = "radioButton_man";
            radioButton_man.Size = new Size(110, 29);
            radioButton_man.TabIndex = 25;
            radioButton_man.TabStop = true;
            radioButton_man.Text = "Мужской";
            radioButton_man.UseVisualStyleBackColor = true;
            radioButton_man.Visible = false;
            radioButton_man.CheckedChanged += radioButton_man_CheckedChanged;
            // 
            // checkBox_homeNumber
            // 
            checkBox_homeNumber.AutoSize = true;
            checkBox_homeNumber.Font = new Font("Segoe UI", 14F);
            checkBox_homeNumber.Location = new Point(468, 295);
            checkBox_homeNumber.Name = "checkBox_homeNumber";
            checkBox_homeNumber.Size = new Size(204, 29);
            checkBox_homeNumber.TabIndex = 24;
            checkBox_homeNumber.Text = "Домашний телефон";
            checkBox_homeNumber.UseVisualStyleBackColor = true;
            checkBox_homeNumber.Visible = false;
            checkBox_homeNumber.CheckedChanged += checkBox_homeNumber_CheckedChanged;
            // 
            // textBox_homeNumber
            // 
            textBox_homeNumber.Font = new Font("Segoe UI", 14F);
            textBox_homeNumber.Location = new Point(678, 295);
            textBox_homeNumber.Name = "textBox_homeNumber";
            textBox_homeNumber.ReadOnly = true;
            textBox_homeNumber.Size = new Size(189, 32);
            textBox_homeNumber.TabIndex = 23;
            textBox_homeNumber.Visible = false;
            // 
            // textBox_numberTelephone
            // 
            textBox_numberTelephone.Font = new Font("Segoe UI", 14F);
            textBox_numberTelephone.Location = new Point(678, 255);
            textBox_numberTelephone.Name = "textBox_numberTelephone";
            textBox_numberTelephone.Size = new Size(189, 32);
            textBox_numberTelephone.TabIndex = 22;
            textBox_numberTelephone.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(514, 258);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 21;
            label4.Text = "Номер телефона";
            label4.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(536, 220);
            label3.Name = "label3";
            label3.Size = new Size(136, 25);
            label3.TabIndex = 19;
            label3.Text = "Место работы";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(592, 181);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 17;
            label2.Text = "Возраст";
            label2.Visible = false;
            // 
            // textBox_fio
            // 
            textBox_fio.Font = new Font("Segoe UI", 14F);
            textBox_fio.Location = new Point(678, 141);
            textBox_fio.Name = "textBox_fio";
            textBox_fio.Size = new Size(189, 32);
            textBox_fio.TabIndex = 16;
            textBox_fio.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(618, 141);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 15;
            label1.Text = "ФИО";
            label1.Visible = false;
            // 
            // numericUpDown_old
            // 
            numericUpDown_old.Font = new Font("Segoe UI", 14F);
            numericUpDown_old.Location = new Point(678, 179);
            numericUpDown_old.Name = "numericUpDown_old";
            numericUpDown_old.Size = new Size(189, 32);
            numericUpDown_old.TabIndex = 29;
            numericUpDown_old.Visible = false;
            // 
            // textBox_login2
            // 
            textBox_login2.Font = new Font("Segoe UI", 14F);
            textBox_login2.Location = new Point(678, 65);
            textBox_login2.Name = "textBox_login2";
            textBox_login2.Size = new Size(189, 32);
            textBox_login2.TabIndex = 30;
            textBox_login2.Visible = false;
            // 
            // textBox_password2
            // 
            textBox_password2.Font = new Font("Segoe UI", 14F);
            textBox_password2.Location = new Point(678, 103);
            textBox_password2.Name = "textBox_password2";
            textBox_password2.Size = new Size(189, 32);
            textBox_password2.TabIndex = 31;
            textBox_password2.Visible = false;
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Font = new Font("Segoe UI", 14F);
            label_login.Location = new Point(607, 68);
            label_login.Name = "label_login";
            label_login.Size = new Size(65, 25);
            label_login.TabIndex = 32;
            label_login.Text = "Логин";
            label_login.Visible = false;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Segoe UI", 14F);
            label_password.Location = new Point(594, 106);
            label_password.Name = "label_password";
            label_password.Size = new Size(78, 25);
            label_password.TabIndex = 33;
            label_password.Text = "Пароль";
            label_password.Visible = false;
            // 
            // button_login2
            // 
            button_login2.Font = new Font("Segoe UI", 14F);
            button_login2.Location = new Point(272, 312);
            button_login2.Name = "button_login2";
            button_login2.Size = new Size(139, 34);
            button_login2.TabIndex = 34;
            button_login2.Text = "войти";
            button_login2.UseVisualStyleBackColor = true;
            button_login2.Visible = false;
            button_login2.Click += button_login2_Click;
            // 
            // button_back
            // 
            button_back.Font = new Font("Segoe UI", 14F);
            button_back.Location = new Point(12, 234);
            button_back.Name = "button_back";
            button_back.Size = new Size(109, 34);
            button_back.TabIndex = 35;
            button_back.Text = "назад";
            button_back.UseVisualStyleBackColor = true;
            button_back.Visible = false;
            button_back.Click += button_back_Click;
            // 
            // comboBox_login1
            // 
            comboBox_login1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_login1.Font = new Font("Segoe UI", 14F);
            comboBox_login1.FormattingEnabled = true;
            comboBox_login1.Location = new Point(127, 236);
            comboBox_login1.Name = "comboBox_login1";
            comboBox_login1.Size = new Size(284, 33);
            comboBox_login1.TabIndex = 36;
            comboBox_login1.Visible = false;
            // 
            // comboBox_work
            // 
            comboBox_work.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_work.Font = new Font("Segoe UI", 14F);
            comboBox_work.FormattingEnabled = true;
            comboBox_work.Location = new Point(678, 217);
            comboBox_work.Name = "comboBox_work";
            comboBox_work.Size = new Size(189, 33);
            comboBox_work.TabIndex = 37;
            comboBox_work.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 592);
            Controls.Add(comboBox_work);
            Controls.Add(comboBox_login1);
            Controls.Add(button_back);
            Controls.Add(button_login2);
            Controls.Add(label_password);
            Controls.Add(label_login);
            Controls.Add(textBox_password2);
            Controls.Add(textBox_login2);
            Controls.Add(numericUpDown_old);
            Controls.Add(button_save);
            Controls.Add(label5);
            Controls.Add(radioButton_women);
            Controls.Add(radioButton_man);
            Controls.Add(checkBox_homeNumber);
            Controls.Add(textBox_homeNumber);
            Controls.Add(textBox_numberTelephone);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox_fio);
            Controls.Add(label1);
            Controls.Add(textBox_password1);
            Controls.Add(button_reg1);
            Controls.Add(button_login1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_old).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_login1;
        private Button button_reg1;
        private TextBox textBox_password1;
        private Button button_save;
        private Label label5;
        private RadioButton radioButton_women;
        private RadioButton radioButton_man;
        private CheckBox checkBox_homeNumber;
        private TextBox textBox_homeNumber;
        private TextBox textBox_numberTelephone;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox_fio;
        private Label label1;
        private NumericUpDown numericUpDown_old;
        private TextBox textBox_login2;
        private TextBox textBox_password2;
        private Label label_login;
        private Label label_password;
        private Button button_login2;
        private Button button_back;
        private ComboBox comboBox_login1;
        private ComboBox comboBox_work;
    }
}
