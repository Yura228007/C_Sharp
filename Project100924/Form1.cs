using System.Windows.Forms;

namespace Project100924
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_line.Text != "")
            {
                listBox_lines.Items.Add(textBox_line.Text);
                textBox_line.Text = "";
            }
        }

        private void button_relocate_Click(object sender, EventArgs e)
        {
            while (listBox_lines.SelectedItems.Count > 0)
            {
                var selectedItem = listBox_lines.SelectedItems[0];
                listBox_selectedLines.Items.Add(selectedItem);
                listBox_lines.Items.Remove(selectedItem);
            }
        }
    }
}
