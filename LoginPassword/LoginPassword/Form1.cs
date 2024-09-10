namespace LoginPassword
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //создание папки data
            DirectoryInfo dir = new DirectoryInfo("data");
            if (!dir.Exists) dir.Create();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton_man_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_homeNumber_CheckedChanged(object sender, EventArgs e)
        {
            textBox_homeNumber.ReadOnly = !checkBox_homeNumber.Checked;
        }

        private void button_reg1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label_login.Visible = true;
            label_password.Visible = true;
            checkBox_homeNumber.Visible = true;
            textBox_fio.Visible = true;
            textBox_login2.Visible = true;
            textBox_password2.Visible = true;
            numericUpDown_old.Visible = true;
            radioButton_man.Visible = true;
            radioButton_women.Visible = true;
            textBox_work.Visible = true;
            textBox_numberTelephone.Visible = true;
            textBox_homeNumber.Visible = true;
            button_save.Visible = true;
            button_login1.Visible = false;
            button_reg1.Visible = false;
            textBox_login2.ReadOnly = false;
            textBox_login2.Text = "";
            textBox_password2.Text = "";
            textBox_fio.Text = "";
            numericUpDown_old.Value = 0;
            textBox_work.Text = "";
            textBox_numberTelephone.Text = "";
            checkBox_homeNumber.Checked = false;
            textBox_homeNumber.Text = "";
            radioButton_man.Checked = false;
            radioButton_women.Checked = false;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_password2.Text != "")
            {
                if (textBox_fio.Text != "")
                {
                    if (numericUpDown_old.Value != 0)
                    {
                        if (textBox_work.Text != "")
                        {
                            if (textBox_numberTelephone.Text != "")
                            {
                                if (radioButton_women.Checked || radioButton_man.Checked)
                                {
                                    if ((checkBox_homeNumber.Checked && textBox_homeNumber.Text != "") || checkBox_homeNumber.Checked == false)
                                    {
                                        using (StreamWriter wr = new StreamWriter($"data/{textBox_login2.Text}.txt"))
                                        {
                                            wr.WriteLine(textBox_password2.Text);
                                            wr.WriteLine(textBox_fio.Text);
                                            wr.WriteLine(numericUpDown_old.Value);
                                            wr.WriteLine(textBox_work.Text);
                                            wr.WriteLine(textBox_numberTelephone.Text);
                                            wr.WriteLine(checkBox_homeNumber.Checked.ToString());
                                            if (checkBox_homeNumber.Checked)
                                                wr.WriteLine(textBox_homeNumber.Text);
                                            else wr.WriteLine();
                                            if (radioButton_man.Checked)
                                                wr.Write("man");
                                            else
                                                wr.Write("women");
                                        }
                                        label1.Visible = false;
                                        label2.Visible = false;
                                        label3.Visible = false;
                                        label4.Visible = false;
                                        label5.Visible = false;
                                        label_login.Visible = false;
                                        label_password.Visible = false;
                                        checkBox_homeNumber.Visible = false;
                                        textBox_fio.Visible = false;
                                        textBox_login2.Visible = false;
                                        textBox_password2.Visible = false;
                                        numericUpDown_old.Visible = false;
                                        radioButton_man.Visible = false;
                                        radioButton_women.Visible = false;
                                        textBox_work.Visible = false;
                                        textBox_numberTelephone.Visible = false;
                                        textBox_homeNumber.Visible = false;
                                        button_save.Visible = false;
                                        button_login1.Visible = true;
                                        button_reg1.Visible = true;
                                        MessageBox.Show("Успешно!", "Окно радости", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else MessageBox.Show("Введите домашний номер телефона", "Окно грусти", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else MessageBox.Show("Выберите пол", "Окно грусти", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else MessageBox.Show("Введите номер телефона", "Окно грусти", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("Введите место работы", "Окно грусти", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Введите свой возраст", "Окно грусти", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Введите ФИО", "Окно грусти", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Введите пароль", "Окно грусти", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_login1_Click(object sender, EventArgs e)
        {
            textBox_login1.Visible = true;
            textBox_password1.Visible = true;
            button_login2.Visible = true;
            button_login1.Visible = false;
            button_reg1.Visible = false;
            button_back.Visible = true;
        }

        private void button_login2_Click(object sender, EventArgs e)
        {
            if (textBox_login1.Text != "")
            {
                if (textBox_password1.Text != "")
                {
                    if (File.Exists($"data/{textBox_login1.Text}.txt"))
                    {
                        using (StreamReader reader = new StreamReader($"data/{textBox_login1.Text}.txt"))
                        {
                            string passwordT = reader.ReadLine();
                            if (textBox_password1.Text == passwordT)
                            {
                                label1.Visible = true;
                                label2.Visible = true;
                                label3.Visible = true;
                                label4.Visible = true;
                                label5.Visible = true;
                                label_login.Visible = true;
                                label_password.Visible = true;
                                checkBox_homeNumber.Visible = true;
                                textBox_fio.Visible = true;
                                textBox_login2.Visible = true;
                                textBox_password2.Visible = true;
                                numericUpDown_old.Visible = true;
                                radioButton_man.Visible = true;
                                radioButton_women.Visible = true;
                                textBox_work.Visible = true;
                                textBox_numberTelephone.Visible = true;
                                textBox_homeNumber.Visible = true;
                                button_save.Visible = true;
                                textBox_login2.ReadOnly = true;
                                textBox_login1.Visible = false;
                                textBox_password1.Visible = false;
                                button_login2.Visible = false;
                                button_back.Visible = false;

                                textBox_login2.Text = textBox_login1.Text;
                                textBox_password2.Text = passwordT;
                                textBox_fio.Text = reader.ReadLine();
                                numericUpDown_old.Value = Int32.Parse(reader.ReadLine());
                                textBox_work.Text = reader.ReadLine();
                                textBox_numberTelephone.Text = reader.ReadLine();
                                if (reader.ReadLine() == "True")
                                {
                                    checkBox_homeNumber.Checked = true;
                                    textBox_homeNumber.Text = reader.ReadLine();
                                }
                                else
                                {
                                    reader.ReadLine();
                                }
                                if (reader.ReadLine() == "man")
                                {
                                    radioButton_man.Checked = true;
                                }
                                else
                                {
                                    radioButton_women.Checked = true;
                                }
                                textBox_login1.Text = "";
                                textBox_password1.Text = "";

                                MessageBox.Show("Вы успешно вошли в аккаунт", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                reader.Close();
                                MessageBox.Show("Неверный пароль", "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else MessageBox.Show("Такого логина нет, попробуйте зарегестрироваться", "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            button_login1.Visible = true;
            button_reg1.Visible = true;
            textBox_login1.Text = "";
            textBox_login1.Visible = false;
            textBox_password1.Text = "";
            textBox_password1.Visible = false;
            button_login2.Visible = false;
            button_back.Visible = false;
        }
    }
}
