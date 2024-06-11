using Note.Properties;
using System.Text;
namespace Note
{
    public partial class Note_Main : Form
    {
        private string text_ready;
        private string message_title;
        private string message_comboBox;
        private string message_data;
        private string pathWithNote;
        private string path;
        DirectoryInfo dir = new DirectoryInfo("data");

        public Note_Main()
        {
            InitializeComponent();
            text_ready = "";
            path = "data";
            pathWithNote = "";
            message_title = "Название. До 128 символов";
            message_data = "Текст. До 1024 символов";
            DirectoryInfo dir = new DirectoryInfo("data");
            if (!dir.Exists)
            {
                dir.Create();
            }
            string[] arr;
            foreach (var i in dir.GetFiles()) list_notes.Items.Add(i.Name);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            text_title_Leave(sender, e);
            text_data_Leave(sender, e);
        }

        private void button_save_Click(object sender, EventArgs e)
        {

            if (text_title != null &&
                text_title.Text != "" &&
                text_title.Text != message_title &&
                comboBox1 != null &&


                text_data != null &&
                text_data.Text != "" &&
                text_data.Text != message_data)
            {
                text_ready += /*"Название: " +*/ text_title.Text + "\n";
                text_ready += /*"Дата: " +*/ dateTimePicker1.Text + "\n";
                text_ready += /*"Важность: " + */comboBox1.Text + "\n";
                text_ready += /*"Текст заметки: " +*/ text_data.Text;
                pathWithNote = path + @"\" + text_title.Text + ".txt";
                using StreamWriter writer = new StreamWriter(pathWithNote);
                {
                    writer.WriteLine(text_ready);
                };

                list_notes.Items.Add($"{text_title.Text}.txt");

                text_ready = "";
                text_title.Text = "";
                comboBox1.Text = "";
                text_data.Text = "";

                show_result.Text = "Успешно!";
                show_result.BackColor = Color.ForestGreen;
            }
            else
            {
                show_result.Text = "Ошибка!";
                show_result.BackColor = Color.DarkRed;
            }
        }


        private void button_clear_Click(object sender, EventArgs e)
        {
            show_result.Text = "Сделайте заметку";
            show_result.BackColor = Color.Coral;
            text_title.Text = "";
            text_data.Text = "";
            comboBox1.Text = "";
        }

        private void text_title_Enter(object sender, EventArgs e)
        {
            text_title.ForeColor = Color.Black;
            if (text_title.Text == message_title)
                text_title.Text = "";
        }

        private void text_title_Leave(object sender, EventArgs e)
        {
            if (text_title.Text == ""
                || text_title.Text == message_title
                || text_title.Text == null)
            {
                text_title.ForeColor = Color.Gray;
                text_title.Text = message_title;
            }
        }

        private void text_data_Enter(object sender, EventArgs e)
        {
            text_data.ForeColor = Color.Black;
            if (text_data.Text == message_data)
                text_data.Text = "";
        }

        private void text_data_Leave(object sender, EventArgs e)
        {
            if (text_data.Text == ""
                || text_data.Text == message_data
                || text_data.Text == null)
            {
                text_data.ForeColor = Color.Gray;
                text_data.Text = message_data;
            }
        }

        private void show_result_Click(object sender, EventArgs e)
        {

        }

        private void list_notes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_notes.SelectedItems != null)
            {
                string selectNote = list_notes.SelectedItem.ToString();

                string filePath = $"data/{selectNote}";
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                    {
                        text_title.Text = Path.GetFileNameWithoutExtension(selectNote);
                        //System.Globalization.CultureInfo provider = new System.Globalization.CultureInfo("ru-RU");
                        //dateTimePicker1.Value = DateTime.ParseExact(sr.ReadLine(), "d MMMM yyyy г.", provider);
                        checkLabel.Text = sr.ReadLine();
                        comboBox1.Text = sr.ReadLine();
                        text_data.Text = sr.ReadToEnd();
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
