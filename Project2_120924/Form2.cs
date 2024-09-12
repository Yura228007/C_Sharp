using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_120924
{


    public partial class Form2 : Form
    {
        List<User> users = new List<User>();
        public Form2()
        {
            InitializeComponent();
            this.AcceptButton = button_logIn;
            this.CancelButton = button1;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            users.Add(new User("admin", "admin"));
            users.Add(new User("worker1", "1111"));
            users.Add(new User("worker2", "2222"));
        }

        private void button_logIn_Click(object sender, EventArgs e)
        {
            foreach (var user in users)
            {
                if (textBox_login.Text == user.login && textBox_password.Text == user.password)
                {
                    if (user.login == "admin")
                    {
                        DialogResult dr = MessageBox.Show("Хотите войти как админ?", "Выберите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            MessageBox.Show($"Успешно вошел {user.login}(admin)");
                        }
                        else
                        {
                            MessageBox.Show($"Успешно вошел {user.login}");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Успешно вошел {user.login}");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
