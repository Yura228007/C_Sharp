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

        public Note_Main()
        {
            InitializeComponent();
            text_ready = "";
            path = "Note";
            pathWithNote = "";
            message_title = "Название. До 128 символов";
            message_comboBox = "Важность. До 32 символов";
            message_data = "Текст. До 1024 символов";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            text_title_Leave(sender, e);
            text_data_Leave(sender, e);
            comboBox1_Leave(sender, e);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (text_title != null &&
                text_title.Text != "" &&
                text_title.Text != message_title &&
                comboBox1 != null &&
                comboBox1.Text != "" &&
                comboBox1.Text != message_comboBox &&
                text_data != null &&
                text_data.Text != "" &&
                text_data.Text != message_data)
            {
                text_ready += "Название: " + text_title.Text + "\n";
                text_ready += "Дата: " + dateTimePicker1.Text + "\n";
                text_ready += "Важность: " + comboBox1.Text + "\n";
                text_ready += "Текст заметки: " + text_data.Text;
                pathWithNote = path + @"\" + text_title.Text + ".txt";
                using StreamWriter writer = new StreamWriter(pathWithNote);
                {
                    writer.WriteLine(text_ready);
                };
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

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.ForeColor = Color.Black;
            if (comboBox1.Text == message_comboBox)
                comboBox1.Text = "";
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == ""
                || comboBox1.Text == message_comboBox
                || comboBox1.Text == null)
            {
                comboBox1.ForeColor = Color.Gray;
                comboBox1.Text = message_comboBox;
            }
        }

        private void show_result_Click(object sender, EventArgs e)
        {

        }
    }
}
