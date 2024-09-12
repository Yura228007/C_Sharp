namespace Project120924
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.AcceptButton = buttonEnt;
            this.CancelButton = buttonEx;

        }

        private void buttonEnt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажата кнопка Вход");
        }

        private void buttonEx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonNewForm_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
