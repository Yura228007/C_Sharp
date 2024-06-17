using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Add_Dish : Form
    {
        private string filePath_products = "data/products.txt";
        private string dirPath_Dishes = "data/dishes";
        Point startPosition_button_delete_ingredient = new Point(469, 218);
        public Add_Dish()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader(filePath_products))
            {
                foreach (string line in sr.ReadToEnd().Split("\r\n"))
                {
                    if (line.Length > 0)
                        name_products_for_dish.Items.Add(line.Substring(line.IndexOf('-') + 2));
                }
            }
        }

        private void button_add_product_for_dish_Click(object sender, EventArgs e)
        {
            //Проверка на наличие объекта в списке по его окончанию
            int index = -1;
            if (name_products_for_dish.Text != "")
            {
                if (value_add_product.Value > 0)
                {
                    for (int i = 0; i < list_products_for_dish.Items.Count; i++)
                    {
                        if (list_products_for_dish.Items[i].ToString().EndsWith(name_products_for_dish.Text))
                        {
                            index = i;
                            break;
                        }
                    }
                    //Запись или редактирование записи продукта в списке
                    if (index != -1)
                    {
                        list_products_for_dish.Items[index] = $"{value_add_product.Value} - {name_products_for_dish.Text}";
                    }
                    else
                    {
                        list_products_for_dish.Items.Add($"{value_add_product.Value} - {name_products_for_dish.Text}");
                    }
                }
                else MessageBox.Show("Выберите количество ингредиента");
            }
            else MessageBox.Show("Выберите ингредиент");

        }

        private void button_add_dish_Click(object sender, EventArgs e)
        {
            if (title_dish.Text != "")
            {
                if (value_price_of_dish.Value != 0)
                {
                    if (list_products_for_dish.Items.Count > 0)
                    {
                        using (StreamWriter sw = new StreamWriter($@"{dirPath_Dishes}/{title_dish.Text}.txt"))
                        {
                            sw.WriteLine(value_price_of_dish.Text);
                            foreach (var item in list_products_for_dish.Items)
                            {
                                sw.WriteLine(item.ToString());
                            }
                        };

                        this.Close();
                    }
                    else MessageBox.Show("Добавьте ингредиенты блюда");
                }
                else MessageBox.Show("Укажите цену блюда");
            }
            else MessageBox.Show("Укажите название блюда");

        }

        private void Add_Dish_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Visible = true;
        }

        private void Add_Dish_Load(object sender, EventArgs e)
        {
            if (DataBank.nameOf_SelectedItem != "")
            {
                title_dish.Text = DataBank.nameOf_SelectedItem;
                using (StreamReader sr = new StreamReader($"{dirPath_Dishes}/{DataBank.nameOf_SelectedItem}.txt"))
                {
                    value_price_of_dish.Value = Convert.ToInt32(sr.ReadLine());
                    list_products_for_dish.Items.AddRange(sr.ReadToEnd().Split("\r\n"));
                }
                list_products_for_dish.Items.Remove("");
            }
        }



        private void list_products_for_dish_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_products_for_dish.SelectedItem != null)
            {
                button_delete_ingredient.Location = startPosition_button_delete_ingredient;
                button_delete_ingredient.Visible = true;
                int index = list_products_for_dish.Items.IndexOf(list_products_for_dish.SelectedItem.ToString());
                if (index <= 9)
                {
                    button_delete_ingredient.Location = new Point(
                        button_delete_ingredient.Location.X, 
                        button_delete_ingredient.Location.Y + index*31
                        );
                }
                else
                {
                    button_delete_ingredient.Location = new Point(
                        button_delete_ingredient.Location.X,
                        button_delete_ingredient.Location.Y + 9 * 31
                        );
                }
            }
        }

        private void button_delete_ingredient_Click(object sender, EventArgs e)
        {
            list_products_for_dish.Items.Remove(list_products_for_dish.SelectedItem.ToString());
            button_delete_ingredient.Visible = false;
        }
    }
}
