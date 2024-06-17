using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        private string filePath_products = "data/products.txt";
        private string dirPath_Dishes = "data/Dishes";
        public Form1()
        {
            InitializeComponent();
            list_products.Items.AddRange(new string[] { });
            //создание папки data
            DirectoryInfo dir = new DirectoryInfo("data");
            if (!dir.Exists) dir.Create();
            //создание файла products
            if (!File.Exists(filePath_products)) File.Create(filePath_products).Close();
            //очистка списка продуктов в приложении
            list_products.Items.Clear();
            //заполнение списка продуктов в приложении из файла
            using (StreamReader sr = new StreamReader(filePath_products))
            {
                list_products.Items.AddRange(sr.ReadToEnd().Split("\r\n"));
                list_products.Items.RemoveAt(list_products.Items.Count - 1);
            }
            //заполнение комбобокса названиями продуктов
            foreach (string line in list_products.Items)
            {
                if (line.Length > 0)
                    name_product_load.Items.Add(line.Substring(line.IndexOf('-') + 2));
            }
            //очистка списка блюд в приложении
            list_dishes.Items.Clear();
            //заполнение списка блюд
            DirectoryInfo infoAboutDishes = new DirectoryInfo(dirPath_Dishes);
            foreach (var i in infoAboutDishes.GetFiles())
                list_dishes.Items.Add(Path.GetFileNameWithoutExtension(i.Name));
        }

        private void main_page_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_product_load_Click(object sender, EventArgs e)
        {
            if (name_product_load.Text != "")
            {
                using (StreamWriter sw = new StreamWriter(filePath_products))
                {

                    //Проверка на наличие объекта в списке по его окончанию
                    int index = -1;
                    for (int i = 0; i < list_products.Items.Count; i++)
                    {
                        if (list_products.Items[i].ToString().EndsWith(name_product_load.Text))
                        {
                            index = i;
                            break;
                        }
                    }

                    //Запись или редактирование записи продукта в списке
                    if (index != -1)
                    {
                        list_products.Items[index] = $"{value_product_load.Value} - {name_product_load.Text}";
                    }
                    else
                    {
                        list_products.Items.Add($"{value_product_load.Value} - {name_product_load.Text}");
                        name_product_load.Items.Add($"{name_product_load.Text}");
                    }

                    //Запись продуктов в файл
                    foreach (var item in list_products.Items)
                    {
                        sw.WriteLine($"{item}");
                    }
                }
            }
            else MessageBox.Show("Напишите имя продукта");
        }
        private void list_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_products.SelectedItem != null)
            {
                string selectNote = list_products.SelectedItem.ToString();

                name_product_load.Text = selectNote.Substring(selectNote.IndexOf('-') + 2);
                value_product_load.Value = Convert.ToInt32(selectNote.Substring(0, selectNote.IndexOf('-') - 1));

                button_delete_product.Visible = true;
            }
        }

        private void button_dishes_load_Click(object sender, EventArgs e)
        {
            DataBank.nameOf_SelectedItem = "";
            Add_Dish add_Dish = new Add_Dish();
            add_Dish.Show();
            this.Visible = false;
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                //очистка списка блюд в приложении
                list_dishes.Items.Clear();
                //заполнение списка блюд
                DirectoryInfo infoAboutDishes = new DirectoryInfo(dirPath_Dishes);
                foreach (var i in infoAboutDishes.GetFiles())
                    list_dishes.Items.Add(Path.GetFileNameWithoutExtension(i.Name));
            }
        }

        private void list_dishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_dishes.SelectedItem != null)
            {
                list_info_about_dish.Items.Clear();
                list_info_about_dish.Visible = true;
                show_info_about_dish.Visible = true;
                button_edit_dish.Visible = true;
                DataBank.nameOf_SelectedItem = list_dishes.SelectedItem.ToString();
                using (StreamReader sr = new StreamReader($"{dirPath_Dishes}/{list_dishes.SelectedItem.ToString()}.txt"))
                {
                    list_info_about_dish.Items.Add("Цена: " + sr.ReadLine());
                    list_info_about_dish.Items.Add("Ингредиенты:");
                    list_info_about_dish.Items.AddRange(sr.ReadToEnd().Split("\r\n"));
                }
                button_delete_dish.Visible = true;
            }
        }

        private void button_delete_dish_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы точно хотите удалить блюдо?", "Сообщение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (res == DialogResult.Yes)
            {
                if (list_dishes.SelectedItem != null)
                {
                    File.Delete($"{dirPath_Dishes}/{list_dishes.SelectedItem.ToString()}.txt");
                    list_dishes.Items.Remove(list_dishes.SelectedItem.ToString());
                    button_delete_dish.Visible = false;
                }
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Add_Dish add_Dish = new Add_Dish();
            add_Dish.Show();
        }

        private void button_delete_product_Click(object sender, EventArgs e)
        {
            if (list_products.SelectedItem != null)
            {
                list_products.Items.Remove(list_products.SelectedItem.ToString());
                using (StreamWriter wr = new StreamWriter(filePath_products))
                    foreach (var item in list_products.Items)
                        wr.WriteLine(item.ToString());
                button_delete_product.Visible = false;
            }
        }
    }
}
