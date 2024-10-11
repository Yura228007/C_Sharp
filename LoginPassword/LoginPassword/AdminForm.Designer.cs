namespace LoginPassword
{
    partial class AdminForm
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
            panel_userData = new Panel();
            comboBox_users = new ComboBox();
            checkBox_homeNumber = new CheckBox();
            comboBox_work = new ComboBox();
            label1 = new Label();
            textBox_fio = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label_password = new Label();
            label4 = new Label();
            label_login = new Label();
            textBox_numberTelephone = new TextBox();
            textBox_password2 = new TextBox();
            textBox_homeNumber = new TextBox();
            radioButton_man = new RadioButton();
            numericUpDown_old = new NumericUpDown();
            radioButton_women = new RadioButton();
            button_save = new Button();
            label5 = new Label();
            button1 = new Button();
            check_ok_homeNumber = new Label();
            check_ok_numberTelephone = new Label();
            check_ok_work = new Label();
            check_ok_old = new Label();
            check_ok_fio = new Label();
            check_ok_login = new Label();
            panel_userData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_old).BeginInit();
            SuspendLayout();
            // 
            // panel_userData
            // 
            panel_userData.Controls.Add(check_ok_homeNumber);
            panel_userData.Controls.Add(comboBox_users);
            panel_userData.Controls.Add(check_ok_numberTelephone);
            panel_userData.Controls.Add(checkBox_homeNumber);
            panel_userData.Controls.Add(check_ok_work);
            panel_userData.Controls.Add(comboBox_work);
            panel_userData.Controls.Add(check_ok_old);
            panel_userData.Controls.Add(label1);
            panel_userData.Controls.Add(check_ok_fio);
            panel_userData.Controls.Add(textBox_fio);
            panel_userData.Controls.Add(check_ok_login);
            panel_userData.Controls.Add(label2);
            panel_userData.Controls.Add(label3);
            panel_userData.Controls.Add(label_password);
            panel_userData.Controls.Add(label4);
            panel_userData.Controls.Add(label_login);
            panel_userData.Controls.Add(textBox_numberTelephone);
            panel_userData.Controls.Add(textBox_password2);
            panel_userData.Controls.Add(textBox_homeNumber);
            panel_userData.Controls.Add(radioButton_man);
            panel_userData.Controls.Add(numericUpDown_old);
            panel_userData.Controls.Add(radioButton_women);
            panel_userData.Controls.Add(button_save);
            panel_userData.Controls.Add(label5);
            panel_userData.Controls.Add(button1);
            panel_userData.Location = new Point(74, 63);
            panel_userData.Name = "panel_userData";
            panel_userData.Size = new Size(762, 387);
            panel_userData.TabIndex = 39;
            // 
            // comboBox_users
            // 
            comboBox_users.Font = new Font("Segoe UI", 14F);
            comboBox_users.FormattingEnabled = true;
            comboBox_users.Location = new Point(229, 19);
            comboBox_users.Name = "comboBox_users";
            comboBox_users.Size = new Size(486, 33);
            comboBox_users.TabIndex = 38;
            comboBox_users.SelectedIndexChanged += comboBox_users_SelectedIndexChanged;
            // 
            // checkBox_homeNumber
            // 
            checkBox_homeNumber.AutoSize = true;
            checkBox_homeNumber.Font = new Font("Segoe UI", 14F);
            checkBox_homeNumber.Location = new Point(19, 250);
            checkBox_homeNumber.Name = "checkBox_homeNumber";
            checkBox_homeNumber.Size = new Size(204, 29);
            checkBox_homeNumber.TabIndex = 24;
            checkBox_homeNumber.Text = "Домашний телефон";
            checkBox_homeNumber.UseVisualStyleBackColor = true;
            checkBox_homeNumber.CheckedChanged += checkBox_homeNumber_CheckedChanged;
            // 
            // comboBox_work
            // 
            comboBox_work.Font = new Font("Segoe UI", 14F);
            comboBox_work.FormattingEnabled = true;
            comboBox_work.Location = new Point(229, 172);
            comboBox_work.Name = "comboBox_work";
            comboBox_work.Size = new Size(486, 33);
            comboBox_work.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(169, 96);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 15;
            label1.Text = "ФИО";
            // 
            // textBox_fio
            // 
            textBox_fio.Font = new Font("Segoe UI", 14F);
            textBox_fio.Location = new Point(229, 96);
            textBox_fio.Name = "textBox_fio";
            textBox_fio.Size = new Size(486, 32);
            textBox_fio.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(143, 136);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 17;
            label2.Text = "Возраст";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(87, 175);
            label3.Name = "label3";
            label3.Size = new Size(136, 25);
            label3.TabIndex = 19;
            label3.Text = "Место работы";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Segoe UI", 14F);
            label_password.Location = new Point(145, 61);
            label_password.Name = "label_password";
            label_password.Size = new Size(78, 25);
            label_password.TabIndex = 33;
            label_password.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(65, 213);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 21;
            label4.Text = "Номер телефона";
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Font = new Font("Segoe UI", 14F);
            label_login.Location = new Point(158, 23);
            label_login.Name = "label_login";
            label_login.Size = new Size(65, 25);
            label_login.TabIndex = 32;
            label_login.Text = "Логин";
            // 
            // textBox_numberTelephone
            // 
            textBox_numberTelephone.Font = new Font("Segoe UI", 14F);
            textBox_numberTelephone.Location = new Point(229, 210);
            textBox_numberTelephone.Name = "textBox_numberTelephone";
            textBox_numberTelephone.Size = new Size(486, 32);
            textBox_numberTelephone.TabIndex = 22;
            // 
            // textBox_password2
            // 
            textBox_password2.Font = new Font("Segoe UI", 14F);
            textBox_password2.Location = new Point(229, 58);
            textBox_password2.Name = "textBox_password2";
            textBox_password2.ReadOnly = true;
            textBox_password2.Size = new Size(486, 32);
            textBox_password2.TabIndex = 31;
            // 
            // textBox_homeNumber
            // 
            textBox_homeNumber.Font = new Font("Segoe UI", 14F);
            textBox_homeNumber.Location = new Point(229, 250);
            textBox_homeNumber.Name = "textBox_homeNumber";
            textBox_homeNumber.ReadOnly = true;
            textBox_homeNumber.Size = new Size(486, 32);
            textBox_homeNumber.TabIndex = 23;
            // 
            // radioButton_man
            // 
            radioButton_man.AutoSize = true;
            radioButton_man.Font = new Font("Segoe UI", 14F);
            radioButton_man.Location = new Point(228, 286);
            radioButton_man.Name = "radioButton_man";
            radioButton_man.Size = new Size(110, 29);
            radioButton_man.TabIndex = 25;
            radioButton_man.TabStop = true;
            radioButton_man.Text = "Мужской";
            radioButton_man.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_old
            // 
            numericUpDown_old.Font = new Font("Segoe UI", 14F);
            numericUpDown_old.Location = new Point(229, 134);
            numericUpDown_old.Name = "numericUpDown_old";
            numericUpDown_old.Size = new Size(486, 32);
            numericUpDown_old.TabIndex = 29;
            // 
            // radioButton_women
            // 
            radioButton_women.AutoSize = true;
            radioButton_women.Font = new Font("Segoe UI", 14F);
            radioButton_women.Location = new Point(344, 286);
            radioButton_women.Name = "radioButton_women";
            radioButton_women.Size = new Size(107, 29);
            radioButton_women.TabIndex = 26;
            radioButton_women.TabStop = true;
            radioButton_women.Text = "Женский";
            radioButton_women.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            button_save.Font = new Font("Segoe UI", 14F);
            button_save.Location = new Point(189, 323);
            button_save.Name = "button_save";
            button_save.Size = new Size(229, 44);
            button_save.TabIndex = 28;
            button_save.Text = "Сохранить";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(131, 290);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 27;
            label5.Text = "Пол";
            // 
            // button1
            // 
            button1.Location = new Point(229, 337);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 40;
            button1.Text = "ESC";
            button1.UseVisualStyleBackColor = true;
            // 
            // check_ok_homeNumber
            // 
            check_ok_homeNumber.AutoSize = true;
            check_ok_homeNumber.Font = new Font("Segoe UI", 14F);
            check_ok_homeNumber.Location = new Point(721, 251);
            check_ok_homeNumber.Name = "check_ok_homeNumber";
            check_ok_homeNumber.Size = new Size(25, 25);
            check_ok_homeNumber.TabIndex = 52;
            check_ok_homeNumber.Text = "×";
            // 
            // check_ok_numberTelephone
            // 
            check_ok_numberTelephone.AutoSize = true;
            check_ok_numberTelephone.Font = new Font("Segoe UI", 14F);
            check_ok_numberTelephone.Location = new Point(721, 213);
            check_ok_numberTelephone.Name = "check_ok_numberTelephone";
            check_ok_numberTelephone.Size = new Size(25, 25);
            check_ok_numberTelephone.TabIndex = 51;
            check_ok_numberTelephone.Text = "×";
            // 
            // check_ok_work
            // 
            check_ok_work.AutoSize = true;
            check_ok_work.Font = new Font("Segoe UI", 14F);
            check_ok_work.Location = new Point(721, 175);
            check_ok_work.Name = "check_ok_work";
            check_ok_work.Size = new Size(25, 25);
            check_ok_work.TabIndex = 50;
            check_ok_work.Text = "×";
            // 
            // check_ok_old
            // 
            check_ok_old.AutoSize = true;
            check_ok_old.Font = new Font("Segoe UI", 14F);
            check_ok_old.Location = new Point(721, 137);
            check_ok_old.Name = "check_ok_old";
            check_ok_old.Size = new Size(25, 25);
            check_ok_old.TabIndex = 49;
            check_ok_old.Text = "×";
            // 
            // check_ok_fio
            // 
            check_ok_fio.AutoSize = true;
            check_ok_fio.Font = new Font("Segoe UI", 14F);
            check_ok_fio.Location = new Point(721, 99);
            check_ok_fio.Name = "check_ok_fio";
            check_ok_fio.Size = new Size(25, 25);
            check_ok_fio.TabIndex = 48;
            check_ok_fio.Text = "×";
            // 
            // check_ok_login
            // 
            check_ok_login.AutoSize = true;
            check_ok_login.Font = new Font("Segoe UI", 14F);
            check_ok_login.Location = new Point(721, 23);
            check_ok_login.Name = "check_ok_login";
            check_ok_login.Size = new Size(25, 25);
            check_ok_login.TabIndex = 46;
            check_ok_login.Text = "×";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 673);
            Controls.Add(panel_userData);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            panel_userData.ResumeLayout(false);
            panel_userData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_old).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_userData;
        private CheckBox checkBox_homeNumber;
        private ComboBox comboBox_work;
        private Label label1;
        private TextBox textBox_fio;
        private Label label2;
        private Label label3;
        private Label label_password;
        private Label label4;
        private Label label_login;
        private TextBox textBox_numberTelephone;
        private TextBox textBox_password2;
        private TextBox textBox_homeNumber;
        private RadioButton radioButton_man;
        private NumericUpDown numericUpDown_old;
        private RadioButton radioButton_women;
        private Button button_save;
        private Label label5;
        private ComboBox comboBox_users;
        private Button button1;
        private Label check_ok_homeNumber;
        private Label check_ok_numberTelephone;
        private Label check_ok_work;
        private Label check_ok_old;
        private Label check_ok_fio;
        private Label check_ok_login;
    }
}