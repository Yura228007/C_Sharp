namespace Restaurant_Manager
{
    public partial class Form1 : Form
    {
        private string filePath_products = "data/products.txt";
        private string dirPath_Dishes = "data/dishes";
        public Form1()
        {
            InitializeComponent();
            //создание папки data
            DirectoryInfo dir = new DirectoryInfo("data");
            if (!dir.Exists) dir.Create();
            //создание файла products
            if (!File.Exists(filePath_products)) File.Create(filePath_products).Close();
            //создание папки dishes
            DirectoryInfo dishesDir = new DirectoryInfo(dirPath_Dishes);
            if (!dishesDir.Exists) dishesDir.Create();
            //очистка списка продуктов в приложении
            table_prodList.Controls.Clear();
            //заполнение списка продуктов
            using (StreamReader sr = new StreamReader(filePath_products))
            {
                foreach (string line in sr.ReadToEnd().Split("\n"))
                    if (line != "")
                        anonLabel_table_products(line.Substring(0, line.IndexOf("-") - 1), Int32.Parse(line.Substring(line.IndexOf("-") + 2)));
            }
            //заполнение списка блюд
            foreach (var i in dishesDir.GetFiles())
                list_dishes.Items.Add(Path.GetFileNameWithoutExtension(i.Name));
            //заполнение комбоБокса продуктов для добавление продуктов к блюду
            using (StreamReader sr = new StreamReader(filePath_products))
            {
                foreach (string line in sr.ReadToEnd().Split("\n"))
                    if (line != "")
                        nameOf_productFor_dish.Items.Add(line.Substring(0, line.IndexOf("-") - 1));
            }
            //foreach (Control control in table_prodList.Controls)
            //{
            //    if (control is Label)
            //    {
            //        nameOf_productFor_prodList.Items.Add(control.Text);
            //    }
            //}
        }
        private void check_minusOne_inValue(object sender, EventArgs e)
        {
            if (((NumericUpDown)sender).Value == -1)
            {
                table_prodList.Controls.Remove((Label)((NumericUpDown)sender).Tag);

                ((NumericUpDown)sender).Dispose();
            }
        }

        private void check_zero_inValue(object sender, EventArgs e)
        {
            if (((NumericUpDown)sender).Value == 0)
            {
                table_info_aboutDish.Controls.Remove((Label)((NumericUpDown)sender).Tag);

                ((NumericUpDown)sender).Dispose();
            }
        }

        private void anonLabel_table_products(string text, int val)
        {
            Label label = new Label();
            label.Text = text;
            table_prodList.Controls.Add(label);

            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Minimum = -1;
            numericUpDown.Maximum = 1000;
            numericUpDown.Value = val;
            numericUpDown.Tag = label;
            numericUpDown.ValueChanged += check_minusOne_inValue;
            table_prodList.Controls.Add(numericUpDown);
        }

        private void btn_save_prodList_Click(object sender, EventArgs e)
        {
            using (StreamWriter wr = new StreamWriter(filePath_products))
            {
                foreach (Control control in table_prodList.Controls)
                {
                    if (control is Label)
                    {
                        wr.Write($"{control.Text} - ");
                    }
                    else
                    {
                        wr.WriteLine(((NumericUpDown)control).Value);
                    }
                }

            }
        }

        private void button_addProduct_prodList_Click(object sender, EventArgs e)
        {
            if (nameOf_productFor_prodList.Text != "")
            {
                anonLabel_table_products(nameOf_productFor_prodList.Text, 1);
            }
            else MessageBox.Show("Напишите название продукта");
        }

        private void anonLabel_table_dishes(string text, int val)
        {
            Label label = new Label();
            label.Text = text;
            table_info_aboutDish.Controls.Add(label);

            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Minimum = 0;
            numericUpDown.Maximum = 1000;
            numericUpDown.Value = val;
            numericUpDown.Tag = label;
            numericUpDown.BorderStyle = BorderStyle.None;
            numericUpDown.ValueChanged += check_zero_inValue;
            table_info_aboutDish.Controls.Add(numericUpDown);
        }

        private void list_dishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_dishes.SelectedItem != null)
            {
                table_info_aboutDish.Controls.Clear();
                table_info_aboutDish.Visible = true;
                show_info_about_dish.Visible = true;
                panel_infoAbout_dish.Visible = true;
                nameOf_productFor_dish.Visible = true;
                button_add_productFor_dish.Visible = true;
                button_save_dish.Visible = true;
                using (StreamReader sr = new StreamReader($"{dirPath_Dishes}/{list_dishes.SelectedItem.ToString()}.txt"))
                {
                    foreach (string line in sr.ReadToEnd().Split("\n"))
                        if (line != "")
                            anonLabel_table_dishes(line.Substring(0, line.IndexOf("-") - 1), Int32.Parse(line.Substring(line.IndexOf("-") + 2)));
                }
                button_delete_dish.Visible = true;
            }
        }

        private void button_delete_dish_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы точно хотите удалить блюдо?", "Сообщение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {
                if (list_dishes.SelectedItem != null)
                {
                    File.Delete($"{dirPath_Dishes}/{list_dishes.SelectedItem.ToString()}.txt");
                    list_dishes.Items.Remove(list_dishes.SelectedItem.ToString());
                    button_delete_dish.Visible = false;
                    table_info_aboutDish.Visible = false;
                    table_info_aboutDish.Controls.Clear();
                    show_info_about_dish.Visible = false;
                    panel_infoAbout_dish.Visible = false;
                }
            }
        }

        private void button_dishes_load_Click(object sender, EventArgs e)
        {
            list_dishes.Items.Add(nameFor_newDish.Text);
            if (!File.Exists($"{dirPath_Dishes}/{nameFor_newDish.Text}.txt")) File.Create($"{dirPath_Dishes}/{nameFor_newDish.Text}.txt").Close();
        }

        private void button_add_productFor_dish_Click(object sender, EventArgs e)
        {
            anonLabel_table_dishes(nameOf_productFor_dish.Text, 1);
        }

        private void button_save_dish_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter($"{dirPath_Dishes}/{list_dishes.SelectedItem.ToString()}.txt")) 
            {
                foreach (Control control in table_info_aboutDish.Controls)
                {
                    if (control is Label)
                    {
                        writer.Write($"{((Label)control).Text} - ");
                    }
                    else
                    {
                        writer.WriteLine(((NumericUpDown)control).Value);
                    }
                }
            }
        }
    }
}
