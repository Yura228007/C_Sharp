namespace Project_050924
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox_homeNumber_CheckedChanged(object sender, EventArgs e)
        {
            textBox_homeNumber.ReadOnly = !checkBox_homeNumber.Checked;
        }

        private void radioButton_man_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_man.Checked) radioButton_women.Checked = false;
        }

        private void radioButton_women_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_women.Checked) radioButton_man.Checked = false;

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_fio.Text != "")
            {
                if (textBox_old.Text != "")
                {
                    if (textBox_work.Text != "")
                    {
                        if (textBox_numberTelephone.Text != "")
                        {            
                            if (radioButton_women.Checked||radioButton_man.Checked)
                            {
                                if ((checkBox_homeNumber.Checked && textBox_homeNumber.Text != "") || checkBox_homeNumber.Checked == false)
                                {
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
