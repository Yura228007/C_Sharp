namespace LoginPassword
{
    public partial class Form1 : Form
    {
        bool flag = true;
        public Form1()
        {
            InitializeComponent();
            //�������� ����� data
            DirectoryInfo dir = new DirectoryInfo("data");
            if (!dir.Exists) dir.Create();
            foreach (var file in dir.GetFiles())
            {
                comboBox_login1.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
            }
            string[] post = new string[] { "HARDWORKER", "MIDLEWORKER", "LOWWORKER" };
            comboBox_work.Items.AddRange(post);
            this.AcceptButton = button_login2;
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
            panel_userData.Visible = true;
            button_login1.Visible = false;
            button_reg1.Visible = false;
            textBox_login2.ReadOnly = false;
            textBox_login2.Text = "";
            textBox_password2.Text = "";
            textBox_fio.Text = "";
            numericUpDown_old.Value = 0;
            comboBox_work.Text = "";
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
                        if (comboBox_work.Text != "")
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
                                            wr.WriteLine(comboBox_work.Text);
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

                                        if (!comboBox_login1.Items.Contains(textBox_login2.Text))
                                        {
                                            comboBox_login1.Items.Add(textBox_login2.Text);
                                        }

                                        panel_userData.Visible = false;
                                        button_login1.Visible = true;
                                        button_reg1.Visible = true;
                                        MessageBox.Show("�������!", "���� �������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else MessageBox.Show("������� �������� ����� ��������", "���� ������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else MessageBox.Show("�������� ���", "���� ������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else MessageBox.Show("������� ����� ��������", "���� ������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("������� ����� ������", "���� ������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("������� ���� �������", "���� ������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("������� ���", "���� ������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("������� ������", "���� ������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_login1_Click(object sender, EventArgs e)
        {
            comboBox_login1.Visible = true;
            textBox_password1.Visible = true;
            button_login2.Visible = true;
            button_login1.Visible = false;
            button_reg1.Visible = false;
            button_back.Visible = true;
        }

        private void button_login2_Click(object sender, EventArgs e)
        {
            if (comboBox_login1.Text != "")
            {
                if (textBox_password1.Text != "")
                {
                    if (File.Exists($"data/{comboBox_login1.Text}.txt"))
                    {
                        using (StreamReader reader = new StreamReader($"data/{comboBox_login1.Text}.txt"))
                        {
                            string passwordT = reader.ReadLine();
                            if (textBox_password1.Text == passwordT)
                            {
                                flag = true;
                                if (comboBox_login1.Text == "admin")
                                {
                                    DialogResult res = MessageBox.Show("������ ���������� ��� �����?", "������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (res == DialogResult.Yes)
                                    {
                                        flag = false;
                                    }
                                }
                                if (comboBox_login1.Text != "admin" || flag)
                                {
                                    textBox_login2.Text = "";
                                    textBox_password2.Text = "";
                                    textBox_fio.Text = "";
                                    numericUpDown_old.Value = 0;
                                    comboBox_work.Text = "";
                                    textBox_numberTelephone.Text = "";
                                    checkBox_homeNumber.Checked = false;
                                    textBox_homeNumber.Text = "";
                                    radioButton_man.Checked = false;
                                    radioButton_women.Checked = false;
                                    panel_userData.Visible = true;
                                    textBox_login2.ReadOnly = true;
                                    comboBox_login1.Visible = false;
                                    textBox_password1.Visible = false;
                                    button_login2.Visible = false;
                                    button_back.Visible = false;

                                    textBox_login2.Text = comboBox_login1.Text;
                                    textBox_password2.Text = passwordT;
                                    textBox_fio.Text = reader.ReadLine();
                                    numericUpDown_old.Value = Int32.Parse(reader.ReadLine());
                                    comboBox_work.Text = reader.ReadLine();
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
                                    comboBox_login1.Text = "";
                                    textBox_password1.Text = "";

                                    MessageBox.Show("�� ������� ����� � �������", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    panel_userData.Visible = true;
                                }
                                else
                                {
                                    AdminForm adminForm = new AdminForm();
                                    adminForm.Owner = this;
                                    adminForm.ShowDialog();
                                }
                            }
                            else
                            {
                                reader.Close();
                                MessageBox.Show("�������� ������", "�������� ������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else MessageBox.Show("������ ������ ���, ���������� ������������������", "�������� ������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            button_login1.Visible = true;
            button_reg1.Visible = true;
            comboBox_login1.Text = "";
            comboBox_login1.Visible = false;
            textBox_password1.Text = "";
            textBox_password1.Visible = false;
            button_login2.Visible = false;
            button_back.Visible = false;
        }

        private void button_back2_Click(object sender, EventArgs e)
        {
            panel_userData.Visible = false;
            button_login1.Visible = true;
            button_reg1.Visible = true;
        }

        private void comboBox_login1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_password1.Text = "";
        }
    }
}
