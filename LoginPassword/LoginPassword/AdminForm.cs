using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPassword
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            DirectoryInfo dir = new DirectoryInfo("data");
            foreach (var file in dir.GetFiles())
            {
                if (Path.GetFileNameWithoutExtension(file.Name) != "admin")
                {
                    comboBox_users.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
                }
            }
            this.AcceptButton = button_save;
            this.CancelButton = button1; 
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader($"data/{comboBox_users.Text}.txt"))
            {
                string passwordT = reader.ReadLine();
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
            }
        }

        private void checkBox_homeNumber_CheckedChanged(object sender, EventArgs e)
        {
            textBox_homeNumber.ReadOnly = !checkBox_homeNumber.Checked;
        }

        private void button_save_Click(object sender, EventArgs e)
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
                                    using (StreamWriter wr = new StreamWriter($"data/{comboBox_users.Text}.txt"))
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
    }
}
