using System.Configuration;

namespace Project_260924
{
    public partial class Form1 : Form
    {
        List <User> users = new List <User> ();
        string line;
        public Form1()
        {
            InitializeComponent();

            users.Add(new User("login1", "password1"));
            users.Add(new User("login2", "password2"));
            users.Add(new User("login3", "password3"));
            users.Add(new User("login4", "password4"));

            Binding binding1 = new Binding("Text", textBox2, "Text");
            //Binding binding2 = new Binding("Text", textBox2, "Text");

            binding1.Format += (sender, e) => { 
                if (e.Value.ToString().Length < 6) 
                { 
                    labelChange_1.Text = "Не ок"; 
                } 
                else 
                { 
                    labelChange_1.Text = "Все ок"; 
                } };
                textBox2.DataBindings.Add(binding1);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
