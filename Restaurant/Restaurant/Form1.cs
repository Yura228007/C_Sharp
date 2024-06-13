using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        private string filePath_products = "data/products.txt";
        public Form1()
        {
            InitializeComponent();
            list_products.Items.AddRange(new string[] { });
            DirectoryInfo dir = new DirectoryInfo("data");
            if (!dir.Exists) dir.Create();
            if (!File.Exists(filePath_products)) File.Create(filePath_products).Close();
            list_products.Items.Clear();
            using (StreamReader sr = new StreamReader(filePath_products)) 
            {
                list_products.Items.AddRange(sr.ReadToEnd().Split("\r\n"));
                list_products.Items.RemoveAt(list_products.Items.Count - 1);
            }
            foreach (string line in list_products.Items)
            {
                if (line.Length > 0)
                    name_product_load.Items.Add(line.Substring(line.IndexOf('-') + 2));
            }
        }

        private void main_page_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_product_load_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (name_product_load.Text == "")
            {
                flag = false;
                MessageBox.Show("Напишите имя продукта");
            }
            if (flag)
            {
                using (StreamWriter sw = new StreamWriter(filePath_products))
                {
                    List<string> names_prosucts = new List<string>();
                    foreach (var i in list_products.Items)
                    {
                        string temp = i.ToString();
                        names_prosucts.Add(temp);
                    }
                    if (list_products.Items.Contains(name_product_load.Text))
                    {
                        list_products.Items[list_products.Items.IndexOf(name_product_load.Text)] = $"{value_product_load.Value} - {name_product_load.Text}";
                    }
                    else
                    {
                        list_products.Items.Add($"{value_product_load.Value} - {name_product_load.Text}");
                    }

                    foreach (var item in list_products.Items)
                    {
                        sw.WriteLine($"{item}");
                    }
                }
            }

        }
        private void list_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_products.SelectedItem != null)
            {
                string selectNote = list_products.SelectedItem.ToString();

                name_product_load.Text = selectNote.Substring(selectNote.IndexOf('-') + 2);
                value_product_load.Value = Convert.ToInt32(selectNote.Substring(0, selectNote.IndexOf('-') - 1));
            }
        }
    }
}
