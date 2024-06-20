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

            //заполнение комбоБокса продуктов для добавление продуктов к блюду
            using (StreamReader sr = new StreamReader(filePath_products))
            {
                foreach (string line in sr.ReadToEnd().Split("\n"))
                    if (line != "")
                        nameOf_productFor_dish.Items.Add(line.Substring(0, line.IndexOf("-") - 1));
            }

            List<string> dishes_name = new List<string>();
            /*            foreach (var i in dishesDir.GetFiles())
                        {
                            dishes_name.Add(i.Name);
                            using (StreamReader sr = new StreamReader($"{dirPath_Dishes}/{i.Name}.txt")) ;
                        }*/
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
                nameOf_productFor_dish.Items.Add(nameOf_productFor_prodList.Text);
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

        //должно быть заменено на клик по лейблу
        private void list_dishes_SelectedIndexChanged(object sender, EventArgs e)
        {
/*            if (list_dishes.SelectedItem != null)
            {
                table_info_aboutDish.Controls.Clear();
                using (StreamReader sr = new StreamReader($"{dirPath_Dishes}/{list_dishes.SelectedItem.ToString()}.txt"))
                {
                    foreach (string line in sr.ReadToEnd().Split("\n"))
                        if (line != "")
                            anonLabel_table_dishes(line.Substring(0, line.IndexOf("-") - 1), Int32.Parse(line.Substring(line.IndexOf("-") + 2)));
                }
                button_delete_dish.Visible = true;
            }*/
        }

        private void listDish_item_Click(object sender, EventArgs e)
        {
            button_delete_dish.Visible = true;

            nameFor_newDish.Text = ((Label)sender).Text;
            newDish_cost.Value = Int32.Parse(((Label)((Label)sender).Tag).Text);
            using (StreamReader sr = new StreamReader($"{dirPath_Dishes}/{((Label)sender).Text}.txt"))
            {
                string recept = sr.ReadToEnd();
                /*string[] products = recept.Split("\n");
                for (int i = 0; i < products.Length; i++)
                {
                    string[] t = products[i].Split(new char[] {':'});
                    table_info_aboutDish.Controls.Add();
                }*/
                foreach (string line in recept.Split("\n"))
                {
                    if (line != "")
                        anonLabel_table_dishes(line.Substring(0, line.IndexOf(":")), Convert.ToInt32(line.Substring(line.IndexOf(":")+1)));
                }
            }
        }

        private void button_delete_dish_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы точно хотите удалить блюдо?", "Сообщение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {
/*                if (list_dishes.SelectedItem != null)
                {
                    File.Delete($"{dirPath_Dishes}/{list_dishes.SelectedItem.ToString()}.txt");
                    list_dishes.Items.Remove(list_dishes.SelectedItem.ToString());
                }*/
            }
        }

        private void button_dishes_load_Click(object sender, EventArgs e)
        {
            if (nameFor_newDish.Text != "")
            {
                if (newDish_cost.Value != 0)
                {
                    if (table_info_aboutDish.Controls.Count > 0)
                    {
                        using (StreamWriter wr = new StreamWriter($"{dirPath_Dishes}/{nameFor_newDish.Text}.txt"))
                        {
                            wr.WriteLine(newDish_cost.Value);
                            foreach (Control control in table_info_aboutDish.Controls)
                            {
                                if (control is Label)
                                {
                                    wr.Write(((Label)control).Text);
                                }
                                else
                                {
                                    wr.WriteLine($":{((NumericUpDown)control).Value}");
                                }
                            }
                        }
                        listDish_update(1, nameFor_newDish.Text, (int)newDish_cost.Value);
                        newDish_cost.Value = 0;
                        table_info_aboutDish.Controls.Clear();
                        nameFor_newDish.Text = "";
                    }
                    else MessageBox.Show("Добавьте ингредиенты!");
                }
                else MessageBox.Show("Укажите цену!");
            }
            else MessageBox.Show("Укажите название блюда!");
        }

        private void button_add_productFor_dish_Click(object sender, EventArgs e)
        {
            anonLabel_table_dishes(nameOf_productFor_dish.Text, 1);
        }

        private void listDish_update(int amount, string dish_name, int cost)
        {
            if (table_list_dishes.Controls.Find(dish_name, false).Count() > 0)
            {
                ((Label)((Label)table_list_dishes.
                    Controls.Find(dish_name, false)[0]).Tag).Text = amount.ToString();
                ((Label)((Label)((Label)table_list_dishes.
                    Controls.Find(dish_name, false)[0]).Tag).Tag).Text = cost.ToString();
            }
            else
            {
                Label d_n = new Label();
                d_n.Name = dish_name;
                d_n.Text = dish_name;
                d_n.Click += listDish_item_Click;

                Label d_a = new Label();
                d_a.Text = amount.ToString();
                d_n.Tag = d_a;

                Label d_c = new Label();
                d_c.Text = cost.ToString();
                d_a.Tag = d_c;

                d_a.Tag = d_n;
                d_c.Tag = d_n;
                d_n.Tag = d_a;

                table_list_dishes.Controls.Add(d_a);
                table_list_dishes.Controls.Add(d_n);
                table_list_dishes.Controls.Add(d_c);
            }
        }
    }
}
