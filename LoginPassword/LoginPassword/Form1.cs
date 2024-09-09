namespace LoginPassword
{
    public partial class Form1 : Form
    {
        class Person
        {
            string password;
            string fullName;
            string old;
            string work;
            string numberTelephone;
            bool numberHomeHave;
            string numberHomeTelephone;
            bool gender;
        }
        


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
            button_login1.Visible = false;
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
            button_reg1.Visible = false;
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
                                        MessageBox.Show("Успешно!", "Окно радости", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
